
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.YPKC
{
    /// <summary>
    ///oracle数据库
    ///YPKC_DJ表的实体类
    ///药品库存_单据主表
    ///此类由代码生成器生成
    ///生成日期：2015-12-17 16:57:59
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Ypkc_dj:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "药品库存_单据主表";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "YPKC_DJ";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 单据流水号(数据库字段名)
        /// </summary>
        public static readonly string DJH = "DJH";

        /// <summary>
        /// 单据类型（关联代码表，入库、退货）(数据库字段名)
        /// </summary>
        public static readonly string DJLX_CODE = "DJLX_CODE";

        /// <summary>
        /// 库存药品类型（关联代码表，西药、成药、中药、卫材）(数据库字段名)
        /// </summary>
        public static readonly string YPFL_CODE = "YPFL_CODE";

        /// <summary>
        /// 来源供应商外键（关联供应商表）(数据库字段名)
        /// </summary>
        public static readonly string FK_LYGYS = "FK_LYGYS";

        /// <summary>
        /// 来源科室外键（关联科室表）(数据库字段名)
        /// </summary>
        public static readonly string FK_LYKS = "FK_LYKS";

        /// <summary>
        /// 来源编号（冗余）(数据库字段名)
        /// </summary>
        public static readonly string LYBH = "LYBH";

        /// <summary>
        /// 来源名称（冗余）(数据库字段名)
        /// </summary>
        public static readonly string LYMC = "LYMC";

        /// <summary>
        /// 目的科室外键（关联科室表，药库/药房）(数据库字段名)
        /// </summary>
        public static readonly string FK_MDKS = "FK_MDKS";

        /// <summary>
        /// 目的供应商外键（关联供应商表）(数据库字段名)
        /// </summary>
        public static readonly string FK_MDGYS = "FK_MDGYS";

        /// <summary>
        /// 目的编号（冗余）(数据库字段名)
        /// </summary>
        public static readonly string MDBH = "MDBH";

        /// <summary>
        /// 目的名称（冗余）(数据库字段名)
        /// </summary>
        public static readonly string MDMC = "MDMC";

        /// <summary>
        /// 制单人姓名(冗余)(数据库字段名)
        /// </summary>
        public static readonly string ZDR = "ZDR";

        /// <summary>
        /// 制单人外键(数据库字段名)
        /// </summary>
        public static readonly string FK_RENYUAN_ZDR = "FK_RENYUAN_ZDR";

        /// <summary>
        /// 记帐人姓名（冗余）(数据库字段名)
        /// </summary>
        public static readonly string JZR = "JZR";

        /// <summary>
        /// 记账人外键(数据库字段名)
        /// </summary>
        public static readonly string FK_RENYUAN_JZR = "FK_RENYUAN_JZR";

        /// <summary>
        /// 制单时间(数据库字段名)
        /// </summary>
        public static readonly string ZDSJ = "ZDSJ";

        /// <summary>
        /// 记帐时间(数据库字段名)
        /// </summary>
        public static readonly string JZSJ = "JZSJ";

        /// <summary>
        /// 是否记帐（关联代码表，是否）(数据库字段名)
        /// </summary>
        public static readonly string JZZT_CODE = "JZZT_CODE";

        /// <summary>
        /// 备注(数据库字段名)
        /// </summary>
        public static readonly string REMARK = "REMARK";

        /// <summary>
        /// 采购方式（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string CAIGOUFS_CODE = "CAIGOUFS_CODE";

        /// <summary>
        /// 配送方式（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string PEISONGFS_CODE = "PEISONGFS_CODE";

        /// <summary>
        /// 购进时间(数据库字段名)
        /// </summary>
        public static readonly string GOUJINSJ = "GOUJINSJ";

        /// <summary>
        /// 验收（合格，不合格）(数据库字段名)
        /// </summary>
        public static readonly string YANSHOU_CODE = "YANSHOU_CODE";

        /// <summary>
        /// 处理意见(数据库字段名)
        /// </summary>
        public static readonly string CHULIYJ = "CHULIYJ";

        /// <summary>
        /// 处理结果(数据库字段名)
        /// </summary>
        public static readonly string CHULIJG = "CHULIJG";

        /// <summary>
        /// 退货状态（药品采购，退货状态）(数据库字段名)
        /// </summary>
        public static readonly string TUIHUOZT_CODE = "TUIHUOZT_CODE";

        /// <summary>
        /// 审核人编号(数据库字段名)
        /// </summary>
        public static readonly string FK_SHR = "FK_SHR";

        /// <summary>
        /// 审核人姓名(数据库字段名)
        /// </summary>
        public static readonly string SHRXM = "SHRXM";

        /// <summary>
        /// 审核时间(数据库字段名)
        /// </summary>
        public static readonly string SHSJ = "SHSJ";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Ypkc_dj对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.YPKC.Ypkc_dj ConvertToYpkc_dj(object obj)
        {
            if (null==obj)
            {
                return new Model.YPKC.Ypkc_dj();
            }
            return (Model.YPKC.Ypkc_dj)obj;
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
        /// 单据流水号（对象属性名）
        /// </summary>
        private decimal? djh;
        /// <summary>
        /// 单据流水号（对象属性名）
        /// </summary>
        public decimal? Djh
        {
            get { return this.djh; }
            set { this.djh = value; }
        }



        /// <summary>
        /// 单据类型（关联代码表，入库、退货）（对象属性名）
        /// </summary>
        private string djlx_code;
        /// <summary>
        /// 单据类型（关联代码表，入库、退货）（对象属性名）
        /// </summary>
        public string Djlx_code
        {
            get { return this.djlx_code; }
            set { this.djlx_code = value; }
        }



        /// <summary>
        /// 库存药品类型（关联代码表，西药、成药、中药、卫材）（对象属性名）
        /// </summary>
        private string ypfl_code;
        /// <summary>
        /// 库存药品类型（关联代码表，西药、成药、中药、卫材）（对象属性名）
        /// </summary>
        public string Ypfl_code
        {
            get { return this.ypfl_code; }
            set { this.ypfl_code = value; }
        }



        /// <summary>
        /// 来源供应商外键（关联供应商表）（对象属性名）
        /// </summary>
        private string fk_lygys;
        /// <summary>
        /// 来源供应商外键（关联供应商表）（对象属性名）
        /// </summary>
        public string Fk_lygys
        {
            get { return this.fk_lygys; }
            set { this.fk_lygys = value; }
        }



        /// <summary>
        /// 来源科室外键（关联科室表）（对象属性名）
        /// </summary>
        private string fk_lyks;
        /// <summary>
        /// 来源科室外键（关联科室表）（对象属性名）
        /// </summary>
        public string Fk_lyks
        {
            get { return this.fk_lyks; }
            set { this.fk_lyks = value; }
        }



        /// <summary>
        /// 来源编号（冗余）（对象属性名）
        /// </summary>
        private string lybh;
        /// <summary>
        /// 来源编号（冗余）（对象属性名）
        /// </summary>
        public string Lybh
        {
            get { return this.lybh; }
            set { this.lybh = value; }
        }



        /// <summary>
        /// 来源名称（冗余）（对象属性名）
        /// </summary>
        private string lymc;
        /// <summary>
        /// 来源名称（冗余）（对象属性名）
        /// </summary>
        public string Lymc
        {
            get { return this.lymc; }
            set { this.lymc = value; }
        }



        /// <summary>
        /// 目的科室外键（关联科室表，药库/药房）（对象属性名）
        /// </summary>
        private string fk_mdks;
        /// <summary>
        /// 目的科室外键（关联科室表，药库/药房）（对象属性名）
        /// </summary>
        public string Fk_mdks
        {
            get { return this.fk_mdks; }
            set { this.fk_mdks = value; }
        }



        /// <summary>
        /// 目的供应商外键（关联供应商表）（对象属性名）
        /// </summary>
        private string fk_mdgys;
        /// <summary>
        /// 目的供应商外键（关联供应商表）（对象属性名）
        /// </summary>
        public string Fk_mdgys
        {
            get { return this.fk_mdgys; }
            set { this.fk_mdgys = value; }
        }



        /// <summary>
        /// 目的编号（冗余）（对象属性名）
        /// </summary>
        private string mdbh;
        /// <summary>
        /// 目的编号（冗余）（对象属性名）
        /// </summary>
        public string Mdbh
        {
            get { return this.mdbh; }
            set { this.mdbh = value; }
        }



        /// <summary>
        /// 目的名称（冗余）（对象属性名）
        /// </summary>
        private string mdmc;
        /// <summary>
        /// 目的名称（冗余）（对象属性名）
        /// </summary>
        public string Mdmc
        {
            get { return this.mdmc; }
            set { this.mdmc = value; }
        }



        /// <summary>
        /// 制单人姓名(冗余)（对象属性名）
        /// </summary>
        private string zdr;
        /// <summary>
        /// 制单人姓名(冗余)（对象属性名）
        /// </summary>
        public string Zdr
        {
            get { return this.zdr; }
            set { this.zdr = value; }
        }



        /// <summary>
        /// 制单人外键（对象属性名）
        /// </summary>
        private string fk_renyuan_zdr;
        /// <summary>
        /// 制单人外键（对象属性名）
        /// </summary>
        public string Fk_renyuan_zdr
        {
            get { return this.fk_renyuan_zdr; }
            set { this.fk_renyuan_zdr = value; }
        }



        /// <summary>
        /// 记帐人姓名（冗余）（对象属性名）
        /// </summary>
        private string jzr;
        /// <summary>
        /// 记帐人姓名（冗余）（对象属性名）
        /// </summary>
        public string Jzr
        {
            get { return this.jzr; }
            set { this.jzr = value; }
        }



        /// <summary>
        /// 记账人外键（对象属性名）
        /// </summary>
        private string fk_renyuan_jzr;
        /// <summary>
        /// 记账人外键（对象属性名）
        /// </summary>
        public string Fk_renyuan_jzr
        {
            get { return this.fk_renyuan_jzr; }
            set { this.fk_renyuan_jzr = value; }
        }



        /// <summary>
        /// 制单时间（对象属性名）
        /// </summary>
        private DateTime? zdsj;
        /// <summary>
        /// 制单时间（对象属性名）
        /// </summary>
        public DateTime? Zdsj
        {
            get { return this.zdsj; }
            set { this.zdsj = value; }
        }



        /// <summary>
        /// 记帐时间（对象属性名）
        /// </summary>
        private DateTime? jzsj;
        /// <summary>
        /// 记帐时间（对象属性名）
        /// </summary>
        public DateTime? Jzsj
        {
            get { return this.jzsj; }
            set { this.jzsj = value; }
        }



        /// <summary>
        /// 是否记帐（关联代码表，是否）（对象属性名）
        /// </summary>
        private string jzzt_code;
        /// <summary>
        /// 是否记帐（关联代码表，是否）（对象属性名）
        /// </summary>
        public string Jzzt_code
        {
            get { return this.jzzt_code; }
            set { this.jzzt_code = value; }
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
        /// 采购方式（关联代码表）（对象属性名）
        /// </summary>
        private string caigoufs_code;
        /// <summary>
        /// 采购方式（关联代码表）（对象属性名）
        /// </summary>
        public string Caigoufs_code
        {
            get { return this.caigoufs_code; }
            set { this.caigoufs_code = value; }
        }



        /// <summary>
        /// 配送方式（关联代码表）（对象属性名）
        /// </summary>
        private string peisongfs_code;
        /// <summary>
        /// 配送方式（关联代码表）（对象属性名）
        /// </summary>
        public string Peisongfs_code
        {
            get { return this.peisongfs_code; }
            set { this.peisongfs_code = value; }
        }



        /// <summary>
        /// 购进时间（对象属性名）
        /// </summary>
        private DateTime? goujinsj;
        /// <summary>
        /// 购进时间（对象属性名）
        /// </summary>
        public DateTime? Goujinsj
        {
            get { return this.goujinsj; }
            set { this.goujinsj = value; }
        }



        /// <summary>
        /// 验收（合格，不合格）（对象属性名）
        /// </summary>
        private string yanshou_code;
        /// <summary>
        /// 验收（合格，不合格）（对象属性名）
        /// </summary>
        public string Yanshou_code
        {
            get { return this.yanshou_code; }
            set { this.yanshou_code = value; }
        }



        /// <summary>
        /// 处理意见（对象属性名）
        /// </summary>
        private string chuliyj;
        /// <summary>
        /// 处理意见（对象属性名）
        /// </summary>
        public string Chuliyj
        {
            get { return this.chuliyj; }
            set { this.chuliyj = value; }
        }



        /// <summary>
        /// 处理结果（对象属性名）
        /// </summary>
        private string chulijg;
        /// <summary>
        /// 处理结果（对象属性名）
        /// </summary>
        public string Chulijg
        {
            get { return this.chulijg; }
            set { this.chulijg = value; }
        }



        /// <summary>
        /// 退货状态（药品采购，退货状态）（对象属性名）
        /// </summary>
        private string tuihuozt_code;
        /// <summary>
        /// 退货状态（药品采购，退货状态）（对象属性名）
        /// </summary>
        public string Tuihuozt_code
        {
            get { return this.tuihuozt_code; }
            set { this.tuihuozt_code = value; }
        }



        /// <summary>
        /// 审核人编号（对象属性名）
        /// </summary>
        private string fk_shr;
        /// <summary>
        /// 审核人编号（对象属性名）
        /// </summary>
        public string Fk_shr
        {
            get { return this.fk_shr; }
            set { this.fk_shr = value; }
        }



        /// <summary>
        /// 审核人姓名（对象属性名）
        /// </summary>
        private string shrxm;
        /// <summary>
        /// 审核人姓名（对象属性名）
        /// </summary>
        public string Shrxm
        {
            get { return this.shrxm; }
            set { this.shrxm = value; }
        }



        /// <summary>
        /// 审核时间（对象属性名）
        /// </summary>
        private DateTime? shsj;
        /// <summary>
        /// 审核时间（对象属性名）
        /// </summary>
        public DateTime? Shsj
        {
            get { return this.shsj; }
            set { this.shsj = value; }
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
        /// 单据类型（关联代码表，入库、退货）对象
        /// </summary>
        private Model.JC.Jc_code djlxCode;
        /// <summary>
        /// 单据类型（关联代码表，入库、退货）对象
        /// </summary>
        public Model.JC.Jc_code DjlxCode
        {
            get { return djlxCode; }
            set { djlxCode = value; }
        }

        /// <summary>
        /// 库存药品类型（关联代码表，西药、成药、中药、卫材）对象
        /// </summary>
        private Model.JC.Jc_code ypflCode;
        /// <summary>
        /// 库存药品类型（关联代码表，西药、成药、中药、卫材）对象
        /// </summary>
        public Model.JC.Jc_code YpflCode
        {
            get { return ypflCode; }
            set { ypflCode = value; }
        }

        /// <summary>
        /// 是否记帐（关联代码表，是否）对象
        /// </summary>
        private Model.JC.Jc_code jzztCode;
        /// <summary>
        /// 是否记帐（关联代码表，是否）对象
        /// </summary>
        public Model.JC.Jc_code JzztCode
        {
            get { return jzztCode; }
            set { jzztCode = value; }
        }

        /// <summary>
        /// 采购方式（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code caigoufsCode;
        /// <summary>
        /// 采购方式（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code CaigoufsCode
        {
            get { return caigoufsCode; }
            set { caigoufsCode = value; }
        }

        /// <summary>
        /// 配送方式（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code peisongfsCode;
        /// <summary>
        /// 配送方式（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code PeisongfsCode
        {
            get { return peisongfsCode; }
            set { peisongfsCode = value; }
        }

        /// <summary>
        /// 验收（合格，不合格）对象
        /// </summary>
        private Model.JC.Jc_code yanshouCode;
        /// <summary>
        /// 验收（合格，不合格）对象
        /// </summary>
        public Model.JC.Jc_code YanshouCode
        {
            get { return yanshouCode; }
            set { yanshouCode = value; }
        }

        /// <summary>
        /// 退货状态（药品采购，退货状态）对象
        /// </summary>
        private Model.JC.Jc_code tuihuoztCode;
        /// <summary>
        /// 退货状态（药品采购，退货状态）对象
        /// </summary>
        public Model.JC.Jc_code TuihuoztCode
        {
            get { return tuihuoztCode; }
            set { tuihuoztCode = value; }
        }

        #endregion model,实体类新增的对象，end

    }
}
