
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.RBAC
{
    /// <summary>
    ///oracle数据库
    ///RBAC_ROLE表的实体类
    ///RBAC_角色
    ///此类由代码生成器生成
    ///生成日期：2015-10-22 17:47:16
    /// 
    /// </summary>
    public class Rbac_role : Base.IBaseModel
        {
        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "RBAC_ROLE";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 角色名称(数据库字段名)
        /// </summary>
        public static readonly string NAME = "NAME";

        /// <summary>
        /// 备注(数据库字段名)
        /// </summary>
        public static readonly string REMARK = "REMARK";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Rbac_role对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.RBAC.Rbac_role ConvertToRbac_role(object obj)
        {
            if (null==obj)
            {
                return new Model.RBAC.Rbac_role();
            }
            return (Model.RBAC.Rbac_role)obj;
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
        /// 角色名称（对象属性名）
        /// </summary>
        private string name;
        /// <summary>
        /// 角色名称（对象属性名）
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
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
