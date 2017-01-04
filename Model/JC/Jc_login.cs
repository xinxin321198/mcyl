
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_LOGIN表的实体类
    ///基础_用户登录日志
    ///此类由代码生成器生成
    ///生成日期：2016-01-04 09:46:37
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_login:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_用户登录日志";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_LOGIN";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 用户外键(数据库字段名)
        /// </summary>
        public static readonly string FK_USER_ID = "FK_USER_ID";

        /// <summary>
        /// 登录账户（冗余）(数据库字段名)
        /// </summary>
        public static readonly string USER_NAME = "USER_NAME";

        /// <summary>
        /// 人员外键(数据库字段名)
        /// </summary>
        public static readonly string FK_RENYUAN_ID = "FK_RENYUAN_ID";

        /// <summary>
        /// 人员姓名（冗余）(数据库字段名)
        /// </summary>
        public static readonly string RENYUAN_NAME = "RENYUAN_NAME";

        /// <summary>
        /// 登录ip地址(数据库字段名)
        /// </summary>
        public static readonly string LOGIN_IP = "LOGIN_IP";

        /// <summary>
        /// 登录时间(数据库字段名)
        /// </summary>
        public static readonly string LOGIN_DATE = "LOGIN_DATE";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Jc_login对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_login ConvertToJc_login(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_login();
            }
            return (Model.JC.Jc_login)obj;
        }



        /// <summary>
        /// 主键（对象属性名）
        /// </summary>
        private string id;
        /// <summary>
        /// 主键（对象属性名）
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }



        /// <summary>
        /// 用户外键（对象属性名）
        /// </summary>
        private string fk_user_id;
        /// <summary>
        /// 用户外键（对象属性名）
        /// </summary>
        public string Fk_user_id
        {
            get { return this.fk_user_id; }
            set { this.fk_user_id = value; }
        }



        /// <summary>
        /// 登录账户（冗余）（对象属性名）
        /// </summary>
        private string user_name;
        /// <summary>
        /// 登录账户（冗余）（对象属性名）
        /// </summary>
        public string User_name
        {
            get { return this.user_name; }
            set { this.user_name = value; }
        }



        /// <summary>
        /// 人员外键（对象属性名）
        /// </summary>
        private string fk_renyuan_id;
        /// <summary>
        /// 人员外键（对象属性名）
        /// </summary>
        public string Fk_renyuan_id
        {
            get { return this.fk_renyuan_id; }
            set { this.fk_renyuan_id = value; }
        }



        /// <summary>
        /// 人员姓名（冗余）（对象属性名）
        /// </summary>
        private string renyuan_name;
        /// <summary>
        /// 人员姓名（冗余）（对象属性名）
        /// </summary>
        public string Renyuan_name
        {
            get { return this.renyuan_name; }
            set { this.renyuan_name = value; }
        }



        /// <summary>
        /// 登录ip地址（对象属性名）
        /// </summary>
        private string login_ip;
        /// <summary>
        /// 登录ip地址（对象属性名）
        /// </summary>
        public string Login_ip
        {
            get { return this.login_ip; }
            set { this.login_ip = value; }
        }



        /// <summary>
        /// 登录时间（对象属性名）
        /// </summary>
        private DateTime? login_date;
        /// <summary>
        /// 登录时间（对象属性名）
        /// </summary>
        public DateTime? Login_date
        {
            get { return this.login_date; }
            set { this.login_date = value; }
        }



        /// <summary>
        /// 作废标志（对象属性名）
        /// </summary>
        private string zfbz;
        /// <summary>
        /// 作废标志（对象属性名）
        /// </summary>
        public string Zfbz
        {
            get { return this.zfbz; }
            set { this.zfbz = value; }
        }

        //        //*****************在此之后添加关联对象
    }
}
