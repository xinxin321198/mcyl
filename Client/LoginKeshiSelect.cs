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

namespace client
{
    public partial class LoginKeshiSelect : Form
    {
        private List<Jc_kswh> keshiList;

        private Jc_kswh selectedKeshi;

        public Jc_kswh SelectedKeshi
        {
            get { return selectedKeshi; }
            set { selectedKeshi = value; }
        }

        public LoginKeshiSelect(List<Jc_kswh> keshiList)
        {
            InitializeComponent();
            this.keshiList = keshiList;
            FormHelper.initFormForToolWindow(this);
            SkinDataGridViewHelper.initDataGridView(this.skinDataGridView_keshi);
        }

        private void LoginKeshiSelect_Load(object sender, EventArgs e)
        {
            SkinDataGridViewHelper.bindingList(this.skinDataGridView_keshi, this.keshiList);

            //#region UI,datagridview隐藏基本字段，start
            ////隱藏列start
            ////skinDataGridView_keshi.Columns["ID"].Visible = false;//隐藏此列
            ////skinDataGridView_keshi.Columns["ID"].HeaderText = "主键";//设置列名
            ////skinDataGridView_keshi.Columns["ID"].DisplayIndex = 0;//列的顺序
            ////skinDataGridView_keshi.Columns["CSRQ"].DefaultCellStyle.Format = BLL.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_keshi.Columns[Jc_kswh.ID].Visible = false;//主键
            //skinDataGridView_keshi.Columns[Jc_kswh.ID].HeaderText = "主键";

            //skinDataGridView_keshi.Columns[Jc_kswh.KSBH].Visible = false;//科室标志
            skinDataGridView_keshi.Columns[Jc_kswh.KSBH].HeaderText = "科室编号";

            //skinDataGridView_keshi.Columns[Jc_kswh.KSMC].Visible = false;//科室名称
            skinDataGridView_keshi.Columns[Jc_kswh.KSMC].HeaderText = "科室名称";

            skinDataGridView_keshi.Columns[Jc_kswh.MZBZ_CODE].Visible = false;//门诊标志（与代码表关联）
            //skinDataGridView_keshi.Columns[Jc_kswh.MZBZ_CODE].HeaderText = "门诊标志（与代码表关联）";

            skinDataGridView_keshi.Columns[Jc_kswh.ZYBZ_CODE].Visible = false;//住院标志（与代码表关联）
            //skinDataGridView_keshi.Columns[Jc_kswh.ZYBZ_CODE].HeaderText = "住院标志（与代码表关联）";

            skinDataGridView_keshi.Columns[Jc_kswh.YKBZ_CODE].Visible = false;//药库标志（与代码表关联）
            //skinDataGridView_keshi.Columns[Jc_kswh.YKBZ_CODE].HeaderText = "药库标志（与代码表关联）";

            skinDataGridView_keshi.Columns[Jc_kswh.YFBZ_CODE].Visible = false;//药房标志（与代码表关联）
            //skinDataGridView_keshi.Columns[Jc_kswh.YFBZ_CODE].HeaderText = "药房标志（与代码表关联）";

            skinDataGridView_keshi.Columns[Jc_kswh.YJBZ_CODE].Visible = false;//医技标志（与代码表关联）
            //skinDataGridView_keshi.Columns[Jc_kswh.YJBZ_CODE].HeaderText = "医技标志（与代码表关联）";

            skinDataGridView_keshi.Columns[Jc_kswh.SSBZ_CODE].Visible = false;//手术标志（与代码表关联）
            //skinDataGridView_keshi.Columns[Jc_kswh.SSBZ_CODE].HeaderText = "手术标志（与代码表关联）";

            skinDataGridView_keshi.Columns[Jc_kswh.ZFBZ].Visible = false;//作废标志
            //skinDataGridView_keshi.Columns[Jc_kswh.ZFBZ].HeaderText = "作废标志";

            //#endregion UI,datagridview隐藏基本字段，end

            skinDataGridView_keshi.Columns["mzbzCode"].Visible = false;//门诊标志（与代码表关联）

            skinDataGridView_keshi.Columns["zybzCode"].Visible = false;//住院标志（与代码表关联）

            skinDataGridView_keshi.Columns["ykbzCode"].Visible = false;//药库标志（与代码表关联）

            skinDataGridView_keshi.Columns["yfbzCode"].Visible = false;//药房标志（与代码表关联）

            skinDataGridView_keshi.Columns["yjbzCode"].Visible = false;//医技标志（与代码表关联）

            skinDataGridView_keshi.Columns["ssbzCode"].Visible = false;//手术标志（与代码表关联）

            //#endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            SkinDataGridViewHelper.endDataGridView(this.skinDataGridView_keshi);

        }

        private void skinDataGridView_keshi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.selectedKeshi =(Jc_kswh) SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_keshi);
                this.Close();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


    }
}
