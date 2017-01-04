
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_JM表的实体类
    ///基础_居民
    ///此类由代码生成器生成
    ///生成日期：2015-11-27 17:46:56
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_jm:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_居民";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_JM";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 身份证号(数据库字段名)
        /// </summary>
        public static readonly string SFZH = "SFZH";

        /// <summary>
        /// 姓名(数据库字段名)
        /// </summary>
        public static readonly string XM = "XM";

        /// <summary>
        /// 性别（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string XB_CODE = "XB_CODE";

        /// <summary>
        /// 出生日期(数据库字段名)
        /// </summary>
        public static readonly string CSRQ = "CSRQ";

        /// <summary>
        /// 民族（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string MZ_CODE = "MZ_CODE";

        /// <summary>
        /// 血型（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string XX_CODE = "XX_CODE";

        /// <summary>
        /// rh代码（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string RH_CODE = "RH_CODE";

        /// <summary>
        /// 出生地址(数据库字段名)
        /// </summary>
        public static readonly string CSDZ = "CSDZ";

        /// <summary>
        /// 户籍地址(数据库字段名)
        /// </summary>
        public static readonly string HJDZ = "HJDZ";

        /// <summary>
        /// 现住址所属行政区划（行政区区划代码）(数据库字段名)
        /// </summary>
        public static readonly string XZZ_XZQH = "XZZ_XZQH";

        /// <summary>
        /// 现住址，详细地址（乡/镇，村，组，门牌号）(数据库字段名)
        /// </summary>
        public static readonly string XZZ_XIANG_XI_DI_ZHI = "XZZ_XIANG_XI_DI_ZHI";

        /// <summary>
        /// 工作单位或学校(数据库字段名)
        /// </summary>
        public static readonly string GZDW_XX = "GZDW_XX";

        /// <summary>
        /// 职业代码（暂做保留）(数据库字段名)
        /// </summary>
        public static readonly string ZY_CODE = "ZY_CODE";

        /// <summary>
        /// 职业(数据库字段名)
        /// </summary>
        public static readonly string ZY = "ZY";

        /// <summary>
        /// 文化代码（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string WH_CODE = "WH_CODE";

        /// <summary>
        /// 婚姻状况（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string HYZK_CODE = "HYZK_CODE";

        /// <summary>
        /// 联系电话(数据库字段名)
        /// </summary>
        public static readonly string LXDH = "LXDH";

        /// <summary>
        /// 监护人姓名(数据库字段名)
        /// </summary>
        public static readonly string JHR_XM = "JHR_XM";

        /// <summary>
        /// 监护人电话(数据库字段名)
        /// </summary>
        public static readonly string JHR_DH = "JHR_DH";

        /// <summary>
        /// 农合编码(数据库字段名)
        /// </summary>
        public static readonly string NHBM = "NHBM";

        /// <summary>
        /// 医保卡号(数据库字段名)
        /// </summary>
        public static readonly string YBKH = "YBKH";

        /// <summary>
        /// 城居卡号(数据库字段名)
        /// </summary>
        public static readonly string CJKH = "CJKH";

        /// <summary>
        /// 支付账号(数据库字段名)
        /// </summary>
        public static readonly string ZFZH = "ZFZH";

        /// <summary>
        /// 健康档案编号(数据库字段名)
        /// </summary>
        public static readonly string JKDABH = "JKDABH";

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
        /// 把object对象转换为Jc_jm对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_jm ConvertToJc_jm(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_jm();
            }
            return (Model.JC.Jc_jm)obj;
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
        /// 性别（关联代码表）（对象属性名）
        /// </summary>
        private string xb_code;
        /// <summary>
        /// 性别（关联代码表）（对象属性名）
        /// </summary>
        public string Xb_code
        {
            get { return this.xb_code; }
            set { this.xb_code = value; }
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
        /// 民族（关联代码表）（对象属性名）
        /// </summary>
        private string mz_code;
        /// <summary>
        /// 民族（关联代码表）（对象属性名）
        /// </summary>
        public string Mz_code
        {
            get { return this.mz_code; }
            set { this.mz_code = value; }
        }



        /// <summary>
        /// 血型（关联代码表）（对象属性名）
        /// </summary>
        private string xx_code;
        /// <summary>
        /// 血型（关联代码表）（对象属性名）
        /// </summary>
        public string Xx_code
        {
            get { return this.xx_code; }
            set { this.xx_code = value; }
        }



        /// <summary>
        /// rh代码（关联代码表）（对象属性名）
        /// </summary>
        private string rh_code;
        /// <summary>
        /// rh代码（关联代码表）（对象属性名）
        /// </summary>
        public string Rh_code
        {
            get { return this.rh_code; }
            set { this.rh_code = value; }
        }



        /// <summary>
        /// 出生地址（对象属性名）
        /// </summary>
        private string csdz;
        /// <summary>
        /// 出生地址（对象属性名）
        /// </summary>
        public string Csdz
        {
            get { return this.csdz; }
            set { this.csdz = value; }
        }



        /// <summary>
        /// 户籍地址（对象属性名）
        /// </summary>
        private string hjdz;
        /// <summary>
        /// 户籍地址（对象属性名）
        /// </summary>
        public string Hjdz
        {
            get { return this.hjdz; }
            set { this.hjdz = value; }
        }



        /// <summary>
        /// 现住址所属行政区划（行政区区划代码）（对象属性名）
        /// </summary>
        private string xzz_xzqh;
        /// <summary>
        /// 现住址所属行政区划（行政区区划代码）（对象属性名）
        /// </summary>
        public string Xzz_xzqh
        {
            get { return this.xzz_xzqh; }
            set { this.xzz_xzqh = value; }
        }



        /// <summary>
        /// 现住址，详细地址（乡/镇，村，组，门牌号）（对象属性名）
        /// </summary>
        private string xzz_xiang_xi_di_zhi;
        /// <summary>
        /// 现住址，详细地址（乡/镇，村，组，门牌号）（对象属性名）
        /// </summary>
        public string Xzz_xiang_xi_di_zhi
        {
            get { return this.xzz_xiang_xi_di_zhi; }
            set { this.xzz_xiang_xi_di_zhi = value; }
        }



        /// <summary>
        /// 工作单位或学校（对象属性名）
        /// </summary>
        private string gzdw_xx;
        /// <summary>
        /// 工作单位或学校（对象属性名）
        /// </summary>
        public string Gzdw_xx
        {
            get { return this.gzdw_xx; }
            set { this.gzdw_xx = value; }
        }



        /// <summary>
        /// 职业代码（暂做保留）（对象属性名）
        /// </summary>
        private string zy_code;
        /// <summary>
        /// 职业代码（暂做保留）（对象属性名）
        /// </summary>
        public string Zy_code
        {
            get { return this.zy_code; }
            set { this.zy_code = value; }
        }



        /// <summary>
        /// 职业（对象属性名）
        /// </summary>
        private string zy;
        /// <summary>
        /// 职业（对象属性名）
        /// </summary>
        public string Zy
        {
            get { return this.zy; }
            set { this.zy = value; }
        }



        /// <summary>
        /// 文化代码（关联代码表）（对象属性名）
        /// </summary>
        private string wh_code;
        /// <summary>
        /// 文化代码（关联代码表）（对象属性名）
        /// </summary>
        public string Wh_code
        {
            get { return this.wh_code; }
            set { this.wh_code = value; }
        }



        /// <summary>
        /// 婚姻状况（关联代码表）（对象属性名）
        /// </summary>
        private string hyzk_code;
        /// <summary>
        /// 婚姻状况（关联代码表）（对象属性名）
        /// </summary>
        public string Hyzk_code
        {
            get { return this.hyzk_code; }
            set { this.hyzk_code = value; }
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
        /// 监护人姓名（对象属性名）
        /// </summary>
        private string jhr_xm;
        /// <summary>
        /// 监护人姓名（对象属性名）
        /// </summary>
        public string Jhr_xm
        {
            get { return this.jhr_xm; }
            set { this.jhr_xm = value; }
        }



        /// <summary>
        /// 监护人电话（对象属性名）
        /// </summary>
        private string jhr_dh;
        /// <summary>
        /// 监护人电话（对象属性名）
        /// </summary>
        public string Jhr_dh
        {
            get { return this.jhr_dh; }
            set { this.jhr_dh = value; }
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
        /// 医保卡号（对象属性名）
        /// </summary>
        private string ybkh;
        /// <summary>
        /// 医保卡号（对象属性名）
        /// </summary>
        public string Ybkh
        {
            get { return this.ybkh; }
            set { this.ybkh = value; }
        }



        /// <summary>
        /// 城居卡号（对象属性名）
        /// </summary>
        private string cjkh;
        /// <summary>
        /// 城居卡号（对象属性名）
        /// </summary>
        public string Cjkh
        {
            get { return this.cjkh; }
            set { this.cjkh = value; }
        }



        /// <summary>
        /// 支付账号（对象属性名）
        /// </summary>
        private string zfzh;
        /// <summary>
        /// 支付账号（对象属性名）
        /// </summary>
        public string Zfzh
        {
            get { return this.zfzh; }
            set { this.zfzh = value; }
        }



        /// <summary>
        /// 健康档案编号（对象属性名）
        /// </summary>
        private string jkdabh;
        /// <summary>
        /// 健康档案编号（对象属性名）
        /// </summary>
        public string Jkdabh
        {
            get { return this.jkdabh; }
            set { this.jkdabh = value; }
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
        #region model,实体类新增的对象，start

        /// <summary>
        /// 性别（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code xbCode;
        /// <summary>
        /// 性别（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code XbCode
        {
            get { return xbCode; }
            set { xbCode = value; }
        }

        /// <summary>
        /// 民族（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code mzCode;
        /// <summary>
        /// 民族（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code MzCode
        {
            get { return mzCode; }
            set { mzCode = value; }
        }

        /// <summary>
        /// 血型（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code xxCode;
        /// <summary>
        /// 血型（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code XxCode
        {
            get { return xxCode; }
            set { xxCode = value; }
        }

        /// <summary>
        /// rh代码（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code rhCode;
        /// <summary>
        /// rh代码（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code RhCode
        {
            get { return rhCode; }
            set { rhCode = value; }
        }

        /// <summary>
        /// 职业代码（暂做保留）对象
        /// </summary>
        private Model.JC.Jc_code zyCode;
        /// <summary>
        /// 职业代码（暂做保留）对象
        /// </summary>
        public Model.JC.Jc_code ZyCode
        {
            get { return zyCode; }
            set { zyCode = value; }
        }

        /// <summary>
        /// 文化代码（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code whCode;
        /// <summary>
        /// 文化代码（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code WhCode
        {
            get { return whCode; }
            set { whCode = value; }
        }

        /// <summary>
        /// 婚姻状况（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code hyzkCode;
        /// <summary>
        /// 婚姻状况（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code HyzkCode
        {
            get { return hyzkCode; }
            set { hyzkCode = value; }
        }

        #endregion model,实体类新增的对象，end
    }
}
