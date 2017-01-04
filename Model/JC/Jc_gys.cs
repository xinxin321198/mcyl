
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_GYS表的实体类
    ///基础_供应商
    ///此类由代码生成器生成
    ///生成日期：2015/12/15 11:40:44
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_gys:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_供应商";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_GYS";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 供应商编号(数据库字段名)
        /// </summary>
        public static readonly string GYSBH = "GYSBH";

        /// <summary>
        /// 供应商名称(数据库字段名)
        /// </summary>
        public static readonly string GYSMC = "GYSMC";

        /// <summary>
        /// 拼音码(数据库字段名)
        /// </summary>
        public static readonly string PYM = "PYM";

        /// <summary>
        /// 五笔码(数据库字段名)
        /// </summary>
        public static readonly string WBM = "WBM";

        /// <summary>
        /// 类型（关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string LX_CODE = "LX_CODE";

        /// <summary>
        /// 地址(数据库字段名)
        /// </summary>
        public static readonly string DZ = "DZ";

        /// <summary>
        /// 联系人(数据库字段名)
        /// </summary>
        public static readonly string LXR = "LXR";

        /// <summary>
        /// 电话(数据库字段名)
        /// </summary>
        public static readonly string DH = "DH";

        /// <summary>
        /// 作废标识(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Jc_gys对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_gys ConvertToJc_gys(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_gys();
            }
            return (Model.JC.Jc_gys)obj;
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
        /// 供应商编号（对象属性名）
        /// </summary>
        private string gysbh;
        /// <summary>
        /// 供应商编号（对象属性名）
        /// </summary>
        public string Gysbh
        {
            get { return this.gysbh; }
            set { this.gysbh = value; }
        }



        /// <summary>
        /// 供应商名称（对象属性名）
        /// </summary>
        private string gysmc;
        /// <summary>
        /// 供应商名称（对象属性名）
        /// </summary>
        public string Gysmc
        {
            get { return this.gysmc; }
            set { this.gysmc = value; }
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
        /// 类型（关联代码表）（对象属性名）
        /// </summary>
        private string lx_code;
        /// <summary>
        /// 类型（关联代码表）（对象属性名）
        /// </summary>
        public string Lx_code
        {
            get { return this.lx_code; }
            set { this.lx_code = value; }
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
        /// 联系人（对象属性名）
        /// </summary>
        private string lxr;
        /// <summary>
        /// 联系人（对象属性名）
        /// </summary>
        public string Lxr
        {
            get { return this.lxr; }
            set { this.lxr = value; }
        }



        /// <summary>
        /// 电话（对象属性名）
        /// </summary>
        private string dh;
        /// <summary>
        /// 电话（对象属性名）
        /// </summary>
        public string Dh
        {
            get { return this.dh; }
            set { this.dh = value; }
        }



        /// <summary>
        /// 作废标识（对象属性名）
        /// </summary>
        private string zfbz;
        /// <summary>
        /// 作废标识（对象属性名）
        /// </summary>
        public string Zfbz
        {
            get { return this.zfbz; }
            set { this.zfbz = value; }
        }

        //        //*****************在此之后添加关联对象
        #region model,实体类新增的对象，start

        /// <summary>
        /// 类型（关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code lxCode;
        /// <summary>
        /// 类型（关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code LxCode
        {
            get { return lxCode; }
            set { lxCode = value; }
        }

        #endregion model,实体类新增的对象，end

    }
}
