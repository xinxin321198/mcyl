using DAL.YPKC.药品库存_单据主表;
using DAL.YPKC.药品库存_单据子表;
using DAL.YPKC.药品库存_库存表;
using DAL.Common;
using Model.Common;
using Model.YPKC;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL.YPKC.药品调拨
{
    public class Ypkc_DiaoBoBLLImp : Ypkc_DiaoBoBLL
    {
         private Ypkc_djDAL ypkc_djDal = new Ypkc_djDALImp();
         private Ypkc_djmxDAL ypkc_djMxDal = new Ypkc_djmxDALImp();
         private Ypkc_kcDAL ypkc_kcDal = new Ypkc_kcDALImp();

         public bool addDiaoboDj(Ypkc_dj dj, List<Ypkc_djmx> djmxList)
        {
            if (dj.Fk_lyks == dj.Fk_mdks)
            {
                throw new Exception("来源科室不允许与目的科室相同");
            }
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务时必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    bool flag1 = false;//默认失败
                    bool falg2 = false;//默认失败
                    bool returnFalg = false;
                    //新增一个单据记录，如果成功，把返回值改为true
                    dj.Djlx_code = CommonCode.药品库存_单据类型.调拨;
                    //作废标志，启用
                    dj.Zfbz = CommonCode.代码值_作废标志代码值.启用;
                    //记账 否
                    dj.Jzzt_code = CommonCode.代码值_是否.否;
                    dj.Id = Model.Common.GUIDHelper.getGuid();//在数据访问层之外就手动生成guid
                    flag1 = ypkc_djDal.insertForLshSequences(dj, con);



                    //新增单据字表记录
                    for (int i = 0; i < djmxList.Count; i++)
                    {
                        djmxList[i].Fk_dj_id = dj.Id;//单据明细表的主表外键
                        djmxList[i].Zfbz = CommonCode.代码值_作废标志代码值.启用;
                    }

                    falg2 = ypkc_djMxDal.inertBatchForLshSequences(djmxList, con);
                    if (flag1)
                    {
                        ts.Complete();//执行成功之后提交整个事务
                        returnFalg = true;
                    }
                    return returnFalg;
                }
            }
        }

        public bool modifyDiaoboDj(Ypkc_dj dj, List<Ypkc_djmx> djmxList)
        {
            bool flag1 = false;//指示第一个数据访问是否成功
            bool flag2 = false;//指示第二个数据访问是否成功
            bool flag3 = false;//指示第二个数据访问是否成功
            bool flagResul = false//最终返回的结果
                ;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务时必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    flag1 = ypkc_djDal.updateById(dj, con);//修改单据的信息
                    Ypkc_djmx djmxDeleteParam = new Ypkc_djmx();
                    djmxDeleteParam.Fk_dj_id = dj.Id;
                    flag2 = ypkc_djMxDal.deleteByOtherCondition(djmxDeleteParam, con);//删除单据字表信息

                    for (int i = 0; i < djmxList.Count; i++)
                    {
                        Ypkc_djmx djmx = djmxList[i];
                        djmx.Fk_dj_id = dj.Id;//单据明细所属的单据ID
                        djmx.Djh = dj.Djh;//单据号
                        djmx.Zfbz = CommonCode.代码值_作废标志代码值.启用;
                    }
                    flag3 = ypkc_djMxDal.inertBatch(djmxList, con);//正常插入字表信息
                    if (flag1 && flag2 && flag3)
                    {
                        flagResul = true;
                        ts.Complete();//执行成功之后提交整个事务
                    }
                    return flagResul;
                }
            }
        }

        public bool jizhangDiaoboDjById(string id)
        {
            /* 1.查询出此单据下的所有药品
             * 2.更改单据主表记录的“记账”字段为已记账
             * 3.根据单据明细的药品查询出药品库存中的药品
             * 4.比对药库库存表中的药品（相同药品编号，对比药房库存，批号或者进价其中一个不一致的就新增；如果三个一直就在原有基础上增加数量，原有库存的数量减少）
             * 5.增加数量的时候记录小单位数量，数量字段使用单据上的数量X换算比例，药品单位类型字段设为小单位
             */

            Ypkc_dj dj = ypkc_djDal.findById(id);
            Ypkc_djmx djmxParam = new Ypkc_djmx();
            djmxParam.Fk_dj_id = id;
            List<Ypkc_djmx> djmxList = (List<Ypkc_djmx>)ypkc_djMxDal.find(djmxParam, null, null, null)[0];//得到单据明细的药品
            List<Ypkc_kc> kcModifyList = new List<Ypkc_kc>();//要修改数量的库存记录
            List<Ypkc_kc> kcInsertList = new List<Ypkc_kc>();//要新增的库存记录
            List<Ypkc_kc> kcReduceList = new List<Ypkc_kc>();//减少来源科室的药品库存数量（先存放，事务中再处理里面的数量）

            for (int i = 0; i < djmxList.Count; i++)
            {
                Ypkc_djmx djmx = djmxList[i];
                Ypkc_kc kcParam = new Ypkc_kc();
                kcParam.Fk_keshi_id = dj.Fk_mdks;//入库的科室
                kcParam.Fk_yp_id = djmx.Fk_yp;//根据药品ID
                kcParam.Ph = djmx.Ph;//批号
                kcParam.Jj = djmx.Jj;//进价
                List<Ypkc_kc> kcList = (List<Ypkc_kc>)ypkc_kcDal.find(kcParam, null, null, null)[0];//根据科室，药品ID，批号，进价，查询得到库存的记录
                
                if (kcList.Count > 1)//如果数量大于一，错误数据
                {
                    throw new Exception("库存表中目的科室:"+dj.Mdmc+"存在多条药品：“" + djmx.Ypmc + "”的“批号”和“进价”相同的数据，请联系管理员");
                }

                //减少的科室的药品数量
                Ypkc_kc laiyuanKcParam = new Ypkc_kc();
                kcParam.Fk_keshi_id = dj.Fk_lyks;//来源的科室
                kcParam.Fk_yp_id = djmx.Fk_yp;//根据药品ID
                kcParam.Ph = djmx.Ph;//批号
                kcParam.Jj = djmx.Jj;//进价
                List<Ypkc_kc> laiyuanKcList = (List<Ypkc_kc>)ypkc_kcDal.find(kcParam, null, null, null)[0];//根据科室，药品ID，批号，进价，查询得到库存的记录
                
                if (kcList.Count > 1)//如果数量大于一，错误数据
                {
                    throw new Exception("库存表中来源科室：" + dj .Lymc+ "存在多条药品：“" + djmx.Ypmc + "”的“批号”和“进价”相同的数据，请联系管理员");
                }

                Ypkc_kc reducelKcParam = new Ypkc_kc();
                reducelKcParam.Fk_keshi_id = dj.Fk_lyks;
                reducelKcParam.Fk_yp_id = djmx.Fk_yp;
                reducelKcParam.Sl = laiyuanKcList[0].Sl - djmx.Sl;//要更新减少来源科室的数量（原本的数量-调拨的数量）
                kcReduceList.Add(reducelKcParam);

                if (kcList.Count == 1)//如果等于一，已存在，要修改数量
                {
                    //更改库存数量（把大单位数量改为小单位数量）
                    kcList[0].Sl = ddwConvertToXdwCount(djmx) + kcList[0].Sl;
                    //冗余字段也跟着修改
                    kcList[0].Ypbh = djmx.Ypbh;
                    kcList[0].Ypmc = djmx.Ypmc;
                    kcList[0].Yptymc = djmx.Yptymc;
                    kcList[0].Ypgg = djmx.Ypgg;
                    kcList[0].Jx = djmx.Jx;
                    kcList[0].Pym = djmx.Pym;

                    //入库时修改库存表中大小单位的冗余字段为最新添加的药品的单位
                    kcList[0].Ddw = djmx.Ddw;
                    kcList[0].Xdw = djmx.Xdw;
                    kcList[0].Hsbl = djmx.Hsbl;

                    //国药准字，批准文号，生产厂家
                    kcList[0].Gyzz = djmx.Gyzz;
                    kcList[0].Pzwh = djmx.Pzwh;
                    kcList[0].Cjmc = djmx.Cjmc;

                    kcList[0].Ypfl_code = dj.Ypfl_code;
                    kcModifyList.Add(kcList[0]);
                }
                else if (kcList.Count == 0)//如果等于0，说明库存没有此种药物，要新增
                {
                    //新增库存的记录
                    Ypkc_kc kcSave = new Ypkc_kc();
                    kcSave.Fk_keshi_id = dj.Fk_mdks;//目的科室外键
                    kcSave.Ksbh = dj.Mdbh;//目的科室编号
                    kcSave.Ksmc = dj.Mdmc;//目的科室名称
                    kcSave.Fk_yp_id = djmx.Fk_yp;//药品外键
                    kcSave.Ypbh = djmx.Ypbh;//药品编号
                    kcSave.Ypmc = djmx.Ypmc;//药品名称
                    kcSave.Yptymc = djmx.Yptymc;//药品通用名称
                    kcSave.Ypgg = djmx.Ypgg;//药品规格
                    kcSave.Jx = djmx.Jx;//剂型
                    kcSave.Pym = djmx.Pym;//拼音码
                    kcSave.Ddw = djmx.Ddw;//包装单位,大单位
                    kcSave.Xdw = djmx.Xdw;//发药单位，小单位
                    kcSave.Dwlx_code = CommonCode.药品库存_药品单位类型.大单位;
                    kcSave.Hsbl = djmx.Hsbl;//换算比例
                    kcSave.Ph = djmx.Ph;//批号
                    kcSave.Yxq = djmx.Yxq;//有效期
                    kcSave.Jj = djmx.Jj;//进价
                    kcSave.Lsj = djmx.Lsj;//零售价
                    kcSave.Yksl = 0;//预扣数量
                    kcSave.Gyzz = djmx.Gyzz;
                    kcSave.Pzwh = djmx.Pzwh;
                    kcSave.Cjmc = djmx.Cjmc;
                    kcSave.Zfbz = CommonCode.代码值_作废标志代码值.启用;//作废标志
                    kcSave.Ypfl_code = dj.Ypfl_code;


                    //新增的时候，数量改为小单位（大单位数量X换算比例，并且单位类型改为小单位）
                    kcSave.Sl = ddwConvertToXdwCount(djmx);//大单位数量转换为小单位数量
                    kcSave.Dwlx_code = CommonCode.药品库存_药品单位类型.小单位;
                    //大单位的进价和零售价转换为小单位的进价和零售价
                    kcSave.Jj = ddwJjConvertToXdwJj(djmx);//大单位进价转换为小单位进价
                    kcSave.Lsj = ddwLsjConvertToXdwLsj(djmx);//大单位零售价转换为小单位零售价

                    kcInsertList.Add(kcSave);
                }
                else
                {
                    throw new Exception("调拨单记账,jizhangDiaoboDjById（）发生的未知错误");
                }
            }

            bool flag1 = false;//指示第一个数据访问是否成功
            bool flag2 = false;//指示第二个数据访问是否成功
            bool flag3 = false;//指示第二个数据访问是否成功
            bool flag4 = false;//指示第二个数据访问是否成功
            bool flagResul = false//最终返回的结果
                ;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务时必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    Ypkc_dj djParam = new Ypkc_dj();
                    djParam.Id = id;
                    djParam.Jzzt_code = CommonCode.代码值_是否.是;
                    flag1 = ypkc_djDal.updateById(djParam, con);//更改单据主表为“已记账”


                    if (kcInsertList.Count > 0)
                    {
                        flag2 = ypkc_kcDal.inertBatch(kcInsertList, con);//新增库存记录
                    }
                    else
                    {
                        flag2 = true;
                    }
                    if (kcModifyList.Count > 0)
                    {
                        flag3 = ypkc_kcDal.updateByIdBatch(kcModifyList, con);//修改库存记录
                    }
                    else
                    {
                        flag3 = true;
                    }
                    if (kcReduceList.Count>0)
                    {
                        //调用多条件的更新方法
                        //构建条件参数和数据参数
                        for (int i = 0; i < kcReduceList.Count; i++)
			            {
                            Ypkc_kc kcParam = new Ypkc_kc();
                            kcParam.Fk_keshi_id = kcReduceList[i].Fk_keshi_id;
                            kcParam.Fk_yp_id = kcReduceList[i].Fk_yp_id;
                            Ypkc_kc kcData = new Ypkc_kc();
                            kcData.Sl = kcReduceList[i].Sl;
                            flag4 = ypkc_kcDal.updateByOtherCondition(kcParam, kcData, con);
			            }
              

                        
                    }
                    else
                    {
                        flag4 = true;
                    }

                    if (flag1 && flag2 && flag3)
                    {
                        ts.Complete();
                        flagResul = true;
                    }
                    return flagResul;
                }
            }
        }


        public int checkDiaoboCount(string keshiId, string ypId)
        {
            Ypkc_dj djParam = new Ypkc_dj();
            djParam.Fk_lyks =keshiId;
            Ypkc_kc kcParam = new Ypkc_kc();
            kcParam.Fk_yp_id = ypId;
            List<Ypkc_dj> djList = (List<Ypkc_dj>)ypkc_djDal.find(djParam, null, null, null)[0];
            List<Ypkc_kc> kcList = (List<Ypkc_kc>)ypkc_kcDal.find(kcParam, null, null, null)[0];

            return checkDiaoboCount(keshiId, ypId);
            
        }


        public bool deleteDiaoboDjById(string djId)
        {
            bool flag1 = false;
            bool flag2 = false;
            bool flagResul = false;
            Ypkc_dj dj = ypkc_djDal.findById(djId);
            if (dj.Jzzt_code == CommonCode.代码值_是否.是)
            {
                throw new Exception("此单据已经记账，不允许修改和删除");
            }

            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务时必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    flag1 = ypkc_djDal.deleteById(djId, con);
                    Ypkc_djmx djmxDelete = new Ypkc_djmx();
                    djmxDelete.Fk_dj_id = djId;
                    flag2 = ypkc_djMxDal.deleteByOtherCondition(djmxDelete, con);
                    if (flag1 && flag2)
                    {
                        ts.Complete();
                        flagResul = true;
                    }
                    return flagResul;
                }
            }
            return false;
        }


        public Ypkc_kc getByKeshiIdAndYpId(string keshiId, string ypId, string ypPh, decimal ypJj)
        {
            Ypkc_kc kcParam = new Ypkc_kc();
            kcParam.Fk_keshi_id = keshiId;
            kcParam.Fk_yp_id = ypId;
            kcParam.Ph = ypPh;
            kcParam.Jj = ypJj;
            List<object> obj =  ypkc_kcDal.find(kcParam, null, null, null);
            List<Ypkc_kc> kcList = (List<Ypkc_kc>)obj[0];
            if (kcList.Count>1)
            {
                throw new Exception("错误：当前来源科室的此种药品的库存记录有多条，请联系管理员");
            }
            if (kcList.Count==0)
            {
                throw new Exception("错误：当前来源科室没有库存记录");
            }
            return kcList[0];
        }









        /// <summary>
        /// 大单位数量转换为小单位数量
        /// </summary>
        /// <param name="djmx"></param>
        /// <returns></returns>
        public decimal ddwConvertToXdwCount(Ypkc_djmx djmx)
        {
            decimal returnValue = (decimal)djmx.Sl * (decimal)djmx.Hsbl;
            return returnValue;
        }

        /// <summary>
        /// 大单位进价转换为小单位的进价
        /// </summary>
        /// <param name="djmx"></param>
        /// <returns></returns>
        public decimal ddwJjConvertToXdwJj(Ypkc_djmx djmx)
        {
            decimal returnValue = (decimal)djmx.Jj/(decimal)djmx.Hsbl;
            return returnValue;
        }


        public decimal ddwLsjConvertToXdwLsj(Ypkc_djmx djmx)
        {
            decimal returnValue = (decimal)djmx.Lsj / (decimal)djmx.Lsj;
            return returnValue;
        }
    }
}
