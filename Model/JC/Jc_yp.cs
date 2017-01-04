
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.JC
{
    /// <summary>
    ///oracle数据库
    ///JC_YP表的实体类
    ///基础_药品字典
    ///此类由代码生成器生成
    ///生成日期：2016-01-20 10:36:09
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com

    /// </summary>
    public class Jc_yp : Base.IBaseModel
    {

        /// <summary>
        /// 表备注
        /// </summary>
        public static readonly string 表备注 = "基础_药品字典";

        /// <summary>
        /// 数据库表名
        /// </summary>
        public static readonly string TABEL_NAME = "JC_YP";


        /// <summary>
        /// 主键(数据库字段名)
        /// </summary>
        public static readonly string ID = "ID";

        /// <summary>
        /// 药品编码(数据库字段名)
        /// </summary>
        public static readonly string YPBM = "YPBM";

        /// <summary>
        /// 药品名称(商品名)(数据库字段名)
        /// </summary>
        public static readonly string YPMC = "YPMC";

        /// <summary>
        /// 药品通用名(数据库字段名)
        /// </summary>
        public static readonly string YPTYMC = "YPTYMC";

        /// <summary>
        /// 药品成分(数据库字段名)
        /// </summary>
        public static readonly string YPCF = "YPCF";

        /// <summary>
        /// 药品批准文号(数据库字段名)
        /// </summary>
        public static readonly string YPPZWH = "YPPZWH";

        /// <summary>
        /// 药品注册证号(数据库字段名)
        /// </summary>
        public static readonly string YPZCZH = "YPZCZH";

        /// <summary>
        /// 国药准字(数据库字段名)
        /// </summary>
        public static readonly string GYZZ = "GYZZ";

        /// <summary>
        /// 剂型,cv5301.01药物剂型代码(关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string YPJX_CODE = "YPJX_CODE";

        /// <summary>
        /// 规格(数据库字段名)
        /// </summary>
        public static readonly string YPGG = "YPGG";

        /// <summary>
        /// 药品单次用量(数据库字段名)
        /// </summary>
        public static readonly string YPDCYL = "YPDCYL";

        /// <summary>
        /// 药品单次用量单位(关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string YPDCYLDW_CODE = "YPDCYLDW_CODE";

        /// <summary>
        /// 用量用法,cv5201.22用药途径代码(关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string YPYYTJ_CODE = "YPYYTJ_CODE";

        /// <summary>
        /// 大单位(药品大单位，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string DDW_CODE = "DDW_CODE";

        /// <summary>
        /// 小单位(药品小单位，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string XDW_CODE = "XDW_CODE";

        /// <summary>
        /// 处方药标志（rx  otc）(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string CFYBZ_CODE = "CFYBZ_CODE";

        /// <summary>
        /// 处方权限基药(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string CFQXJY_CODE = "CFQXJY_CODE";

        /// <summary>
        /// 处方权限医保(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string CFQXYB_CODE = "CFQXYB_CODE";

        /// <summary>
        /// 处方权限毒麻(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string CFQXDM_CODE = "CFQXDM_CODE";

        /// <summary>
        /// 处方权限精神(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string CFQXJS_CODE = "CFQXJS_CODE";

        /// <summary>
        /// 处方权限贵重(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string CFQXGZ_CODE = "CFQXGZ_CODE";

        /// <summary>
        /// 处方权限进口(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string CFQXJK_CODE = "CFQXJK_CODE";

        /// <summary>
        /// 处方权限自制(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string CFQXZZ_CODE = "CFQXZZ_CODE";

        /// <summary>
        /// 处方权限自费(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string CFQXZF_CODE = "CFQXZF_CODE";

        /// <summary>
        /// 处方权限特殊(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string CFQXTS_CODE = "CFQXTS_CODE";

        /// <summary>
        /// 皮试(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string PS_CODE = "PS_CODE";

        /// <summary>
        /// cv5301.06药物类型代码(关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string YPLX_CODE = "YPLX_CODE";

        /// <summary>
        /// 药品描述适应症(数据库字段名)
        /// </summary>
        public static readonly string YPMSSYZ = "YPMSSYZ";

        /// <summary>
        /// 药品描述禁忌症（疾病）(数据库字段名)
        /// </summary>
        public static readonly string YPMSJJZ = "YPMSJJZ";

        /// <summary>
        /// 药品描述孕妇或哺乳期禁用(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string YPMSYFHBRQJY_CODE = "YPMSYFHBRQJY_CODE";

        /// <summary>
        /// 药品描述不良反应(数据库字段名)
        /// </summary>
        public static readonly string YPMSBLFY = "YPMSBLFY";

        /// <summary>
        /// 药品分类(关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string YPFL_CODE = "YPFL_CODE";

        /// <summary>
        /// 药价级别(关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string YJJB_CODE = "YJJB_CODE";

        /// <summary>
        /// 条形码(数据库字段名)
        /// </summary>
        public static readonly string TXM = "TXM";

        /// <summary>
        /// 二维码(数据库字段名)
        /// </summary>
        public static readonly string EWM = "EWM";

        /// <summary>
        /// 拼音码(数据库字段名)
        /// </summary>
        public static readonly string PYM = "PYM";

        /// <summary>
        /// 换算系数(数据库字段名)
        /// </summary>
        public static readonly string HSXS = "HSXS";

        /// <summary>
        /// 是否拆零用(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string SFCLY_CODE = "SFCLY_CODE";

        /// <summary>
        /// 包装批发价(数据库字段名)
        /// </summary>
        public static readonly string BZPFJ = "BZPFJ";

        /// <summary>
        /// 包装零售价(数据库字段名)
        /// </summary>
        public static readonly string BZLSJ = "BZLSJ";

        /// <summary>
        /// 包装门诊价(数据库字段名)
        /// </summary>
        public static readonly string BZMZJ = "BZMZJ";

        /// <summary>
        /// 包装住院价(数据库字段名)
        /// </summary>
        public static readonly string BZZYJ = "BZZYJ";

        /// <summary>
        /// 换算比例(数据库字段名)
        /// </summary>
        public static readonly string HSBL = "HSBL";

        /// <summary>
        /// 是否拆零卖(是否，关联代码表)(数据库字段名)
        /// </summary>
        public static readonly string SFCLM_CODE = "SFCLM_CODE";

        /// <summary>
        /// 有效状态（0无效，1有效, 关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string YXZT_CODE = "YXZT_CODE";

        /// <summary>
        /// 单次上限用量(数据库字段名)
        /// </summary>
        public static readonly string DCSXYL = "DCSXYL";

        /// <summary>
        /// 单次上限用量(数据库字段名)
        /// </summary>
        public static readonly string DCXXYL = "DCXXYL";

        /// <summary>
        /// 连续用量天数(数据库字段名)
        /// </summary>
        public static readonly string LXYLTS = "LXYLTS";

        /// <summary>
        /// 连续用量次数(数据库字段名)
        /// </summary>
        public static readonly string LXYLCS = "LXYLCS";

        /// <summary>
        /// 生产企业(数据库字段名)
        /// </summary>
        public static readonly string SCQY = "SCQY";

        /// <summary>
        /// 批准日期(数据库字段名)
        /// </summary>
        public static readonly string PZRQ = "PZRQ";

        /// <summary>
        /// 是否是抗生素（1是，0否，关联代码表）(数据库字段名)
        /// </summary>
        public static readonly string SFKSS_CODE = "SFKSS_CODE";

        /// <summary>
        /// 作废标志（0作废，1有效）(数据库字段名)
        /// </summary>
        public static readonly string ZFBZ = "ZFBZ";

        /// <summary>
        /// 单次用量单位比例(数据库字段名)
        /// </summary>
        public static readonly string DCYLDWBL = "DCYLDWBL";
        /// <summary>
        /// 把object对象转换为Jc_yp对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Model.JC.Jc_yp ConvertToJc_yp(object obj)
        {
            if (null == obj)
            {
                return new Model.JC.Jc_yp();
            }
            return (Model.JC.Jc_yp)obj;
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
        /// 药品编码（对象属性名）
        /// </summary>
        private string ypbm;
        /// <summary>
        /// 药品编码（对象属性名）
        /// </summary>
        public string Ypbm
        {
            get { return this.ypbm; }
            set { this.ypbm = value; }
        }



        /// <summary>
        /// 药品名称(商品名)（对象属性名）
        /// </summary>
        private string ypmc;
        /// <summary>
        /// 药品名称(商品名)（对象属性名）
        /// </summary>
        public string Ypmc
        {
            get { return this.ypmc; }
            set { this.ypmc = value; }
        }



        /// <summary>
        /// 药品通用名（对象属性名）
        /// </summary>
        private string yptymc;
        /// <summary>
        /// 药品通用名（对象属性名）
        /// </summary>
        public string Yptymc
        {
            get { return this.yptymc; }
            set { this.yptymc = value; }
        }



        /// <summary>
        /// 药品成分（对象属性名）
        /// </summary>
        private string ypcf;
        /// <summary>
        /// 药品成分（对象属性名）
        /// </summary>
        public string Ypcf
        {
            get { return this.ypcf; }
            set { this.ypcf = value; }
        }



        /// <summary>
        /// 药品批准文号（对象属性名）
        /// </summary>
        private string yppzwh;
        /// <summary>
        /// 药品批准文号（对象属性名）
        /// </summary>
        public string Yppzwh
        {
            get { return this.yppzwh; }
            set { this.yppzwh = value; }
        }



        /// <summary>
        /// 药品注册证号（对象属性名）
        /// </summary>
        private string ypzczh;
        /// <summary>
        /// 药品注册证号（对象属性名）
        /// </summary>
        public string Ypzczh
        {
            get { return this.ypzczh; }
            set { this.ypzczh = value; }
        }



        /// <summary>
        /// 国药准字（对象属性名）
        /// </summary>
        private string gyzz;
        /// <summary>
        /// 国药准字（对象属性名）
        /// </summary>
        public string Gyzz
        {
            get { return this.gyzz; }
            set { this.gyzz = value; }
        }



        /// <summary>
        /// 剂型,cv5301.01药物剂型代码(关联代码表)（对象属性名）
        /// </summary>
        private string ypjx_code;
        /// <summary>
        /// 剂型,cv5301.01药物剂型代码(关联代码表)（对象属性名）
        /// </summary>
        public string Ypjx_code
        {
            get { return this.ypjx_code; }
            set { this.ypjx_code = value; }
        }



        /// <summary>
        /// 规格（对象属性名）
        /// </summary>
        private string ypgg;
        /// <summary>
        /// 规格（对象属性名）
        /// </summary>
        public string Ypgg
        {
            get { return this.ypgg; }
            set { this.ypgg = value; }
        }



        /// <summary>
        /// 药品单次用量（对象属性名）
        /// </summary>
        private decimal? ypdcyl;
        /// <summary>
        /// 药品单次用量（对象属性名）
        /// </summary>
        public decimal? Ypdcyl
        {
            get { return this.ypdcyl; }
            set { this.ypdcyl = value; }
        }



        /// <summary>
        /// 药品单次用量单位(关联代码表)（对象属性名）
        /// </summary>
        private string ypdcyldw_code;
        /// <summary>
        /// 药品单次用量单位(关联代码表)（对象属性名）
        /// </summary>
        public string Ypdcyldw_code
        {
            get { return this.ypdcyldw_code; }
            set { this.ypdcyldw_code = value; }
        }



        /// <summary>
        /// 用量用法,cv5201.22用药途径代码(关联代码表)（对象属性名）
        /// </summary>
        private string ypyytj_code;
        /// <summary>
        /// 用量用法,cv5201.22用药途径代码(关联代码表)（对象属性名）
        /// </summary>
        public string Ypyytj_code
        {
            get { return this.ypyytj_code; }
            set { this.ypyytj_code = value; }
        }



        /// <summary>
        /// 大单位(药品大单位，关联代码表)（对象属性名）
        /// </summary>
        private string ddw_code;
        /// <summary>
        /// 大单位(药品大单位，关联代码表)（对象属性名）
        /// </summary>
        public string Ddw_code
        {
            get { return this.ddw_code; }
            set { this.ddw_code = value; }
        }



        /// <summary>
        /// 小单位(药品小单位，关联代码表)（对象属性名）
        /// </summary>
        private string xdw_code;
        /// <summary>
        /// 小单位(药品小单位，关联代码表)（对象属性名）
        /// </summary>
        public string Xdw_code
        {
            get { return this.xdw_code; }
            set { this.xdw_code = value; }
        }



        /// <summary>
        /// 处方药标志（rx  otc）(是否，关联代码表)（对象属性名）
        /// </summary>
        private string cfybz_code;
        /// <summary>
        /// 处方药标志（rx  otc）(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Cfybz_code
        {
            get { return this.cfybz_code; }
            set { this.cfybz_code = value; }
        }



        /// <summary>
        /// 处方权限基药(是否，关联代码表)（对象属性名）
        /// </summary>
        private string cfqxjy_code;
        /// <summary>
        /// 处方权限基药(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Cfqxjy_code
        {
            get { return this.cfqxjy_code; }
            set { this.cfqxjy_code = value; }
        }



        /// <summary>
        /// 处方权限医保(是否，关联代码表)（对象属性名）
        /// </summary>
        private string cfqxyb_code;
        /// <summary>
        /// 处方权限医保(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Cfqxyb_code
        {
            get { return this.cfqxyb_code; }
            set { this.cfqxyb_code = value; }
        }



        /// <summary>
        /// 处方权限毒麻(是否，关联代码表)（对象属性名）
        /// </summary>
        private string cfqxdm_code;
        /// <summary>
        /// 处方权限毒麻(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Cfqxdm_code
        {
            get { return this.cfqxdm_code; }
            set { this.cfqxdm_code = value; }
        }



        /// <summary>
        /// 处方权限精神(是否，关联代码表)（对象属性名）
        /// </summary>
        private string cfqxjs_code;
        /// <summary>
        /// 处方权限精神(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Cfqxjs_code
        {
            get { return this.cfqxjs_code; }
            set { this.cfqxjs_code = value; }
        }



        /// <summary>
        /// 处方权限贵重(是否，关联代码表)（对象属性名）
        /// </summary>
        private string cfqxgz_code;
        /// <summary>
        /// 处方权限贵重(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Cfqxgz_code
        {
            get { return this.cfqxgz_code; }
            set { this.cfqxgz_code = value; }
        }



        /// <summary>
        /// 处方权限进口(是否，关联代码表)（对象属性名）
        /// </summary>
        private string cfqxjk_code;
        /// <summary>
        /// 处方权限进口(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Cfqxjk_code
        {
            get { return this.cfqxjk_code; }
            set { this.cfqxjk_code = value; }
        }



        /// <summary>
        /// 处方权限自制(是否，关联代码表)（对象属性名）
        /// </summary>
        private string cfqxzz_code;
        /// <summary>
        /// 处方权限自制(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Cfqxzz_code
        {
            get { return this.cfqxzz_code; }
            set { this.cfqxzz_code = value; }
        }



        /// <summary>
        /// 处方权限自费(是否，关联代码表)（对象属性名）
        /// </summary>
        private string cfqxzf_code;
        /// <summary>
        /// 处方权限自费(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Cfqxzf_code
        {
            get { return this.cfqxzf_code; }
            set { this.cfqxzf_code = value; }
        }



        /// <summary>
        /// 处方权限特殊(是否，关联代码表)（对象属性名）
        /// </summary>
        private string cfqxts_code;
        /// <summary>
        /// 处方权限特殊(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Cfqxts_code
        {
            get { return this.cfqxts_code; }
            set { this.cfqxts_code = value; }
        }



        /// <summary>
        /// 皮试(是否，关联代码表)（对象属性名）
        /// </summary>
        private string ps_code;
        /// <summary>
        /// 皮试(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Ps_code
        {
            get { return this.ps_code; }
            set { this.ps_code = value; }
        }



        /// <summary>
        /// cv5301.06药物类型代码(关联代码表)（对象属性名）
        /// </summary>
        private string yplx_code;
        /// <summary>
        /// cv5301.06药物类型代码(关联代码表)（对象属性名）
        /// </summary>
        public string Yplx_code
        {
            get { return this.yplx_code; }
            set { this.yplx_code = value; }
        }



        /// <summary>
        /// 药品描述适应症（对象属性名）
        /// </summary>
        private string ypmssyz;
        /// <summary>
        /// 药品描述适应症（对象属性名）
        /// </summary>
        public string Ypmssyz
        {
            get { return this.ypmssyz; }
            set { this.ypmssyz = value; }
        }



        /// <summary>
        /// 药品描述禁忌症（疾病）（对象属性名）
        /// </summary>
        private string ypmsjjz;
        /// <summary>
        /// 药品描述禁忌症（疾病）（对象属性名）
        /// </summary>
        public string Ypmsjjz
        {
            get { return this.ypmsjjz; }
            set { this.ypmsjjz = value; }
        }



        /// <summary>
        /// 药品描述孕妇或哺乳期禁用(是否，关联代码表)（对象属性名）
        /// </summary>
        private string ypmsyfhbrqjy_code;
        /// <summary>
        /// 药品描述孕妇或哺乳期禁用(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Ypmsyfhbrqjy_code
        {
            get { return this.ypmsyfhbrqjy_code; }
            set { this.ypmsyfhbrqjy_code = value; }
        }



        /// <summary>
        /// 药品描述不良反应（对象属性名）
        /// </summary>
        private string ypmsblfy;
        /// <summary>
        /// 药品描述不良反应（对象属性名）
        /// </summary>
        public string Ypmsblfy
        {
            get { return this.ypmsblfy; }
            set { this.ypmsblfy = value; }
        }



        /// <summary>
        /// 药品分类(关联代码表)（对象属性名）
        /// </summary>
        private string ypfl_code;
        /// <summary>
        /// 药品分类(关联代码表)（对象属性名）
        /// </summary>
        public string Ypfl_code
        {
            get { return this.ypfl_code; }
            set { this.ypfl_code = value; }
        }



        /// <summary>
        /// 药价级别(关联代码表)（对象属性名）
        /// </summary>
        private string yjjb_code;
        /// <summary>
        /// 药价级别(关联代码表)（对象属性名）
        /// </summary>
        public string Yjjb_code
        {
            get { return this.yjjb_code; }
            set { this.yjjb_code = value; }
        }



        /// <summary>
        /// 条形码（对象属性名）
        /// </summary>
        private string txm;
        /// <summary>
        /// 条形码（对象属性名）
        /// </summary>
        public string Txm
        {
            get { return this.txm; }
            set { this.txm = value; }
        }



        /// <summary>
        /// 二维码（对象属性名）
        /// </summary>
        private string ewm;
        /// <summary>
        /// 二维码（对象属性名）
        /// </summary>
        public string Ewm
        {
            get { return this.ewm; }
            set { this.ewm = value; }
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
        /// 换算系数（对象属性名）
        /// </summary>
        private decimal? hsxs;
        /// <summary>
        /// 换算系数（对象属性名）
        /// </summary>
        public decimal? Hsxs
        {
            get { return this.hsxs; }
            set { this.hsxs = value; }
        }



        /// <summary>
        /// 是否拆零用(是否，关联代码表)（对象属性名）
        /// </summary>
        private string sfcly_code;
        /// <summary>
        /// 是否拆零用(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Sfcly_code
        {
            get { return this.sfcly_code; }
            set { this.sfcly_code = value; }
        }



        /// <summary>
        /// 包装批发价（对象属性名）
        /// </summary>
        private decimal? bzpfj;
        /// <summary>
        /// 包装批发价（对象属性名）
        /// </summary>
        public decimal? Bzpfj
        {
            get { return this.bzpfj; }
            set { this.bzpfj = value; }
        }



        /// <summary>
        /// 包装零售价（对象属性名）
        /// </summary>
        private decimal? bzlsj;
        /// <summary>
        /// 包装零售价（对象属性名）
        /// </summary>
        public decimal? Bzlsj
        {
            get { return this.bzlsj; }
            set { this.bzlsj = value; }
        }



        /// <summary>
        /// 包装门诊价（对象属性名）
        /// </summary>
        private decimal? bzmzj;
        /// <summary>
        /// 包装门诊价（对象属性名）
        /// </summary>
        public decimal? Bzmzj
        {
            get { return this.bzmzj; }
            set { this.bzmzj = value; }
        }



        /// <summary>
        /// 包装住院价（对象属性名）
        /// </summary>
        private decimal? bzzyj;
        /// <summary>
        /// 包装住院价（对象属性名）
        /// </summary>
        public decimal? Bzzyj
        {
            get { return this.bzzyj; }
            set { this.bzzyj = value; }
        }



        /// <summary>
        /// 换算比例（对象属性名）
        /// </summary>
        private decimal? hsbl;
        /// <summary>
        /// 换算比例（对象属性名）
        /// </summary>
        public decimal? Hsbl
        {
            get { return this.hsbl; }
            set { this.hsbl = value; }
        }



        /// <summary>
        /// 是否拆零卖(是否，关联代码表)（对象属性名）
        /// </summary>
        private string sfclm_code;
        /// <summary>
        /// 是否拆零卖(是否，关联代码表)（对象属性名）
        /// </summary>
        public string Sfclm_code
        {
            get { return this.sfclm_code; }
            set { this.sfclm_code = value; }
        }



        /// <summary>
        /// 有效状态（0无效，1有效, 关联代码表）（对象属性名）
        /// </summary>
        private string yxzt_code;
        /// <summary>
        /// 有效状态（0无效，1有效, 关联代码表）（对象属性名）
        /// </summary>
        public string Yxzt_code
        {
            get { return this.yxzt_code; }
            set { this.yxzt_code = value; }
        }



        /// <summary>
        /// 单次上限用量（对象属性名）
        /// </summary>
        private decimal? dcsxyl;
        /// <summary>
        /// 单次上限用量（对象属性名）
        /// </summary>
        public decimal? Dcsxyl
        {
            get { return this.dcsxyl; }
            set { this.dcsxyl = value; }
        }



        /// <summary>
        /// 单次上限用量（对象属性名）
        /// </summary>
        private decimal? dcxxyl;
        /// <summary>
        /// 单次上限用量（对象属性名）
        /// </summary>
        public decimal? Dcxxyl
        {
            get { return this.dcxxyl; }
            set { this.dcxxyl = value; }
        }



        /// <summary>
        /// 连续用量天数（对象属性名）
        /// </summary>
        private decimal? lxylts;
        /// <summary>
        /// 连续用量天数（对象属性名）
        /// </summary>
        public decimal? Lxylts
        {
            get { return this.lxylts; }
            set { this.lxylts = value; }
        }



        /// <summary>
        /// 连续用量次数（对象属性名）
        /// </summary>
        private decimal? lxylcs;
        /// <summary>
        /// 连续用量次数（对象属性名）
        /// </summary>
        public decimal? Lxylcs
        {
            get { return this.lxylcs; }
            set { this.lxylcs = value; }
        }



        /// <summary>
        /// 生产企业（对象属性名）
        /// </summary>
        private string scqy;
        /// <summary>
        /// 生产企业（对象属性名）
        /// </summary>
        public string Scqy
        {
            get { return this.scqy; }
            set { this.scqy = value; }
        }



        /// <summary>
        /// 批准日期（对象属性名）
        /// </summary>
        private DateTime? pzrq;
        /// <summary>
        /// 批准日期（对象属性名）
        /// </summary>
        public DateTime? Pzrq
        {
            get { return this.pzrq; }
            set { this.pzrq = value; }
        }



        /// <summary>
        /// 是否是抗生素（1是，0否，关联代码表）（对象属性名）
        /// </summary>
        private string sfkss_code;
        /// <summary>
        /// 是否是抗生素（1是，0否，关联代码表）（对象属性名）
        /// </summary>
        public string Sfkss_code
        {
            get { return this.sfkss_code; }
            set { this.sfkss_code = value; }
        }



        /// <summary>
        /// 作废标志（0作废，1有效）（对象属性名）
        /// </summary>
        private string zfbz;
        /// <summary>
        /// 作废标志（0作废，1有效）（对象属性名）
        /// </summary>
        public string Zfbz
        {
            get { return this.zfbz; }
            set { this.zfbz = value; }
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

        //        //*****************在此之后添加关联对象
        #region model,实体类新增的对象，start


        /// <summary>
        /// 剂型,cv5301.01药物剂型代码(关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code ypjxCode;
        /// <summary>
        /// 剂型,cv5301.01药物剂型代码(关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code YpjxCode
        {
            get { return ypjxCode; }
            set { ypjxCode = value; }
        }

        /// <summary>
        /// 药品单次用量单位(关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code ypdcyldwCode;
        /// <summary>
        /// 药品单次用量单位(关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code YpdcyldwCode
        {
            get { return ypdcyldwCode; }
            set { ypdcyldwCode = value; }
        }

        /// <summary>
        /// 用量用法,cv5201.22用药途径代码(关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code ypyytjCode;
        /// <summary>
        /// 用量用法,cv5201.22用药途径代码(关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code YpyytjCode
        {
            get { return ypyytjCode; }
            set { ypyytjCode = value; }
        }

        /// <summary>
        /// 大单位(药品大单位，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code ddwCode;
        /// <summary>
        /// 大单位(药品大单位，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code DdwCode
        {
            get { return ddwCode; }
            set { ddwCode = value; }
        }

        /// <summary>
        /// 小单位(药品小单位，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code xdwCode;
        /// <summary>
        /// 小单位(药品小单位，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code XdwCode
        {
            get { return xdwCode; }
            set { xdwCode = value; }
        }

        /// <summary>
        /// 处方药标志（rx  otc）(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code cfybzCode;
        /// <summary>
        /// 处方药标志（rx  otc）(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code CfybzCode
        {
            get { return cfybzCode; }
            set { cfybzCode = value; }
        }

        /// <summary>
        /// 处方权限基药(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code cfqxjyCode;
        /// <summary>
        /// 处方权限基药(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code CfqxjyCode
        {
            get { return cfqxjyCode; }
            set { cfqxjyCode = value; }
        }

        /// <summary>
        /// 处方权限医保(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code cfqxybCode;
        /// <summary>
        /// 处方权限医保(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code CfqxybCode
        {
            get { return cfqxybCode; }
            set { cfqxybCode = value; }
        }

        /// <summary>
        /// 处方权限毒麻(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code cfqxdmCode;
        /// <summary>
        /// 处方权限毒麻(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code CfqxdmCode
        {
            get { return cfqxdmCode; }
            set { cfqxdmCode = value; }
        }

        /// <summary>
        /// 处方权限精神(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code cfqxjsCode;
        /// <summary>
        /// 处方权限精神(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code CfqxjsCode
        {
            get { return cfqxjsCode; }
            set { cfqxjsCode = value; }
        }

        /// <summary>
        /// 处方权限贵重(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code cfqxgzCode;
        /// <summary>
        /// 处方权限贵重(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code CfqxgzCode
        {
            get { return cfqxgzCode; }
            set { cfqxgzCode = value; }
        }

        /// <summary>
        /// 处方权限进口(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code cfqxjkCode;
        /// <summary>
        /// 处方权限进口(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code CfqxjkCode
        {
            get { return cfqxjkCode; }
            set { cfqxjkCode = value; }
        }

        /// <summary>
        /// 处方权限自制(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code cfqxzzCode;
        /// <summary>
        /// 处方权限自制(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code CfqxzzCode
        {
            get { return cfqxzzCode; }
            set { cfqxzzCode = value; }
        }

        /// <summary>
        /// 处方权限自费(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code cfqxzfCode;
        /// <summary>
        /// 处方权限自费(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code CfqxzfCode
        {
            get { return cfqxzfCode; }
            set { cfqxzfCode = value; }
        }

        /// <summary>
        /// 处方权限特殊(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code cfqxtsCode;
        /// <summary>
        /// 处方权限特殊(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code CfqxtsCode
        {
            get { return cfqxtsCode; }
            set { cfqxtsCode = value; }
        }

        /// <summary>
        /// 皮试(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code psCode;
        /// <summary>
        /// 皮试(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code PsCode
        {
            get { return psCode; }
            set { psCode = value; }
        }

        /// <summary>
        /// cv5301.06药物类型代码(关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code yplxCode;
        /// <summary>
        /// cv5301.06药物类型代码(关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code YplxCode
        {
            get { return yplxCode; }
            set { yplxCode = value; }
        }

        /// <summary>
        /// 药品描述孕妇或哺乳期禁用(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code ypmsyfhbrqjyCode;
        /// <summary>
        /// 药品描述孕妇或哺乳期禁用(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code YpmsyfhbrqjyCode
        {
            get { return ypmsyfhbrqjyCode; }
            set { ypmsyfhbrqjyCode = value; }
        }

        /// <summary>
        /// 药品分类(关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code ypflCode;
        /// <summary>
        /// 药品分类(关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code YpflCode
        {
            get { return ypflCode; }
            set { ypflCode = value; }
        }

        /// <summary>
        /// 药价级别(关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code yjjbCode;
        /// <summary>
        /// 药价级别(关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code YjjbCode
        {
            get { return yjjbCode; }
            set { yjjbCode = value; }
        }

        /// <summary>
        /// 是否拆零用(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code sfclyCode;
        /// <summary>
        /// 是否拆零用(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code SfclyCode
        {
            get { return sfclyCode; }
            set { sfclyCode = value; }
        }

        /// <summary>
        /// 是否拆零卖(是否，关联代码表)对象
        /// </summary>
        private Model.JC.Jc_code sfclmCode;
        /// <summary>
        /// 是否拆零卖(是否，关联代码表)对象
        /// </summary>
        public Model.JC.Jc_code SfclmCode
        {
            get { return sfclmCode; }
            set { sfclmCode = value; }
        }

        /// <summary>
        /// 有效状态（0无效，1有效, 关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code yxztCode;
        /// <summary>
        /// 有效状态（0无效，1有效, 关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code YxztCode
        {
            get { return yxztCode; }
            set { yxztCode = value; }
        }

        /// <summary>
        /// 是否是抗生素（1是，0否，关联代码表）对象
        /// </summary>
        private Model.JC.Jc_code sfkssCode;
        /// <summary>
        /// 是否是抗生素（1是，0否，关联代码表）对象
        /// </summary>
        public Model.JC.Jc_code SfkssCode
        {
            get { return sfkssCode; }
            set { sfkssCode = value; }
        }

        #endregion model,实体类新增的对象，end

    }
}
