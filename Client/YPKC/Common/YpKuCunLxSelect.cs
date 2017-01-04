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
using BLL.JC.基础_代码字典;
using BLL.JC.代码;
using client.Common;
using Model.Common;

namespace client.YPKC.Common
{
    public partial class YpKuCunLxSelect : Form
    {
        private Jc_code selectedYpKuCunLx;

        public Jc_code SelectedYpKuCunLx
        {
            get { return selectedYpKuCunLx; }
            set { selectedYpKuCunLx = value; }
        }

        private Jc_codeBLL jc_codeBll = new Jc_codeBLLImp();
        private CodeBLL codeBll = new CodeBLLImp();

        public YpKuCunLxSelect()
        {
            InitializeComponent();
            FormHelper.initFormForToolWindow(this);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SelectedYpKuCunLx = new Jc_codeBLLImp().getById("2228329E288C4FA8A3833A0008996FE5");
            this.Close();
        }

        private void YpKuCunLxSelect_Load(object sender, EventArgs e)
        {
            try
            {

                List<Jc_code> codeList = codeBll.getListByCodeTypeValue(CommonCode.代码类型值.药品_分类);
                SkinDataGridViewHelper.bindingList(skinDataGridView1, codeList);

                  #region UI,datagridview隐藏基本字段，start
                //隱藏列start
                //.Columns["ID"].Visible = false;//隐藏此列
                //.Columns["ID"].HeaderText = "主键";//设置列名
                //.Columns["ID"].DisplayIndex = 0;//列的顺序
                //.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

                skinDataGridView1.Columns[Jc_code.ID].Visible = false;//主键
                skinDataGridView1.Columns[Jc_code.ID].HeaderText = "主键";

                //skinDataGridView1.Columns[Jc_code.NAME].Visible = false;//代码名称
                skinDataGridView1.Columns[Jc_code.NAME].HeaderText = "单据类型";

                skinDataGridView1.Columns[Jc_code.VALUE].Visible = false;//代码值
                skinDataGridView1.Columns[Jc_code.VALUE].HeaderText = "代码值";

                skinDataGridView1.Columns[Jc_code.FK_CODE_TYPE].Visible = false;//代码所属类型(关联到代码类型表id)
                skinDataGridView1.Columns[Jc_code.FK_CODE_TYPE].HeaderText = "代码所属类型(关联到代码类型表id)";

                skinDataGridView1.Columns[Jc_code.PYM].Visible = false;//拼音码
                skinDataGridView1.Columns[Jc_code.PYM].HeaderText = "拼音码";

                skinDataGridView1.Columns[Jc_code.WBM].Visible = false;//五笔码
                skinDataGridView1.Columns[Jc_code.WBM].HeaderText = "五笔码";

                skinDataGridView1.Columns[Jc_code.REMARK].Visible = false;//备注
                skinDataGridView1.Columns[Jc_code.REMARK].HeaderText = "备注";

                skinDataGridView1.Columns[Jc_code.ZFBZ].Visible = false;//作废废标志（0禁用，1启用）
                skinDataGridView1.Columns[Jc_code.ZFBZ].HeaderText = "作废废标志（0禁用，1启用）";
                skinDataGridView1.Columns[Jc_code.SORT].Visible = false;

                #endregion UI,datagridview隐藏基本字段，end
                skinDataGridView1.Columns["Jc_code_type"].Visible = false;
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }

        }

        private void skinDataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.selectedYpKuCunLx = (Jc_code)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView1);
                this.Close();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
    }
}
