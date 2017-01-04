
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_ZLXM表的实体类
    ///基础_诊疗项目管理
    ///此类由代码生成器生成
    ///生成日期：2015/12/16 13:33:43
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_zlxm:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_诊疗项目管理";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_ZLXM";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 项目编码(数据库字段名)
        /// </summary>
        public static readonly string XMBH = "XMBH";

        /// <summary>
        /// 项目名称(数据库字段名)
        /// </summary>
        public static readonly string XMMC = "XMMC";

        /// <summary>
        /// 单位(数据库字段名)
        /// </summary>
        public static readonly string DW = "DW";

        /// <summary>
        /// 单价(数据库字段名)
        /// </summary>
        public static readonly string DJ = "DJ";

        /// <summary>
        /// 最高限价(数据库字段名)
        /// </summary>
        public static readonly string ZGXJ = "ZGXJ";

        /// <summary>
        /// 诊疗项目分类(关联代码表，诊疗项目分类)(数据库字段名)
        /// </summary>
        public static readonly string FL_CODE = "FL_CODE";

        /// <summary>
        /// 费用归类(关联代码表，诊疗项目费用归类)(数据库字段名)
        /// </summary>
        public static readonly string FYGL_CODE = "FYGL_CODE";

        /// <summary>
        /// 拼音码(数据库字段名)
        /// </summary>
        public static readonly string PYM = "PYM";

        /// <summary>
        /// 五笔码(数据库字段名)
        /// </summary>
        public static readonly string WBM = "WBM";

        /// <summary>
        /// 数字码(数据库字段名)
        /// </summary>
        public static readonly string SZM = "SZM";

        /// <summary>
        /// 项目内容(数据库字段名)
        /// </summary>
        public static readonly string XMNR = "XMNR";

        /// <summary>
        /// 除外内容(数据库字段名)
        /// </summary>
        public static readonly string CWNR = "CWNR";

        /// <summary>
        /// 说明(数据库字段名)
        /// </summary>
        public static readonly string NOTE = "NOTE";

        /// <summary>
        /// 检查方法(数据库字段名)
        /// </summary>
        public static readonly string JCFF = "JCFF";

        /// <summary>
        /// 标准(数据库字段名)
        /// </summary>
        public static readonly string BIAOZHUAN = "BIAOZHUAN";

        /// <summary>
        /// 禁检(数据库字段名)
        /// </summary>
        public static readonly string JINJIAN = "JINJIAN";

        /// <summary>
        /// 应急(数据库字段名)
        /// </summary>
        public static readonly string YINJI = "YINJI";

        /// <summary>
        /// 公布时间(数据库字段名)
        /// </summary>
        public static readonly string GBSJ = "GBSJ";

        /// <summary>
        /// 公布机构(数据库字段名)
        /// </summary>
        public static readonly string GBJG = "GBJG";

        /// <summary>
        /// 医保编码(数据库字段名)
        /// </summary>
        public static readonly string YBBM = "YBBM";

        /// <summary>
        /// 农合编码(数据库字段名)
        /// </summary>
        public static readonly string NHBM = "NHBM";

        /// <summary>
        /// 农合收费类别（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string NHSFLB_CODE = "NHSFLB_CODE";

        /// <summary>
        /// 作废(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Jc_zlxm对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_zlxm ConvertToJc_zlxm(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_zlxm();
            }
            return (Model.JC.Jc_zlxm)obj;
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
        /// 项目编码（对象属性名）
        /// </summary>
        private string xmbh;
        /// <summary>
        /// 项目编码（对象属性名）
        /// </summary>
        public string Xmbh
        {
            get { return this.xmbh; }
            set { this.xmbh = value; }
        }



        /// <summary>
        /// 项目名称（对象属性名）
        /// </summary>
        private string xmmc;
        /// <summary>
        /// 项目名称（对象属性名）
        /// </summary>
        public string Xmmc
        {
            get { return this.xmmc; }
            set { this.xmmc = value; }
        }



        /// <summary>
        /// 单位（对象属性名）
        /// </summary>
        private string dw;
        /// <summary>
        /// 单位（对象属性名）
        /// </summary>
        public string Dw
        {
            get { return this.dw; }
            set { this.dw = value; }
        }



        /// <summary>
        /// 单价（对象属性名）
        /// </summary>
        private decimal? dj;
        /// <summary>
        /// 单价（对象属性名）
        /// </summary>
        public decimal? Dj
        {
            get { return this.dj; }
            set { this.dj = value; }
        }



        /// <summary>
        /// 最高限价（对象属性名）
        /// </summary>
        private decimal? zgxj;
        /// <summary>
        /// 最高限价（对象属性名）
        /// </summary>
        public decimal? Zgxj
        {
            get { return this.zgxj; }
            set { this.zgxj = value; }
        }



        /// <summary>
        /// 诊疗项目分类(关联代码表，诊疗项目分类)（对象属性名）
        /// </summary>
        private string fl_code;
        /// <summary>
        /// 诊疗项目分类(关联代码表，诊疗项目分类)（对象属性名）
        /// </summary>
        public string Fl_code
        {
            get { return this.fl_code; }
            set { this.fl_code = value; }
        }



        /// <summary>
        /// 费用归类(关联代码表，诊疗项目费用归类)（对象属性名）
        /// </summary>
        private string fygl_code;
        /// <summary>
        /// 费用归类(关联代码表，诊疗项目费用归类)（对象属性名）
        /// </summary>
        public string Fygl_code
        {
            get { return this.fygl_code; }
            set { this.fygl_code = value; }
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
        /// 数字码（对象属性名）
        /// </summary>
        private string szm;
        /// <summary>
        /// 数字码（对象属性名）
        /// </summary>
        public string Szm
        {
            get { return this.szm; }
            set { this.szm = value; }
        }



        /// <summary>
        /// 项目内容（对象属性名）
        /// </summary>
        private string xmnr;
        /// <summary>
        /// 项目内容（对象属性名）
        /// </summary>
        public string Xmnr
        {
            get { return this.xmnr; }
            set { this.xmnr = value; }
        }



        /// <summary>
        /// 除外内容（对象属性名）
        /// </summary>
        private string cwnr;
        /// <summary>
        /// 除外内容（对象属性名）
        /// </summary>
        public string Cwnr
        {
            get { return this.cwnr; }
            set { this.cwnr = value; }
        }



        /// <summary>
        /// 说明（对象属性名）
        /// </summary>
        private string note;
        /// <summary>
        /// 说明（对象属性名）
        /// </summary>
        public string Note
        {
            get { return this.note; }
            set { this.note = value; }
        }



        /// <summary>
        /// 检查方法（对象属性名）
        /// </summary>
        private string jcff;
        /// <summary>
        /// 检查方法（对象属性名）
        /// </summary>
        public string Jcff
        {
            get { return this.jcff; }
            set { this.jcff = value; }
        }



        /// <summary>
        /// 标准（对象属性名）
        /// </summary>
        private string biaozhuan;
        /// <summary>
        /// 标准（对象属性名）
        /// </summary>
        public string Biaozhuan
        {
            get { return this.biaozhuan; }
            set { this.biaozhuan = value; }
        }



        /// <summary>
        /// 禁检（对象属性名）
        /// </summary>
        private string jinjian;
        /// <summary>
        /// 禁检（对象属性名）
        /// </summary>
        public string Jinjian
        {
            get { return this.jinjian; }
            set { this.jinjian = value; }
        }



        /// <summary>
        /// 应急（对象属性名）
        /// </summary>
        private string yinji;
        /// <summary>
        /// 应急（对象属性名）
        /// </summary>
        public string Yinji
        {
            get { return this.yinji; }
            set { this.yinji = value; }
        }



        /// <summary>
        /// 公布时间（对象属性名）
        /// </summary>
        private DateTime? gbsj;
        /// <summary>
        /// 公布时间（对象属性名）
        /// </summary>
        public DateTime? Gbsj
        {
            get { return this.gbsj; }
            set { this.gbsj = value; }
        }



        /// <summary>
        /// 公布机构（对象属性名）
        /// </summary>
        private string gbjg;
        /// <summary>
        /// 公布机构（对象属性名）
        /// </summary>
        public string Gbjg
        {
            get { return this.gbjg; }
            set { this.gbjg = value; }
        }



        /// <summary>
        /// 医保编码（对象属性名）
        /// </summary>
        private string ybbm;
        /// <summary>
        /// 医保编码（对象属性名）
        /// </summary>
        public string Ybbm
        {
            get { return this.ybbm; }
            set { this.ybbm = value; }
        }



        /// <summary>
        /// 农合编码（对象属性名）
        /// </summary>
        private string nhbm;
        /// <summary>
        /// 农合编码（对象属性名）
        /// </summary>
        public string Nhbm
        {
            get { return this.nhbm; }
            set { this.nhbm = value; }
        }



        /// <summary>
        /// 农合收费类别（关联代码表）（对象属性名）
        /// </summary>
        private string nhsflb_code;
        /// <summary>
        /// 农合收费类别（关联代码表）（对象属性名）
        /// </summary>
        public string Nhsflb_code
        {
            get { return this.nhsflb_code; }
            set { this.nhsflb_code = value; }
        }



        /// <summary>
        /// 作废（对象属性名）
        /// </summary>
        private string zfbz;
        /// <summary>
        /// 作废（对象属性名）
        /// </summary>
        public string Zfbz
        {
            get { return this.zfbz; }
            set { this.zfbz = value; }
        }

        //        //*****************在此之后添加关联对象
        #region model,实体类新增的对象，start

        /// <summary>
        /// 诊疗项目分类(关联代码表，诊疗项目分类)对象
        /// </summary>
        private Model.JC.Jc_code flCode;
        /// <summary>
        /// 诊疗项目分类(关联代码表，诊疗项目分类)对象
        /// </summary>
        public Model.JC.Jc_code FlCode
        {
            get { return flCode; }
            set { flCode = value; }
        }

        /// <summary>
        /// 费用归类(关联代码表，诊疗项目费用归类)对象
        /// </summary>
        private Model.JC.Jc_code fyglCode;
        /// <summary>
        /// 费用归类(关联代码表，诊疗项目费用归类)对象
        /// </summary>
        public Model.JC.Jc_code FyglCode
        {
            get { return fyglCode; }
            set { fyglCode = value; }
        }

        /// <summary>
        /// 农合收费类别（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code nhsflbCode;
        /// <summary>
        /// 农合收费类别（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code NhsflbCode
        {
            get { return nhsflbCode; }
            set { nhsflbCode = value; }
        }

        #endregion model,实体类新增的对象，end

    }
}
