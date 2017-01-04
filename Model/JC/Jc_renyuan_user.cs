
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_RENYUAN_USER表的实体类
    ///基础_工作人员账户关系表
    ///此类由代码生成器生成
    ///生成日期：2015-12-02 12:14:49
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_renyuan_user:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_工作人员账户关系表";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_RENYUAN_USER";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 工作人员外键(数据库字段名)
        /// </summary>
        public static readonly string FK_RENYUAN_ID = "FK_RENYUAN_ID";

        /// <summary>
        /// 账户外键(数据库字段名)
        /// </summary>
        public static readonly string FK_USER_ID = "FK_USER_ID";

        /// <summary>
        /// 作废标志（0是禁用，1是启用）(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Jc_renyuan_user对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_renyuan_user ConvertToJc_renyuan_user(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_renyuan_user();
            }
            return (Model.JC.Jc_renyuan_user)obj;
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
        /// 工作人员外键（对象属性名）
        /// </summary>
        private string fk_renyuan_id;
        /// <summary>
        /// 工作人员外键（对象属性名）
        /// </summary>
        public string Fk_renyuan_id
        {
            get { return this.fk_renyuan_id; }
            set { this.fk_renyuan_id = value; }
        }



        /// <summary>
        /// 账户外键（对象属性名）
        /// </summary>
        private string fk_user_id;
        /// <summary>
        /// 账户外键（对象属性名）
        /// </summary>
        public string Fk_user_id
        {
            get { return this.fk_user_id; }
            set { this.fk_user_id = value; }
        }



        /// <summary>
        /// 作废标志（0是禁用，1是启用）（对象属性名）
        /// </summary>
        private string zfbz;
        /// <summary>
        /// 作废标志（0是禁用，1是启用）（对象属性名）
        /// </summary>
        public string Zfbz
        {
            get { return this.zfbz; }
            set { this.zfbz = value; }
        }

        //        //*****************在此之后添加关联对象
        #region model,实体类新增的对象，start

        /// <summary>
        /// 工作人员外键对象
        /// </summary>
        private Model.JC.Jc_renyuan jc_renyuan;
        /// <summary>
        /// 工作人员外键对象
        /// </summary>
        public Model.JC.Jc_renyuan Jc_renyuan
        {
            get { return jc_renyuan; }
            set { jc_renyuan = value; }
        }

        /// <summary>
        /// 账户外键对象
        /// </summary>
        private Model.RBAC.Rbac_user rbac_user;
        /// <summary>
        /// 账户外键对象
        /// </summary>
        public Model.RBAC.Rbac_user Rbac_user
        {
            get { return rbac_user; }
            set { rbac_user = value; }
        }

        #endregion model,实体类新增的对象，end
    }
}
