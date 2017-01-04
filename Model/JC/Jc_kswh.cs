
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_KSWH表的实体类
    ///基础_科室
    ///此类由代码生成器生成
    ///生成日期：2015-11-28 17:27:32
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_kswh:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_科室";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_KSWH";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 科室编号(数据库字段名)
        /// </summary>
        public static readonly string KSBH = "KSBH";

        /// <summary>
        /// 科室名称(数据库字段名)
        /// </summary>
        public static readonly string KSMC = "KSMC";

        /// <summary>
        /// 门诊标志（与代码表关联）(数据库字段名)
        /// </summary>
        public static readonly string MZBZ_CODE = "MZBZ_CODE";

        /// <summary>
        /// 住院标志（与代码表关联）(数据库字段名)
        /// </summary>
        public static readonly string ZYBZ_CODE = "ZYBZ_CODE";

        /// <summary>
        /// 药库标志（与代码表关联）(数据库字段名)
        /// </summary>
        public static readonly string YKBZ_CODE = "YKBZ_CODE";

        /// <summary>
        /// 药房标志（与代码表关联）(数据库字段名)
        /// </summary>
        public static readonly string YFBZ_CODE = "YFBZ_CODE";

        /// <summary>
        /// 医技标志（与代码表关联）(数据库字段名)
        /// </summary>
        public static readonly string YJBZ_CODE = "YJBZ_CODE";

        /// <summary>
        /// 手术标志（与代码表关联）(数据库字段名)
        /// </summary>
        public static readonly string SSBZ_CODE = "SSBZ_CODE";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Jc_kswh对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_kswh ConvertToJc_kswh(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_kswh();
            }
            return (Model.JC.Jc_kswh)obj;
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
        /// 科室编号（对象属性名）
        /// </summary>
        private string ksbh;
        /// <summary>
        /// 科室编号（对象属性名）
        /// </summary>
        public string Ksbh
        {
            get { return this.ksbh; }
            set { this.ksbh = value; }
        }



        /// <summary>
        /// 科室名称（对象属性名）
        /// </summary>
        private string ksmc;
        /// <summary>
        /// 科室名称（对象属性名）
        /// </summary>
        public string Ksmc
        {
            get { return this.ksmc; }
            set { this.ksmc = value; }
        }



        /// <summary>
        /// 门诊标志（与代码表关联）（对象属性名）
        /// </summary>
        private string mzbz_code;
        /// <summary>
        /// 门诊标志（与代码表关联）（对象属性名）
        /// </summary>
        public string Mzbz_code
        {
            get { return this.mzbz_code; }
            set { this.mzbz_code = value; }
        }



        /// <summary>
        /// 住院标志（与代码表关联）（对象属性名）
        /// </summary>
        private string zybz_code;
        /// <summary>
        /// 住院标志（与代码表关联）（对象属性名）
        /// </summary>
        public string Zybz_code
        {
            get { return this.zybz_code; }
            set { this.zybz_code = value; }
        }



        /// <summary>
        /// 药库标志（与代码表关联）（对象属性名）
        /// </summary>
        private string ykbz_code;
        /// <summary>
        /// 药库标志（与代码表关联）（对象属性名）
        /// </summary>
        public string Ykbz_code
        {
            get { return this.ykbz_code; }
            set { this.ykbz_code = value; }
        }



        /// <summary>
        /// 药房标志（与代码表关联）（对象属性名）
        /// </summary>
        private string yfbz_code;
        /// <summary>
        /// 药房标志（与代码表关联）（对象属性名）
        /// </summary>
        public string Yfbz_code
        {
            get { return this.yfbz_code; }
            set { this.yfbz_code = value; }
        }



        /// <summary>
        /// 医技标志（与代码表关联）（对象属性名）
        /// </summary>
        private string yjbz_code;
        /// <summary>
        /// 医技标志（与代码表关联）（对象属性名）
        /// </summary>
        public string Yjbz_code
        {
            get { return this.yjbz_code; }
            set { this.yjbz_code = value; }
        }



        /// <summary>
        /// 手术标志（与代码表关联）（对象属性名）
        /// </summary>
        private string ssbz_code;
        /// <summary>
        /// 手术标志（与代码表关联）（对象属性名）
        /// </summary>
        public string Ssbz_code
        {
            get { return this.ssbz_code; }
            set { this.ssbz_code = value; }
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
        /// 门诊标志（与代码表关联）对象
        /// </summary>
        private Model.JC.Jc_code mzbzCode;
        /// <summary>
        /// 门诊标志（与代码表关联）对象
        /// </summary>
        public Model.JC.Jc_code MzbzCode
        {
            get { return mzbzCode; }
            set { mzbzCode = value; }
        }

        /// <summary>
        /// 住院标志（与代码表关联）对象
        /// </summary>
        private Model.JC.Jc_code zybzCode;
        /// <summary>
        /// 住院标志（与代码表关联）对象
        /// </summary>
        public Model.JC.Jc_code ZybzCode
        {
            get { return zybzCode; }
            set { zybzCode = value; }
        }

        /// <summary>
        /// 药库标志（与代码表关联）对象
        /// </summary>
        private Model.JC.Jc_code ykbzCode;
        /// <summary>
        /// 药库标志（与代码表关联）对象
        /// </summary>
        public Model.JC.Jc_code YkbzCode
        {
            get { return ykbzCode; }
            set { ykbzCode = value; }
        }

        /// <summary>
        /// 药房标志（与代码表关联）对象
        /// </summary>
        private Model.JC.Jc_code yfbzCode;
        /// <summary>
        /// 药房标志（与代码表关联）对象
        /// </summary>
        public Model.JC.Jc_code YfbzCode
        {
            get { return yfbzCode; }
            set { yfbzCode = value; }
        }

        /// <summary>
        /// 医技标志（与代码表关联）对象
        /// </summary>
        private Model.JC.Jc_code yjbzCode;
        /// <summary>
        /// 医技标志（与代码表关联）对象
        /// </summary>
        public Model.JC.Jc_code YjbzCode
        {
            get { return yjbzCode; }
            set { yjbzCode = value; }
        }

        /// <summary>
        /// 手术标志（与代码表关联）对象
        /// </summary>
        private Model.JC.Jc_code ssbzCode;
        /// <summary>
        /// 手术标志（与代码表关联）对象
        /// </summary>
        public Model.JC.Jc_code SsbzCode
        {
            get { return ssbzCode; }
            set { ssbzCode = value; }
        }

        #endregion model,实体类新增的对象，end
    }
}
