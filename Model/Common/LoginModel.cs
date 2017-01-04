using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.JC;
using Model.RBAC;

namespace Model.Common
{
    public class LoginModel
    {
        /// <summary>
        /// 当前登录用户
        /// </summary>
        private Rbac_user loginUser;
        /// <summary>
        /// 当前登录用户
        /// </summary>
        public Rbac_user LoginUser
        {
            get { return loginUser; }
            set { loginUser = value; }
        }

        /// <summary>
        /// 当前登录用户所属的人员
        /// </summary>
        private Jc_renyuan loginRenyuan;
        /// <summary>
        /// 当前登录用户所属的人员
        /// </summary>
        public Jc_renyuan LoginRenyuan
        {
            get { return loginRenyuan; }
            set { loginRenyuan = value; }
        }


        /// <summary>
        /// 人员当前登录的科室
        /// </summary>
        private Jc_kswh loginKeShi;
        /// <summary>
        /// 人员当前登录的科室
        /// </summary>
        public Jc_kswh LoginKeShi
        {
            get { return loginKeShi; }
            set { loginKeShi = value; }
        }

        /// <summary>
        /// 当前登录的计算机IP地址
        /// </summary>
        private string loginIp;

        /// <summary>
        /// 当前登录的计算机IP地址
        /// </summary>
        public string LoginIp
        {
          get { return loginIp; }
          set { loginIp = value; }
        }


        /// <summary>
        /// 当前登录的时间（取服务器的时间）
        /// </summary>
        private DateTime loginDateTime;
        /// <summary>
        /// 当前登录的时间（取服务器的时间）
        /// </summary>
        public DateTime LoginDateTime
        {
            get { return loginDateTime; }
            set { loginDateTime = value; }
        }

        /// <summary>
        /// 当前登录是否是管理员(默认不是)
        /// </summary>
        private bool isAdmin = false;
        /// <summary>
        /// 当前登录是否是管理员(默认不是)
        /// </summary>
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        /// <summary>
        /// 当前登录人员所属的科室集合
        /// </summary>
        private List<Jc_kswh> keshiList;
        /// <summary>
        /// 当前登录的人员所属的科室集合
        /// </summary>
        public List<Jc_kswh> KeshiList
        {
            get { return keshiList; }
            set { keshiList = value; }
        }



    }
}
