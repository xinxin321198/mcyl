
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_RY_KS表的实体类
    ///基础_工作人员所属科室关系
    ///此类由代码生成器生成
    ///生成日期：2015-12-02 15:50:41
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_ry_ks:Base.IBaseModel
        {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_工作人员所属科室关系";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_RY_KS";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 人员id外键(数据库字段名)
        /// </summary>
        public static readonly string FK_RENYUAN_ID = "FK_RENYUAN_ID";

        /// <summary>
        /// 科室id外键(数据库字段名)
        /// </summary>
        public static readonly string FK_KESHI_ID = "FK_KESHI_ID";

        /// <summary>
        /// 作废标志(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";
        /// <summary>
        /// 把object对象转换为Jc_ry_ks对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_ry_ks ConvertToJc_ry_ks(object obj)
        {
            if (null==obj)
            {
                return new Model.JC.Jc_ry_ks();
            }
            return (Model.JC.Jc_ry_ks)obj;
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
        /// 人员id外键（对象属性名）
        /// </summary>
        private string fk_renyuan_id;
        /// <summary>
        /// 人员id外键（对象属性名）
        /// </summary>
        public string Fk_renyuan_id
        {
            get { return this.fk_renyuan_id; }
            set { this.fk_renyuan_id = value; }
        }



        /// <summary>
        /// 科室id外键（对象属性名）
        /// </summary>
        private string fk_keshi_id;
        /// <summary>
        /// 科室id外键（对象属性名）
        /// </summary>
        public string Fk_keshi_id
        {
            get { return this.fk_keshi_id; }
            set { this.fk_keshi_id = value; }
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
        /// 人员id外键对象
        /// </summary>
        private Model.JC.Jc_renyuan jc_renyuan;
        /// <summary>
        /// 人员id外键对象
        /// </summary>
        public Model.JC.Jc_renyuan Jc_renyuan
        {
            get { return jc_renyuan; }
            set { jc_renyuan = value; }
        }

        /// <summary>
        /// 科室id外键对象
        /// </summary>
        private Model.JC.Jc_kswh jc_kswh;
        /// <summary>
        /// 科室id外键对象
        /// </summary>
        public Model.JC.Jc_kswh Jc_kswh
        {
            get { return jc_kswh; }
            set { jc_kswh = value; }
        }

        #endregion model,实体类新增的对象，end
    }
}
