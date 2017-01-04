using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.JC.基础_供应商;
using client.Common;
using Model.Common;
using Model.JC;

namespace client.JC.供应商
{
    public partial class GysSearch : Form
    {
        private PageInfo page = null;
        private Jc_gysBLL gysBll = new Jc_gysBLLImp();

        private string queryString;
        public string QueryString
        {
            get { return queryString; }
            set { queryString = value; }
        }

        private Jc_gys selectedGys = null;
        public Jc_gys SelectedGys
        {
            get { return selectedGys; }
            set { selectedGys = value; }
        }

        public GysSearch()
        {
            InitializeComponent();
            this.initUI();

        }
        private void initUI()
        {
            FormHelper.initFormForToolWindow(this);//以工具窗体的方式初始化此窗体
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_gys);

        }

        /// <summary>
        /// 初始化分页控件
        /// </summary>
        private void initPageControl_gysType()
        {
            toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前页码
            toolStripLabel_pageCount.Text = this.page.PageCount.ToString();//总页数
            toolStripLabel_pageSize.Text = this.page.PageSize.ToString();//每页显示多少条
            toolStripLabel_allCount.Text = this.page.AllCount.ToString();//数据总数
            toolStrip_IDC10TypePage.Dock = DockStyle.Bottom;

        }

        private void initDataGridView(string ss)
        {
            if (null == ss || "" == ss)
            {
                return;
            }

            StringHelper.字符类型 flag = StringHelper.judgeStringFirstCharType(ss);
            Jc_gys gysParamLike = new Jc_gys();
            if (flag == StringHelper.字符类型.数字)
            {
                gysParamLike.Gysbh = ss;//供应商编号
                

            }
            else if (flag == StringHelper.字符类型.字母)
            {
                gysParamLike.Pym = ss.ToUpper();//拼音码转换为大写匹配相似项

            }
            else if (flag == StringHelper.字符类型.中文)
            {
                gysParamLike.Gysmc= ss;//供应商名称

            }
            else
            {
                throw new Exception("检索字符串中有不能识别的字符");
            }
            Jc_gys gysParam = new Jc_gys();
            gysParam.Zfbz = CommonCode.代码值_作废标志代码值.启用;
            List<object> objs = gysBll.getListByPage(gysParam, this.page, gysParamLike, null);
            SkinDataGridViewHelper.bindingList(skinDataGridView_gys, objs[0]);

            this.page = (PageInfo)objs[1];
            this.initPageControl_gysType();

           
            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //dataGridView_gys.Columns["ID"].Visible = false;//隐藏此列
            //dataGridView_gys.Columns["ID"].HeaderText = "主键";//设置列名
            //dataGridView_gys.Columns["ID"].DisplayIndex = 0;//列的顺序
            //dataGridView_gys.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_gys.Columns[Jc_gys.ID].Visible = false;//主键
            skinDataGridView_gys.Columns[Jc_gys.ID].HeaderText = "主键";

            //dataGridView_gys.Columns[Jc_gys.GYSBH].Visible = false;//供应商编号
            skinDataGridView_gys.Columns[Jc_gys.GYSBH].HeaderText = "供应商编号";

            //dataGridView_gys.Columns[Jc_gys.GYSMC].Visible = false;//供应商名称
            skinDataGridView_gys.Columns[Jc_gys.GYSMC].HeaderText = "供应商名称";

            //dataGridView_gys.Columns[Jc_gys.PYM].Visible = false;//拼音码
            skinDataGridView_gys.Columns[Jc_gys.PYM].HeaderText = "拼音码";

            skinDataGridView_gys.Columns[Jc_gys.LX_CODE].Visible = false;//类型（关联代码表）
            skinDataGridView_gys.Columns[Jc_gys.LX_CODE].HeaderText = "类型（关联代码表）";

            //dataGridView_gys.Columns[Jc_gys.DZ].Visible = false;//地址
            skinDataGridView_gys.Columns[Jc_gys.DZ].HeaderText = "地址";

            //dataGridView_gys.Columns[Jc_gys.LXR].Visible = false;//联系人
            skinDataGridView_gys.Columns[Jc_gys.LXR].HeaderText = "联系人";

            //dataGridView_gys.Columns[Jc_gys.DH].Visible = false;//电话
            skinDataGridView_gys.Columns[Jc_gys.DH].HeaderText = "电话";

            skinDataGridView_gys.Columns[Jc_gys.ZFBZ].Visible = false;//作废标识
            skinDataGridView_gys.Columns[Jc_gys.ZFBZ].HeaderText = "作废标识";

            //skinDataGridView_gys.Columns[Jc_gys.WBM].Visible = false;//五笔码
            skinDataGridView_gys.Columns[Jc_gys.WBM].HeaderText = "五笔码";

            #endregion UI,datagridview隐藏基本字段，end

            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_gys, "lxCode", "lxCodeName", "类型（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            skinDataGridView_gys.Columns["lxCode"].Visible = false;//类型（关联代码表）

            #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_gys);


        }
        private void GysSearch_Load(object sender, EventArgs e)
        {
            try
            {
                textBox_query.Clear();
                textBox_query.Text = this.QueryString;

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
        private void GysSearch_Activated(object sender, EventArgs e)
        {
            try
            {

                TextBoxHelper.setTextBoxSelectionEnd(textBox_query);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void GysSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;//取消关闭窗体
            this.Hide();
        }

        private void GysSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Keys key = e.KeyCode;
                if (e.Control != true)
                {//如果没按Ctrl键
                }
                if (key == Keys.Down || key == Keys.Up)
                {
                    skinDataGridView_gys.Focus();
                }
                if (key == Keys.Left || key == Keys.Right)
                {
                    textBox_query.Focus();
                }
                if (key == Keys.Enter)
                {
                    
                        this.selectedGys = (Jc_gys)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_gys);
                        this.queryString = null;
                        this.Close();
                   
                }
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
                this.page.CurrentPage = 1;//当前页设为第一页
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前所在页
                this.initDataGridView(this.queryString);//构建好page对象后刷新列表
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
                this.page.CurrentPage = this.page.PrevPage;//当前页设为上一页
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前所在页
                this.initDataGridView(this.queryString);//构建好page对象后刷新列表
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
                this.page.CurrentPage = this.page.NextPage;//当前页设为下一页
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前所在页
                this.initDataGridView(this.queryString);//构建好page对象后刷新列表
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
                this.page.CurrentPage = this.page.PageCount;//当前页设为末尾页页
                this.toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前所在页
                this.initDataGridView(this.queryString);//构建好page对象后刷新列表
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinDataGridView_gys_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.selectedGys = (Jc_gys)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_gys);
                this.queryString = null;
                this.Close();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void textBox_query_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (this.textBox_query.Text.Trim() == null || this.textBox_query.Text.Trim() == "")
                {
                    return;
                }
                this.QueryString = this.textBox_query.Text.Trim().ToUpper();
                this.page = null;
                this.initDataGridView(QueryString);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
    }
}
