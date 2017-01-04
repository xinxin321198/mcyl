using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.JC;
using client.Common;
using Model.Common;

namespace client.JC.基础_居民
{
    public partial class JmEdit : Form
    {
        private Jc_jm oldJc_jm = null;
        private BLL.JC.基础_居民.Jc_jmBLL jc_jmBll = new BLL.JC.基础_居民.Jc_jmBLLImp();

        public JmEdit()
        {
            InitializeComponent();
            this.initUI();
        }

        public JmEdit(Jc_jm oldJc_jm)
        {
            this.oldJc_jm = oldJc_jm;
            InitializeComponent();
            this.initUI();


        }



        /// <summary>
        /// 比较Jc_jm类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldJc_jm"></param>
        /// <param name="newJc_jm"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkJc_jmIsEqual(Jc_jm oldJc_jm, Jc_jm newJc_jm)
        {
            bool flag = false;

            //身份证号
            if (oldJc_jm.Sfzh != newJc_jm.Sfzh)
            {
                flag = true;
            }

            //姓名
            if (oldJc_jm.Xm != newJc_jm.Xm)
            {
                flag = true;
            }

            //性别（关联代码表）
            if (oldJc_jm.Xb_code != newJc_jm.Xb_code)
            {
                flag = true;
            }

            //出生日期
            if (oldJc_jm.Csrq != newJc_jm.Csrq)
            {
                flag = true;
            }

            //民族（关联代码表）
            if (oldJc_jm.Mz_code != newJc_jm.Mz_code)
            {
                flag = true;
            }

            //血型（关联代码表）
            if (oldJc_jm.Xx_code != newJc_jm.Xx_code)
            {
                flag = true;
            }

            //rh代码（关联代码表）
            if (oldJc_jm.Rh_code != newJc_jm.Rh_code)
            {
                flag = true;
            }

            //出生地址
            if (oldJc_jm.Csdz != newJc_jm.Csdz)
            {
                flag = true;
            }

            //户籍地址
            if (oldJc_jm.Hjdz != newJc_jm.Hjdz)
            {
                flag = true;
            }

            //现住址所属行政区划（行政区区划代码）
            if (oldJc_jm.Xzz_xzqh != newJc_jm.Xzz_xzqh)
            {
                flag = true;
            }

            //现住址，详细地址（乡/镇，村，组，门牌号）
            if (oldJc_jm.Xzz_xiang_xi_di_zhi != newJc_jm.Xzz_xiang_xi_di_zhi)
            {
                flag = true;
            }

            //工作单位或学校
            if (oldJc_jm.Gzdw_xx != newJc_jm.Gzdw_xx)
            {
                flag = true;
            }

            //职业代码（暂做保留）
            if (oldJc_jm.Zy_code != newJc_jm.Zy_code)
            {
                flag = true;
            }

            //职业
            if (oldJc_jm.Zy != newJc_jm.Zy)
            {
                flag = true;
            }

            //文化代码（关联代码表）
            if (oldJc_jm.Wh_code != newJc_jm.Wh_code)
            {
                flag = true;
            }

            //婚姻状况（关联代码表）
            if (oldJc_jm.Hyzk_code != newJc_jm.Hyzk_code)
            {
                flag = true;
            }

            //联系电话
            if (oldJc_jm.Lxdh != newJc_jm.Lxdh)
            {
                flag = true;
            }

            //监护人姓名
            if (oldJc_jm.Jhr_xm != newJc_jm.Jhr_xm)
            {
                flag = true;
            }

            //监护人电话
            if (oldJc_jm.Jhr_dh != newJc_jm.Jhr_dh)
            {
                flag = true;
            }

            //农合编码
            if (oldJc_jm.Nhbm != newJc_jm.Nhbm)
            {
                flag = true;
            }

            //医保卡号
            if (oldJc_jm.Ybkh != newJc_jm.Ybkh)
            {
                flag = true;
            }

            //城居卡号
            if (oldJc_jm.Cjkh != newJc_jm.Cjkh)
            {
                flag = true;
            }

            //支付账号
            if (oldJc_jm.Zfzh != newJc_jm.Zfzh)
            {
                flag = true;
            }

            //健康档案编号
            if (oldJc_jm.Jkdabh != newJc_jm.Jkdabh)
            {
                flag = true;
            }

            //拼音码
            if (oldJc_jm.Pym != newJc_jm.Pym)
            {
                flag = true;
            }

            //五笔码
            if (oldJc_jm.Wbm != newJc_jm.Wbm)
            {
                flag = true;
            }

            //作废标志
            if (oldJc_jm.Zfbz != newJc_jm.Zfbz)
            {
                flag = true;
            }

            if (!flag)
            {
                throw new Exception("没有修改数据，不需要保存");
            }
            return;
        }


        /// <summary>
        /// 校验Jc_jm类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Jc_jm"></param>
        private void checkJc_jmIsNull(Jc_jm jc_jm)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            //if (null == jc_jm.Id || "" == jc_jm.Id)
            //{
            //    flag = true;
            //    sb.Append("请指定‘主键’的值\n");
            //}

            //身份证号
            if (null == jc_jm.Sfzh || "" == jc_jm.Sfzh)
            {
                flag = true;
                sb.Append("请指定‘身份证号’的值\n");
            }

            //姓名
            if (null == jc_jm.Xm || "" == jc_jm.Xm)
            {
                flag = true;
                sb.Append("请指定‘姓名’的值\n");
            }

            //性别（关联代码表）
            if (null == jc_jm.Xb_code || "" == jc_jm.Xb_code)
            {
                flag = true;
                sb.Append("请指定‘性别（关联代码表）’的值\n");
            }

            //出生日期
            if (null == jc_jm.Csrq || DateTime.MinValue == jc_jm.Csrq)
            {
                flag = true;
                sb.Append("请指定‘出生日期’的值\n");
            }

            //民族（关联代码表）
            if (null == jc_jm.Mz_code || "" == jc_jm.Mz_code)
            {
                flag = true;
                sb.Append("请指定‘民族（关联代码表）’的值\n");
            }

            //血型（关联代码表）
            if (null == jc_jm.Xx_code || "" == jc_jm.Xx_code)
            {
                flag = true;
                sb.Append("请指定‘血型（关联代码表）’的值\n");
            }

            //rh代码（关联代码表）
            if (null == jc_jm.Rh_code || "" == jc_jm.Rh_code)
            {
                flag = true;
                sb.Append("请指定‘rh代码（关联代码表）’的值\n");
            }

            //出生地址
            if (null == jc_jm.Csdz || "" == jc_jm.Csdz)
            {
                flag = true;
                sb.Append("请指定‘出生地址’的值\n");
            }

            //户籍地址
            if (null == jc_jm.Hjdz || "" == jc_jm.Hjdz)
            {
                flag = true;
                sb.Append("请指定‘户籍地址’的值\n");
            }

            //现住址所属行政区划（行政区区划代码）
            if (null == jc_jm.Xzz_xzqh || "" == jc_jm.Xzz_xzqh)
            {
                flag = true;
                sb.Append("请指定‘现住址所属行政区划（行政区区划代码）’的值\n");
            }

            //现住址，详细地址（乡/镇，村，组，门牌号）
            if (null == jc_jm.Xzz_xiang_xi_di_zhi || "" == jc_jm.Xzz_xiang_xi_di_zhi)
            {
                flag = true;
                sb.Append("请指定‘现住址，详细地址（乡/镇，村，组，门牌号）’的值\n");
            }

            //工作单位或学校
            if (null == jc_jm.Gzdw_xx || "" == jc_jm.Gzdw_xx)
            {
                flag = true;
                sb.Append("请指定‘工作单位或学校’的值\n");
            }

            //职业代码（暂做保留）
            if (null == jc_jm.Zy_code || "" == jc_jm.Zy_code)
            {
                flag = true;
                sb.Append("请指定‘职业代码（暂做保留）’的值\n");
            }

            //职业
            //if (null == jc_jm.Zy || "" == jc_jm.Zy)
            //{
            //    flag = true;
            //    sb.Append("请指定‘职业’的值\n");
            //}

            //文化代码（关联代码表）
            if (null == jc_jm.Wh_code || "" == jc_jm.Wh_code)
            {
                flag = true;
                sb.Append("请指定‘文化代码（关联代码表）’的值\n");
            }

            //婚姻状况（关联代码表）
            if (null == jc_jm.Hyzk_code || "" == jc_jm.Hyzk_code)
            {
                flag = true;
                sb.Append("请指定‘婚姻状况（关联代码表）’的值\n");
            }

            //联系电话
            if (null == jc_jm.Lxdh || "" == jc_jm.Lxdh)
            {
                flag = true;
                sb.Append("请指定‘联系电话’的值\n");
            }

            //监护人姓名
            if (null == jc_jm.Jhr_xm || "" == jc_jm.Jhr_xm)
            {
                flag = true;
                sb.Append("请指定‘监护人姓名’的值\n");
            }

            //监护人电话
            if (null == jc_jm.Jhr_dh || "" == jc_jm.Jhr_dh)
            {
                flag = true;
                sb.Append("请指定‘监护人电话’的值\n");
            }

            //农合编码
            if (null == jc_jm.Nhbm || "" == jc_jm.Nhbm)
            {
                flag = true;
                sb.Append("请指定‘农合编码’的值\n");
            }

            //医保卡号
            if (null == jc_jm.Ybkh || "" == jc_jm.Ybkh)
            {
                flag = true;
                sb.Append("请指定‘医保卡号’的值\n");
            }

            //城居卡号
            if (null == jc_jm.Cjkh || "" == jc_jm.Cjkh)
            {
                flag = true;
                sb.Append("请指定‘城居卡号’的值\n");
            }

            //支付账号
            if (null == jc_jm.Zfzh || "" == jc_jm.Zfzh)
            {
                flag = true;
                sb.Append("请指定‘支付账号’的值\n");
            }

            //健康档案编号
            if (null == jc_jm.Jkdabh || "" == jc_jm.Jkdabh)
            {
                flag = true;
                sb.Append("请指定‘健康档案编号’的值\n");
            }

            //拼音码
            if (null == jc_jm.Pym || "" == jc_jm.Pym)
            {
                flag = true;
                sb.Append("请指定‘拼音码’的值\n");
            }

            //五笔码
            if (null == jc_jm.Wbm || "" == jc_jm.Wbm)
            {
                flag = true;
                sb.Append("请指定‘五笔码’的值\n");
            }

            //作废标志
            if (null == jc_jm.Zfbz || "" == jc_jm.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志’的值\n");
            }

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }


        private void initUI()
        {
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_cancel, skinButton_save);
            DateTimePickerHelper.initDateTimePicker(dateTimePicker_出生日期);
            ComboBoxHelper.initComboBoxForCode(comboBox_性别, CommonCode.代码类型值.性别类型值, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_民族, CommonCode.代码类型值.民族类型值, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_血型, CommonCode.代码类型值.CV5103_02ABO血型代码, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_职业, CommonCode.代码类型值.CV0207_01职业代码, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_文化, CommonCode.代码类型值.学历类型值, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_婚姻状况, CommonCode.代码类型值.婚姻状况类型值, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_RH, CommonCode.代码类型值.RH代码, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForZfbz(comboBox_作废标志);

            //地区
            Jc_area areaParamSheng = new Jc_area();
            areaParamSheng.Level_code = CommonCode.代码值_行政区划等级.省级;
            ComboBoxHelper.initComboBoxForArea(comboBox_省, areaParamSheng, CommonCode.代码值_作废标志代码值.启用);

            comboBox_县区.Enabled = false;
            comboBox_州市.Enabled = false;
            comboBox_乡镇.Enabled = false;
            comboBox_村委会.Enabled = false;

            if (this.oldJc_jm == null)
            {
                //新增
                textBox_姓名.Text = "王五";
                comboBox_性别.SelectedIndex = 1;
                textBox_身份证号.Text ="534565896589658";
                comboBox_职业.SelectedIndex = 1;
                comboBox_民族.SelectedIndex = 1;
                comboBox_血型.SelectedIndex = 1;
                comboBox_文化.SelectedIndex = 1;
                comboBox_婚姻状况.SelectedIndex = 1;
                comboBox_RH.SelectedIndex =1;
                comboBox_作废标志.SelectedIndex = 1;

                textBox_出生地址.Text = "chushengdizhi";
                textBox_户籍地址.Text = "hujidizhi";
                comboBox_省.SelectedIndex = 0;
                //comboBox_州市.SelectedIndex = 1;
                //comboBox_县区.SelectedIndex = 1;
                //comboBox_乡镇.SelectedIndex = 1;
                //comboBox_村委会.SelectedIndex = 1;
                textBox_工作单位或学校.Text = "textBox_工作单位或学校";
                textBox_详细地址.Text = "详细地址";
                textBox_联系电话.Text = "1333333333333";
                textBox_监护人电话.Text = "1111111111";
                textBox_监护人邢敏.Text="监护人姓名";

                textBox_农合编码.Text = "11111111";
                textBox_医保卡号.Text = "xxxxxxxxxxxx";
                textBox_城居卡号.Text = "bbbbbbbbbb";
                textBox_健康档案编号.Text = "nnnnnnnnnnn";
                textBox_支付账号.Text = "zzzzzzzzz";
                textBox_拼音码.Text = PinYinConverter.GetFirst(textBox_姓名.Text);
                textBox_五笔码.Text = WuBiConverter.GetWBCode(textBox_姓名.Text);
            }
            else
            {
                //修改
                textBox_姓名.Text = this.oldJc_jm.Xm;
                comboBox_性别.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_性别, this.oldJc_jm.Xb_code, CommonCode.实体类名称.基础_代码字典实体类名);
                dateTimePicker_出生日期.Value = (DateTime)this.oldJc_jm.Csrq;
                textBox_身份证号.Text = this.oldJc_jm.Sfzh;
                comboBox_民族.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_民族, this.oldJc_jm.Mz_code, CommonCode.实体类名称.基础_代码字典实体类名);
                comboBox_血型.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_血型, this.oldJc_jm.Xx_code, CommonCode.实体类名称.基础_代码字典实体类名);
                comboBox_职业.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_职业, this.oldJc_jm.Zy_code, CommonCode.实体类名称.基础_代码字典实体类名);
                comboBox_文化.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_文化, this.oldJc_jm.Wh_code, CommonCode.实体类名称.基础_代码字典实体类名);
                comboBox_婚姻状况.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_婚姻状况, this.oldJc_jm.Hyzk_code, CommonCode.实体类名称.基础_代码字典实体类名);
                comboBox_RH.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_RH, this.oldJc_jm.Rh_code, CommonCode.实体类名称.基础_代码字典实体类名);
                comboBox_作废标志.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_作废标志, this.oldJc_jm.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名);

                //根据行政区划代码判断属于哪一级的行政区划，并且哪些控件可用
                ComboBoxHelper.initComboBoxForEditArea(comboBox_省, comboBox_州市, comboBox_县区, comboBox_乡镇, comboBox_村委会, this.oldJc_jm.Xzz_xzqh);
                textBox_出生地址.Text = this.oldJc_jm.Csdz;
                textBox_户籍地址.Text = this.oldJc_jm.Hjdz;
                textBox_详细地址.Text = this.oldJc_jm.Xzz_xiang_xi_di_zhi;
                textBox_工作单位或学校.Text = this.oldJc_jm.Gzdw_xx;
                textBox_联系电话.Text = this.oldJc_jm.Lxdh;
                textBox_监护人邢敏.Text = this.oldJc_jm.Jhr_xm;
                textBox_监护人电话.Text = this.oldJc_jm.Jhr_dh;
                textBox_农合编码.Text = this.oldJc_jm.Nhbm;
                textBox_医保卡号.Text = this.oldJc_jm.Ybkh;
                textBox_城居卡号.Text = this.oldJc_jm.Cjkh;
                textBox_支付账号.Text = this.oldJc_jm.Zfzh;
                textBox_健康档案编号.Text = this.oldJc_jm.Jkdabh;
                textBox_拼音码.Text = this.oldJc_jm.Pym;
                textBox_五笔码.Text = this.oldJc_jm.Wbm;

            }
        }



        private void JmEdit_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Jc_jm jmSave = new Jc_jm();
                jmSave.Xm  = textBox_姓名.Text.Trim();
                jmSave.Xb_code = Jc_code.ConvertToJc_code(comboBox_性别.SelectedItem).Value;
                jmSave.Csrq = dateTimePicker_出生日期.Value;
                jmSave.Sfzh = textBox_身份证号.Text.Trim();
                jmSave.Mz_code = Jc_code.ConvertToJc_code(comboBox_民族.SelectedItem).Value;
                jmSave.Xx_code = Jc_code.ConvertToJc_code(comboBox_血型.SelectedItem).Value;
                jmSave.Zy_code = Jc_code.ConvertToJc_code(comboBox_职业.SelectedItem).Value;
                jmSave.Wh_code = Jc_code.ConvertToJc_code(comboBox_文化.SelectedItem).Value;
                jmSave.Hyzk_code = Jc_code.ConvertToJc_code(comboBox_婚姻状况.SelectedItem).Value;
                jmSave.Csdz = textBox_出生地址.Text.Trim();
                jmSave.Hjdz = textBox_户籍地址.Text.Trim();
                jmSave.Xzz_xzqh = ComboBoxHelper.getComboBoxAreaCode(comboBox_省, comboBox_州市, comboBox_县区, comboBox_乡镇, comboBox_村委会);
                jmSave.Xzz_xiang_xi_di_zhi = textBox_详细地址.Text.Trim();
                jmSave.Gzdw_xx = textBox_工作单位或学校.Text.Trim();
                jmSave.Lxdh = textBox_联系电话.Text.Trim();
                jmSave.Rh_code = Jc_code.ConvertToJc_code(comboBox_RH.SelectedItem).Value;
                jmSave.Jhr_xm = textBox_监护人邢敏.Text.Trim();
                jmSave.Jhr_dh = textBox_监护人电话.Text.Trim();
                jmSave.Nhbm = textBox_农合编码.Text.Trim();
                jmSave.Ybkh = textBox_医保卡号.Text.Trim();
                jmSave.Cjkh = textBox_城居卡号.Text.Trim();
                jmSave.Zfzh = textBox_支付账号.Text.Trim();
                jmSave.Jkdabh = textBox_健康档案编号.Text.Trim();
                jmSave.Pym = textBox_拼音码.Text.Trim();
                jmSave.Wbm = textBox_五笔码.Text.Trim();
                jmSave.Zfbz = Jc_code.ConvertToJc_code(comboBox_作废标志.SelectedItem).Value;

                this.checkJc_jmIsNull(jmSave);
                bool flag = false;
                if (null == this.oldJc_jm)
                {
                    //新增
                    flag = jc_jmBll.save(jmSave);
                }
                else
                {
                    this.checkJc_jmIsEqual(this.oldJc_jm, jmSave);
                    jmSave.Id = this.oldJc_jm.Id;
                    flag = jc_jmBll.save(jmSave);
                    
                }

                if (flag)
                {
                    MyMessageBox.Show("保存成功");
                    this.Close();
                }
                else
                {
                    MyMessageBox.Show("保存失败");

                }

            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);   
            }
        }



        private void comboBox_省_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string code = Jc_area.ConvertToJc_area(comboBox_省.SelectedItem).Code;
                Jc_area areaParam = new Jc_area();
                areaParam.Level_code = CommonCode.代码值_行政区划等级.州市级;
                areaParam.Pcode = code;
                ComboBoxHelper.initComboBoxForArea(comboBox_州市, areaParam, CommonCode.代码值_作废标志代码值.启用);
                comboBox_县区.Enabled = false;
                comboBox_县区.SelectedIndex = -1;
                comboBox_乡镇.Enabled = false;
                comboBox_乡镇.SelectedIndex = -1;
                comboBox_村委会.Enabled = false;
                comboBox_村委会.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);   
            }
        }

        private void comboBox_州市_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string code = Jc_area.ConvertToJc_area(comboBox_州市.SelectedItem).Code;
                Jc_area areaParam = new Jc_area();
                areaParam.Level_code = CommonCode.代码值_行政区划等级.区县级;
                areaParam.Pcode = code;
                ComboBoxHelper.initComboBoxForArea(comboBox_县区, areaParam, CommonCode.代码值_作废标志代码值.启用);
                comboBox_乡镇.Enabled = false;
                comboBox_乡镇.SelectedIndex = -1;
                comboBox_村委会.Enabled = false;
                comboBox_村委会.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void comboBox_县区_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string code = Jc_area.ConvertToJc_area(comboBox_县区.SelectedItem).Code;
                Jc_area areaParam = new Jc_area();
                areaParam.Level_code = CommonCode.代码值_行政区划等级.乡镇级;
                areaParam.Pcode = code;
                ComboBoxHelper.initComboBoxForArea(comboBox_乡镇, areaParam, CommonCode.代码值_作废标志代码值.启用);
                comboBox_村委会.Enabled = false;
                comboBox_村委会.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void comboBox_乡镇_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string code = Jc_area.ConvertToJc_area(comboBox_乡镇.SelectedItem).Code;
                Jc_area areaParam = new Jc_area();
                areaParam.Level_code = CommonCode.代码值_行政区划等级.村委会级;
                areaParam.Pcode = code;
                ComboBoxHelper.initComboBoxForArea(comboBox_村委会, areaParam, CommonCode.代码值_作废标志代码值.启用);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void textBox_姓名_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_拼音码.Text = PinYinConverter.GetFirst( textBox_姓名.Text.Trim());
                textBox_五笔码.Text = WuBiConverter.GetWBCode( textBox_姓名.Text.Trim());
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
    }
}
