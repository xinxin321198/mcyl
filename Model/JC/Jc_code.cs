
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_CODE表的实体类
    ///基础_代码字典
    ///此类由代码生成器生成
    ///生成日期：2016-01-12 17:58:59
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com

    /// </summary>
    public class Jc_code : Base.IBaseModel
    {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_代码字典";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_CODE";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 代码名称(数据库字段名)
        /// </summary>
        public static readonly string NAME = "NAME";

        /// <summary>
        /// 代码值(数据库字段名)
        /// </summary>
        public static readonly string VALUE = "VALUE";

        /// <summary>
        /// 代码所属类型(关联到代码类型表id)(数据库字段名)
        /// </summary>
        public static readonly string FK_CODE_TYPE = "FK_CODE_TYPE";

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
        /// 作废废标志（0禁用，1启用）(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";

        /// <summary>
        /// 排序码(数据库字段名)
        /// </summary>
        public static readonly string SORT = "SORT";
        /// <summary>
        /// 把object对象转换为Jc_code对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_code ConvertToJc_code(object obj)
        {
            if (null == obj)
            {
                return new Model.JC.Jc_code();
            }
            return (Model.JC.Jc_code)obj;
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
        /// 代码名称（对象属性名）
        /// </summary>
        private string name;
        /// <summary>
        /// 代码名称（对象属性名）
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }



        /// <summary>
        /// 代码值（对象属性名）
        /// </summary>
        private string value;
        /// <summary>
        /// 代码值（对象属性名）
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }



        /// <summary>
        /// 代码所属类型(关联到代码类型表id)（对象属性名）
        /// </summary>
        private string fk_code_type;
        /// <summary>
        /// 代码所属类型(关联到代码类型表id)（对象属性名）
        /// </summary>
        public string Fk_code_type
        {
            get { return this.fk_code_type; }
            set { this.fk_code_type = value; }
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
        /// 作废废标志（0禁用，1启用）（对象属性名）
        /// </summary>
        private string zfbz;
        /// <summary>
        /// 作废废标志（0禁用，1启用）（对象属性名）
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

        #region model,实体类新增的对象，start


        /// <summary>
        /// 代码所属类型(关联到代码类型表id)对象
        /// </summary>
        private Model.JC.Jc_code_type jc_code_type;
        /// <summary>
        /// 代码所属类型(关联到代码类型表id)对象
        /// </summary>
        public Model.JC.Jc_code_type Jc_code_type
        {
            get { return jc_code_type; }
            set { jc_code_type = value; }
        }

        #endregion model,实体类新增的对象，end
    }
}
