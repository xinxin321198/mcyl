
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_AREA表的实体类
    ///基础_行政区划
    ///此类由代码生成器生成
    ///生成日期：2015-11-28 14:56:09
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_area:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_行政区划";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_AREA";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 名称(数据库字段名)
        /// </summary>
        public static readonly string NAME = "NAME";

        /// <summary>
        /// 行政区划代码(数据库字段名)
        /// </summary>
        public static readonly string CODE = "CODE";

        /// <summary>
        /// 父级行政区划id(数据库字段名)
        /// </summary>
        public static readonly string PID = "PID";

        /// <summary>
        /// 父级行政区划代码(数据库字段名)
        /// </summary>
        public static readonly string PCODE = "PCODE";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";

        /// <summary>
        /// 行政区划等级(数据库字段名)
        /// </summary>
        public static readonly string LEVEL_CODE = "LEVEL_CODE";

        /// <summary>
        /// 城乡分类（仅居委会有效）(数据库字段名)
        /// </summary>
        public static readonly string TYPE_CODE = "TYPE_CODE";

        /// <summary>
        /// 备注(数据库字段名)
        /// </summary>
        public static readonly string REMARK = "REMARK";
        /// <summary>
        /// 把object对象转换为Jc_area对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_area ConvertToJc_area(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_area();
            }
            return (Model.JC.Jc_area)obj;
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
        /// 名称（对象属性名）
        /// </summary>
        private string name;
        /// <summary>
        /// 名称（对象属性名）
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }



        /// <summary>
        /// 行政区划代码（对象属性名）
        /// </summary>
        private string code;
        /// <summary>
        /// 行政区划代码（对象属性名）
        /// </summary>
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }



        /// <summary>
        /// 父级行政区划id（对象属性名）
        /// </summary>
        private string pid;
        /// <summary>
        /// 父级行政区划id（对象属性名）
        /// </summary>
        public string Pid
        {
            get { return this.pid; }
            set { this.pid = value; }
        }



        /// <summary>
        /// 父级行政区划代码（对象属性名）
        /// </summary>
        private string pcode;
        /// <summary>
        /// 父级行政区划代码（对象属性名）
        /// </summary>
        public string Pcode
        {
            get { return this.pcode; }
            set { this.pcode = value; }
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



        /// <summary>
        /// 行政区划等级（对象属性名）
        /// </summary>
        private string level_code;
        /// <summary>
        /// 行政区划等级（对象属性名）
        /// </summary>
        public string Level_code
        {
            get { return this.level_code; }
            set { this.level_code = value; }
        }



        /// <summary>
        /// 城乡分类（仅居委会有效）（对象属性名）
        /// </summary>
        private string type_code;
        /// <summary>
        /// 城乡分类（仅居委会有效）（对象属性名）
        /// </summary>
        public string Type_code
        {
            get { return this.type_code; }
            set { this.type_code = value; }
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

        //        //*****************在此之后添加关联对象
        #region model,实体类新增的对象，start
        #region model,实体类新增的对象，start

        /// <summary>
        /// 行政区划等级对象
        /// </summary>
        private Model.JC.Jc_code levelCode;
        /// <summary>
        /// 行政区划等级对象
        /// </summary>
        public Model.JC.Jc_code LevelCode
        {
            get { return levelCode; }
            set { levelCode = value; }
        }

        #endregion model,实体类新增的对象，end

        #endregion model,实体类新增的对象，end
    }
}
