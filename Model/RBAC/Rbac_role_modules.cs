
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.RBAC
{
    /// <summary>
    ///oracle数据库
    ///RBAC_ROLE_MODULES表的实体类
    ///RBAC_角色模块关系
    ///此类由代码生成器生成
    ///生成日期：2015-10-22 17:47:11
    /// 
    /// </summary>
    public class Rbac_role_modules : Base.IBaseModel
        {
        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "RBAC_ROLE_MODULES";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 角色id(数据库字段名)
        /// </summary>
        public static readonly string FK_ROLE_ID = "FK_ROLE_ID";

        /// <summary>
        /// 模块id(数据库字段名)
        /// </summary>
        public static readonly string FK_MODULES_ID = "FK_MODULES_ID";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Rbac_role_modules对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.RBAC.Rbac_role_modules ConvertToRbac_role_modules(object obj)
        {
            if (null==obj)
            {
                return new Model.RBAC.Rbac_role_modules();
            }
            return (Model.RBAC.Rbac_role_modules)obj;
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
        /// 角色id（对象属性名）
        /// </summary>
        private string fk_role_id;
        /// <summary>
        /// 角色id（对象属性名）
        /// </summary>
        public string Fk_role_id
        {
            get { return this.fk_role_id; }
            set { this.fk_role_id = value; }
        }



        /// <summary>
        /// 模块id（对象属性名）
        /// </summary>
        private string fk_modules_id;
        /// <summary>
        /// 模块id（对象属性名）
        /// </summary>
        public string Fk_modules_id
        {
            get { return this.fk_modules_id; }
            set { this.fk_modules_id = value; }
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
        #region model,实体类新增的对象，start

        /// <summary>
        /// 角色id对象
        /// </summary>
        private Model.RBAC.Rbac_role rbac_role;
        /// <summary>
        /// 角色id对象
        /// </summary>
        public Model.RBAC.Rbac_role Rbac_role
        {
            get { return rbac_role; }
            set { rbac_role = value; }
        }

        /// <summary>
        /// 模块id对象
        /// </summary>
        private Model.RBAC.Rbac_modules rbac_modules;
        /// <summary>
        /// 模块id对象
        /// </summary>
        public Model.RBAC.Rbac_modules Rbac_modules
        {
            get { return rbac_modules; }
            set { rbac_modules = value; }
        }

        #endregion model,实体类新增的对象，end
    }
}
