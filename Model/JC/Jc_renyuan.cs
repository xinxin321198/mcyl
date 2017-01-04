
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_RENYUAN表的实体类
    ///基础_工作人员
    ///此类由代码生成器生成
    ///生成日期：2015-11-21 18:13:03
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_renyuan:Base.IBaseModel
        {
        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_RENYUAN";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 姓名(数据库字段名)
        /// </summary>
        public static readonly string XM = "XM";

        /// <summary>
        /// 性别（关联基础字典表）(数据库字段名)
        /// </summary>
        public static readonly string XB_CODE = "XB_CODE";

        /// <summary>
        /// 民族（关联基础字典表）(数据库字段名)
        /// </summary>
        public static readonly string MZ_CODE = "MZ_CODE";

        /// <summary>
        /// 出生日期(数据库字段名)
        /// </summary>
        public static readonly string CSRQ = "CSRQ";

        /// <summary>
        /// 身份证号(数据库字段名)
        /// </summary>
        public static readonly string SFZH = "SFZH";

        /// <summary>
        /// 政治面貌（关联基础字典表）(数据库字段名)
        /// </summary>
        public static readonly string ZZMM_CODE = "ZZMM_CODE";

        /// <summary>
        /// 婚姻状况（关联基础字典表）(数据库字段名)
        /// </summary>
        public static readonly string HYZK_CODE = "HYZK_CODE";

        /// <summary>
        /// 毕业学校(数据库字段名)
        /// </summary>
        public static readonly string BYXX = "BYXX";

        /// <summary>
        /// 学历（关联基础字典表）(数据库字段名)
        /// </summary>
        public static readonly string XL_CODE = "XL_CODE";

        /// <summary>
        /// 参加工作时间(数据库字段名)
        /// </summary>
        public static readonly string CJGZSJ = "CJGZSJ";

        /// <summary>
        /// 专业(数据库字段名)
        /// </summary>
        public static readonly string ZY = "ZY";

        /// <summary>
        /// 籍贯(数据库字段名)
        /// </summary>
        public static readonly string JG = "JG";

        /// <summary>
        /// 地址(数据库字段名)
        /// </summary>
        public static readonly string DZ = "DZ";

        /// <summary>
        /// 联系电话(数据库字段名)
        /// </summary>
        public static readonly string LXDH = "LXDH";

        /// <summary>
        /// qq(数据库字段名)
        /// </summary>
        public static readonly string QQ = "QQ";

        /// <summary>
        /// 邮箱(数据库字段名)
        /// </summary>
        public static readonly string YX = "YX";

        /// <summary>
        /// 备注(数据库字段名)
        /// </summary>
        public static readonly string BZ = "BZ";

        /// <summary>
        /// 拼音码(数据库字段名)
        /// </summary>
        public static readonly string PYM = "PYM";

        /// <summary>
        /// 五笔码(数据库字段名)
        /// </summary>
        public static readonly string WBM = "WBM";

        /// <summary>
        /// 人员类型（关联基础字典表）(数据库字段名)
        /// </summary>
        public static readonly string RYLX_CODE = "RYLX_CODE";

        /// <summary>
        /// 作废标志（0是禁用，1是启用）(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Jc_renyuan对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_renyuan ConvertToJc_renyuan(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_renyuan();
            }
            return (Model.JC.Jc_renyuan)obj;
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
        /// 姓名（对象属性名）
        /// </summary>
        private string xm;
        /// <summary>
        /// 姓名（对象属性名）
        /// </summary>
        public string Xm
        {
            get { return this.xm; }
            set { this.xm = value; }
        }



        /// <summary>
        /// 性别（关联基础字典表）（对象属性名）
        /// </summary>
        private string xb_code;
        /// <summary>
        /// 性别（关联基础字典表）（对象属性名）
        /// </summary>
        public string Xb_code
        {
            get { return this.xb_code; }
            set { this.xb_code = value; }
        }



        /// <summary>
        /// 民族（关联基础字典表）（对象属性名）
        /// </summary>
        private string mz_code;
        /// <summary>
        /// 民族（关联基础字典表）（对象属性名）
        /// </summary>
        public string Mz_code
        {
            get { return this.mz_code; }
            set { this.mz_code = value; }
        }



        /// <summary>
        /// 出生日期（对象属性名）
        /// </summary>
        private DateTime? csrq;
        /// <summary>
        /// 出生日期（对象属性名）
        /// </summary>
        public DateTime? Csrq
        {
            get { return this.csrq; }
            set { this.csrq = value; }
        }



        /// <summary>
        /// 身份证号（对象属性名）
        /// </summary>
        private string sfzh;
        /// <summary>
        /// 身份证号（对象属性名）
        /// </summary>
        public string Sfzh
        {
            get { return this.sfzh; }
            set { this.sfzh = value; }
        }



        /// <summary>
        /// 政治面貌（关联基础字典表）（对象属性名）
        /// </summary>
        private string zzmm_code;
        /// <summary>
        /// 政治面貌（关联基础字典表）（对象属性名）
        /// </summary>
        public string Zzmm_code
        {
            get { return this.zzmm_code; }
            set { this.zzmm_code = value; }
        }



        /// <summary>
        /// 婚姻状况（关联基础字典表）（对象属性名）
        /// </summary>
        private string hyzk_code;
        /// <summary>
        /// 婚姻状况（关联基础字典表）（对象属性名）
        /// </summary>
        public string Hyzk_code
        {
            get { return this.hyzk_code; }
            set { this.hyzk_code = value; }
        }



        /// <summary>
        /// 毕业学校（对象属性名）
        /// </summary>
        private string byxx;
        /// <summary>
        /// 毕业学校（对象属性名）
        /// </summary>
        public string Byxx
        {
            get { return this.byxx; }
            set { this.byxx = value; }
        }



        /// <summary>
        /// 学历（关联基础字典表）（对象属性名）
        /// </summary>
        private string xl_code;
        /// <summary>
        /// 学历（关联基础字典表）（对象属性名）
        /// </summary>
        public string Xl_code
        {
            get { return this.xl_code; }
            set { this.xl_code = value; }
        }



        /// <summary>
        /// 参加工作时间（对象属性名）
        /// </summary>
        private DateTime? cjgzsj;
        /// <summary>
        /// 参加工作时间（对象属性名）
        /// </summary>
        public DateTime? Cjgzsj
        {
            get { return this.cjgzsj; }
            set { this.cjgzsj = value; }
        }



        /// <summary>
        /// 专业（对象属性名）
        /// </summary>
        private string zy;
        /// <summary>
        /// 专业（对象属性名）
        /// </summary>
        public string Zy
        {
            get { return this.zy; }
            set { this.zy = value; }
        }



        /// <summary>
        /// 籍贯（对象属性名）
        /// </summary>
        private string jg;
        /// <summary>
        /// 籍贯（对象属性名）
        /// </summary>
        public string Jg
        {
            get { return this.jg; }
            set { this.jg = value; }
        }



        /// <summary>
        /// 地址（对象属性名）
        /// </summary>
        private string dz;
        /// <summary>
        /// 地址（对象属性名）
        /// </summary>
        public string Dz
        {
            get { return this.dz; }
            set { this.dz = value; }
        }



        /// <summary>
        /// 联系电话（对象属性名）
        /// </summary>
        private string lxdh;
        /// <summary>
        /// 联系电话（对象属性名）
        /// </summary>
        public string Lxdh
        {
            get { return this.lxdh; }
            set { this.lxdh = value; }
        }



        /// <summary>
        /// qq（对象属性名）
        /// </summary>
        private string qq;
        /// <summary>
        /// qq（对象属性名）
        /// </summary>
        public string Qq
        {
            get { return this.qq; }
            set { this.qq = value; }
        }



        /// <summary>
        /// 邮箱（对象属性名）
        /// </summary>
        private string yx;
        /// <summary>
        /// 邮箱（对象属性名）
        /// </summary>
        public string Yx
        {
            get { return this.yx; }
            set { this.yx = value; }
        }



        /// <summary>
        /// 备注（对象属性名）
        /// </summary>
        private string bz;
        /// <summary>
        /// 备注（对象属性名）
        /// </summary>
        public string Bz
        {
            get { return this.bz; }
            set { this.bz = value; }
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
        /// 人员类型（关联基础字典表）（对象属性名）
        /// </summary>
        private string rylx_code;
        /// <summary>
        /// 人员类型（关联基础字典表）（对象属性名）
        /// </summary>
        public string Rylx_code
        {
            get { return this.rylx_code; }
            set { this.rylx_code = value; }
        }



        /// <summary>
        /// 作废标志（0是禁用，1是启用）（对象属性名）
        /// </summary>
        private string zfbz;
        /// <summary>
        /// 作废标志（0是禁用，1是启用）（对象属性名）
        /// </summary>
        public string Zfbz
        {
            get { return this.zfbz; }
            set { this.zfbz = value; }
        }

        //        //*****************在此之后添加关联对象
        #region model,实体类新增的对象，start

        /// <summary>
        /// 性别（关联基础字典表）对象
        /// </summary>
        private Model.JC.Jc_code xbCode;
        /// <summary>
        /// 性别（关联基础字典表）对象
        /// </summary>
        public Model.JC.Jc_code XbCode
        {
            get { return xbCode; }
            set { xbCode = value; }
        }

        /// <summary>
        /// 民族（关联基础字典表）对象
        /// </summary>
        private Model.JC.Jc_code mzCode;
        /// <summary>
        /// 民族（关联基础字典表）对象
        /// </summary>
        public Model.JC.Jc_code MzCode
        {
            get { return mzCode; }
            set { mzCode = value; }
        }

        /// <summary>
        /// 政治面貌（关联基础字典表）对象
        /// </summary>
        private Model.JC.Jc_code zzmmCode;
        /// <summary>
        /// 政治面貌（关联基础字典表）对象
        /// </summary>
        public Model.JC.Jc_code ZzmmCode
        {
            get { return zzmmCode; }
            set { zzmmCode = value; }
        }

        /// <summary>
        /// 婚姻状况（关联基础字典表）对象
        /// </summary>
        private Model.JC.Jc_code hyzkCode;
        /// <summary>
        /// 婚姻状况（关联基础字典表）对象
        /// </summary>
        public Model.JC.Jc_code HyzkCode
        {
            get { return hyzkCode; }
            set { hyzkCode = value; }
        }

        /// <summary>
        /// 学历（关联基础字典表）对象
        /// </summary>
        private Model.JC.Jc_code xlCode;
        /// <summary>
        /// 学历（关联基础字典表）对象
        /// </summary>
        public Model.JC.Jc_code XlCode
        {
            get { return xlCode; }
            set { xlCode = value; }
        }

        /// <summary>
        /// 人员类型（关联基础字典表）对象
        /// </summary>
        private Model.JC.Jc_code rylxCode;
        /// <summary>
        /// 人员类型（关联基础字典表）对象
        /// </summary>
        public Model.JC.Jc_code RylxCode
        {
            get { return rylxCode; }
            set { rylxCode = value; }
        }

        #endregion model,实体类新增的对象，end
    }
}
