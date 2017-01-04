
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MZ
{
    /// <summary>
    ///oracle数据库
    ///MZ_BL表的实体类
    ///门诊_病历
    ///此类由代码生成器生成
    ///生成日期：2015-12-31 10:42:12
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Mz_bl:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "门诊_病历";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "MZ_BL";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";

        /// <summary>
        /// 主诉(数据库字段名)
        /// </summary>
        public static readonly string ZS = "ZS";

        /// <summary>
        /// 现病史(数据库字段名)
        /// </summary>
        public static readonly string XBS = "XBS";

        /// <summary>
        /// 既往史(数据库字段名)
        /// </summary>
        public static readonly string JWS = "JWS";

        /// <summary>
        /// 过敏史(数据库字段名)
        /// </summary>
        public static readonly string GMS = "GMS";

        /// <summary>
        /// 体温（摄氏度）(数据库字段名)
        /// </summary>
        public static readonly string TW = "TW";

        /// <summary>
        /// 呼吸（次/分）(数据库字段名)
        /// </summary>
        public static readonly string HX = "HX";

        /// <summary>
        /// 脉搏（次/分）(数据库字段名)
        /// </summary>
        public static readonly string MB = "MB";

        /// <summary>
        /// 收缩血压（mmhg）(数据库字段名)
        /// </summary>
        public static readonly string SSXY = "SSXY";

        /// <summary>
        /// 舒张血压（mmhg）(数据库字段名)
        /// </summary>
        public static readonly string SZXY = "SZXY";

        /// <summary>
        /// 心率（次/分）(数据库字段名)
        /// </summary>
        public static readonly string XL = "XL";

        /// <summary>
        /// 空腹血糖值（mmol/l）(数据库字段名)
        /// </summary>
        public static readonly string KFXTZ = "KFXTZ";

        /// <summary>
        /// 查体(数据库字段名)
        /// </summary>
        public static readonly string CHA_TI = "CHA_TI";

        /// <summary>
        /// 挂号表外键（关联挂号表）(数据库字段名)
        /// </summary>
        public static readonly string FK_GH_ID = "FK_GH_ID";

        /// <summary>
        /// 挂号表的流水号（冗余）(数据库字段名)
        /// </summary>
        public static readonly string GH_LSH = "GH_LSH";

        /// <summary>
        /// 处理意见(数据库字段名)
        /// </summary>
        public static readonly string CLYJ = "CLYJ";
        /// <summary>
        /// 把object对象转换为Mz_bl对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.MZ.Mz_bl ConvertToMz_bl(object obj)
        {
            if (null==obj)
            {
                return new Model.MZ.Mz_bl();
            }
            return (Model.MZ.Mz_bl)obj;
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
        /// 主诉（对象属性名）
        /// </summary>
        private string zs;
        /// <summary>
        /// 主诉（对象属性名）
        /// </summary>
        public string Zs
        {
            get { return this.zs; }
            set { this.zs = value; }
        }



        /// <summary>
        /// 现病史（对象属性名）
        /// </summary>
        private string xbs;
        /// <summary>
        /// 现病史（对象属性名）
        /// </summary>
        public string Xbs
        {
            get { return this.xbs; }
            set { this.xbs = value; }
        }



        /// <summary>
        /// 既往史（对象属性名）
        /// </summary>
        private string jws;
        /// <summary>
        /// 既往史（对象属性名）
        /// </summary>
        public string Jws
        {
            get { return this.jws; }
            set { this.jws = value; }
        }



        /// <summary>
        /// 过敏史（对象属性名）
        /// </summary>
        private string gms;
        /// <summary>
        /// 过敏史（对象属性名）
        /// </summary>
        public string Gms
        {
            get { return this.gms; }
            set { this.gms = value; }
        }



        /// <summary>
        /// 体温（摄氏度）（对象属性名）
        /// </summary>
        private decimal? tw;
        /// <summary>
        /// 体温（摄氏度）（对象属性名）
        /// </summary>
        public decimal? Tw
        {
            get { return this.tw; }
            set { this.tw = value; }
        }



        /// <summary>
        /// 呼吸（次/分）（对象属性名）
        /// </summary>
        private decimal? hx;
        /// <summary>
        /// 呼吸（次/分）（对象属性名）
        /// </summary>
        public decimal? Hx
        {
            get { return this.hx; }
            set { this.hx = value; }
        }



        /// <summary>
        /// 脉搏（次/分）（对象属性名）
        /// </summary>
        private decimal? mb;
        /// <summary>
        /// 脉搏（次/分）（对象属性名）
        /// </summary>
        public decimal? Mb
        {
            get { return this.mb; }
            set { this.mb = value; }
        }



        /// <summary>
        /// 收缩血压（mmhg）（对象属性名）
        /// </summary>
        private decimal? ssxy;
        /// <summary>
        /// 收缩血压（mmhg）（对象属性名）
        /// </summary>
        public decimal? Ssxy
        {
            get { return this.ssxy; }
            set { this.ssxy = value; }
        }



        /// <summary>
        /// 舒张血压（mmhg）（对象属性名）
        /// </summary>
        private decimal? szxy;
        /// <summary>
        /// 舒张血压（mmhg）（对象属性名）
        /// </summary>
        public decimal? Szxy
        {
            get { return this.szxy; }
            set { this.szxy = value; }
        }



        /// <summary>
        /// 心率（次/分）（对象属性名）
        /// </summary>
        private decimal? xl;
        /// <summary>
        /// 心率（次/分）（对象属性名）
        /// </summary>
        public decimal? Xl
        {
            get { return this.xl; }
            set { this.xl = value; }
        }



        /// <summary>
        /// 空腹血糖值（mmol/l）（对象属性名）
        /// </summary>
        private decimal? kfxtz;
        /// <summary>
        /// 空腹血糖值（mmol/l）（对象属性名）
        /// </summary>
        public decimal? Kfxtz
        {
            get { return this.kfxtz; }
            set { this.kfxtz = value; }
        }



        /// <summary>
        /// 查体（对象属性名）
        /// </summary>
        private string cha_ti;
        /// <summary>
        /// 查体（对象属性名）
        /// </summary>
        public string Cha_ti
        {
            get { return this.cha_ti; }
            set { this.cha_ti = value; }
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
        /// 处理意见（对象属性名）
        /// </summary>
        private string clyj;
        /// <summary>
        /// 处理意见（对象属性名）
        /// </summary>
        public string Clyj
        {
            get { return this.clyj; }
            set { this.clyj = value; }
        }

        //        //*****************在此之后添加关联对象
    }
}
