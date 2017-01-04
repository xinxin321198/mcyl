using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.RBAC;
using Model.JC;
using Model.Common;

namespace BLL.YW.登录
{
    /// <remarks>用户登录业务逻辑</remarks>
    public interface LoginBLL
    {
        /// <summary>
        /// 检查当前用户名密码是否可以登录
        /// </summary>
        LoginModel login(Rbac_user userParam);

    }
}
