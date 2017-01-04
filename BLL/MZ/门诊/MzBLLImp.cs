using DAL.JC.基础_居民;
using DAL.MZ.门诊_病历;
using DAL.MZ.门诊_病历诊断;
using DAL.MZ.门诊_挂号;
using DAL.MZ.门诊_医嘱;
using Model.Common;
using Model.JC;
using Model.MZ;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Model.YPKC;
using DAL.YPKC.药品库存_库存表;
using BLL.JC.代码;

namespace BLL.MZ.门诊
{
    public class MzBLLImp : MzBLL
    {
        private Mz_blDAL blDal = new Mz_blDALImp();
        private Mz_blzdDAL blzdDal = new Mz_blzdDALImp();

        private Mz_ghDAL ghDal = new Mz_ghDALImp();
        private Jc_jmDAL jc_jmDal = new Jc_jmDALImp();
        private Mz_yzDAL yzDal = new Mz_yzDALImp();
        private Ypkc_kcDAL kcDal = new Ypkc_kcDALImp();

        private CodeBLL codeBll = new CodeBLLImp();
        /// <summary>
        /// 保存挂号，保存到两张表，居民表和挂号表(正常挂号和门诊医生挂号)
        /// </summary>
        /// <param Name="jm"></param>
        /// <param Name="gh"></param>
        /// <returns></returns>
        public bool saveGh(Jc_jm jm, Mz_gh gh)
        {
            bool flag1 = false;//指示第一个操作是否成功
            bool flag2 = false;//指示第二个操作是否成功
            bool flagResul = false//最终返回的结果
                ;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    //生成guid

                    flag1 = jc_jmDal.save(jm, con);//保存居民信息(如果是选择的就修改，如果是直接填写的信息就新增)
                    gh.Fk_jc_jm = jm.Id;
                    gh.State_code = Model.Common.CommonCode.门诊_挂号状态.已挂号;
                    flag2 = ghDal.insertForSequences(gh, con);//保存挂号信息
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
        /// 划价收费的挂号（划价收费挂号）
        /// </summary>
        /// <param name="jm"></param>
        /// <param name="gh"></param>
        /// <returns></returns>
        public bool saveGhForShouFei(Jc_jm jm, Mz_gh gh)
        {
            bool flag1 = false;//指示第一个操作是否成功
            bool flag2 = false;//指示第二个操作是否成功
            bool flagResul = false//最终返回的结果
                ;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    //生成guid

                    flag1 = jc_jmDal.save(jm, con);//保存居民信息(如果是选择的就修改，如果是直接填写的信息就新增)
                    gh.Fk_jc_jm = jm.Id;
                    gh.State_code = Model.Common.CommonCode.门诊_挂号状态.划价收费挂号;
                    flag2 = ghDal.insertForSequences(gh, con);//保存挂号信息
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
        /// 根据挂号ID，退号
        /// </summary>
        /// <returns></returns>
        public bool ghTuiHaoById(string ghId)
        {
            Mz_gh gh = new Mz_gh();
            gh.Id = ghId;
            gh.State_code = Model.Common.CommonCode.门诊_挂号状态.已退号;
            bool flag = ghDal.updateById(gh, null);
            return flag;
        }

        /// <summary>
        /// 保存门诊病历信息（包括门诊病历表和门诊病历诊断表）
        /// </summary>
        /// <param name="bl"></param>
        /// <param name="blzdList"></param>
        /// <returns></returns>
        public bool SaveMzbl(Model.MZ.Mz_bl bl, List<Model.MZ.Mz_blzd> blzdList)
        {
            bool flag1 = false;//指示第一个操作是否成功
            bool flag2 = false;//指示第二个操作是否成功
            bool flagResul = false//最终返回的结果
                ;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    //生成guid
                    bl.Id = GUIDHelper.getGuid();
                    flag1 = blDal.insert(bl, con);//保存门诊病历

                    //保存病历诊断
                    for (int i = 0; i < blzdList.Count; i++)
                    {
                        blzdList[i].Fk_bl_id = bl.Id;
                    }
                    flag2 = blzdDal.inertBatch(blzdList, con);//保存挂号信息
                    if (flag1 && flag2)
                    {
                        flagResul = true;
                        ts.Complete();//执行成功之后提交整个事务
                    }
                    return flagResul;
                }
            }
        }


        public bool modifyMzbl(Model.MZ.Mz_bl bl, List<Model.MZ.Mz_blzd> blzdList)
        {
            bool flag1 = false;//指示第一个操作是否成功
            bool flag2 = false;//指示第二个操作是否成功
            bool flag3 = false;
            bool flagResul = false//最终返回的结果
                ;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {

                    flag1 = blDal.updateById(bl, con);//修改门诊病历
                    Mz_blzd blzdDelete = new Mz_blzd();
                    blzdDelete.Fk_bl_id = bl.Id;
                    flag2 = blzdDal.deleteByOtherCondition(blzdDelete, con);//删除病历诊断信息，重新添加
                    //保存病历诊断
                    for (int i = 0; i < blzdList.Count; i++)
                    {
                        blzdList[i].Fk_bl_id = bl.Id;
                    }
                    flag3 = blzdDal.inertBatch(blzdList, con);//保存挂号信息
                    if (flag1 && flag2 && flag3)
                    {
                        flagResul = true;
                        ts.Complete();//执行成功之后提交整个事务
                    }
                    return flagResul;
                }
            }
        }


        public Model.MZ.Mz_bl getMzblByGhId(string ghId)
        {
            Mz_bl blParam = new Mz_bl();
            blParam.Fk_gh_id = ghId;
            List<object> objs = blDal.find(blParam, null, null, null);//根据挂号的ID查询出属于此号的病历对象
            List<Mz_bl> blList = (List<Mz_bl>)objs[0];
            if (blList.Count > 1)
            {
                throw new Exception("错误：此号有多个病历记录，请联系管理员");
            }
            if (blList.Count == 1)
            {
                return blList[0];
            }
            else
            {
                return null;
            }
        }


        public bool ghJieZhenStart(string ghId)
        {
            Mz_gh gh = new Mz_gh();
            gh.Id = ghId;//设ID，是为了修改，或者直接调用update也一样
            gh.State_code = CommonCode.门诊_挂号状态.接诊中;//设为接诊中
            return ghDal.save(gh,null);
        }

        public bool ghJieZhenEnd(string ghId)
        {
            bool flag = true;
            StringBuilder errorMsg = new StringBuilder();
            //1.得到此挂号下的所有药品的医嘱=此药数量
            //2.得到其它已诊断完的医嘱下的1的药品医嘱（药品ID，批号，进价，零售价,科室）=已开数量
            //3.得到1下的药品的总库存（药品ID，批号，进价，零售价,科室）//总库存量
            //3.总库存-已开药品数量=可开数量
            //4.如果此药数量>可开数量,数量超标,就记录下此种药数量还剩多少，开了多少，超了多少

            //1.得到此挂号下的所有药品的医嘱
            Mz_yz yzParam = new Mz_yz();
            yzParam.Fk_gh_id = ghId;
            yzParam.Yzlx_code = CommonCode.门诊_医嘱类型.药品;
            List<Mz_yz> yzList = (List<Mz_yz>)yzDal.find(yzParam, null, null, null)[0];//本医嘱

            for (int i = 0; i < yzList.Count; i++)
            {


                decimal yiKaiYpCount = 0;
                //2.得到其它已诊断完的医嘱下的1的药品医嘱（药品ID，批号，进价，零售价,科室）
                Mz_gh ghParam = new Mz_gh();
                ghParam.State_code = CommonCode.门诊_挂号状态.未收费;
                List<Mz_gh> ghList = (List<Mz_gh>)ghDal.find(ghParam, null, null, null)[0];
                for (int j = 0; j < ghList.Count; j++)
                {
                    Mz_yz yzZhenduanEndParam = new Mz_yz();
                    yzZhenduanEndParam.Fk_gh_id = ghList[j].Id;
                    yzZhenduanEndParam.Fk_keshi_id = yzList[i].Fk_keshi_id;
                    yzZhenduanEndParam.Fk_yp = yzList[i].Fk_yp;
                    yzZhenduanEndParam.Ph = yzList[i].Ph;
                    yzZhenduanEndParam.Jj = yzList[i].Jj;
                    yzZhenduanEndParam.Lsj = yzList[i].Lsj;
                    yzZhenduanEndParam.Yzlx_code = CommonCode.门诊_医嘱类型.药品;
                    List<Mz_yz> yzZhenduanList = (List<Mz_yz>)yzDal.find(yzZhenduanEndParam, null, null, null)[0];//未领药医嘱

                    if (yzZhenduanList.Count>1)
                    {
                        throw new Exception("同科室、同批号、同进价、同零售价的医嘱“"+yzList[i].Xmmc+"”，在流水号“"+ghList[i].Lsh+"”的挂号下存在多个，请联系管理员");
                    }
                    yiKaiYpCount = yiKaiYpCount + (decimal)yzZhenduanList[0].Sl;

                }


                //3.得到1下的药品的总库存（药品ID，批号，进价，零售价,科室）
                Ypkc_kc zkcParam = new Ypkc_kc();
                zkcParam.Fk_keshi_id = yzList[i].Fk_keshi_id;
                zkcParam.Fk_yp_id = yzList[i].Fk_yp;
                zkcParam.Ph = yzList[i].Ph;
                zkcParam.Jj = yzList[i].Jj;
                zkcParam.Lsj = yzList[i].Lsj;
                List<Ypkc_kc> zkcList = (List<Ypkc_kc>)kcDal.find(zkcParam, null, null, null)[0];//总库存

                if (zkcList.Count > 1)
                {
                    throw new Exception("同科室、同批号、同进价、同零售价的" + yzList[i].Xmmc + "，在库存表存在多个，请联系管理员");
                }
                Ypkc_kc zkc = zkcList[0];

                decimal keKaiYp = (decimal)zkc.Sl - yiKaiYpCount;//总库存-已开药品数量=可开数量

                if (yzList[i].Sl>keKaiYp)//如果此药数量>可开数量,数量超标
                {
                    errorMsg.Append(@"
药品”" + yzList[i].Xmmc + @"“的开药的数量为“" + yzList[i].Sl + @"”，已超过可开药的库存量，请减少此药的数量后重试
可开药的库存量“" + keKaiYp + @"”
其它病人医嘱已开数量：" + yiKaiYpCount + @"
总库存量：" + zkc.Sl + @"
");
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }


            if (flag)
            {
                Mz_gh gh = new Mz_gh();
                gh.Id = ghId;//设ID，是为了修改，或者直接调用update也一样
                gh.State_code = CommonCode.门诊_挂号状态.未收费;
                flag = ghDal.save(gh, null);
            }
            else
            {
                throw new Exception(errorMsg.ToString());
            }
            return flag;
			




        }


        public bool shouFeiJiZhang(string ghId)
        {
            Mz_gh gh = new Mz_gh();
            gh.Id = ghId;
            gh.State_code = CommonCode.门诊_挂号状态.已收费;
            return ghDal.updateById(gh, null);
        }


        public bool faYao(List<Mz_yz> yzList)
        {
            List<Ypkc_kc> newKcList = new List<Ypkc_kc>();

            Jc_code gou = codeBll.getCodeByValue(CommonCode.代码值_勾叉.勾, CommonCode.代码类型值.基础_勾叉);
            foreach (Mz_yz item in yzList)
            {
                item.Sfwc = gou.Name;
                item.Sfwc_code = gou.Value;

                Ypkc_kc kc = new Ypkc_kc();
                kc.Fk_yp_id = item.Fk_yp;
                kc.Fk_keshi_id = item.Fk_keshi_id;
                kc.Ph = item.Ph;
                kc.Jj = item.Jj;
                List<Ypkc_kc> kcList = (List<Ypkc_kc>) kcDal.find(kc, null, null, null)[0];
                if (kcList.Count==0)
                {
                    throw new Exception("错误：库存中没有此种药品的记录，药品编号:"+item.Xmbh+",药品所属科室："+item.Keshi+",药品批号："+item.Ph+",药品进价："+item.Jj);
                }
                if (kcList.Count>1)
                {
                    throw new Exception("错误：库存中有多条此种药品的的记录，药品编号:"+item.Xmbh+",药品所属科室："+item.Keshi+",药品批号："+item.Ph+",药品进价："+item.Jj);
                }
                kcList[0].Sl = kcList[0].Sl - item.Sl;
                newKcList.Add(kcList[0]);
                
            }
            //减少这些药在库存表中的库存数量,在库存中是小单位

            bool flag1 = false;
            bool flag2 = false;
            bool returnFalg = false;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    flag1 = yzDal.updateByIdBatch(yzList, con);
                    flag2 = kcDal.updateByIdBatch(newKcList, con);

                    if (flag1&&flag2)
                    {
                        ts.Complete();
                        returnFalg = true;
                    }
                }
            }

            return returnFalg;
        }


        public List<Mz_gh> getWeiShouFeiGhListContactObject()
        {
            Mz_gh gh = new Mz_gh();
            gh.State_code = CommonCode.门诊_挂号状态.未收费;
            List<SortInfo> sortList = new List<SortInfo>();
            sortList.Add(new SortInfo(Mz_gh.GHRQ));
            List<object> objs =  ghDal.findContactObjects(gh, null, null, sortList);
            List<Mz_gh> ghList = (List<Mz_gh>)objs[0];
            List<Mz_gh> newGhList = new List<Mz_gh>();
            foreach (var item in ghList)
            {
                DateTime secondDays = DateTime.Now.AddDays(-2);//当前天数的2天前
                if (item.Ghrq >= secondDays)//如果挂号时间小于当前时间两天前，就remove
                {
                    newGhList.Add(item);
                }
            }
            return newGhList;
        }
    }
}
