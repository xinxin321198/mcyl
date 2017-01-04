
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_CODE_TYPE表的实体类
    ///基础_代码类型字典
    ///此类由代码生成器生成
    ///生成日期：2016-01-12 17:35:27
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com

    /// </summary>
    public class Jc_code_type : Base.IBaseModel
    {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_代码类型字典";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_CODE_TYPE";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 代码类型名称(数据库字段名)
        /// </summary>
        public static readonly string NAME = "NAME";

        /// <summary>
        /// 代码类型值(数据库字段名)
        /// </summary>
        public static readonly string VALUE = "VALUE";

        /// <summary>
        /// 拼音码(数据库字段名)
        /// </summary>
        public static readonly string PYM = "PYM";

        /// <summary>
        /// 五笔码(数据库字段名)
        /// </summary>
        public static readonly string WBM = "WBM";

        /// <summary>
        /// 备注(数据库字段名)
        /// </summary>
        public static readonly string REMARK = "REMARK";

        /// <summary>
        /// 作废标志（0禁用，1启用）(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";

        /// <summary>
        /// 排序码(数据库字段名)
        /// </summary>
        public static readonly string SORT = "SORT";
        /// <summary>
        /// 把object对象转换为Jc_code_type对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_code_type ConvertToJc_code_type(object obj)
        {
            if (null == obj)
            {
                return new Model.JC.Jc_code_type();
            }
            return (Model.JC.Jc_code_type)obj;
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
        /// 代码类型名称（对象属性名）
        /// </summary>
        private string name;
        /// <summary>
        /// 代码类型名称（对象属性名）
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }



        /// <summary>
        /// 代码类型值（对象属性名）
        /// </summary>
        private string value;
        /// <summary>
        /// 代码类型值（对象属性名）
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }



        /// <summary>
        /// 拼音码（对象属性名）
        /// </summary>
        private string pym;
        /// <summary>
        /// 拼音码（对象属性名）
        /// </summary>
        public string Pym
        {
            get { return this.pym; }
            set { this.pym = value; }
        }



        /// <summary>
        /// 五笔码（对象属性名）
        /// </summary>
        private string wbm;
        /// <summary>
        /// 五笔码（对象属性名）
        /// </summary>
        public string Wbm
        {
            get { return this.wbm; }
            set { this.wbm = value; }
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
        /// 作废标志（0禁用，1启用）（对象属性名）
        /// </summary>
        private string zfbz;
        /// <summary>
        /// 作废标志（0禁用，1启用）（对象属性名）
        /// </summary>
        public string Zfbz
        {
            get { return this.zfbz; }
            set { this.zfbz = value; }
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

        //        //*****************在此之后添加关联对象
    }
}
