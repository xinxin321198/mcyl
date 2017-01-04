
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MZ
{
    /// <summary>
    ///oracle数据库
    ///MZ_GH表的实体类
    ///门诊_挂号
    ///此类由代码生成器生成
    ///生成日期：2015-12-30 17:18:17
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Mz_gh:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "门诊_挂号";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "MZ_GH";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 流水号(数据库字段名)
        /// </summary>
        public static readonly string LSH = "LSH";

        /// <summary>
        /// 挂号病人的外键(数据库字段名)
        /// </summary>
        public static readonly string FK_JC_JM = "FK_JC_JM";

        /// <summary>
        /// 病人姓名（冗余）(数据库字段名)
        /// </summary>
        public static readonly string BRXM = "BRXM";

        /// <summary>
        /// 病人出生日期（冗余）(数据库字段名)
        /// </summary>
        public static readonly string BRCSRQ = "BRCSRQ";

        /// <summary>
        /// 病人性别（冗余）(数据库字段名)
        /// </summary>
        public static readonly string BRXB = "BRXB";

        /// <summary>
        /// 病人身份证号（冗余）(数据库字段名)
        /// </summary>
        public static readonly string BRSFZH = "BRSFZH";

        /// <summary>
        /// 病人联系电话（冗余）(数据库字段名)
        /// </summary>
        public static readonly string BRLXDH = "BRLXDH";

        /// <summary>
        /// 现住址所属行政区划（冗余）(数据库字段名)
        /// </summary>
        public static readonly string BRXZZ_XZQH = "BRXZZ_XZQH";

        /// <summary>
        /// 现住址，详细地址（冗余）(数据库字段名)
        /// </summary>
        public static readonly string BRXZZ_DETAIL = "BRXZZ_DETAIL";

        /// <summary>
        /// 病人类型(数据库字段名)
        /// </summary>
        public static readonly string BRLX_CODE = "BRLX_CODE";

        /// <summary>
        /// 挂号科室外键(数据库字段名)
        /// </summary>
        public static readonly string FK_JC_KSWH = "FK_JC_KSWH";

        /// <summary>
        /// 挂号的医生外键(数据库字段名)
        /// </summary>
        public static readonly string FK_JC_RENYUAN = "FK_JC_RENYUAN";

        /// <summary>
        /// 挂号类型（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string GHLX_CODE = "GHLX_CODE";

        /// <summary>
        /// 挂号日期(数据库字段名)
        /// </summary>
        public static readonly string GHRQ = "GHRQ";

        /// <summary>
        /// 挂号状态(数据库字段名)
        /// </summary>
        public static readonly string STATE_CODE = "STATE_CODE";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Mz_gh对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.MZ.Mz_gh ConvertToMz_gh(object obj)
        {
            if (null==obj)
            {
                return new Model.MZ.Mz_gh();
            }
            return (Model.MZ.Mz_gh)obj;
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
        /// 挂号病人的外键（对象属性名）
        /// </summary>
        private string fk_jc_jm;
        /// <summary>
        /// 挂号病人的外键（对象属性名）
        /// </summary>
        public string Fk_jc_jm
        {
            get { return this.fk_jc_jm; }
            set { this.fk_jc_jm = value; }
        }



        /// <summary>
        /// 病人姓名（冗余）（对象属性名）
        /// </summary>
        private string brxm;
        /// <summary>
        /// 病人姓名（冗余）（对象属性名）
        /// </summary>
        public string Brxm
        {
            get { return this.brxm; }
            set { this.brxm = value; }
        }



        /// <summary>
        /// 病人出生日期（冗余）（对象属性名）
        /// </summary>
        private DateTime? brcsrq;
        /// <summary>
        /// 病人出生日期（冗余）（对象属性名）
        /// </summary>
        public DateTime? Brcsrq
        {
            get { return this.brcsrq; }
            set { this.brcsrq = value; }
        }



        /// <summary>
        /// 病人性别（冗余）（对象属性名）
        /// </summary>
        private string brxb;
        /// <summary>
        /// 病人性别（冗余）（对象属性名）
        /// </summary>
        public string Brxb
        {
            get { return this.brxb; }
            set { this.brxb = value; }
        }



        /// <summary>
        /// 病人身份证号（冗余）（对象属性名）
        /// </summary>
        private string brsfzh;
        /// <summary>
        /// 病人身份证号（冗余）（对象属性名）
        /// </summary>
        public string Brsfzh
        {
            get { return this.brsfzh; }
            set { this.brsfzh = value; }
        }



        /// <summary>
        /// 病人联系电话（冗余）（对象属性名）
        /// </summary>
        private string brlxdh;
        /// <summary>
        /// 病人联系电话（冗余）（对象属性名）
        /// </summary>
        public string Brlxdh
        {
            get { return this.brlxdh; }
            set { this.brlxdh = value; }
        }



        /// <summary>
        /// 现住址所属行政区划（冗余）（对象属性名）
        /// </summary>
        private string brxzz_xzqh;
        /// <summary>
        /// 现住址所属行政区划（冗余）（对象属性名）
        /// </summary>
        public string Brxzz_xzqh
        {
            get { return this.brxzz_xzqh; }
            set { this.brxzz_xzqh = value; }
        }



        /// <summary>
        /// 现住址，详细地址（冗余）（对象属性名）
        /// </summary>
        private string brxzz_detail;
        /// <summary>
        /// 现住址，详细地址（冗余）（对象属性名）
        /// </summary>
        public string Brxzz_detail
        {
            get { return this.brxzz_detail; }
            set { this.brxzz_detail = value; }
        }



        /// <summary>
        /// 病人类型（对象属性名）
        /// </summary>
        private string brlx_code;
        /// <summary>
        /// 病人类型（对象属性名）
        /// </summary>
        public string Brlx_code
        {
            get { return this.brlx_code; }
            set { this.brlx_code = value; }
        }



        /// <summary>
        /// 挂号科室外键（对象属性名）
        /// </summary>
        private string fk_jc_kswh;
        /// <summary>
        /// 挂号科室外键（对象属性名）
        /// </summary>
        public string Fk_jc_kswh
        {
            get { return this.fk_jc_kswh; }
            set { this.fk_jc_kswh = value; }
        }



        /// <summary>
        /// 挂号的医生外键（对象属性名）
        /// </summary>
        private string fk_jc_renyuan;
        /// <summary>
        /// 挂号的医生外键（对象属性名）
        /// </summary>
        public string Fk_jc_renyuan
        {
            get { return this.fk_jc_renyuan; }
            set { this.fk_jc_renyuan = value; }
        }



        /// <summary>
        /// 挂号类型（关联代码表）（对象属性名）
        /// </summary>
        private string ghlx_code;
        /// <summary>
        /// 挂号类型（关联代码表）（对象属性名）
        /// </summary>
        public string Ghlx_code
        {
            get { return this.ghlx_code; }
            set { this.ghlx_code = value; }
        }



        /// <summary>
        /// 挂号日期（对象属性名）
        /// </summary>
        private DateTime? ghrq;
        /// <summary>
        /// 挂号日期（对象属性名）
        /// </summary>
        public DateTime? Ghrq
        {
            get { return this.ghrq; }
            set { this.ghrq = value; }
        }



        /// <summary>
        /// 挂号状态（对象属性名）
        /// </summary>
        private string state_code;
        /// <summary>
        /// 挂号状态（对象属性名）
        /// </summary>
        public string State_code
        {
            get { return this.state_code; }
            set { this.state_code = value; }
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
        /// 挂号病人的外键对象
        /// </summary>
        private Model.JC.Jc_jm jc_jm;
        /// <summary>
        /// 挂号病人的外键对象
        /// </summary>
        public Model.JC.Jc_jm Jc_jm
        {
            get { return jc_jm; }
            set { jc_jm = value; }
        }

        /// <summary>
        /// 病人类型对象
        /// </summary>
        private Model.JC.Jc_code brlxCode;
        /// <summary>
        /// 病人类型对象
        /// </summary>
        public Model.JC.Jc_code BrlxCode
        {
            get { return brlxCode; }
            set { brlxCode = value; }
        }

        /// <summary>
        /// 挂号科室外键对象
        /// </summary>
        private Model.JC.Jc_kswh jc_kswh;
        /// <summary>
        /// 挂号科室外键对象
        /// </summary>
        public Model.JC.Jc_kswh Jc_kswh
        {
            get { return jc_kswh; }
            set { jc_kswh = value; }
        }

        /// <summary>
        /// 挂号的医生外键对象
        /// </summary>
        private Model.JC.Jc_renyuan jc_renyuan;
        /// <summary>
        /// 挂号的医生外键对象
        /// </summary>
        public Model.JC.Jc_renyuan Jc_renyuan
        {
            get { return jc_renyuan; }
            set { jc_renyuan = value; }
        }

        /// <summary>
        /// 挂号类型（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code ghlxCode;
        /// <summary>
        /// 挂号类型（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code GhlxCode
        {
            get { return ghlxCode; }
            set { ghlxCode = value; }
        }

        /// <summary>
        /// 挂号状态对象
        /// </summary>
        private Model.JC.Jc_code stateCode;
        /// <summary>
        /// 挂号状态对象
        /// </summary>
        public Model.JC.Jc_code StateCode
        {
            get { return stateCode; }
            set { stateCode = value; }
        }

        #endregion model,实体类新增的对象，end

    }
}
