using Model.Common;
using Model.JC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.JC.基础_行政区划;
using BLL.JC.基础_代码字典;
using BLL.JC.基础_工作人员;
using BLL.JC.基础_科室;
using BLL.RBAC.RBAC_用户;
using BLL.JC.基础_供应商;
using Model.RBAC;

namespace client.Common
{
    /// <summary>
    /// ComboBox控件的帮助类
    /// </summary>
    public class ComboBoxHelper
    {

        private static Jc_areaBLL jc_areaBLL = new Jc_areaBLLImp();
        private static Jc_codeBLL jc_codeBLL = new Jc_codeBLLImp();
        private static Jc_renyuanBLL jc_renyuanBLL = new Jc_renyuanBLLImp();
        private static Jc_kswhBLL jc_ksBLL = new Jc_kswhBLLImp();
        private static Rbac_userBLL rbac_userBLL = new Rbac_userBLLImp();
        private static Jc_gysBLL jc_gysBLL = new Jc_gysBLLImp();
        


        /// <summary>
        /// 公共的初始化combobox的一些属性
        /// </summary>
        /// <param Name="cb"></param>
        public static void initComboBoxStart(ComboBox cb)
        {
            cb.Enabled = true;
            cb.Items.Clear();//清空combobox
            cb.DropDownStyle = ComboBoxStyle.DropDownList;//下拉列表，不可编辑文本
        }

        public static void initComboBoxEnd(ComboBox cb)
        {
            if (cb.Items.Count>=1)
            {
                cb.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 根据传入的代码类型和作废标志值，初始化comboBox
        /// </summary>
        /// <param Name="cb"></param>
        /// <param Name="codeTypeValue">传入代码类型值</param>
        public static void initComboBoxForCode(ComboBox cb, string codeTypeValue, string zfbzValue)
        {
            initComboBoxStart(cb);
            Jc_code codeParam = new Jc_code();
            codeParam.Zfbz = zfbzValue;
            Jc_code_type codeTypeParam = new Jc_code_type();
            codeTypeParam.Value = codeTypeValue;
            codeParam.Jc_code_type = codeTypeParam;
            List<SortInfo> sortList = new List<SortInfo>();
            sortList.Add(new SortInfo(Jc_code.SORT));
            List<Jc_code> codeList = (List<Jc_code>)jc_codeBLL.getListContactObject(codeParam, null, sortList)[0];
            cb.Items.AddRange(codeList.ToArray());
            cb.DisplayMember = "Name";//显示的是jc_code对象的Name
            cb.ValueMember = "Value";//value是jc_code的Value
            initComboBoxEnd(cb);
        }

        /// <summary>
        /// 初始化药品分类及诊疗项目
        /// </summary>
        /// <param Name="cb"></param>
        /// <param Name="codeTypeValue">传入代码类型值</param>
        public static void initComboBoxForYpflCodeAndZlxmCode(ComboBox cb)
        {
            initComboBoxStart(cb);
            List<SortInfo> sortList = new List<SortInfo>();
            sortList.Add(new SortInfo(Jc_code.SORT));
            Jc_code ypCodeParam = new Jc_code();
            ypCodeParam.Zfbz = CommonCode.代码值_作废标志代码值.启用;
            Jc_code_type YpCodeTypeParam = new Jc_code_type();
            YpCodeTypeParam.Value = CommonCode.代码类型值.药品_分类;
            ypCodeParam.Jc_code_type = YpCodeTypeParam;
            List<Jc_code> ypCodeList = (List<Jc_code>)jc_codeBLL.getListContactObject(ypCodeParam, null, sortList)[0];

            Jc_code zlxmCodeParam = new Jc_code();
            zlxmCodeParam.Zfbz = CommonCode.代码值_作废标志代码值.启用;
            Jc_code_type zlxmCodeTypeParam = new Jc_code_type();
            zlxmCodeTypeParam.Value = CommonCode.代码类型值.诊疗项目分类;
            zlxmCodeParam.Jc_code_type = zlxmCodeTypeParam;
            List<Jc_code> zlxmCodeList = (List<Jc_code>)jc_codeBLL.getListContactObject(zlxmCodeParam, null, sortList)[0];


            cb.Items.AddRange(ypCodeList.ToArray());
            cb.Items.AddRange(zlxmCodeList.ToArray());
            cb.DisplayMember = "Name";//显示的是jc_code对象的Name
            cb.ValueMember = "Value";//value是jc_code的Value
            initComboBoxEnd(cb);
        }

        /// <summary>
        /// 初始化作废标志combobox
        /// </summary>
        /// <param Name="cb"></param>
        public static void initComboBoxForZfbz(ComboBox cb)
        {
            initComboBoxStart(cb);
            cb.Items.AddRange(CommonCode.代码值_作废标志代码值.getZfbzList().ToArray());//把jc_code对象放进combobox中
            cb.DisplayMember = "Name";//显示的是jc_code对象的Name
            cb.ValueMember = "Value";//value是jc_code的Value
            initComboBoxEnd(cb);

        }

        /// <summary>
        /// 初始化工作人员的combobox
        /// </summary>
        /// <param Name="cb"></param>
        /// <param Name="renyuanParam"></param>
        public static void initComboBoxForRenyuan(ComboBox cb, Jc_renyuan renyuanParam, string zfbzValue)
        {
            initComboBoxStart(cb);
            if (null == renyuanParam)
            {
                renyuanParam = new Jc_renyuan();
            }
            renyuanParam.Zfbz = zfbzValue;
            List<Jc_renyuan> renyuans = (List<Jc_renyuan>)jc_renyuanBLL.getList(renyuanParam,null,null)[0];
            cb.Items.AddRange(renyuans.ToArray());//把jc_code对象放进combobox中
            cb.DisplayMember = "XM";//显示的是人员对象的名称
            cb.ValueMember = "ID";//value是人员的主键ID
            initComboBoxEnd(cb);

        }

        /// <summary>
        /// 初始化科室的combobox
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="kswhParam"></param>
        /// <param name="zfbzValue"></param>
        public static void initComboBoxForKswh(ComboBox cb, Jc_kswh kswhParam, string zfbzValue)
        {
            initComboBoxStart(cb);
            if (null == kswhParam)
            {
                kswhParam = new Jc_kswh();
            }
            kswhParam.Zfbz = zfbzValue;
            List<Jc_kswh> ksList = (List<Jc_kswh>)jc_ksBLL.getList(kswhParam, null, null)[0];
            cb.Items.AddRange(ksList.ToArray());//把jc_code对象放进combobox中
            cb.DisplayMember = "KSMC";//显示的是科室对象的名称
            cb.ValueMember = "ID";//value是人员的主键ID
            initComboBoxEnd(cb);

        }


        /// <summary>
        /// 初始化科室的combobox(只有药房和药库的科室，启用的科室)
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="kswhParam"></param>
        /// <param name="zfbzValue"></param>
        public static void initComboBoxForKswh_YfYk(ComboBox cb)
        {
            initComboBoxStart(cb);
            Jc_kswh yfksParam = new Jc_kswh();
            yfksParam.Yfbz_code = CommonCode.代码值_勾叉.勾;
            yfksParam.Zfbz = CommonCode.代码值_作废标志代码值.启用;
            List<Jc_kswh> yfksList = (List<Jc_kswh>)jc_ksBLL.getList(yfksParam, null, null)[0];
            Jc_kswh ykksParam = new Jc_kswh();
            ykksParam.Ykbz_code = CommonCode.代码值_勾叉.勾;
            ykksParam.Zfbz = CommonCode.代码值_作废标志代码值.启用;
            List<Jc_kswh> ykksList = (List<Jc_kswh>)jc_ksBLL.getList(ykksParam, null, null)[0];
            cb.Items.AddRange(yfksList.ToArray());//把jc_code对象放进combobox中
            cb.Items.AddRange(ykksList.ToArray());//把jc_code对象放进combobox中
            cb.DisplayMember = "KSMC";//显示的是人员对象的名称
            cb.ValueMember = "ID";//value是人员的主键ID
            initComboBoxEnd(cb);

        }

        /// <summary>
        /// 初始化供应商的combobox
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="kswhParam"></param>
        /// <param name="zfbzValue"></param>
        public static void initComboBoxForGys(ComboBox cb, Jc_gys gysParam, string zfbzValue)
        {
            initComboBoxStart(cb);
            if (null == gysParam)
            {
                gysParam = new Jc_gys();
            }
            gysParam.Zfbz = zfbzValue;
            List<Jc_gys> gysList = (List<Jc_gys>)jc_gysBLL.getList(gysParam, null, null)[0];
            cb.Items.AddRange(gysList.ToArray());//把jc_code对象放进combobox中
            cb.DisplayMember = Jc_gys.GYSMC;//显示的是人员对象的名称
            cb.ValueMember = "ID";//value是人员的主键ID
            initComboBoxEnd(cb);

        }    
        
        /// <summary>
        /// 初始化账户的combobox
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="kswhParam"></param>
        /// <param name="zfbzValue"></param>
        public static void initComboBoxForUser(ComboBox cb, Rbac_user user, string zfbzValue)
        {
            initComboBoxStart(cb);
            if (null == user)
            {
                user = new Rbac_user();
            }
            user.Zfbz = zfbzValue;
            List<Rbac_user> userList = (List<Rbac_user>)rbac_userBLL.getList(user, null, null)[0];
            cb.Items.AddRange(userList.ToArray());//把jc_code对象放进combobox中
            cb.DisplayMember = "NAME";//显示的是账户名
            cb.ValueMember = "ID";//value是主键ID
            initComboBoxEnd(cb);

        }

        /// <summary>
        /// 初始化行政区划的combobox
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="areaParam"></param>
        /// <param name="zfbzValue"></param>
        public static void initComboBoxForArea(ComboBox cb, Jc_area areaParam, string zfbzValue)
        {
            initComboBoxStart(cb);
            if (null == areaParam)
            {
                areaParam = new Jc_area();
            }
            areaParam.Zfbz = zfbzValue;


            List<Jc_area> areaList = (List<Jc_area>)jc_areaBLL.getList(areaParam, null, null)[0];
            cb.Items.AddRange(areaList.ToArray());
            cb.DisplayMember = "NAME";
            cb.ValueMember = "CODE";
            initComboBoxEnd(cb);

        }

        /// <summary>
        /// 初始化带行政区划的编辑窗口中的combobox
        /// </summary>
        /// <param name="cb_sheng"></param>
        /// <param name="cb_shi"></param>
        /// <param name="cb_xian"></param>
        /// <param name="cb_jiedao"></param>
        /// <param name="cb_weiyuanhui"></param>
        /// <param name="areaCode"></param>
        public static void initComboBoxForEditArea(ComboBox cb_sheng, ComboBox cb_shi, ComboBox cb_xian, ComboBox cb_jiedao, ComboBox cb_weiyuanhui, string areaCode)
        {
            //首先根据areaCode判断最低行政区划等级,把上级所有行政区划等级得控件设为可用
            //并且根据areaCode计算出所有上级行政区划的code
            //根据每一级的行政区划等级，初始化控件的数据
            //选中每一级的行政区划项
            string endAreaLevel = null;//保存最低层的区划等级
            string shengCode = null;//省级行政区划代码
            string shiCode = null;//市级行政区划代码
            string xianCode = null;//县级行政区划代码
            string jiedaoCode = null;//乡镇街道行政区划代码
            string weiyuanhuiCode = null;//委员会行政区划代码



            if (areaCode.Length != 12)
            {
                throw new Exception("行政区划代码必须是12位！");
            }

            //控件禁用启用
            cb_sheng.Enabled = false;
            cb_shi.Enabled = false;
            cb_xian.Enabled = false;
            cb_jiedao.Enabled = false;
            cb_weiyuanhui.Enabled = false;
            if (areaCode.Substring(2, 10) == "0000000000")//后十位是十个0，说明是省级
            {
                endAreaLevel = CommonCode.代码值_行政区划等级.省级;
                cb_sheng.Enabled = true;
                cb_shi.Enabled = false;
                cb_xian.Enabled = false;
                cb_jiedao.Enabled = false;
                cb_weiyuanhui.Enabled = false;
            }
            else if (areaCode.Substring(4, 8) == "00000000")//后八位是00000000，说明是州市
            {
                endAreaLevel = CommonCode.代码值_行政区划等级.州市级;
                cb_sheng.Enabled = true;
                cb_shi.Enabled = true;
                cb_xian.Enabled = false;
                cb_jiedao.Enabled = false;
                cb_weiyuanhui.Enabled = false;
            }
            else if (areaCode.Substring(6, 6) == "000000")//后六位等于000000，说明是区县
            {
                endAreaLevel = CommonCode.代码值_行政区划等级.区县级;
                cb_sheng.Enabled = true;
                cb_shi.Enabled = true;
                cb_xian.Enabled = true;
                cb_jiedao.Enabled = false;
                cb_weiyuanhui.Enabled = false;
            }
            else if (areaCode.Substring(9, 3) == "000")//如果后三位等于000，说明是乡镇街道
            {
                endAreaLevel = CommonCode.代码值_行政区划等级.乡镇级;
                cb_sheng.Enabled = true;
                cb_shi.Enabled = true;
                cb_xian.Enabled = true;
                cb_jiedao.Enabled = true;
                cb_weiyuanhui.Enabled = false;
            }
            else if (areaCode.Substring(9, 3) != "000")//如果后三位不等于000，说明是居委会
            {
                endAreaLevel = CommonCode.代码值_行政区划等级.村委会级;
                cb_sheng.Enabled = true;
                cb_shi.Enabled = true;
                cb_xian.Enabled = true;
                cb_jiedao.Enabled = true;
                cb_weiyuanhui.Enabled = true;
            }
            else
            {
                throw new Exception("解析行政区划代码未知错误！");
            }

            if (endAreaLevel == null)
            {
                throw new Exception("解析行政区划代码未知错误！");
            }

            //各级的代码
            shengCode = areaCode.Substring(0, 2) + "0000000000";
            shiCode = areaCode.Substring(0, 4) + "00000000";
            xianCode = areaCode.Substring(0, 6) + "000000";
            jiedaoCode = areaCode.Substring(0, 9) + "000";
            weiyuanhuiCode = areaCode;

            Jc_area sheng = new Jc_area();
            sheng.Level_code = CommonCode.代码值_行政区划等级.省级;
            ComboBoxHelper.initComboBoxForArea(cb_sheng, sheng, CommonCode.代码值_作废标志代码值.启用);
            cb_sheng.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(cb_sheng, shengCode, CommonCode.实体类名称.基础_行政区划表);

            Jc_area shi = new Jc_area();
            shi.Level_code = CommonCode.代码值_行政区划等级.州市级;
            shi.Pcode = shengCode;
            ComboBoxHelper.initComboBoxForArea(cb_shi, shi, CommonCode.代码值_作废标志代码值.启用);
            cb_shi.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(cb_shi, shiCode, CommonCode.实体类名称.基础_行政区划表);

            Jc_area xian = new Jc_area();
            xian.Level_code = CommonCode.代码值_行政区划等级.区县级;
            xian.Pcode = shiCode;
            ComboBoxHelper.initComboBoxForArea(cb_xian, xian, CommonCode.代码值_作废标志代码值.启用);
            cb_xian.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(cb_xian, xianCode, CommonCode.实体类名称.基础_行政区划表);

            Jc_area jiedao = new Jc_area();
            jiedao.Level_code = CommonCode.代码值_行政区划等级.乡镇级;
            jiedao.Pcode = xianCode;
            ComboBoxHelper.initComboBoxForArea(cb_jiedao, jiedao, CommonCode.代码值_作废标志代码值.启用);
            cb_jiedao.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(cb_jiedao, jiedaoCode, CommonCode.实体类名称.基础_行政区划表);

            Jc_area weiyuanhui = new Jc_area();
            weiyuanhui.Level_code = CommonCode.代码值_行政区划等级.村委会级;
            weiyuanhui.Pcode = jiedaoCode;
            ComboBoxHelper.initComboBoxForArea(cb_weiyuanhui, weiyuanhui, CommonCode.代码值_作废标志代码值.启用);
            cb_weiyuanhui.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(cb_weiyuanhui, weiyuanhuiCode, CommonCode.实体类名称.基础_行政区划表);

        }



        /// <summary>
        /// 根据一个value，得到combobox中对应value的项的索引值，combobox存的是Jc_code对象（所以不能使用indexOf方法取，因为不是同一对象，hashcode不一样）
        /// </summary>
        /// <returns></returns>
        public static int getComboBoxIndexByValue(ComboBox cb, string value, string objectType)
        {
            switch (objectType)
            {
                case CommonCode.实体类名称.基础_代码字典实体类名:
                    {
                        for (int i = 0; i < cb.Items.Count; i++)
                        {
                            Jc_code code = (Jc_code)cb.Items[i];
                            if (value == code.Value)
                            {
                                return i;
                            }
                        }
                    } break;
                case CommonCode.实体类名称.基础_工作人员实体类名:
                    {
                        for (int i = 0; i < cb.Items.Count; i++)
                        {
                            Jc_renyuan renyuan = (Jc_renyuan)cb.Items[i];
                            if (value == renyuan.Id)
                            {
                                return i;
                            }
                        }
                    } break;
                case CommonCode.实体类名称.基础_科室实体类名:
                    {
                        for (int i = 0; i < cb.Items.Count; i++)
                        {
                            Jc_kswh keshi = (Jc_kswh)cb.Items[i];
                            if (value == keshi.Id)
                            {
                                return i;
                            }
                        }
                    } break;
                case CommonCode.实体类名称.基础_行政区划表:
                    {
                        for (int i = 0; i < cb.Items.Count; i++)
                        {
                            Jc_area area = (Jc_area)cb.Items[i];
                            if (value == area.Code)
                            {
                                return i;
                            }
                        }
                    } break;
                case CommonCode.实体类名称.基础_供应商实体类名:
                    {
                        for (int i = 0; i < cb.Items.Count; i++)
                        {
                            Jc_gys gys = (Jc_gys)cb.Items[i];
                            if (value == gys.Id)
                            {
                                return i;
                            }
                        }
                    } break;
                default:
                    {
                        throw new Exception("尚未实现针对" + objectType + "类的getComboBoxIndexByValue，Client.Common.ComboBoxHelper类的getComboBoxIndexByValue中进行实现");
                    }
            }

            return -1;
        }


        /// <summary>
        /// 根据选择的行政区划得到行政区划代码
        /// </summary>
        /// <param name="cb_sheng"></param>
        /// <param name="cb_shi"></param>
        /// <param name="cb_xian"></param>
        /// <param name="cb_xiangzhen"></param>
        /// <param name="cb_weiyuanhui"></param>
        /// <returns></returns>
        public static string getComboBoxAreaCode(ComboBox cb_sheng, ComboBox cb_shi, ComboBox cb_xian, ComboBox cb_xiangzhen, ComboBox cb_weiyuanhui)
        {
            string areaCode = null;
            if (cb_sheng.Enabled)
            {
                areaCode = Jc_area.ConvertToJc_area(cb_sheng.SelectedItem).Code;
            }
            if (cb_shi.SelectedIndex != -1)
            {
                areaCode = Jc_area.ConvertToJc_area(cb_shi.SelectedItem).Code;
            }
            if (cb_xian.SelectedIndex != -1)
            {
                areaCode = Jc_area.ConvertToJc_area(cb_xian.SelectedItem).Code;
            }
            if (cb_xiangzhen.SelectedIndex != -1)
            {
                areaCode = Jc_area.ConvertToJc_area(cb_xiangzhen.SelectedItem).Code;
            }
            if (cb_weiyuanhui.SelectedIndex != -1)
            {
                areaCode = Jc_area.ConvertToJc_area(cb_weiyuanhui.SelectedItem).Code;
            }
            return areaCode;
        }


    }
}
