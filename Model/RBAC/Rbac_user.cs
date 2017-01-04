
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.RBAC
{
    /// <summary>
    ///oracle数据库
    ///RBAC_USER表的实体类
    ///RBAC_用户
    ///此类由代码生成器生成
    ///生成日期：2015-12-05 12:05:02
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Rbac_user:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "RBAC_用户";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "RBAC_USER";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 账号(数据库字段名)
        /// </summary>
        public static readonly string NAME = "NAME";

        /// <summary>
        /// 密码(数据库字段名)
        /// </summary>
        public static readonly string PWD = "PWD";

        /// <summary>
        /// 账户类型（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string LX_CODE = "LX_CODE";

        /// <summary>
        /// 备注(数据库字段名)
        /// </summary>
        public static readonly string REMARK = "REMARK";

        /// <summary>
        /// 作废标志（0为禁用，1为启用）(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";

        /// <summary>
        /// 创建日期(数据库字段名)
        /// </summary>
        public static readonly string CJRQ = "CJRQ";
        /// <summary>
        /// 把object对象转换为Rbac_user对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.RBAC.Rbac_user ConvertToRbac_user(object obj)
        {
            if (null==obj)
            {
                return new Model.RBAC.Rbac_user();
            }
            return (Model.RBAC.Rbac_user)obj;
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
        /// 账号（对象属性名）
        /// </summary>
        private string name;
        /// <summary>
        /// 账号（对象属性名）
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }



        /// <summary>
        /// 密码（对象属性名）
        /// </summary>
        private string pwd;
        /// <summary>
        /// 密码（对象属性名）
        /// </summary>
        public string Pwd
        {
            get { return this.pwd; }
            set { this.pwd = value; }
        }



        /// <summary>
        /// 账户类型（关联代码表）（对象属性名）
        /// </summary>
        private string lx_code;
        /// <summary>
        /// 账户类型（关联代码表）（对象属性名）
        /// </summary>
        public string Lx_code
        {
            get { return this.lx_code; }
            set { this.lx_code = value; }
        }



        /// <summary>
        /// 备注（对象属性名）
        /// </summary>
        private string remark;
        /// <summary>
        /// 备注（对象属性名）
        /// </summary>
        public string Remark
        {
            get { return this.remark; }
            set { this.remark = value; }
        }



        /// <summary>
        /// 作废标志（0为禁用，1为启用）（对象属性名）
        /// </summary>
        private string zfbz;
        /// <summary>
        /// 作废标志（0为禁用，1为启用）（对象属性名）
        /// </summary>
        public string Zfbz
        {
            get { return this.zfbz; }
            set { this.zfbz = value; }
        }



        /// <summary>
        /// 创建日期（对象属性名）
        /// </summary>
        private DateTime cjrq;
        /// <summary>
        /// 创建日期（对象属性名）
        /// </summary>
        public DateTime Cjrq
        {
            get { return this.cjrq; }
            set { this.cjrq = value; }
        }

        //        //*****************在此之后添加关联对象
        #region model,实体类新增的对象，start

        /// <summary>
        /// 账户类型（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code lxCode;
        /// <summary>
        /// 账户类型（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code LxCode
        {
            get { return lxCode; }
            set { lxCode = value; }
        }

        #endregion model,实体类新增的对象，end
    }
}
