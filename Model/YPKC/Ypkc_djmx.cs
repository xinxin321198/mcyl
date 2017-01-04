
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.YPKC
{
    /// <summary>
    ///oracle数据库
    ///YPKC_DJMX表的实体类
    ///药品库存_单据子表
    ///此类由代码生成器生成
    ///生成日期：2015-12-24 16:04:23
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Ypkc_djmx:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "药品库存_单据子表";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "YPKC_DJMX";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 所属入库单据流水号(数据库字段名)
        /// </summary>
        public static readonly string DJH = "DJH";

        /// <summary>
        /// 单据主表记录外键（关联单据主表）(数据库字段名)
        /// </summary>
        public static readonly string FK_DJ_ID = "FK_DJ_ID";

        /// <summary>
        /// 药品字典外键(数据库字段名)
        /// </summary>
        public static readonly string FK_YP = "FK_YP";

        /// <summary>
        /// 药品编号（冗余）(数据库字段名)
        /// </summary>
        public static readonly string YPBH = "YPBH";

        /// <summary>
        /// 药品名称（冗余）(数据库字段名)
        /// </summary>
        public static readonly string YPMC = "YPMC";

        /// <summary>
        /// 药品通用名称（冗余）(数据库字段名)
        /// </summary>
        public static readonly string YPTYMC = "YPTYMC";

        /// <summary>
        /// 包装单位，大单位（冗余）(数据库字段名)
        /// </summary>
        public static readonly string DDW = "DDW";

        /// <summary>
        /// 发药单位，小单位（冗余）(数据库字段名)
        /// </summary>
        public static readonly string XDW = "XDW";

        /// <summary>
        /// 换算比例（冗余）(数据库字段名)
        /// </summary>
        public static readonly string HSBL = "HSBL";

        /// <summary>
        /// 批准文号（冗余）(数据库字段名)
        /// </summary>
        public static readonly string PZWH = "PZWH";

        /// <summary>
        /// 国药准字（冗余）(数据库字段名)
        /// </summary>
        public static readonly string GYZZ = "GYZZ";

        /// <summary>
        /// 剂型（冗余）(数据库字段名)
        /// </summary>
        public static readonly string JX = "JX";

        /// <summary>
        /// 药品规格（冗余）(数据库字段名)
        /// </summary>
        public static readonly string YPGG = "YPGG";

        /// <summary>
        /// 生产厂家名称（冗余）(数据库字段名)
        /// </summary>
        public static readonly string CJMC = "CJMC";

        /// <summary>
        /// 拼音码（冗余）(数据库字段名)
        /// </summary>
        public static readonly string PYM = "PYM";

        /// <summary>
        /// 批号(数据库字段名)
        /// </summary>
        public static readonly string PH = "PH";

        /// <summary>
        /// 有效期(数据库字段名)
        /// </summary>
        public static readonly string YXQ = "YXQ";

        /// <summary>
        /// 进价(数据库字段名)
        /// </summary>
        public static readonly string JJ = "JJ";

        /// <summary>
        /// 零售价(数据库字段名)
        /// </summary>
        public static readonly string LSJ = "LSJ";

        /// <summary>
        /// 数量(数据库字段名)
        /// </summary>
        public static readonly string SL = "SL";

        /// <summary>
        /// 进价金额合计(数据库字段名)
        /// </summary>
        public static readonly string JJJE = "JJJE";

        /// <summary>
        /// 零售价金额合计(数据库字段名)
        /// </summary>
        public static readonly string LSJJE = "LSJJE";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Ypkc_djmx对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.YPKC.Ypkc_djmx ConvertToYpkc_djmx(object obj)
        {
            if (null==obj)
            {
                return new Model.YPKC.Ypkc_djmx();
            }
            return (Model.YPKC.Ypkc_djmx)obj;
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
        /// 所属入库单据流水号（对象属性名）
        /// </summary>
        private decimal? djh;
        /// <summary>
        /// 所属入库单据流水号（对象属性名）
        /// </summary>
        public decimal? Djh
        {
            get { return this.djh; }
            set { this.djh = value; }
        }



        /// <summary>
        /// 单据主表记录外键（关联单据主表）（对象属性名）
        /// </summary>
        private string fk_dj_id;
        /// <summary>
        /// 单据主表记录外键（关联单据主表）（对象属性名）
        /// </summary>
        public string Fk_dj_id
        {
            get { return this.fk_dj_id; }
            set { this.fk_dj_id = value; }
        }



        /// <summary>
        /// 药品字典外键（对象属性名）
        /// </summary>
        private string fk_yp;
        /// <summary>
        /// 药品字典外键（对象属性名）
        /// </summary>
        public string Fk_yp
        {
            get { return this.fk_yp; }
            set { this.fk_yp = value; }
        }



        /// <summary>
        /// 药品编号（冗余）（对象属性名）
        /// </summary>
        private string ypbh;
        /// <summary>
        /// 药品编号（冗余）（对象属性名）
        /// </summary>
        public string Ypbh
        {
            get { return this.ypbh; }
            set { this.ypbh = value; }
        }



        /// <summary>
        /// 药品名称（冗余）（对象属性名）
        /// </summary>
        private string ypmc;
        /// <summary>
        /// 药品名称（冗余）（对象属性名）
        /// </summary>
        public string Ypmc
        {
            get { return this.ypmc; }
            set { this.ypmc = value; }
        }



        /// <summary>
        /// 药品通用名称（冗余）（对象属性名）
        /// </summary>
        private string yptymc;
        /// <summary>
        /// 药品通用名称（冗余）（对象属性名）
        /// </summary>
        public string Yptymc
        {
            get { return this.yptymc; }
            set { this.yptymc = value; }
        }



        /// <summary>
        /// 包装单位，大单位（冗余）（对象属性名）
        /// </summary>
        private string ddw;
        /// <summary>
        /// 包装单位，大单位（冗余）（对象属性名）
        /// </summary>
        public string Ddw
        {
            get { return this.ddw; }
            set { this.ddw = value; }
        }



        /// <summary>
        /// 发药单位，小单位（冗余）（对象属性名）
        /// </summary>
        private string xdw;
        /// <summary>
        /// 发药单位，小单位（冗余）（对象属性名）
        /// </summary>
        public string Xdw
        {
            get { return this.xdw; }
            set { this.xdw = value; }
        }



        /// <summary>
        /// 换算比例（冗余）（对象属性名）
        /// </summary>
        private decimal? hsbl;
        /// <summary>
        /// 换算比例（冗余）（对象属性名）
        /// </summary>
        public decimal? Hsbl
        {
            get { return this.hsbl; }
            set { this.hsbl = value; }
        }



        /// <summary>
        /// 批准文号（冗余）（对象属性名）
        /// </summary>
        private string pzwh;
        /// <summary>
        /// 批准文号（冗余）（对象属性名）
        /// </summary>
        public string Pzwh
        {
            get { return this.pzwh; }
            set { this.pzwh = value; }
        }



        /// <summary>
        /// 国药准字（冗余）（对象属性名）
        /// </summary>
        private string gyzz;
        /// <summary>
        /// 国药准字（冗余）（对象属性名）
        /// </summary>
        public string Gyzz
        {
            get { return this.gyzz; }
            set { this.gyzz = value; }
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
        /// 药品规格（冗余）（对象属性名）
        /// </summary>
        private string ypgg;
        /// <summary>
        /// 药品规格（冗余）（对象属性名）
        /// </summary>
        public string Ypgg
        {
            get { return this.ypgg; }
            set { this.ypgg = value; }
        }



        /// <summary>
        /// 生产厂家名称（冗余）（对象属性名）
        /// </summary>
        private string cjmc;
        /// <summary>
        /// 生产厂家名称（冗余）（对象属性名）
        /// </summary>
        public string Cjmc
        {
            get { return this.cjmc; }
            set { this.cjmc = value; }
        }



        /// <summary>
        /// 拼音码（冗余）（对象属性名）
        /// </summary>
        private string pym;
        /// <summary>
        /// 拼音码（冗余）（对象属性名）
        /// </summary>
        public string Pym
        {
            get { return this.pym; }
            set { this.pym = value; }
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
        /// 有效期（对象属性名）
        /// </summary>
        private DateTime? yxq;
        /// <summary>
        /// 有效期（对象属性名）
        /// </summary>
        public DateTime? Yxq
        {
            get { return this.yxq; }
            set { this.yxq = value; }
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
        /// 进价金额合计（对象属性名）
        /// </summary>
        private decimal? jjje;
        /// <summary>
        /// 进价金额合计（对象属性名）
        /// </summary>
        public decimal? Jjje
        {
            get { return this.jjje; }
            set { this.jjje = value; }
        }



        /// <summary>
        /// 零售价金额合计（对象属性名）
        /// </summary>
        private decimal? lsjje;
        /// <summary>
        /// 零售价金额合计（对象属性名）
        /// </summary>
        public decimal? Lsjje
        {
            get { return this.lsjje; }
            set { this.lsjje = value; }
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
