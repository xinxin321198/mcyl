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
using Model.Common;
using Model.JC;
using Model.YPKC;

namespace client.YPKC.药品退货
{
    public partial class YpthEdit : Form
    {
        Jc_renyuan workRenyuan = null;//打开此窗体的工作人员
        private Jc_code djLx = null;//新增，打开此窗体时候的开单类型
        private Jc_code ypLx = null;//新增，开单的药品类型
        Ypkc_dj oldDj = null;
         /// <summary>
        /// 
        /// </summary>
        /// <param name="workRenyuan"></param>
        /// <param name="djLx">单据类型</param>
        public YpthEdit(Jc_renyuan workRenyuan, Jc_code djLx, Jc_code ypLx)
        {
            this.workRenyuan = workRenyuan;
            this.djLx = djLx;
            this.ypLx = ypLx;
            InitializeComponent();
            this.initUI();

        }
        public YpthEdit(Ypkc_dj oldDj, Jc_renyuan workRenyuan)
        {
            this.oldDj = oldDj;
            this.djLx= this.oldDj.DjlxCode;
            this.workRenyuan = workRenyuan;
            InitializeComponent();
            this.initUI();

        }
        private void initUI()
        {
            FormHelper.initForm(this);
            SkinButtonHelper.initButton(skinButton_save, skinButton_记账);
            LabelHelper.initTitleLabel(label_djlx, label_number);

            ComboBoxHelper.initComboBoxForGys(skinComboBox_目的供应商, null, CommonCode.代码值_作废标志代码值.启用);

            //初始化有药房标志和药库标志的科室
            ComboBoxHelper.initComboBoxForKswh_YfYk(skinComboBox_来源科室);

            ComboBoxHelper.initComboBoxForCode(skinComboBox_采购方式, CommonCode.代码类型值.库存_采购方式, CommonCode.代码值_作废标志代码值.启用);


            SkinDataGridViewHelper.initDataGridView(skinDataGridView1);

            textBox_制单人姓名.ReadOnly = true;
            //查询得到当前登录用户所属的人员名称
            textBox_制单人姓名.Text = this.workRenyuan.Xm;
            if (this.oldDj != null)//修改，以及记账
            {
                this.label_number.Text = "NO." + this.oldDj.Djh;
                label_djlx.Text = this.oldDj.YpflCode.Name + this.oldDj.DjlxCode.Name;
                skinComboBox_目的供应商.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_目的供应商, this.oldDj.Fk_mdgys, CommonCode.实体类名称.基础_供应商实体类名);
                skinComboBox_来源科室.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_来源科室, this.oldDj.Fk_lyks, CommonCode.实体类名称.基础_科室实体类名);
                skinComboBox_采购方式.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_采购方式, this.oldDj.Caigoufs_code, CommonCode.实体类名称.基础_代码字典实体类名);              
                rtfRichTextBox_remark.Text = this.oldDj.Remark;
            }
            else//新增打开
            {
                label_djlx.Text = this.ypLx.Name + this.djLx.Name;

            }

        }

        private void YpthEdit_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }

        }

        private void skinButton_save_Click(object sender, EventArgs e)
        {
            try
            {

                Ypkc_dj djSave = new Ypkc_dj();
                //目的供应商
                djSave.Fk_mdgys= Jc_gys.ConvertToJc_gys(skinComboBox_目的供应商.SelectedItem).Id;
                djSave.Mdbh = Jc_gys.ConvertToJc_gys(skinComboBox_目的供应商.SelectedItem).Gysbh;
                djSave.Mdmc = Jc_gys.ConvertToJc_gys(skinComboBox_目的供应商.SelectedItem).Gysmc;
                //来源科室
                djSave.Fk_mdks = Jc_kswh.ConvertToJc_kswh(skinComboBox_来源科室.SelectedItem).Id;
                djSave.Lybh = Jc_kswh.ConvertToJc_kswh(skinComboBox_来源科室.SelectedItem).Ksbh;
                djSave.Lymc = Jc_kswh.ConvertToJc_kswh(skinComboBox_来源科室.SelectedItem).Ksmc;
                //制单人
                djSave.Zdr = this.workRenyuan.Xm;
                djSave.Fk_renyuan_zdr = this.workRenyuan.Id;


                djSave.Remark = rtfRichTextBox_remark.Text.Trim();

                djSave.Caigoufs_code = Jc_code.ConvertToJc_code(skinComboBox_采购方式.SelectedItem).Value;

                djSave.Djlx_code = CommonCode.药品库存_单据类型.退货;//单据类型为“退货”
                djSave.Ypfl_code = this.ypLx.Value;//药品类型
                djSave.Jzzt_code = CommonCode.代码值_是否.否;//是否记账为“否”
                djSave.Zfbz = CommonCode.代码值_作废标志代码值.启用;

                bool falg = false;//falg为false保存失败


                if (falg)
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

       
    }
}
