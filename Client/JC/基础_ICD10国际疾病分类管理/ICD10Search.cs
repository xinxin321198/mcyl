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
using BLL.JC.基础_IDC10疾病种类;
using BLL.JC.基础_ICD10编码对应疾病类型;
using BLL.JC.基础_ICD10;
using BLL.JC.ICD10;

namespace client.JC.基础_ICD10国际疾病分类管理
{
    public partial class ICD10Search : Form
    {
        private PageInfo page = null;

        private ICD10BLL icd10Bll = new ICD10BLLImp();

        private string queryString = null;

        public string QueryString
        {
            get { return queryString; }
            set { queryString = value; }
        }

        private Jc_icd10 selectedICD10 = null;

        public Jc_icd10 SelectedICD10
        {
            get { return selectedICD10; }
            set { selectedICD10 = value; }
        }


        public ICD10Search()
        {
            InitializeComponent();
            FormHelper.initForm(this);
            LabelHelper.initTitleLabel(label_msg);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_icd10);
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
        private void ICD10Search_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void initDataGridView()
        {
            if (this.queryString==null||queryString=="")
            {
                return;
            }
            Jc_icd10 icd10Like = new Jc_icd10();
            if (StringHelper.字符类型.数字 == StringHelper.judgeStringFirstCharType(queryString))
            {
                icd10Like.Icd10_code = textBox_query.Text.Trim();       
            }
            else if (StringHelper.字符类型.字母 == StringHelper.judgeStringFirstCharType(queryString))
            {
                icd10Like.Pym = textBox_query.Text.Trim().ToUpper(); 
            }
            else if (StringHelper.字符类型.中文 == StringHelper.judgeStringFirstCharType(queryString))
            {
                icd10Like.Name = textBox_query.Text.Trim();
            }
            else
            {
                throw new Exception("检索字符串中有不能识别的字符");
            }
            List<SortInfo> sortList = new List<SortInfo>();
            sortList.Add(new SortInfo(Jc_icd10.ICD10_CODE));
            List<object> objs = icd10Bll.getListByPageForFast(null, this.page, icd10Like, sortList);
            SkinDataGridViewHelper.bindingList(skinDataGridView_icd10, objs[0]);
            this.page = (PageInfo)objs[1];
            this.initPageControl_icd10Type();


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

            //dataGridView2.Columns[Jc_icd10.NAME].Visible = false;//icd-10中文名称
            skinDataGridView_icd10.Columns[Jc_icd10.NAME].HeaderText = "icd-10中文名称";

            //dataGridView2.Columns[Jc_icd10.EN_NAME].Visible = false;//icd-10英文名称
            skinDataGridView_icd10.Columns[Jc_icd10.EN_NAME].HeaderText = "icd-10英文名称";

            //skinDataGridView_icd10.Columns[Jc_icd10.PYM].Visible = false;//拼音码
            skinDataGridView_icd10.Columns[Jc_icd10.PYM].HeaderText = "拼音码";

            //skinDataGridView_icd10.Columns[Jc_icd10.WBM].Visible = false;//五笔码
            skinDataGridView_icd10.Columns[Jc_icd10.WBM].HeaderText = "五笔码";

            skinDataGridView_icd10.Columns[Jc_icd10.ZFBZ].Visible = false;//作废标志
            skinDataGridView_icd10.Columns[Jc_icd10.ZFBZ].HeaderText = "作废标志";

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_icd10);
        }

        //首页按钮的点击事件
        private void toolStripButton_startPage_Click(object sender, EventArgs e)
        {
            try
            {
                this.page.CurrentPage = 1;//当前页设为第一页
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前所在页
                this.initDataGridView();//构建好page对象后刷新列表
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        //上一页按钮的点击事件
        private void toolStripButton_prevPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.page.PrevPage == 0)
                {
                    return;
                }
                this.page.CurrentPage = this.page.PrevPage;//当前页设为上一页
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前所在页
                this.initDataGridView();//构建好page对象后刷新列表
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        //下一页按钮的点击事件
        private void toolStripButton_nextPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.page.NextPage == 0)
                {
                    return;
                }
                this.page.CurrentPage = this.page.NextPage;//当前页设为下一页
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前所在页
                this.initDataGridView();//构建好page对象后刷新列表
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        //末尾页按钮的点击事件
        private void toolStripButton_endPage_Click(object sender, EventArgs e)
        {
            try
            {
                this.page.CurrentPage = this.page.PageCount;//当前页设为末尾页页
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前所在页
                this.initDataGridView();//构建好page对象后刷新列表
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


        private void ICD10Search_Activated(object sender, EventArgs e)
        {
            textBox_query.Text = this.queryString;
            TextBoxHelper.setTextBoxSelectionEnd(textBox_query);
        }


        private void textBox_query_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.page = null;
                this.queryString = textBox_query.Text.Trim().ToUpper();
                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


        private void ICD10Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;//取消关闭窗体
            this.Hide();
        }



        private void skinDataGridView_icd10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {

                this.selectedICD10 = (Jc_icd10)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_icd10);
                this.Close();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinDataGridView_icd10_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Keys key = e.KeyCode;
                if (e.Control != true)
                {//如果没按Ctrl键
                }

                if (key == Keys.Enter)
                {
                    this.selectedICD10 = (Jc_icd10)SkinDataGridViewHelper.getKeyPreesEnterCurrentDataGridViewItem(skinDataGridView_icd10);
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void ICD10Search_KeyUp(object sender, KeyEventArgs e)
        {
            
            try
            {
                Keys key = e.KeyCode;
                if (e.Control != true)
                {//如果没按Ctrl键
                }
                if (key == Keys.Down || key == Keys.Up)
                {
                    skinDataGridView_icd10.Focus();
                }
                if (key == Keys.Left || key == Keys.Right)
                {
                    textBox_query.Focus();
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
            
        }

    
    }
}
