
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_FPLY表的实体类
    ///基础_发票领用管理
    ///此类由代码生成器生成
    ///生成日期：2015-11-21 18:02:49
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_fply:Base.IBaseModel
        {
        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_FPLY";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 流水号(数据库字段名)
        /// </summary>
        public static readonly string LSH = "LSH";

        /// <summary>
        /// 领用人编号(数据库字段名)
        /// </summary>
        public static readonly string LYR_ID = "LYR_ID";

        /// <summary>
        /// 领用时间(数据库字段名)
        /// </summary>
        public static readonly string LYSJ = "LYSJ";

        /// <summary>
        /// 起始发票号(数据库字段名)
        /// </summary>
        public static readonly string FPH_START = "FPH_START";

        /// <summary>
        /// 终止发票号(数据库字段名)
        /// </summary>
        public static readonly string FPH_END = "FPH_END";

        /// <summary>
        /// 操作员编号(数据库字段名)
        /// </summary>
        public static readonly string CZY_ID = "CZY_ID";

        /// <summary>
        /// 发票类型(数据库字段名)
        /// </summary>
        public static readonly string FPLX = "FPLX";

        /// <summary>
        /// 作废标志（0禁用，1启用）(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Jc_fply对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_fply ConvertToJc_fply(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_fply();
            }
            return (Model.JC.Jc_fply)obj;
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
        /// 流水号（对象属性名）
        /// </summary>
        private decimal? lsh;
        /// <summary>
        /// 流水号（对象属性名）
        /// </summary>
        public decimal? Lsh
        {
            get { return this.lsh; }
            set { this.lsh = value; }
        }



        /// <summary>
        /// 领用人编号（对象属性名）
        /// </summary>
        private string lyr_id;
        /// <summary>
        /// 领用人编号（对象属性名）
        /// </summary>
        public string Lyr_id
        {
            get { return this.lyr_id; }
            set { this.lyr_id = value; }
        }



        /// <summary>
        /// 领用时间（对象属性名）
        /// </summary>
        private DateTime lysj;
        /// <summary>
        /// 领用时间（对象属性名）
        /// </summary>
        public DateTime Lysj
        {
            get { return this.lysj; }
            set { this.lysj = value; }
        }



        /// <summary>
        /// 起始发票号（对象属性名）
        /// </summary>
        private string fph_start;
        /// <summary>
        /// 起始发票号（对象属性名）
        /// </summary>
        public string Fph_start
        {
            get { return this.fph_start; }
            set { this.fph_start = value; }
        }



        /// <summary>
        /// 终止发票号（对象属性名）
        /// </summary>
        private string fph_end;
        /// <summary>
        /// 终止发票号（对象属性名）
        /// </summary>
        public string Fph_end
        {
            get { return this.fph_end; }
            set { this.fph_end = value; }
        }



        /// <summary>
        /// 操作员编号（对象属性名）
        /// </summary>
        private string czy_id;
        /// <summary>
        /// 操作员编号（对象属性名）
        /// </summary>
        public string Czy_id
        {
            get { return this.czy_id; }
            set { this.czy_id = value; }
        }



        /// <summary>
        /// 发票类型（对象属性名）
        /// </summary>
        private string fplx;
        /// <summary>
        /// 发票类型（对象属性名）
        /// </summary>
        public string Fplx
        {
            get { return this.fplx; }
            set { this.fplx = value; }
        }



        /// <summary>
        /// 作废标志（0禁用，1启用）（对象属性名）
        /// </summary>
        private string zfbz;
        /// <summary>
        /// 作废标志（0禁用，1启用）（对象属性名）
        /// </summary>
        public string Zfbz
        {
            get { return this.zfbz; }
            set { this.zfbz = value; }
        }

        //        //*****************在此之后添加关联对象
    }
}
