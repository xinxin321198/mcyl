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
using BLL.JC.基础_代码字典;

namespace client.JC.代码字典管理
{
    public partial class CodeSearch : Form
    {

        private Jc_codeBLL codeBll = new Jc_codeBLLImp();

        private Jc_code_type codeType = null;

        private PageInfo page = null;

        private Jc_code selectedCode = null;

        public Jc_code SelectedCode
        {
            get { return selectedCode; }
            set { selectedCode = value; }
        }




        public CodeSearch(Jc_code_type codeType)
        {
            this.codeType = codeType;
            InitializeComponent();
            FormHelper.initFormForToolWindow(this);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_code);

        }

        private void CodeSearch_Load(object sender, EventArgs e)
        {
            try
            {
                textBox_codeTypeName.ReadOnly = true;
                textBox_codeTypeValue.ReadOnly = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CodeSearch_Activated(object sender, EventArgs e)
        {
            this.textBox_pym.Focus();
        }

        private void initDataGridView()
        {
            Jc_code codeParam = null;
            if (null != this.codeType)
            {
                codeParam = new Jc_code();
                codeParam.Jc_code_type = this.codeType;
            }

            Jc_code codeLike = new Jc_code();
            codeLike.Pym = textBox_pym.Text.Trim().ToUpper();
            codeLike.Wbm = textBox_wbm.Text.Trim().ToUpper();

            List<SortInfo> sortList = new List<SortInfo>();
            sortList.Add(new SortInfo(Jc_code.VALUE));
            List<object> objs = codeBll.getListContactObjectByPage(codeParam, this.page, codeLike, sortList);
            SkinDataGridViewHelper.bindingList(skinDataGridView_code, objs[0]);
            this.page = (PageInfo)objs[1];


            if (skinDataGridView_code.DataSource == null)
            {
                return;
            }


            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //.Columns["ID"].Visible = false;//隐藏此列
            //.Columns["ID"].HeaderText = "主键";//设置列名
            //.Columns["ID"].DisplayIndex = 0;//列的顺序
            //.Columns["CSRQ"].DefaultCellStyle.Format = BLL.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_code.Columns[Jc_code.ID].Visible = false;//主键
            skinDataGridView_code.Columns[Jc_code.ID].HeaderText = "主键";
            //skinDataGridView_code.Columns[Jc_code.NAME].Visible = false;//代码名称
            skinDataGridView_code.Columns[Jc_code.NAME].HeaderText = "代码名称";
            //skinDataGridView_code.Columns[Jc_code.VALUE].Visible = false;//代码值
            skinDataGridView_code.Columns[Jc_code.VALUE].HeaderText = "代码值";
            skinDataGridView_code.Columns[Jc_code.FK_CODE_TYPE].Visible = false;//代码所属类型(关联到代码类型表id)
            //skinDataGridView_code.Columns[Jc_code.FK_CODE_TYPE].HeaderText = "代码所属类型(关联到代码类型表id)";
            skinDataGridView_code.Columns[Jc_code.PYM].Visible = false;//拼音码
            skinDataGridView_code.Columns[Jc_code.PYM].HeaderText = "拼音码";
            skinDataGridView_code.Columns[Jc_code.WBM].Visible = false;//五笔码
            skinDataGridView_code.Columns[Jc_code.WBM].HeaderText = "五笔码";
            //skinDataGridView_code.Columns[Jc_code.REMARK].Visible = false;//备注
            skinDataGridView_code.Columns[Jc_code.REMARK].HeaderText = "备注";
            skinDataGridView_code.Columns[Jc_code.ZFBZ].Visible = false;//作废废标志（0禁用，1启用）
            skinDataGridView_code.Columns[Jc_code.ZFBZ].HeaderText = "作废废标志（0禁用，1启用）";

            #endregion UI,datagridview隐藏基本字段，end

            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            //DataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_code, "jc_code_type", "jc_code_typeName", "代码所属类型(关联到代码类型表id)", CommonCode.实体类名称.基础_代码类型字典实体类名);

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            skinDataGridView_code.Columns["jc_code_type"].Visible = false;//代码所属类型(关联到代码类型表id)

            #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_code);

        }

        private void textBox_pym_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.page = null;
                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void textBox_wbm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.page = null;
                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton_startPage_Click(object sender, EventArgs e)
        {
            try
            {
                this.page.CurrentPage = 1;
                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton_prevPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.page.PrevPage == 0)
                {
                    return;
                }
                this.page.CurrentPage = this.page.PrevPage;

                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton_nextPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.page.NextPage == 0)
                {
                    return;
                }
                this.page.CurrentPage = this.page.NextPage;
                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton_endPage_Click(object sender, EventArgs e)
        {
            try
            {
                this.page.CurrentPage = this.page.PageCount;
                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.selectedCode = (Jc_code)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_code);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
