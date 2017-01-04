using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.Common;
using Model.JC;
using Model.Common;
using BLL.JC.基础_科室;
using BLL.JC.基础_工作人员所属科室关系;
using Model.RBAC;
using client.JC.基础_居民;
using BLL.MZ.门诊;
using Model.MZ;
using client.JC.工作人员管理;

namespace client.MZ.门诊挂号
{
    public partial class Mzgh : Form
    {
        private MzBLL mzBll = new MzBLLImp();

        private Jc_kswhBLL jc_kswhBLL = new Jc_kswhBLLImp();

        private Jc_ry_ksBLL jc_ry_ksBLL = new Jc_ry_ksBLLImp();


        private Main main = null;


        private Jc_jm jmSave = null;



        public Mzgh(Main main)
        {
            this.main = main;

            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_病人查询, skinButton_挂号确定, skinButton_关闭, skinButton_医生查询, skinButton_重打印);
            ComboBoxHelper.initComboBoxForCode(comboBox_病人类型, CommonCode.代码类型值.病人类型, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_性别, CommonCode.代码类型值.性别类型值, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_挂号类型, CommonCode.代码类型值.挂号_类型, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForKswh(comboBox_挂号科室, null, CommonCode.代码值_作废标志代码值.启用);
            //工作人员
            Jc_renyuan renyuanParam = new Jc_renyuan();
            renyuanParam.Rylx_code = CommonCode.代码值_工作人员类型.医生;
            ComboBoxHelper.initComboBoxForRenyuan(comboBox_挂号医生, renyuanParam, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(comboBox_职业, CommonCode.代码类型值.CV0207_01职业代码, CommonCode.代码值_作废标志代码值.启用);
            DateTimePickerHelper.initDateTimePicker(dateTimePicker_出身日期);
            //地区
            Jc_area areaParamSheng = new Jc_area();
            areaParamSheng.Level_code = CommonCode.代码值_行政区划等级.省级;
            ComboBoxHelper.initComboBoxForArea(skinComboBox_省, areaParamSheng, CommonCode.代码值_作废标志代码值.启用);

        }

        private void Mzgh_Load(object sender, EventArgs e)
        {

            try
            {
                this.initUI();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message); ;
            }
        }

        private void initUI()
        {
            this.clearUI();

           
            //挂号界面

            comboBox_挂号科室.Enabled = false;


            this.initDataGridView_renyuan();//初始化datagridview
            textBox10_月.Enabled = false;
            textBox7_岁.Enabled = false;
            textBox2_天.Enabled = false;

            skinComboBox_州市.Enabled = false;
            skinComboBox_乡镇.Enabled = false;
            skinComboBox_居委会.Enabled = false;

        }



        private void dateTimePicker1_csrq_ValueChanged(object sender, EventArgs e)
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



        private void checkUI()
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();
            if (-1 == comboBox_病人类型.SelectedIndex)
            {
                flag = true;
                sb.Append("请选择病人类型\n");
            }
            if ("" == textBox_病人姓名.Text.Trim())
            {
                flag = true;
                sb.Append("病人姓名不能为空\n");
            }
            if (-1 == comboBox_性别.SelectedIndex)
            {
                flag = true;
                sb.Append("请选择病人性别\n");
            }
            if (-1 == comboBox_挂号科室.SelectedIndex)
            {
                flag = true;
                sb.Append("请选择挂号科室\n");
            }
            if (-1 == comboBox_挂号类型.SelectedIndex)
            {
                flag = true;
                sb.Append("请选择挂号类型\n");
            }
            if (""==textBox10_月.Text.Trim()||""==textBox7_岁.Text.Trim())
            {
                flag = true;
                sb.Append("请选择病人出生日期\n");
            }
            if ("" == textBox_身份证号.Text.Trim())
            {
                flag = true;
                sb.Append("请输入身份证号\n");
            }
            //if ("" == textBox9_lxdh.Text.Trim())
            //{
            //    flag = true;
            //    sb.Append("请输入联系电话\n");
            //}
            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }

        private void clearUI()
        {
            comboBox_病人类型.SelectedIndex = -1;
            textBox_病人姓名.Clear();
            comboBox_性别.SelectedIndex = -1;
            comboBox_挂号科室.SelectedIndex = -1;
            comboBox_挂号医生.SelectedIndex = -1;
            comboBox_挂号类型.SelectedIndex = -1;
            textBox7_岁.Clear();
            textBox10_月.Clear();
            textBox_身份证号.Clear();
            textBox_联系电话.Clear();
        }



        //初始化挂号科室列表
        private void initDataGridView_renyuan()
        {
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_keshi);
            Jc_kswh ksParam = new Jc_kswh();
            ksParam.Mzbz_code = CommonCode.代码值_勾叉.勾;
            List<object> objs = jc_kswhBLL.getList(ksParam, null, null);
            SkinDataGridViewHelper.bindingList(skinDataGridView_keshi, objs[0]);


            if (skinDataGridView_keshi.DataSource == null)
            {
                return;
            }
            skinDataGridView_keshi.Columns[Jc_kswh.ID].Visible = false;
            skinDataGridView_keshi.Columns[Jc_kswh.KSBH].HeaderText = "科室编号";
            skinDataGridView_keshi.Columns[Jc_kswh.KSMC].HeaderText = "科室名称";
            skinDataGridView_keshi.Columns[Jc_kswh.MZBZ_CODE].Visible = false;
            skinDataGridView_keshi.Columns[Jc_kswh.SSBZ_CODE].Visible = false;
            skinDataGridView_keshi.Columns[Jc_kswh.YFBZ_CODE].Visible = false;
            skinDataGridView_keshi.Columns[Jc_kswh.YJBZ_CODE].Visible = false;
            skinDataGridView_keshi.Columns[Jc_kswh.YKBZ_CODE].Visible = false;
            skinDataGridView_keshi.Columns[Jc_kswh.ZFBZ].Visible = false;
            skinDataGridView_keshi.Columns[Jc_kswh.ZYBZ_CODE].Visible = false;

            skinDataGridView_keshi.Columns["mzbzCode"].Visible = false;//门诊标志（与代码表关联）

            skinDataGridView_keshi.Columns["zybzCode"].Visible = false;//住院标志（与代码表关联）

            skinDataGridView_keshi.Columns["ykbzCode"].Visible = false;//药库标志（与代码表关联）

            skinDataGridView_keshi.Columns["yfbzCode"].Visible = false;//药房标志（与代码表关联）

            skinDataGridView_keshi.Columns["yjbzCode"].Visible = false;//医技标志（与代码表关联）

            skinDataGridView_keshi.Columns["ssbzCode"].Visible = false;//手术标志（与代码表关联）

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_keshi);

        }


        private void dataGridView_renyuan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Jc_kswh ksTmp = Jc_kswh.ConvertToJc_kswh(SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_keshi));
                comboBox_挂号科室.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_挂号科室, ksTmp.Id, CommonCode.实体类名称.基础_科室实体类名);
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        private void button4_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_省_SelectionChangeCommitted(object sender, EventArgs e)
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

        private void comboBox_州市_SelectionChangeCommitted(object sender, EventArgs e)
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


        private void dataGridView_renyuan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Space )
                {
                    Jc_kswh ksTmp = Jc_kswh.ConvertToJc_kswh(SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_keshi));
                    comboBox_挂号科室.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_挂号科室, ksTmp.Id, CommonCode.实体类名称.基础_科室实体类名);
                }
                
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

        private void comboBox_乡镇_SelectionChangeCommitted(object sender, EventArgs e)
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

        private void skinButton_病人查询_Click(object sender, EventArgs e)
        {
            try
            {
                JmSearch jmsearch = new JmSearch();
                jmsearch.ShowDialog();
                Jc_jm jm = jmsearch.DoubleClickJc_jm;
                if (null==jm)
                {
                    return;
                }
                this.jmSave = jm;
                textBox_医保卡号.Text = jm.Ybkh;
                textBox_病人姓名.Text = jm.Xm;
                comboBox_性别.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_性别, jm.Xb_code, CommonCode.实体类名称.基础_代码字典实体类名);
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

        private void skinButton_挂号确定_Click(object sender, EventArgs e)
        {
            try
            {
                this.checkUI();
                Mz_gh ghSave = new Mz_gh();
                //从界面上取值构建保存对象
                if (this.jmSave == null)
                {
                    this.jmSave = new Jc_jm();
                }


                jmSave.Xm = textBox_病人姓名.Text;
                jmSave.Ybkh = textBox_医保卡号.Text;
                jmSave.Xb_code = Jc_code.ConvertToJc_code(comboBox_性别.SelectedItem).Value;
                jmSave.Csrq = dateTimePicker_出身日期.Value;
                jmSave.Sfzh = textBox_身份证号.Text;
                jmSave.Lxdh = textBox_联系电话.Text;
                jmSave.Zy_code = Jc_code.ConvertToJc_code(comboBox_职业.SelectedItem).Value;
                jmSave.Zfbz = Model.Common.CommonCode.代码值_作废标志代码值.启用;
                jmSave.Xzz_xzqh = ComboBoxHelper.getComboBoxAreaCode(skinComboBox_省, skinComboBox_州市, skinComboBox_县区, skinComboBox_乡镇, skinComboBox_居委会);
                jmSave.Xzz_xiang_xi_di_zhi = textBox_详细地址.Text;
                jmSave.Pym = PinYinConverter.GetFirst(jmSave.Xm);
                jmSave.Wbm = WuBiConverter.GetWBCode(jmSave.Xm);


                ghSave.Brlx_code = Jc_code.ConvertToJc_code(comboBox_病人类型.SelectedItem).Value;
                ghSave.Brxm = textBox_病人姓名.Text;
                ghSave.Brcsrq = dateTimePicker_出身日期.Value;
                ghSave.Brxb = Jc_code.ConvertToJc_code(comboBox_性别.SelectedItem).Name;
                ghSave.Brsfzh = textBox_身份证号.Text;
                ghSave.Brlxdh = textBox_联系电话.Text;
                ghSave.Brxzz_xzqh = ComboBoxHelper.getComboBoxAreaCode(skinComboBox_省, skinComboBox_州市, skinComboBox_县区, skinComboBox_乡镇, skinComboBox_居委会);
                ghSave.Brxzz_detail = textBox_详细地址.Text;
                ghSave.Fk_jc_kswh = Jc_kswh.ConvertToJc_kswh(comboBox_挂号科室.SelectedItem).Id;
                ghSave.Fk_jc_renyuan = Jc_renyuan.ConvertToJc_renyuan(comboBox_挂号医生.SelectedItem).Id;
                ghSave.Ghlx_code = Jc_code.ConvertToJc_code(comboBox_挂号类型.SelectedItem).Value;
                ghSave.Zfbz = Model.Common.CommonCode.代码值_作废标志代码值.启用;


                bool flag = mzBll.saveGh(jmSave, ghSave);
                if (flag)
                {
                    MyMessageBox.Show("挂号成功");
                }
                else
                {
                    MyMessageBox.Show("挂号失败");
                }
                this.initUI();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinButton_医生查询_Click(object sender, EventArgs e)
        {
            try
            {
                RenyuanSearch renyuansearch = new RenyuanSearch();
                renyuansearch.ShowDialog();
                if (renyuansearch.SelectedRenyuan!=null)
                {
                    comboBox_挂号医生.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_挂号医生, renyuansearch.SelectedRenyuan.Id, CommonCode.实体类名称.基础_工作人员实体类名);
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinButton_重打印_Click(object sender, EventArgs e)
        {
            try
            {
                MyMessageBox.Show("尚未实现打印");
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);

            }
        }

        private void skinButton_关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
