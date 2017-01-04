using DAL.JC.基础_工作人员账户关系表;
using DAL.RBAC.RBAC_角色;
using DAL.RBAC.RBAC_角色模块关系;
using DAL.RBAC.RBAC_模块;
using DAL.RBAC.RBAC_用户;
using DAL.RBAC.RBAC_用户角色关系表;
using Model.JC;
using Model.RBAC;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL.RBAC.权限
{
    public class PermissionsBLLImp:PermissionsBLL
    {

        private Rbac_roleDAL roleDal = new Rbac_roleDALImp();

        private Rbac_user_roleDAL userRoleDal = new Rbac_user_roleDALImp();

        private Rbac_role_modulesDAL roleModulesDal = new Rbac_role_modulesDALImp();
        private Rbac_modulesDAL modulesDal = new Rbac_modulesDALImp();

        private Jc_renyuan_userDAL renyuanUserDal = new Jc_renyuan_userDALImp();
        private Rbac_userDAL userDal = new Rbac_userDALImp();


        public bool deleteRoleAndRelationByRoleId(string roleId)
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
                    Rbac_role_modules roleModulesDelete = new Rbac_role_modules();
                    roleModulesDelete.Fk_role_id = roleId;
                    flag1 = roleModulesDal.deleteByOtherCondition(roleModulesDelete, con); //使用DAL层的重载方法传入OracleConnection对象
                    Rbac_user_role deleteParam = new Rbac_user_role();
                    deleteParam.Fk_role_id = roleId;
                    flag2 = userRoleDal.deleteByOtherCondition(deleteParam, con);
                    flag3 = roleDal.deleteById(roleId, con);//使用DAL层的重载方法传入OracleConnection对象
                    if (flag1 && flag2 && flag3)
                    {
                        flagResul = true;
                        ts.Complete();//执行成功之后提交整个事务
                    }
                    return flagResul;
                }
            }
        }




        public bool refreshRole_modulesByRoleId(List<Rbac_role_modules> roleModulesSaveList, string roleId)
        {
            bool flag1 = false;
            bool flag2 = false;
            bool flagResul = false;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    Rbac_role_modules role_modulesDelete = new Rbac_role_modules();
                    role_modulesDelete.Fk_role_id = roleId;
                    flag1 = roleModulesDal.deleteByOtherCondition(role_modulesDelete, con);//使用DAL层的重载方法传入OracleConnection对象
                    for (int i = 0; i < roleModulesSaveList.Count; i++)
                    {
                        Rbac_role_modules saveData = roleModulesSaveList[i];
                        flag2 = roleModulesDal.save(saveData, con);
                    }
                    if (flag1 && flag2)
                    {
                        flagResul = true;
                        ts.Complete();//执行成功之后提交整个事务
                    }
                    return flagResul;
                }
            }
        }




        public bool deleteChildNodeAndRoleRelationByModulesId(string id)
        {


            bool flag1 = false;//指示第一个操作是否成功
            bool flag2 = false;//指示第二个操作是否成功
            bool flagResul = false//最终返回的结果
                ;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    flag2 = modulesDal.deleteCurrentAndChildNodeRoleRelation(id, con);//使用DAL层的重载方法传入OracleConnection对象
                    flag1 = modulesDal.deleteCurrentAndChildNode(id, con);//使用DAL层的重载方法传入OracleConnection对象

                    if (flag1 && flag2)
                    {
                        flagResul = true;
                        ts.Complete();//执行成功之后提交整个事务
                    }
                    return flagResul;
                }
            }
        }








        public List<Rbac_modules> getModulesByUserId(string userId, Rbac_modules modulesParam)
        {
            return (List<Rbac_modules>)modulesDal.getModulesByUserId(userId, modulesParam, null)[0];
        }


        /// <summary>
        /// 根据ID删除用户，并且删除用户相关联的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool deleteAndRelationByUserId(string id)
        {
            bool flag1 = false;//指示第一个数据访问是否成功
            bool flag2 = false;//指示第二个数据访问是否成功
            bool flagResul = false//最终返回的结果
                ;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务时必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    //删除type
                    Jc_renyuan_user renyuanUser = new Jc_renyuan_user();
                    renyuanUser.Fk_user_id = id;
                    flag1 = renyuanUserDal.deleteByOtherCondition(renyuanUser, con);//调用数据访问层的方法
                    //删除属于此type类型的所有code
                    flag2 = userDal.deleteById(id, con);//调用数据访问层的方法
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
        /// 得到设定关联过人员的账户
        /// </summary>
        /// <returns></returns>
        public List<Rbac_user> getSetOffRenyuan_user()
        {
            return userDal.getSetOffRenyuan_user();
        }

        public bool refreshUserRole(List<Rbac_user_role> userRoleSaveList, string userId)
        {
            bool flag1 = false;
            bool flag2 = false;
            bool flagResul = false;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    Rbac_user_role user_roleDeleteParam = new Rbac_user_role();
                    user_roleDeleteParam.Fk_user_id = userId;
                    flag1 = userRoleDal.deleteByOtherCondition(user_roleDeleteParam, con);//使用DAL层的重载方法传入OracleConnection对象
                    if (userRoleSaveList.Count == 0)
                    {
                        flag2 = true;
                    }
                    for (int i = 0; i < userRoleSaveList.Count; i++)
                    {
                        Rbac_user_role saveData = userRoleSaveList[i];
                        flag2 = userRoleDal.save(saveData, con);
                    }
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
