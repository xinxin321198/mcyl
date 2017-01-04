using Model.JC;
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
using Model.RBAC;
using BLL.JC.基础_IDC10疾病种类;
using BLL.JC.基础_ICD10;

namespace client.JC.基础_ICD10国际疾病分类管理
{
    public partial class ICD10TypeMgr : Form
    {
        private Main main = null;//主窗体引用
        private Jc_icd10_typeBLL icdtypebll = new Jc_icd10_typeBLLImp();
        private PageInfo page = null;

        private Jc_icd10BLL icd10Bll = new Jc_icd10BLLImp();
        private PageInfo icd10Page = null;
        public ICD10TypeMgr()
        {
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_icd10Add,skinButton_icd10ExcelImport);
        }
        public ICD10TypeMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(skinButton_icd10Add, skinButton_icd10ExcelImport);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICD10TypeImportForExcel importExcel = new ICD10TypeImportForExcel();
            importExcel.ShowDialog();
            this.initDataGridView_icd10Type();
        }


        /// <summary>
        /// 初始化分页控件
        /// </summary>
        private void initPageControl_icd10Type()
        {
            toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前页码
            toolStripLabel_pageCount.Text = this.page.PageCount.ToString();//总页数
            toolStripLabel_pageSize.Text = this.page.PageSize.ToString();//每页显示多少条
            toolStripLabel_allCount.Text = this.page.AllCount.ToString();//数据总数
            toolStrip_IDC10TypePage.Dock = DockStyle.Bottom;

        }


        private void ICD10Mgr_Load(object sender, EventArgs e)
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
            this.initDataGridView_icd10Type();
            this.initPageControl_icd10Type();
            this.initDataGridView_icd10();
            this.initPageControl_icd10();

        }

        private void initDataGridView_icd10()
        {
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_icd10);
            List<SortInfo> sortParam = new List<SortInfo>();
            sortParam.Add(new SortInfo(Jc_icd10.ICD10_CODE));
            List<object> objs = icd10Bll.getListByPage(null, this.icd10Page, null, sortParam);
            SkinDataGridViewHelper.bindingList(skinDataGridView_icd10, objs[0]);

            this.icd10Page = (PageInfo)objs[1];


            if (skinDataGridView_icd10.DataSource == null)
            {
                return;
            }
                    //隱藏列start
        //.Columns["ID"].Visible = false;//隐藏此列
        //.Columns["ID"].HeaderText = "主键";//设置列名
        //.Columns["ID"].DisplayIndex = 0;//列的顺序
        //.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_icd10.Columns[Jc_icd10.ID].Visible = false;//主键
            skinDataGridView_icd10.Columns[Jc_icd10.ID].HeaderText = "主键";

            //skinDataGridView_icd10.Columns[Jc_icd10.ICD10_CODE].Visible = false;//icd-10编码
            skinDataGridView_icd10.Columns[Jc_icd10.ICD10_CODE].HeaderText = "icd-10编码";

            //skinDataGridView_icd10.Columns[Jc_icd10.NAME].Visible = false;//icd-10中文名称
            skinDataGridView_icd10.Columns[Jc_icd10.NAME].HeaderText = "icd-10中文名称";

            //skinDataGridView_icd10.Columns[Jc_icd10.EN_NAME].Visible = false;//icd-10英文名称
            skinDataGridView_icd10.Columns[Jc_icd10.EN_NAME].HeaderText = "icd-10英文名称";

            //skinDataGridView_icd10.Columns[Jc_icd10.PYM].Visible = false;//拼音码
            skinDataGridView_icd10.Columns[Jc_icd10.PYM].HeaderText = "拼音码";

        //dataGridView2.Columns[Jc_icd10.WBM].Visible = false;//五笔码
            skinDataGridView_icd10.Columns[Jc_icd10.WBM].HeaderText = "五笔码";

            skinDataGridView_icd10.Columns[Jc_icd10.ZFBZ].Visible = false;//作废标志
        skinDataGridView_icd10.Columns[Jc_icd10.ZFBZ].HeaderText = "作废标志";

        SkinDataGridViewHelper.endDataGridView(skinDataGridView_icd10);

        }

        /// <summary>
        /// 初始化分页控件
        /// </summary>
        private void initPageControl_icd10()
        {
            toolStripLabel_icd_currentPage.Text = this.icd10Page.CurrentPage.ToString();//当前页码
            toolStripLabel_icd_pageCount.Text = this.icd10Page.PageCount.ToString();//总页数
            toolStripLabel_icd_pageSize.Text = this.icd10Page.PageSize.ToString();//每页显示多少条
            toolStripLabel_icd_allCount.Text = this.icd10Page.AllCount.ToString();//数据总数
            toolStrip_ICD10.Dock = DockStyle.Bottom;

        }

        private void initDataGridView_icd10Type()
        {
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_icd10type);
            List<SortInfo> sortParam = new List<SortInfo>();
            sortParam.Add(new SortInfo(Jc_icd10_type.CODE));
            List<object> objs = icdtypebll.getListByPage(null, this.page, null, sortParam);
            SkinDataGridViewHelper.bindingList(skinDataGridView_icd10type, objs[0]);

            this.page =  (PageInfo)objs[1];

            if (skinDataGridView_icd10type.DataSource == null)
            {
                return;
            }

            skinDataGridView_icd10type.Columns[Jc_icd10_type.ID].Visible = false;//主键
            skinDataGridView_icd10type.Columns[Jc_icd10_type.ID].HeaderText = "主键";

            //skinDataGridView_icd10type.Columns[Jc_icd10_type.CODE].Visible = false;//疾病代码
            skinDataGridView_icd10type.Columns[Jc_icd10_type.CODE].HeaderText = "疾病代码";

            //skinDataGridView_icd10type.Columns[Jc_icd10_type.NAME].Visible = false;//疾病种类名称
            skinDataGridView_icd10type.Columns[Jc_icd10_type.NAME].HeaderText = "疾病种类名称";

            //skinDataGridView_icd10type.Columns[Jc_icd10_type.EN_NAME].Visible = false;//英文名
            skinDataGridView_icd10type.Columns[Jc_icd10_type.EN_NAME].HeaderText = "英文名";

            //skinDataGridView_icd10type.Columns[Jc_icd10_type.PYM].Visible = false;//拼音码
            skinDataGridView_icd10type.Columns[Jc_icd10_type.PYM].HeaderText = "拼音码";

            //skinDataGridView_icd10type.Columns[Jc_icd10_type.WBM].Visible = false;//五笔码
            skinDataGridView_icd10type.Columns[Jc_icd10_type.WBM].HeaderText = "五笔码";

            skinDataGridView_icd10type.Columns[Jc_icd10_type.ZFBZ].Visible = false;//作废标志
            skinDataGridView_icd10type.Columns[Jc_icd10_type.ZFBZ].HeaderText = "作废标志";


            SkinDataGridViewHelper.endDataGridView(skinDataGridView_icd10type);
        }

        private void toolStripButton_startPage_Click(object sender, EventArgs e)
        {
            try
            {
                this.page.CurrentPage = 1;
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();
                this.initDataGridView_icd10Type();
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
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();
                this.initDataGridView_icd10Type();
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
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();
                this.initDataGridView_icd10Type();
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
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();
                this.initDataGridView_icd10Type();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void button_icd10编码_Click(object sender, EventArgs e)
        {
            try
            {
                Jc_icd10_type icd10Type = (Jc_icd10_type)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_icd10);
                ICD10TypeRelation relation = new ICD10TypeRelation(icd10Type);
                relation.ShowDialog();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void button_icd10ExcelImport_Click(object sender, EventArgs e)
        {
            try
            {
                ICD10ImportForExcel icd10import = new ICD10ImportForExcel();
                icd10import.ShowDialog();
                this.page = null;

                this.initDataGridView_icd10();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton__Click(object sender, EventArgs e)
        {
            try
            {
                this.icd10Page.CurrentPage = 1;
                this.toolStripLabel_icd_currentPage.Text = this.icd10Page.CurrentPage.ToString();

                this.initDataGridView_icd10();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.icd10Page.PrevPage == 0)
                {
                    return;
                }
                this.icd10Page.CurrentPage = this.icd10Page.PrevPage;
                this.toolStripLabel_icd_currentPage.Text = this.icd10Page.CurrentPage.ToString();

                this.initDataGridView_icd10();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.icd10Page.NextPage == 0)
                {
                    return;
                }
                this.icd10Page.CurrentPage = this.icd10Page.NextPage;
                this.toolStripLabel_icd_currentPage.Text = this.icd10Page.CurrentPage.ToString();

                this.initDataGridView_icd10();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                this.icd10Page.CurrentPage = this.icd10Page.PageCount;
                this.toolStripLabel_icd_currentPage.Text = this.icd10Page.CurrentPage.ToString();

                this.initDataGridView_icd10();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ICD10Search search = new ICD10Search();
                search.ShowDialog();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skinButton_icd10Add_Click(object sender, EventArgs e)
        {
            try
            {
                ICD10Edit iCD10edit = new ICD10Edit();
                iCD10edit.ShowDialog();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinDataGridView_icd10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Jc_icd10 icd10 = (Jc_icd10)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_icd10);
                ICD10Edit iCD10edit = new ICD10Edit(icd10);
                iCD10edit.ShowDialog();
                this.initDataGridView_icd10();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ICD10TypeEdit iCD10Typeedit = new ICD10TypeEdit();
                iCD10Typeedit.ShowDialog();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }

        }

        private void skinDataGridView_icd10type_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Jc_icd10_type icd10_type = (Jc_icd10_type)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_icd10type);
                ICD10TypeEdit iCD10Typeedit = new ICD10TypeEdit(icd10_type);
                iCD10Typeedit.ShowDialog();
                this.initDataGridView_icd10Type();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }

        }
    }
}
