
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MZ
{
    /// <summary>
    ///oracle数据库
    ///MZ_BLZD表的实体类
    ///门诊_病历诊断
    ///此类由代码生成器生成
    ///生成日期：2015-12-31 10:48:18
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Mz_blzd:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "门诊_病历诊断";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "MZ_BLZD";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";

        /// <summary>
        /// 挂号表外键（关联挂号表）(数据库字段名)
        /// </summary>
        public static readonly string FK_GH_ID = "FK_GH_ID";

        /// <summary>
        /// 挂号表的流水号（冗余）(数据库字段名)
        /// </summary>
        public static readonly string GH_LSH = "GH_LSH";

        /// <summary>
        /// icd10疾病表外键（关联icd10疾病表）(数据库字段名)
        /// </summary>
        public static readonly string FK_ICD10_ID = "FK_ICD10_ID";

        /// <summary>
        /// icd10疾病编码（冗余）(数据库字段名)
        /// </summary>
        public static readonly string ICD10_CODE = "ICD10_CODE";

        /// <summary>
        /// icd10疾病中文名称(数据库字段名)
        /// </summary>
        public static readonly string ICD10_NAME = "ICD10_NAME";

        /// <summary>
        /// 门诊病历外键（关联门诊病历表）(数据库字段名)
        /// </summary>
        public static readonly string FK_BL_ID = "FK_BL_ID";
        /// <summary>
        /// 把object对象转换为Mz_blzd对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.MZ.Mz_blzd ConvertToMz_blzd(object obj)
        {
            if (null==obj)
            {
                return new Model.MZ.Mz_blzd();
            }
            return (Model.MZ.Mz_blzd)obj;
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
        /// 挂号表外键（关联挂号表）（对象属性名）
        /// </summary>
        private string fk_gh_id;
        /// <summary>
        /// 挂号表外键（关联挂号表）（对象属性名）
        /// </summary>
        public string Fk_gh_id
        {
            get { return this.fk_gh_id; }
            set { this.fk_gh_id = value; }
        }



        /// <summary>
        /// 挂号表的流水号（冗余）（对象属性名）
        /// </summary>
        private decimal? gh_lsh;
        /// <summary>
        /// 挂号表的流水号（冗余）（对象属性名）
        /// </summary>
        public decimal? Gh_lsh
        {
            get { return this.gh_lsh; }
            set { this.gh_lsh = value; }
        }



        /// <summary>
        /// icd10疾病表外键（关联icd10疾病表）（对象属性名）
        /// </summary>
        private string fk_icd10_id;
        /// <summary>
        /// icd10疾病表外键（关联icd10疾病表）（对象属性名）
        /// </summary>
        public string Fk_icd10_id
        {
            get { return this.fk_icd10_id; }
            set { this.fk_icd10_id = value; }
        }



        /// <summary>
        /// icd10疾病编码（冗余）（对象属性名）
        /// </summary>
        private string icd10_code;
        /// <summary>
        /// icd10疾病编码（冗余）（对象属性名）
        /// </summary>
        public string Icd10_code
        {
            get { return this.icd10_code; }
            set { this.icd10_code = value; }
        }



        /// <summary>
        /// icd10疾病中文名称（对象属性名）
        /// </summary>
        private string icd10_name;
        /// <summary>
        /// icd10疾病中文名称（对象属性名）
        /// </summary>
        public string Icd10_name
        {
            get { return this.icd10_name; }
            set { this.icd10_name = value; }
        }



        /// <summary>
        /// 门诊病历外键（关联门诊病历表）（对象属性名）
        /// </summary>
        private string fk_bl_id;
        /// <summary>
        /// 门诊病历外键（关联门诊病历表）（对象属性名）
        /// </summary>
        public string Fk_bl_id
        {
            get { return this.fk_bl_id; }
            set { this.fk_bl_id = value; }
        }

        //        //*****************在此之后添加关联对象
    }
}
