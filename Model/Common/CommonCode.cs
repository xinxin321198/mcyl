using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.JC;

namespace Model.Common
{
    /// <summary>
    /// 公共代码类
    /// </summary>
    public class CommonCode
    {

        /// <summary>
        /// 代码类型管理类（存的值是jc_code_type表中的value，添加一项新的代码类别请在此类中新添加一项）
        /// </summary>
        public class 代码类型值
        {
            public const string 基础_作废标志类型值 = "zfbz";
            public const string 基础_勾叉 = "forkHook";
            public const string 基础_有效状态 = "validState";
            public const string 基础_是否 = "yesNo";

            public const string 挂号_类型 = "registerType";
            public const string 挂号_状态 = "ghSate";
            public const string 门诊_医嘱类型 = "mz_yzlx";

            public const string 药品_分类 = "drugType";
            public const string 药品_药价级别 = "drugPriceLevel";
            public const string 药品_单次用量单位 = "drugDosageUnit";
            public const string 药品_用药频率 = "yypl";
            public const string 药品_大单位 = "yp_ddw";
            public const string 药品_小单位 = "yp_xdw";


            public const string 工作人员类型 = "workerType";
            public const string 行政区划等级 = "areaLevel";
            public const string 性别类型值 = "sex";
            public const string 民族类型值 = "nation";
            public const string 政治面貌类型值 = "political";
            public const string 婚姻状况类型值 = "marital";
            public const string 学历类型值 = "education";
            public const string 账户类别 = "userType";
            public const string 病人类型 = "patientType";
            public const string RH代码 = "RH";
            public const string 供应商类型 = "gyslx";

            public const string CV0207_01职业代码 = "occupation";
            public const string CV5103_02ABO血型代码 = "bloodType";
            public const string CV5301_01药物剂型代码 = "ywjx";
            public const string CV5201_22用药途径代码 = "yytj";
            public const string CV5301_06药物类型代码 = "ywlx";

            public const string RBAC_模块类型 = "rbac_modules_type";

            public const string 费用归类 = "fygl";
            public const string 诊疗项目分类 = "zlfl";
            public const string 诊疗项目_农合收费类别 = "zlxm_nhsflb";


            public const string 库存_单据类型 = "kc_djlx";
            public const string 库存_配送方式 = "kc_psfs";
            public const string 库存_采购方式 = "kc_cgfs";
            public const string 库存_验收 = "kc_ys";
            public const string 库存_退货状态 = "kc_thzt";
            public const string 库存_药品单位类型 = "kc_ypdwlx";

        }


        /// <summary>
        /// 关于数据库表实体类的名称（新增实体类请在此类中添加一项）
        /// </summary>
        public class 实体类名称
        {

            public const string 基础_代码字典实体类名 = "Jc_code";
            public const string 基础_代码类型字典实体类名 = "Jc_code_type";
            public const string 基础_科室实体类名 = "Jc_kswh";
            public const string 基础_工作人员实体类名 = "Jc_renyuan";
            public const string 基础_居民实体类名 = "Jc_jm";
            public const string 业务_挂号实体类名 = "Yw_gh";
            public const string 基础_人员所属科室实体类名 = "Jc_ry_ks";
            public const string 基础_行政区划表 = "Jc_area";
            public const string 基础_疾病种类表 = "Jc_disease_type";
            public const string 基础_IDC10疾病种类实体类名 = "Jc_disease_type_icd10";
            public const string 基础_IDC10国际疾病分类代码表 = "Jc_idc_10";
            public const string 基础_药品 = "Jc_yp";
            public const string RBAC_角色实体类名 = "Rbac_role";
            public const string RBAC_模块实体类名 = "Rbac_modules";
            public const string RBAC_用户实体类名 = "Rbac_user";
            public const string 基础_供应商实体类名 = "Jc_gys";

        }




        /// <summary>
        /// 关于禁用和启用两项代码的类（只有此代码不在数据库中管理）
        /// </summary>
        public class 代码值_作废标志代码值
        {
            /// <summary>
            /// 禁用的代码值
            /// </summary>
            public const string 禁用 = "0";
            /// <summary>
            /// 启用的代码值
            /// </summary>
            public const string 启用 = "1";

            /// <summary>
            /// 得到禁用启用的代码值集合（此代码整个系统通用，不存于数据库中）
            /// </summary>
            /// <returns></returns>
            public static List<Jc_code> getZfbzList()
            {
                List<Jc_code> zfbz_s = new List<Jc_code>();
                Jc_code enableCode = new Jc_code();
                enableCode.Name = "禁用";
                enableCode.Value = CommonCode.代码值_作废标志代码值.禁用;
                Jc_code disableCode = new Jc_code();
                disableCode.Name = "启用";
                disableCode.Value = CommonCode.代码值_作废标志代码值.启用;
                zfbz_s.Add(enableCode);
                zfbz_s.Add(disableCode);
                return zfbz_s;
            }
        }


        public class 药品库存_单据类型
        {
            public const string 入库 = "01";
            public const string 退货 = "02";
            public const string 调拨 = "03";
            public const string 领用 = "04";
            public const string 销售 = "05";
            public const string 报损 = "06";
            public const string 盘点 = "07";

        }
        public class 药品库存_退货状态
        {
            public const string 未退货 = "01";
            public const string 已退货 = "02";

        }

        public class 药品库存_药品单位类型
        {
            public const string 大单位 = "0";
            public const string 小单位 = "1";

        }

        /// <summary>
        /// 行政区划等级值
        /// </summary>
        public class 代码值_行政区划等级
        {
            public const string 省级 = "01";

            public const string 州市级 = "02";

            public const string 区县级 = "03";

            public const string 乡镇级 = "04";

            public const string 村委会级 = "05";
        }


        public class 代码值_勾叉
        {
            public const string 勾 = "1";
            public const string 叉 = "0";

        }

        public class 代码值_是否
        {
            public const string 是 = "1";
            public const string 否 = "0";

        }

        public class 代码值_有效无效
        {
            public const string 有效 = "1";
            public const string 无效 = "0";

        }

        public class 代码值_工作人员类型
        {
            public const string 医生 = "01";
        }


        public class RBAC_模块类型
        {
            public const string 菜单 = "01";
            public const string 功能点 = "02";

        }

        public class 门诊_医嘱类型
        {
            public const string  药品= "1";
            public const string 诊疗项目 = "2";

        }

        public class 门诊_挂号状态
        {
            public const string 已挂号 = "01";
            public const string 已退号 = "02";
            public const string 接诊中 = "03";
            public const string 未收费 = "04";
            public const string 划价收费挂号 = "05";
            public const string 已收费 = "06";
            public const string 已拿药 = "07";

        }

        public class 药品_用药频率
        {
            public const string 一天一次 = "qd";
            public const string 一天二次 = "bid";
            public const string 一天三次 = "tid";
            public const string 立即 = "st";
        }
    }
}
