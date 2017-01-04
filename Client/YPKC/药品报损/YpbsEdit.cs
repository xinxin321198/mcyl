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

namespace client.YPKC.药品报损
{
    
    public partial class YpbsEdit : Form
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
        public YpbsEdit(Jc_renyuan workRenyuan, Jc_code djLx, Jc_code ypLx)
        {
            this.workRenyuan = workRenyuan;
            this.djLx = djLx;
            this.ypLx = ypLx;
            InitializeComponent();
            this.initUI();

        }
        public YpbsEdit(Ypkc_dj oldDj, Jc_renyuan workRenyuan)
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

            ComboBoxHelper.initComboBoxForGys(skinComboBox_供应商, null, CommonCode.代码值_作废标志代码值.启用);

            //初始化所有的科室
            ComboBoxHelper.initComboBoxForKswh(skinComboBox_来源科室, null, CommonCode.代码值_作废标志代码值.启用);

            ComboBoxHelper.initComboBoxForCode(skinComboBox_采购方式, CommonCode.代码类型值.库存_采购方式, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForCode(skinComboBox_验收, CommonCode.代码类型值.库存_验收, CommonCode.代码值_作废标志代码值.启用);


            SkinDataGridViewHelper.initDataGridView(skinDataGridView1);

            textBox_制单人姓名.ReadOnly = true;
            //查询得到当前登录用户所属的人员名称
            textBox_制单人姓名.Text = this.workRenyuan.Xm;
            if (this.oldDj != null)//修改，以及记账
            {
                this.label_number.Text = "NO." + this.oldDj.Djh;
                label_djlx.Text = this.oldDj.YpflCode.Name + this.oldDj.DjlxCode.Name;
                skinComboBox_供应商.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_供应商, this.oldDj.Fk_lygys, CommonCode.实体类名称.基础_供应商实体类名);
                skinComboBox_来源科室.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_来源科室, this.oldDj.Fk_lyks, CommonCode.实体类名称.基础_科室实体类名);
                skinComboBox_采购方式.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_采购方式, this.oldDj.Caigoufs_code, CommonCode.实体类名称.基础_代码字典实体类名);              
                skinComboBox_验收.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_验收, this.oldDj.Yanshou_code, CommonCode.实体类名称.基础_代码字典实体类名);
                rtfRichTextBox_remark.Text = this.oldDj.Remark;
            }
            else//新增打开
            {
                label_djlx.Text = this.ypLx.Name + this.djLx.Name;

            }

        }

        private void YpbsEdit_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }

        }
       
    }
}
