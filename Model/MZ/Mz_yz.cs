
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MZ
{
    /// <summary>
    ///oracle数据库
    ///MZ_YZ表的实体类
    ///门诊_医嘱
    ///此类由代码生成器生成
    ///生成日期：2016-02-05 17:29:35
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com

    /// </summary>
    public class Mz_yz : Base.IBaseModel
    {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "门诊_医嘱";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "MZ_YZ";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";

        /// <summary>
        /// 医嘱内容(数据库字段名)
        /// </summary>
        public static readonly string YZNR = "YZNR";

        /// <summary>
        /// 医嘱类型（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string YZLX_CODE = "YZLX_CODE";

        /// <summary>
        /// 药品外键（关联药品表）(数据库字段名)
        /// </summary>
        public static readonly string FK_YP = "FK_YP";

        /// <summary>
        /// 诊疗项目外键（关联诊疗项目表）(数据库字段名)
        /// </summary>
        public static readonly string FK_ZLXM = "FK_ZLXM";

        /// <summary>
        /// 项目编号（冗余）(数据库字段名)
        /// </summary>
        public static readonly string XMBH = "XMBH";

        /// <summary>
        /// 项目名称（冗余）(数据库字段名)
        /// </summary>
        public static readonly string XMMC = "XMMC";

        /// <summary>
        /// 小单位（冗余）(数据库字段名)
        /// </summary>
        public static readonly string XDW = "XDW";

        /// <summary>
        /// 规格（冗余）(数据库字段名)
        /// </summary>
        public static readonly string GG = "GG";

        /// <summary>
        /// 剂型（冗余）(数据库字段名)
        /// </summary>
        public static readonly string JX = "JX";

        /// <summary>
        /// 数量(数据库字段名)
        /// </summary>
        public static readonly string SL = "SL";

        /// <summary>
        /// 用药途径（冗余）(数据库字段名)
        /// </summary>
        public static readonly string YYTJ = "YYTJ";

        /// <summary>
        /// 用药频率（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string YYPL_CODE = "YYPL_CODE";

        /// <summary>
        /// 单次用量（冗余）(数据库字段名)
        /// </summary>
        public static readonly string DCYL = "DCYL";

        /// <summary>
        /// 单次用量单位（冗余）(数据库字段名)
        /// </summary>
        public static readonly string DCYLDW = "DCYLDW";

        /// <summary>
        /// 天数(数据库字段名)
        /// </summary>
        public static readonly string TS = "TS";

        /// <summary>
        /// 用药频率（冗余）(数据库字段名)
        /// </summary>
        public static readonly string YYPL = "YYPL";

        /// <summary>
        /// 挂号表外键（关联挂号表）(数据库字段名)
        /// </summary>
        public static readonly string FK_GH_ID = "FK_GH_ID";

        /// <summary>
        /// 挂号表的流水号（冗余）(数据库字段名)
        /// </summary>
        public static readonly string GH_LSH = "GH_LSH";

        /// <summary>
        /// 滴速(数据库字段名)
        /// </summary>
        public static readonly string DS = "DS";

        /// <summary>
        /// 批号(数据库字段名)
        /// </summary>
        public static readonly string PH = "PH";

        /// <summary>
        /// 进价(数据库字段名)
        /// </summary>
        public static readonly string JJ = "JJ";

        /// <summary>
        /// 零售价(数据库字段名)
        /// </summary>
        public static readonly string LSJ = "LSJ";

        /// <summary>
        /// 单次用量单位比例(数据库字段名)
        /// </summary>
        public static readonly string DCYLDWBL = "DCYLDWBL";

        /// <summary>
        /// 科室外键（关联科室表）(数据库字段名)
        /// </summary>
        public static readonly string FK_KESHI_ID = "FK_KESHI_ID";

        /// <summary>
        /// 是否完成（关联代码表，是否）(数据库字段名)
        /// </summary>
        public static readonly string SFWC_CODE = "SFWC_CODE";

        /// <summary>
        /// 是否完成（冗余）(数据库字段名)
        /// </summary>
        public static readonly string SFWC = "SFWC";

        /// <summary>
        /// 科室（冗余）(数据库字段名)
        /// </summary>
        public static readonly string KESHI = "KESHI";
        /// <summary>
        /// 把object对象转换为Mz_yz对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.MZ.Mz_yz ConvertToMz_yz(object obj)
        {
            if (null == obj)
            {
                return new Model.MZ.Mz_yz();
            }
            return (Model.MZ.Mz_yz)obj;
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
        /// 医嘱内容（对象属性名）
        /// </summary>
        private string yznr;
        /// <summary>
        /// 医嘱内容（对象属性名）
        /// </summary>
        public string Yznr
        {
            get { return this.yznr; }
            set { this.yznr = value; }
        }



        /// <summary>
        /// 医嘱类型（关联代码表）（对象属性名）
        /// </summary>
        private string yzlx_code;
        /// <summary>
        /// 医嘱类型（关联代码表）（对象属性名）
        /// </summary>
        public string Yzlx_code
        {
            get { return this.yzlx_code; }
            set { this.yzlx_code = value; }
        }



        /// <summary>
        /// 药品外键（关联药品表）（对象属性名）
        /// </summary>
        private string fk_yp;
        /// <summary>
        /// 药品外键（关联药品表）（对象属性名）
        /// </summary>
        public string Fk_yp
        {
            get { return this.fk_yp; }
            set { this.fk_yp = value; }
        }



        /// <summary>
        /// 诊疗项目外键（关联诊疗项目表）（对象属性名）
        /// </summary>
        private string fk_zlxm;
        /// <summary>
        /// 诊疗项目外键（关联诊疗项目表）（对象属性名）
        /// </summary>
        public string Fk_zlxm
        {
            get { return this.fk_zlxm; }
            set { this.fk_zlxm = value; }
        }



        /// <summary>
        /// 项目编号（冗余）（对象属性名）
        /// </summary>
        private string xmbh;
        /// <summary>
        /// 项目编号（冗余）（对象属性名）
        /// </summary>
        public string Xmbh
        {
            get { return this.xmbh; }
            set { this.xmbh = value; }
        }



        /// <summary>
        /// 项目名称（冗余）（对象属性名）
        /// </summary>
        private string xmmc;
        /// <summary>
        /// 项目名称（冗余）（对象属性名）
        /// </summary>
        public string Xmmc
        {
            get { return this.xmmc; }
            set { this.xmmc = value; }
        }



        /// <summary>
        /// 小单位（冗余）（对象属性名）
        /// </summary>
        private string xdw;
        /// <summary>
        /// 小单位（冗余）（对象属性名）
        /// </summary>
        public string Xdw
        {
            get { return this.xdw; }
            set { this.xdw = value; }
        }



        /// <summary>
        /// 规格（冗余）（对象属性名）
        /// </summary>
        private string gg;
        /// <summary>
        /// 规格（冗余）（对象属性名）
        /// </summary>
        public string Gg
        {
            get { return this.gg; }
            set { this.gg = value; }
        }



        /// <summary>
        /// 剂型（冗余）（对象属性名）
        /// </summary>
        private string jx;
        /// <summary>
        /// 剂型（冗余）（对象属性名）
        /// </summary>
        public string Jx
        {
            get { return this.jx; }
            set { this.jx = value; }
        }



        /// <summary>
        /// 数量（对象属性名）
        /// </summary>
        private decimal? sl;
        /// <summary>
        /// 数量（对象属性名）
        /// </summary>
        public decimal? Sl
        {
            get { return this.sl; }
            set { this.sl = value; }
        }



        /// <summary>
        /// 用药途径（冗余）（对象属性名）
        /// </summary>
        private string yytj;
        /// <summary>
        /// 用药途径（冗余）（对象属性名）
        /// </summary>
        public string Yytj
        {
            get { return this.yytj; }
            set { this.yytj = value; }
        }



        /// <summary>
        /// 用药频率（关联代码表）（对象属性名）
        /// </summary>
        private string yypl_code;
        /// <summary>
        /// 用药频率（关联代码表）（对象属性名）
        /// </summary>
        public string Yypl_code
        {
            get { return this.yypl_code; }
            set { this.yypl_code = value; }
        }



        /// <summary>
        /// 单次用量（冗余）（对象属性名）
        /// </summary>
        private decimal? dcyl;
        /// <summary>
        /// 单次用量（冗余）（对象属性名）
        /// </summary>
        public decimal? Dcyl
        {
            get { return this.dcyl; }
            set { this.dcyl = value; }
        }



        /// <summary>
        /// 单次用量单位（冗余）（对象属性名）
        /// </summary>
        private string dcyldw;
        /// <summary>
        /// 单次用量单位（冗余）（对象属性名）
        /// </summary>
        public string Dcyldw
        {
            get { return this.dcyldw; }
            set { this.dcyldw = value; }
        }



        /// <summary>
        /// 天数（对象属性名）
        /// </summary>
        private decimal? ts;
        /// <summary>
        /// 天数（对象属性名）
        /// </summary>
        public decimal? Ts
        {
            get { return this.ts; }
            set { this.ts = value; }
        }



        /// <summary>
        /// 用药频率（冗余）（对象属性名）
        /// </summary>
        private string yypl;
        /// <summary>
        /// 用药频率（冗余）（对象属性名）
        /// </summary>
        public string Yypl
        {
            get { return this.yypl; }
            set { this.yypl = value; }
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
        /// 滴速（对象属性名）
        /// </summary>
        private string ds;
        /// <summary>
        /// 滴速（对象属性名）
        /// </summary>
        public string Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }



        /// <summary>
        /// 批号（对象属性名）
        /// </summary>
        private string ph;
        /// <summary>
        /// 批号（对象属性名）
        /// </summary>
        public string Ph
        {
            get { return this.ph; }
            set { this.ph = value; }
        }



        /// <summary>
        /// 进价（对象属性名）
        /// </summary>
        private decimal? jj;
        /// <summary>
        /// 进价（对象属性名）
        /// </summary>
        public decimal? Jj
        {
            get { return this.jj; }
            set { this.jj = value; }
        }



        /// <summary>
        /// 零售价（对象属性名）
        /// </summary>
        private decimal? lsj;
        /// <summary>
        /// 零售价（对象属性名）
        /// </summary>
        public decimal? Lsj
        {
            get { return this.lsj; }
            set { this.lsj = value; }
        }



        /// <summary>
        /// 单次用量单位比例（对象属性名）
        /// </summary>
        private decimal? dcyldwbl;
        /// <summary>
        /// 单次用量单位比例（对象属性名）
        /// </summary>
        public decimal? Dcyldwbl
        {
            get { return this.dcyldwbl; }
            set { this.dcyldwbl = value; }
        }



        /// <summary>
        /// 科室外键（关联科室表）（对象属性名）
        /// </summary>
        private string fk_keshi_id;
        /// <summary>
        /// 科室外键（关联科室表）（对象属性名）
        /// </summary>
        public string Fk_keshi_id
        {
            get { return this.fk_keshi_id; }
            set { this.fk_keshi_id = value; }
        }



        /// <summary>
        /// 是否完成（关联代码表，是否）（对象属性名）
        /// </summary>
        private string sfwc_code;
        /// <summary>
        /// 是否完成（关联代码表，是否）（对象属性名）
        /// </summary>
        public string Sfwc_code
        {
            get { return this.sfwc_code; }
            set { this.sfwc_code = value; }
        }



        /// <summary>
        /// 是否完成（冗余）（对象属性名）
        /// </summary>
        private string sfwc;
        /// <summary>
        /// 是否完成（冗余）（对象属性名）
        /// </summary>
        public string Sfwc
        {
            get { return this.sfwc; }
            set { this.sfwc = value; }
        }



        /// <summary>
        /// 科室（冗余）（对象属性名）
        /// </summary>
        private string keshi;
        /// <summary>
        /// 科室（冗余）（对象属性名）
        /// </summary>
        public string Keshi
        {
            get { return this.keshi; }
            set { this.keshi = value; }
        }

        //        //*****************在此之后添加关联对象
    }
}
