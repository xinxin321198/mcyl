
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_ICD10表的实体类
    ///基础_ICD10
    ///此类由代码生成器生成
    ///生成日期：2015-12-03 16:46:44
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_icd10:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_ICD10";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_ICD10";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// icd-10编码(数据库字段名)
        /// </summary>
        public static readonly string ICD10_CODE = "ICD10_CODE";

        /// <summary>
        /// icd-10中文名称(数据库字段名)
        /// </summary>
        public static readonly string NAME = "NAME";

        /// <summary>
        /// icd-10英文名称(数据库字段名)
        /// </summary>
        public static readonly string EN_NAME = "EN_NAME";

        /// <summary>
        /// 拼音码(数据库字段名)
        /// </summary>
        public static readonly string PYM = "PYM";

        /// <summary>
        /// 五笔码(数据库字段名)
        /// </summary>
        public static readonly string WBM = "WBM";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Jc_icd10对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_icd10 ConvertToJc_icd10(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_icd10();
            }
            return (Model.JC.Jc_icd10)obj;
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
        /// icd-10编码（对象属性名）
        /// </summary>
        private string icd10_code;
        /// <summary>
        /// icd-10编码（对象属性名）
        /// </summary>
        public string Icd10_code
        {
            get { return this.icd10_code; }
            set { this.icd10_code = value; }
        }



        /// <summary>
        /// icd-10中文名称（对象属性名）
        /// </summary>
        private string name;
        /// <summary>
        /// icd-10中文名称（对象属性名）
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }



        /// <summary>
        /// icd-10英文名称（对象属性名）
        /// </summary>
        private string en_name;
        /// <summary>
        /// icd-10英文名称（对象属性名）
        /// </summary>
        public string En_name
        {
            get { return this.en_name; }
            set { this.en_name = value; }
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
