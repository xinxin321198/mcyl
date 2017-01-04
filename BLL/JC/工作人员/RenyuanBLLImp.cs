using DAL.JC.基础_工作人员;
using DAL.JC.基础_工作人员所属科室关系;
using Model.JC;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DAL.JC.基础_工作人员账户关系表;

namespace BLL.JC.工作人员
{
    public class RenyuanBLLImp:RenyuanBLL
    {
        private Jc_ry_ksDAL jc_ry_ksDal = new Jc_ry_ksDALImp();
        private Jc_renyuanDAL jc_renyuanDal = new Jc_renyuanDALImp();
        private Jc_renyuan_userDAL renyuanUserDal = new Jc_renyuan_userDALImp();

        public bool deleteRenyuanContactRecordById(string jc_renyuanId)
        {
            bool flag1 = false;//指示第一个操作是否成功
            bool flag2 = false;
            bool flag3= false;
            bool flagResul = false//最终返回的结果
                ;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    Jc_ry_ks ry_keDelete = new Jc_ry_ks();
                    ry_keDelete.Fk_renyuan_id = jc_renyuanId;
                    flag1 = jc_ry_ksDal.deleteByOtherCondition(ry_keDelete, con);//删除人员相关的人员科室关系记录
                    Jc_renyuan_user renyuanUserDelete = new Jc_renyuan_user();
                    renyuanUserDelete.Fk_renyuan_id = jc_renyuanId;
                    flag2 = renyuanUserDal.deleteByOtherCondition(renyuanUserDelete, con);//删除人员相关的账户
                    flag3 = jc_renyuanDal.deleteById(jc_renyuanId, con);//人员记录

                    if (flag1 && flag3)
                    {
                        flagResul = true;
                        ts.Complete();//执行成功之后提交整个事务
                    }
                    return flagResul;
                }
            }
        }



        /// <summary>
        /// 校验身份证号的唯一性
        /// </summary>
        public void checkSfzh(Jc_renyuan jc_renyuanParam)
        {
            Jc_renyuan sfzh = new Jc_renyuan();
            sfzh.Sfzh = jc_renyuanParam.Sfzh;
            int count = jc_renyuanDal.getCount(sfzh, null);
            if (count >= 1)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"此身份证号重复！
                        ");
                List<Jc_renyuan> renyuanList = (List<Jc_renyuan>)jc_renyuanDal.find(sfzh, null, null, null)[0];
                for (int i = 0; i < renyuanList.Count; i++)
                {
                    Jc_renyuan renyuan = renyuanList[i];
                    sb.Append(@"" + renyuan.Xm + @"
                        ");
                }
                sb.Append(@"正在使用此身份证号！
                        ");
                throw new Exception(sb.ToString());
            }
        }


        public bool refreshRy_ksByRenyuanId(List<Jc_ry_ks> ry_ksListSave, string renyuanId)
        {
            bool flag1 = false;
            bool flag2 = false;
            bool flagResul = false;//最终返回的结果

            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    Jc_ry_ks ry_ksDelete = new Jc_ry_ks();
                    ry_ksDelete.Fk_renyuan_id = renyuanId;
                    flag1 = jc_ry_ksDal.deleteByOtherCondition(ry_ksDelete, con);//先删除关于此人员的关系
                    flag2 = jc_ry_ksDal.inertBatch(ry_ksListSave, con);//再保存

                    if (flag1 && flag2)
                    {
                        flagResul = true;
                        ts.Complete();//执行成功之后提交整个事务
                    }
                    return flagResul;
                }
            }
        }
        //*******************在此以后添加新的方法end


        public bool refreshRy_ksByKeshiId(List<Jc_ry_ks> ry_ksListSave, string keshiId)
        {
            //删除属于某科室的所有关系记录
            //添加此科室下的人员
            throw new NotImplementedException();
        }


        public Jc_renyuan getRenyuanByUserId(string userId)
        {
            Jc_renyuan_user renyuanUser = new Jc_renyuan_user();
            renyuanUser.Fk_user_id = userId;
            List<object> objs = renyuanUserDal.findContactObjects(renyuanUser, null, null, null);
            List<Jc_renyuan_user> renyuanUserList = (List<Jc_renyuan_user>)objs[0];
            if (renyuanUserList.Count <= 0)
            {
                throw new Exception("错误：此账户没有关联过工作人员，请联系管理员");
            }
            if (renyuanUserList.Count > 1)
            {
                throw new Exception("错误：此账户关联了多个工作人员，请联系管理员");
            }
            return renyuanUserList[0].Jc_renyuan;
        }


        public bool refreshRenyuanUserByRenyuanId(List<Jc_renyuan_user> renyuanUserList, string renyuanId)
        {
            if (renyuanUserList.Count > 1)
            {
                throw new Exception("一个工作人员只允许设置一个账户");
            }
            else if (renyuanUserList.Count == 1)
            {
                string userId = renyuanUserList[0].Fk_user_id;
                Jc_renyuan_user renyuanUserParam = new Jc_renyuan_user();
                renyuanUserParam.Fk_user_id = userId;
                List<Jc_renyuan_user> temList = (List<Jc_renyuan_user>)renyuanUserDal.findContactObjects(renyuanUserParam, null, null, null)[0];
                if (temList.Count > 1)
                {
                    throw new Exception("错误，此账户关联了多个人员，请联系管理员");
                }
                else if (temList.Count == 1)
                {
                    throw new Exception("此账户已关联了人员：" + temList[0].Jc_renyuan.Xm + "，请重新选一个账户");
                }
            }

            bool flag1 = false;
            bool flag2 = false;
            bool flagResul = false;//最终返回的结果

            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    Jc_renyuan_user renyuanUserDelete = new Jc_renyuan_user();
                    renyuanUserDelete.Fk_renyuan_id = renyuanId;
                    flag1 = renyuanUserDal.deleteByOtherCondition(renyuanUserDelete, con);
                    flag2 = renyuanUserDal.inertBatch(renyuanUserList, con);

                    if (flag1 && flag2)
                    {
                        flagResul = true;
                        ts.Complete();//执行成功之后提交整个事务
                    }
                    return flagResul;
                }
            }
        }




    }
}
