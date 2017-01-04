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
using Model.Common;
using client.Common;
using client.JC.基础_居民;
using Model.MZ;
using BLL.MZ.门诊;

namespace client.MZ.门诊医生站
{
    public partial class MzFast_gh : Form
    {
        private LoginModel loginModel = null;

        private Jc_jm jmSave = null;

        private MzBLL mzBll = new MzBLLImp();



        public MzFast_gh(LoginModel loginModel)
        {
            this.loginModel = loginModel;
            InitializeComponent();
            SkinButtonHelper.initButton(this.skinButton_save, this.skinButton_病人查询);
            DateTimePickerHelper.initDateTimePicker(dateTimePicker_出身日期);
            //初始化combobox
            ComboBoxHelper.initComboBoxForCode(skinComboBox_病人类型, CommonCode.代码类型值.病人类型, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(skinComboBox_挂号类型, CommonCode.代码类型值.挂号_类型, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(skinComboBox_性别, CommonCode.代码类型值.性别类型值, CommonCode.代码值_作废标志代码值.启用);

            //地区
            Jc_area areaParamSheng = new Jc_area();
            areaParamSheng.Level_code = CommonCode.代码值_行政区划等级.省级;
            ComboBoxHelper.initComboBoxForArea(skinComboBox_省, areaParamSheng, CommonCode.代码值_作废标志代码值.启用);

            skinComboBox_县区.Enabled = false;
            skinComboBox_州市.Enabled = false;
            skinComboBox_乡镇.Enabled = false;
            skinComboBox_居委会.Enabled = false;

            this.textBox_keshi.Text = this.loginModel.LoginKeShi.Ksmc;
            this.textBox_keshi.ReadOnly = true;
            this.textBox_yisheng.Text = this.loginModel.LoginRenyuan.Xm;
            this.textBox_yisheng.ReadOnly = true;
        }

        private void Fast_gh_Load(object sender, EventArgs e)
        {
            try
            {
                this.initUI();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void initUI()
        {



   
           
        }

        private void skinButton_病人查询_Click(object sender, EventArgs e)
        {
            try
            {
                JmSearch jmsearch = new JmSearch();
                jmsearch.ShowDialog();
                Jc_jm jm = jmsearch.DoubleClickJc_jm;
                if (null == jm)
                {
                    return;
                }
                this.jmSave = jm;

                textBox_医保卡号.Text = jm.Ybkh;
                textBox_病人姓名.Text = jm.Xm;
                skinComboBox_性别.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_性别, jm.Xb_code, CommonCode.实体类名称.基础_代码字典实体类名);
                dateTimePicker_出身日期.Value = (DateTime)jm.Csrq;
                textBox_身份证号.Text = jm.Sfzh;
                textBox_联系电话.Text = jm.Lxdh;
                comboBox_职业.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_职业, jm.Zy_code, CommonCode.实体类名称.基础_代码字典实体类名);
                ComboBoxHelper.initComboBoxForEditArea(skinComboBox_省, skinComboBox_州市, skinComboBox_县区, skinComboBox_乡镇, skinComboBox_居委会, jm.Xzz_xzqh);
                textBox_详细地址.Text = jm.Xzz_xiang_xi_di_zhi;
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }



        /// <summary>
        /// 校验Jc_jm类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Jc_jm"></param>
        private void checkJc_jmIsNull(Jc_jm jc_jm)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();


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


            //现住址所属行政区划（行政区区划代码）
            if (null == jc_jm.Xzz_xzqh || "" == jc_jm.Xzz_xzqh)
            {
                flag = true;
                sb.Append("请指定‘现住址所属行政区划（行政区区划代码）’的值\n");
            }

  
            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }

        private void skinButton_save_Click(object sender, EventArgs e)
        {
            try
            {
                //this.checkUI();
                Mz_gh ghSave = new Mz_gh();
                //从界面上取值构建保存对象
                if (this.jmSave == null)
                {
                    this.jmSave = new Jc_jm();
                }
                ghSave.Brlx_code = Jc_code.ConvertToJc_code(skinComboBox_病人类型.SelectedItem).Value;
                jmSave.Xm = textBox_病人姓名.Text;
                jmSave.Ybkh = textBox_医保卡号.Text;
                jmSave.Xb_code = Jc_code.ConvertToJc_code(skinComboBox_性别.SelectedItem).Value;
                ghSave.Fk_jc_kswh = this.loginModel.LoginKeShi.Id;
                ghSave.Fk_jc_renyuan = this.loginModel.LoginRenyuan.Id;
                ghSave.Ghlx_code = Jc_code.ConvertToJc_code(skinComboBox_挂号类型.SelectedItem).Value;
                ghSave.Zfbz = Model.Common.CommonCode.代码值_作废标志代码值.启用;
                ghSave.Brxm = textBox_病人姓名.Text;
                ghSave.Brxb = Jc_code.ConvertToJc_code(skinComboBox_性别.SelectedItem).Name;
                ghSave.Brcsrq = dateTimePicker_出身日期.Value;
                ghSave.Brsfzh = textBox_身份证号.Text;
                ghSave.Brlxdh = textBox_联系电话.Text;
                ghSave.Brxzz_xzqh = ComboBoxHelper.getComboBoxAreaCode(skinComboBox_省, skinComboBox_州市, skinComboBox_县区, skinComboBox_乡镇, skinComboBox_居委会);
                ghSave.Brxzz_detail = textBox_详细地址.Text;
                jmSave.Csrq = dateTimePicker_出身日期.Value;
                jmSave.Sfzh = textBox_身份证号.Text;
                jmSave.Lxdh = textBox_联系电话.Text;
                jmSave.Zy_code = Jc_code.ConvertToJc_code(comboBox_职业.SelectedItem).Value;
                jmSave.Zfbz = Model.Common.CommonCode.代码值_作废标志代码值.启用;
                jmSave.Xzz_xzqh = ComboBoxHelper.getComboBoxAreaCode(skinComboBox_省, skinComboBox_州市, skinComboBox_县区, skinComboBox_乡镇, skinComboBox_居委会);
                jmSave.Xzz_xiang_xi_di_zhi = textBox_详细地址.Text;
                jmSave.Pym = PinYinConverter.GetFirst(jmSave.Xm);
                jmSave.Wbm = WuBiConverter.GetWBCode(jmSave.Xm);
                this.checkJc_jmIsNull(jmSave);
                bool flag = mzBll.saveGh(jmSave, ghSave);
                if (flag)
                {
                    MyMessageBox.Show("挂号成功");
                }
                else
                {
                    MyMessageBox.Show("挂号失败");
                }
                this.Close();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker_出身日期_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                     textBox7_岁.Text = DateTimePickerHelper.getAgeForYear(dateTimePicker_出身日期.Value).ToString();
                textBox10_月.Text = DateTimePickerHelper.getAgeForMonth(dateTimePicker_出身日期.Value).ToString();
                textBox2_天.Text = DateTimePickerHelper.getAgeForDay(dateTimePicker_出身日期.Value).ToString(); ;
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinComboBox_省_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string code = Jc_area.ConvertToJc_area(skinComboBox_省.SelectedItem).Code;
                Jc_area areaParam = new Jc_area();
                areaParam.Level_code = CommonCode.代码值_行政区划等级.州市级;
                areaParam.Pcode = code;
                ComboBoxHelper.initComboBoxForArea(skinComboBox_州市, areaParam, CommonCode.代码值_作废标志代码值.启用);
                skinComboBox_县区.Enabled = false;
                skinComboBox_县区.SelectedIndex = -1;
                skinComboBox_乡镇.Enabled = false;
                skinComboBox_乡镇.SelectedIndex = -1;
                skinComboBox_居委会.Enabled = false;
                skinComboBox_居委会.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinComboBox_州市_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string code = Jc_area.ConvertToJc_area(skinComboBox_州市.SelectedItem).Code;
                Jc_area areaParam = new Jc_area();
                areaParam.Level_code = CommonCode.代码值_行政区划等级.区县级;
                areaParam.Pcode = code;
                ComboBoxHelper.initComboBoxForArea(skinComboBox_县区, areaParam, CommonCode.代码值_作废标志代码值.启用);
                skinComboBox_乡镇.Enabled = false;
                skinComboBox_乡镇.SelectedIndex = -1;
                skinComboBox_居委会.Enabled = false;
                skinComboBox_居委会.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinComboBox_县区_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string code = Jc_area.ConvertToJc_area(skinComboBox_县区.SelectedItem).Code;
                Jc_area areaParam = new Jc_area();
                areaParam.Level_code = CommonCode.代码值_行政区划等级.乡镇级;
                areaParam.Pcode = code;
                ComboBoxHelper.initComboBoxForArea(skinComboBox_乡镇, areaParam, CommonCode.代码值_作废标志代码值.启用);
                skinComboBox_居委会.Enabled = false;
                skinComboBox_居委会.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinComboBox_乡镇_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string code = Jc_area.ConvertToJc_area(skinComboBox_乡镇.SelectedItem).Code;
                Jc_area areaParam = new Jc_area();
                areaParam.Level_code = CommonCode.代码值_行政区划等级.村委会级;
                areaParam.Pcode = code;
                ComboBoxHelper.initComboBoxForArea(skinComboBox_居委会, areaParam, CommonCode.代码值_作废标志代码值.启用);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
    }
}
