using Model.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RBAC.权限
{
    public interface PermissionsBLL
    {

        /// <summary>
        /// 删除角色相关的模块关系
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        bool deleteRoleAndRelationByRoleId(string roleId);




        /// <summary>
        /// 根据角色的ID，刷新角色模块关系，（删除此角色的所有记录，重新添加记录)
        /// </summary>
        /// <param name="roleModulesSaveList"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        bool refreshRole_modulesByRoleId(List<Rbac_role_modules> roleModulesSaveList, string roleId);



        /// <summary>
        /// 根据模块ID,删除节点，并且删除相关的下级节点以及所有节点有关的角色关系
        /// </summary>
        /// <param Name="id"></param>
        /// <returns></returns>
        bool deleteChildNodeAndRoleRelationByModulesId(string modulesId);

        /// <summary>
        /// 根据用户的id,得到此用户拥有的所有模块，已去重复（1.根据用户ID得到此用户拥有的所有角色。2.所拥有的角色查询得到角色所拥有的所有模块。3.去掉重复返回出来）
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="modulesParam"></param>
        /// <returns></returns>
        List<Rbac_modules> getModulesByUserId(string userId, Rbac_modules modulesParam);



        /// <summary>
        /// 根据用户ID删除用户，并且删除用户相关联的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool deleteAndRelationByUserId(string id);


        /// <summary>
        /// 得到已关联过人员的账户
        /// </summary>
        /// <returns></returns>
        List<Rbac_user> getSetOffRenyuan_user();



        /// <summary>
        /// 根据角色Id,刷新用户角色关系(删除此用户的所有角色记录，重新添加记录)
        /// </summary>
        /// <param name="userROleSaveList"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        bool refreshUserRole(List<Rbac_user_role> userRoleSaveList, string roleId);
    }
}
