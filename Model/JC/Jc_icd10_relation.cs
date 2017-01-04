
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_ICD10_RELATION表的实体类
    ///基础_ICD10编码对应疾病类型
    ///此类由代码生成器生成
    ///生成日期：2015-12-02 16:12:31
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_icd10_relation:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_ICD10编码对应疾病类型";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_ICD10_RELATION";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 疾病种类外键(数据库字段名)
        /// </summary>
        public static readonly string FK_JC_ICD10_TYPE = "FK_JC_ICD10_TYPE";

        /// <summary>
        /// 所属icd-10编码范围（编码的前几位）(数据库字段名)
        /// </summary>
        public static readonly string ICD10_CODE_SCOPE = "ICD10_CODE_SCOPE";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Jc_icd10_relation对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_icd10_relation ConvertToJc_icd10_relation(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_icd10_relation();
            }
            return (Model.JC.Jc_icd10_relation)obj;
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
        /// 疾病种类外键（对象属性名）
        /// </summary>
        private string fk_jc_icd10_type;
        /// <summary>
        /// 疾病种类外键（对象属性名）
        /// </summary>
        public string Fk_jc_icd10_type
        {
            get { return this.fk_jc_icd10_type; }
            set { this.fk_jc_icd10_type = value; }
        }



        /// <summary>
        /// 所属icd-10编码范围（编码的前几位）（对象属性名）
        /// </summary>
        private string icd10_code_scope;
        /// <summary>
        /// 所属icd-10编码范围（编码的前几位）（对象属性名）
        /// </summary>
        public string Icd10_code_scope
        {
            get { return this.icd10_code_scope; }
            set { this.icd10_code_scope = value; }
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
        /// 疾病种类外键对象
        /// </summary>
        private Model.JC.Jc_icd10_type jc_icd10_type;
        /// <summary>
        /// 疾病种类外键对象
        /// </summary>
        public Model.JC.Jc_icd10_type Jc_icd10_type
        {
            get { return jc_icd10_type; }
            set { jc_icd10_type = value; }
        }

        #endregion model,实体类新增的对象，end

    }
}
