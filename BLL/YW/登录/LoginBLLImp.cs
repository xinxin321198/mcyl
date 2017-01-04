using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.RBAC.RBAC_用户;
using Model.RBAC;
using Model.JC;
using BLL.JC.基础_工作人员账户关系表;
using Model.Common;
using BLL.JC.基础_工作人员所属科室关系;
using BLL.Common;
using BLL.JC.工作人员;
using BLL.JC.基础_科室;

namespace BLL.YW.登录
{
    public class LoginBLLImp :LoginBLL
    {
        private Jc_kswhBLL kswhBll = new Jc_kswhBLLImp();

        private Rbac_userDALImp jc_userDal = new Rbac_userDALImp();

        private Jc_renyuan_userBLL renyuanUserBll = new Jc_renyuan_userBLLImp();

        private Jc_ry_ksBLL renyuanKeshiBll = new Jc_ry_ksBLLImp();

        private CommonBLL commonBll = new CommonBLLImp();

        private RenyuanBLL renyuanBll = new RenyuanBLLImp();

        public LoginModel login(Rbac_user jc_userParam)
        {
            LoginModel returnLoginModel = new LoginModel();;//当前登录的对象
            //登录时间
            returnLoginModel.LoginDateTime = commonBll.getCurrenDateTime();
            if ("" == jc_userParam.Pwd || null == jc_userParam.Pwd)
            {
                throw new Exception("密码不能为空");
            }
            jc_userParam.Pwd = Model.Common.MD5Helper.getEncryption(jc_userParam.Pwd);

            //读配置文件验证是否是管理员
            Rbac_user admin = Model.Common.AppConfigHelper.getAdmin();
            if (jc_userParam.Name == admin.Name && jc_userParam.Pwd == admin.Pwd)
            {
                returnLoginModel.IsAdmin = true;
                Rbac_user user = new Rbac_user();
                user.Name = jc_userParam.Name;
                user.Pwd = jc_userParam.Pwd;
                returnLoginModel.LoginUser = user;
                return returnLoginModel;
            }

            //查询数据库验证用户
            List<Rbac_user> users = (List<Rbac_user>)jc_userDal.find(jc_userParam, null, null,null)[0];
            if (users.Count <=0)
            {
                throw new Exception("此用户不存在或密码错误");
            }
            if (users.Count > 1)
            {
                throw new Exception("用户存在多个，请与管理员联系");
            }
            returnLoginModel.LoginUser = users[0];
            //根据账户ID得到工作人员
            returnLoginModel.LoginRenyuan = renyuanBll.getRenyuanByUserId(returnLoginModel.LoginUser.Id);
            



            returnLoginModel.KeshiList = kswhBll.getKeshiListByRenyuanId(returnLoginModel.LoginRenyuan.Id);
           



            return returnLoginModel;
        }

    }
}
