
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.YPKC
{
    /// <summary>
    ///oracle数据库
    ///YPKC_KC表的实体类
    ///药品库存_库存表
    ///此类由代码生成器生成
    ///生成日期：2016-01-13 16:50:23
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com

    /// </summary>
    public class Ypkc_kc : Base.IBaseModel
    {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "药品库存_库存表";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "YPKC_KC";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 科室外键（关联科室表）(数据库字段名)
        /// </summary>
        public static readonly string FK_KESHI_ID = "FK_KESHI_ID";

        /// <summary>
        /// 科室编号（冗余）(数据库字段名)
        /// </summary>
        public static readonly string KSBH = "KSBH";

        /// <summary>
        /// 科室名称（冗余）(数据库字段名)
        /// </summary>
        public static readonly string KSMC = "KSMC";

        /// <summary>
        /// 药品字典外键（关联药品字典表）(数据库字段名)
        /// </summary>
        public static readonly string FK_YP_ID = "FK_YP_ID";

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
        /// 药品规格（冗余）(数据库字段名)
        /// </summary>
        public static readonly string YPGG = "YPGG";

        /// <summary>
        /// 剂型（冗余）(数据库字段名)
        /// </summary>
        public static readonly string JX = "JX";

        /// <summary>
        /// 拼音码（冗余）(数据库字段名)
        /// </summary>
        public static readonly string PYM = "PYM";

        /// <summary>
        /// 大单位（冗余）(数据库字段名)
        /// </summary>
        public static readonly string DDW = "DDW";

        /// <summary>
        /// 小单位（冗余）(数据库字段名)
        /// </summary>
        public static readonly string XDW = "XDW";

        /// <summary>
        /// 药品单位类型（关联代码表，单位类型）(数据库字段名)
        /// </summary>
        public static readonly string DWLX_CODE = "DWLX_CODE";

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
        /// 生产厂家名称（冗余）(数据库字段名)
        /// </summary>
        public static readonly string CJMC = "CJMC";

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
        /// 预扣数量(数据库字段名)
        /// </summary>
        public static readonly string YKSL = "YKSL";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";

        /// <summary>
        /// 药品类型（关联代码表，西药、成药、中药、卫材）(数据库字段名)
        /// </summary>
        public static readonly string YPFL_CODE = "YPFL_CODE";
        /// <summary>
        /// 把object对象转换为Ypkc_kc对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.YPKC.Ypkc_kc ConvertToYpkc_kc(object obj)
        {
            if (null == obj)
            {
                return new Model.YPKC.Ypkc_kc();
            }
            return (Model.YPKC.Ypkc_kc)obj;
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
        /// 科室编号（冗余）（对象属性名）
        /// </summary>
        private string ksbh;
        /// <summary>
        /// 科室编号（冗余）（对象属性名）
        /// </summary>
        public string Ksbh
        {
            get { return this.ksbh; }
            set { this.ksbh = value; }
        }



        /// <summary>
        /// 科室名称（冗余）（对象属性名）
        /// </summary>
        private string ksmc;
        /// <summary>
        /// 科室名称（冗余）（对象属性名）
        /// </summary>
        public string Ksmc
        {
            get { return this.ksmc; }
            set { this.ksmc = value; }
        }



        /// <summary>
        /// 药品字典外键（关联药品字典表）（对象属性名）
        /// </summary>
        private string fk_yp_id;
        /// <summary>
        /// 药品字典外键（关联药品字典表）（对象属性名）
        /// </summary>
        public string Fk_yp_id
        {
            get { return this.fk_yp_id; }
            set { this.fk_yp_id = value; }
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
        /// 大单位（冗余）（对象属性名）
        /// </summary>
        private string ddw;
        /// <summary>
        /// 大单位（冗余）（对象属性名）
        /// </summary>
        public string Ddw
        {
            get { return this.ddw; }
            set { this.ddw = value; }
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
        /// 药品单位类型（关联代码表，单位类型）（对象属性名）
        /// </summary>
        private string dwlx_code;
        /// <summary>
        /// 药品单位类型（关联代码表，单位类型）（对象属性名）
        /// </summary>
        public string Dwlx_code
        {
            get { return this.dwlx_code; }
            set { this.dwlx_code = value; }
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
        /// 预扣数量（对象属性名）
        /// </summary>
        private decimal? yksl;
        /// <summary>
        /// 预扣数量（对象属性名）
        /// </summary>
        public decimal? Yksl
        {
            get { return this.yksl; }
            set { this.yksl = value; }
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
        /// 药品类型（关联代码表，西药、成药、中药、卫材）（对象属性名）
        /// </summary>
        private string ypfl_code;
        /// <summary>
        /// 药品类型（关联代码表，西药、成药、中药、卫材）（对象属性名）
        /// </summary>
        public string Ypfl_code
        {
            get { return this.ypfl_code; }
            set { this.ypfl_code = value; }
        }

        //        //*****************在此之后添加关联对象

        #region model,实体类新增的对象，start


        /// <summary>
        /// 药品单位类型（关联代码表，单位类型）对象
        /// </summary>
        private Model.JC.Jc_code dwlxCode;
        /// <summary>
        /// 药品单位类型（关联代码表，单位类型）对象
        /// </summary>
        public Model.JC.Jc_code DwlxCode
        {
            get { return dwlxCode; }
            set { dwlxCode = value; }
        }

        /// <summary>
        /// 药品类型（关联代码表，西药、成药、中药、卫材）对象
        /// </summary>
        private Model.JC.Jc_code ypflCode;
        /// <summary>
        /// 药品类型（关联代码表，西药、成药、中药、卫材）对象
        /// </summary>
        public Model.JC.Jc_code YpflCode
        {
            get { return ypflCode; }
            set { ypflCode = value; }
        }

        #endregion model,实体类新增的对象，end

    }
}
