
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_ICD10_TYPE表的实体类
    ///基础_IDC10疾病种类
    ///此类由代码生成器生成
    ///生成日期：2015-11-21 17:48:53
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_icd10_type:Base.IBaseModel
        {
        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_ICD10_TYPE";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 疾病代码(数据库字段名)
        /// </summary>
        public static readonly string CODE = "CODE";

        /// <summary>
        /// 疾病种类名称(数据库字段名)
        /// </summary>
        public static readonly string NAME = "NAME";

        /// <summary>
        /// 英文名(数据库字段名)
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
        /// 把object对象转换为Jc_icd10_type对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_icd10_type ConvertToJc_icd10_type(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_icd10_type();
            }
            return (Model.JC.Jc_icd10_type)obj;
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
        /// 疾病代码（对象属性名）
        /// </summary>
        private string code;
        /// <summary>
        /// 疾病代码（对象属性名）
        /// </summary>
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }



        /// <summary>
        /// 疾病种类名称（对象属性名）
        /// </summary>
        private string name;
        /// <summary>
        /// 疾病种类名称（对象属性名）
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }



        /// <summary>
        /// 英文名（对象属性名）
        /// </summary>
        private string en_name;
        /// <summary>
        /// 英文名（对象属性名）
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
