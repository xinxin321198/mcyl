using DAL.YPKC.药品库存_单据主表;
using DAL.YPKC.药品库存_单据子表;
using DAL.YPKC.药品库存_库存表;
using Model.Common;
using Model.YPKC;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL.YPKC.药品入库
{
    public class Ypkc_RuKuBLLImp : Ypkc_RuKuBLL
    {

        private Ypkc_djDAL ypkc_djDal = new Ypkc_djDALImp();

        private Ypkc_djmxDAL ypkc_djMxDal = new Ypkc_djmxDALImp();

        private Ypkc_kcDAL ypkc_kcDal = new Ypkc_kcDALImp();

        /// <summary>
        /// 新增一个入库单（同时添加主表和字表的信息）
        /// </summary>
        /// <param name="dj"></param>
        /// <param name="djmxList"></param>
        /// <returns></returns>
        public bool addRuKuDj(Ypkc_dj dj, List<Ypkc_djmx> djmxList)
        {
            bool flag1 = false;//指示第一个数据访问是否成功
            bool flag2 = false;//指示第二个数据访问是否成功
            bool flagResul = false//最终返回的结果
                ;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务时必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    dj.Id = Model.Common.GUIDHelper.getGuid();

                    flag1 = ypkc_djDal.insertForLshSequences(dj, con);//新增单据（GUID使用手动添加，单据流水号使用sequences（ypkc_djh）取下一号）

                    for (int i = 0; i < djmxList.Count; i++)
                    {
                        Ypkc_djmx djmx = djmxList[i];
                        djmx.Fk_dj_id = dj.Id;//单据明细所属的单据ID
                    }
                    flag2 = ypkc_djMxDal.inertBatchForLshSequences(djmxList, con);//单据的流水号使用sequences（ypkc_djh）取当前的号
                    if (flag1 && flag2)
                    {
                        flagResul = true;
                        ts.Complete();//执行成功之后提交整个事务
                    }
                    return flagResul;
                }
            }
        }

        /// <summary>
        /// 修改入库单
        /// </summary>
        /// <param name="dj"></param>
        /// <param name="djmxList"></param>
        /// <returns></returns>
        public bool modifyRuKuDj(Ypkc_dj dj, List<Ypkc_djmx> djmxList)
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


        /// <summary>
        /// 入库单记账（计算库存，如果药的编码和批号和价格相同，才能在原有基础上新增数量，否则就新增）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool jizhangRuKuDjById(string id)
        {
            /* 1.查询出此单据下的所有药品
             * 2.更改单据主表记录的“记账”字段为已记账
             * 3.根据单据明细的药品查询出药品库存中的药品
             * 3.比对药库库存表中的药品（相同药品编号编号、跟已有库存中不同批号或者不同进价的就新增一个库存，否则在 原有基础上增加数量）
             */
            Ypkc_dj dj = ypkc_djDal.findById(id);
            Ypkc_djmx djmxParam = new Ypkc_djmx();
            djmxParam.Fk_dj_id = id;
            List<Ypkc_djmx> djmxList = (List<Ypkc_djmx>)ypkc_djMxDal.find(djmxParam, null, null, null)[0];//得到单据明细的药品
            List<Ypkc_kc> kcModifyList = new List<Ypkc_kc>();
            List<Ypkc_kc> kcInsertList = new List<Ypkc_kc>();
    
            for (int i = 0; i < djmxList.Count; i++)
            {
                Ypkc_djmx djmx = djmxList[i];
                Ypkc_kc kcParam = new Ypkc_kc();
                kcParam.Fk_keshi_id = dj.Fk_mdks;//入库的科室
                kcParam.Fk_yp_id = djmx.Fk_yp;//根据药品ID
                kcParam.Ph = djmx.Ph;//批号
                kcParam.Jj = djmx.Jj;//进价
                List<Ypkc_kc> kcList = (List<Ypkc_kc>)ypkc_kcDal.find(kcParam, null, null, null)[0];
                if (kcList.Count > 1)
                {
                    throw new Exception("库存表中存在多条药品“ID”、“批号”和“进价”相同的数据，请联系管理员，名称为"+kcList[i].Ypmc+"");
                }
                else if (kcList.Count == 1)
                {
                    //更改库存数量
                    kcList[0].Sl = djmx.Sl + kcList[0].Sl;
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

                    //药品类型
                    kcList[0].Ypfl_code = dj.Ypfl_code;
                    kcModifyList.Add(kcList[0]);
                }
                else if (kcList.Count == 0)
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
                    kcSave.Sl = djmx.Sl;//数量
                    kcSave.Yksl = 0;//预扣数量
                    kcSave.Gyzz = djmx.Gyzz;
                    kcSave.Pzwh = djmx.Pzwh;
                    kcSave.Cjmc = djmx.Cjmc;
                    kcSave.Zfbz = CommonCode.代码值_作废标志代码值.启用;//作废标志

                    //药品类型
                    kcSave.Ypfl_code = dj.Ypfl_code;
                    kcInsertList.Add(kcSave);
                }
                else
                {
                    throw new Exception("入库单记账,jizhangRuKuDjById（）发生的未知错误");
                }
            }

            bool flag1 = false;//指示第一个数据访问是否成功
            bool flag2 = false;//指示第二个数据访问是否成功
            bool flag3 = false;//指示第二个数据访问是否成功
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
                        flag2 = ypkc_kcDal.inertBatch(kcInsertList, con);
                    }
                    else
                    {
                        flag2 = true;
                    }
                    if (kcModifyList.Count > 0)
                    {
                        flag3 = ypkc_kcDal.updateByIdBatch(kcModifyList, con);
                    }
                    else
                    {
                        flag3 = true;
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


        public bool deleteRuKuDjById(string djId)
        {

            bool flag1 = false;
            bool flag2 = false;
            bool flagResul = false;
            Ypkc_dj dj =  ypkc_djDal.findById(djId);
            if (dj.Jzzt_code == CommonCode.代码值_是否.是)
            {
                throw new Exception("此单据已经记账，不允许修改和删除");
            }

            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务时必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    flag1 = ypkc_djDal.deleteById(djId,con);
                    Ypkc_djmx djmxDelete = new Ypkc_djmx();
                    djmxDelete.Fk_dj_id = djId;
                    flag2 = ypkc_djMxDal.deleteByOtherCondition(djmxDelete,con);
                    if (flag1 && flag2 )
                    {
                        ts.Complete();
                        flagResul = true;
                    }
                    return flagResul;
                }
            }
            return false;
        }
    }
}
