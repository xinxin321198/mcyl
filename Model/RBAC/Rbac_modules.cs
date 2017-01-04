
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.RBAC
{
    /// <summary>
    ///oracle数据库
    ///RBAC_MODULES表的实体类
    ///RBAC_模块
    ///此类由代码生成器生成
    ///生成日期：2015-11-04 16:09:38
    /// 
    /// </summary>
    public class Rbac_modules : Base.IBaseModel
    {
        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "RBAC_MODULES";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 父id(数据库字段名)
        /// </summary>
        public static readonly string PID = "PID";

        /// <summary>
        /// 模块名称(数据库字段名)
        /// </summary>
        public static readonly string NAME = "NAME";

        /// <summary>
        /// 块要打开的窗体完全限定名称（包括命名空间）(数据库字段名)
        /// </summary>
        public static readonly string WINDOW_NAME = "WINDOW_NAME";

        /// <summary>
        /// 模块类型，菜单还是功能点（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string TYPE_CODE = "TYPE_CODE";

        /// <summary>
        /// 菜单是否允许直接打开窗体（功能点必须允许,菜单可选，关联代码表，是否）(数据库字段名)
        /// </summary>
        public static readonly string IS_OPEN_WINDOW_CODE = "IS_OPEN_WINDOW_CODE";

        /// <summary>
        /// 排序码(数据库字段名)
        /// </summary>
        public static readonly string SORT = "SORT";

        /// <summary>
        /// 图标名称(数据库字段名)
        /// </summary>
        public static readonly string ICON = "ICON";

        /// <summary>
        /// 备注(数据库字段名)
        /// </summary>
        public static readonly string REMARK = "REMARK";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Rbac_modules对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.RBAC.Rbac_modules ConvertToRbac_modules(object obj)
        {
            if (null == obj)
            {
                return new Model.RBAC.Rbac_modules();
            }
            return (Model.RBAC.Rbac_modules)obj;
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
        /// 父id（对象属性名）
        /// </summary>
        private string pid;
        /// <summary>
        /// 父id（对象属性名）
        /// </summary>
        public string Pid
        {
            get { return this.pid; }
            set { this.pid = value; }
        }



        /// <summary>
        /// 模块名称（对象属性名）
        /// </summary>
        private string name;
        /// <summary>
        /// 模块名称（对象属性名）
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }



        /// <summary>
        /// 块要打开的窗体完全限定名称（包括命名空间）（对象属性名）
        /// </summary>
        private string window_name;
        /// <summary>
        /// 块要打开的窗体完全限定名称（包括命名空间）（对象属性名）
        /// </summary>
        public string Window_name
        {
            get { return this.window_name; }
            set { this.window_name = value; }
        }



        /// <summary>
        /// 模块类型，菜单还是功能点（关联代码表）（对象属性名）
        /// </summary>
        private string type_code;
        /// <summary>
        /// 模块类型，菜单还是功能点（关联代码表）（对象属性名）
        /// </summary>
        public string Type_code
        {
            get { return this.type_code; }
            set { this.type_code = value; }
        }



        /// <summary>
        /// 菜单是否允许直接打开窗体（功能点必须允许,菜单可选，关联代码表，是否）（对象属性名）
        /// </summary>
        private string is_open_window_code;
        /// <summary>
        /// 菜单是否允许直接打开窗体（功能点必须允许,菜单可选，关联代码表，是否）（对象属性名）
        /// </summary>
        public string Is_open_window_code
        {
            get { return this.is_open_window_code; }
            set { this.is_open_window_code = value; }
        }



        /// <summary>
        /// 排序码（对象属性名）
        /// </summary>
        private decimal? sort;
        /// <summary>
        /// 排序码（对象属性名）
        /// </summary>
        public decimal? Sort
        {
            get { return this.sort; }
            set { this.sort = value; }
        }



        /// <summary>
        /// 图标名称（对象属性名）
        /// </summary>
        private string icon;
        /// <summary>
        /// 图标名称（对象属性名）
        /// </summary>
        public string Icon
        {
            get { return this.icon; }
            set { this.icon = value; }
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

        //        //*****************在此之后添加关联对象

		/// <summary>
        /// 父模块
        /// </summary>
        private Rbac_modules p_modules;
        /// <summary>
        /// 父模块
        /// </summary>
        public Rbac_modules P_modules
        {
            get { return p_modules; }
            set { p_modules = value; }
        }





        //*******************************model,实体类新增的对象，start

        /// <summary>
        /// 模块类型，菜单还是功能点（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code typeCode;
        /// <summary>
        /// 模块类型，菜单还是功能点（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code TypeCode
        {
            get { return typeCode; }
            set { typeCode = value; }
        }

        /// <summary>
        /// 菜单是否允许直接打开窗体（功能点必须允许,菜单可选，关联代码表，是否）对象
        /// </summary>
        private Model.JC.Jc_code is_open_windowCode;
        /// <summary>
        /// 菜单是否允许直接打开窗体（功能点必须允许,菜单可选，关联代码表，是否）对象
        /// </summary>
        public Model.JC.Jc_code Is_open_windowCode
        {
            get { return is_open_windowCode; }
            set { is_open_windowCode = value; }
        }

            //*******************************model,实体类新增的对象，end
    }
}
