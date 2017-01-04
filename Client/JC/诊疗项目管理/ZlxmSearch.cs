using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.JC.基础_诊疗项目管理;
using client.Common;
using Model.Common;
using Model.JC;

namespace client.JC.诊疗项目管理
{
    public partial class ZlxmSearch : Form
    {
        private PageInfo page = null;//分页

        private Jc_zlxmBLL zlxmBll = new Jc_zlxmBLLImp();
        /// <summary>
        /// 检索
        /// </summary>
        private Jc_zlxm selectedZlxm;

        public Jc_zlxm SelectedZlxm//其他地方能调用不发生冲突
        {
            get { return selectedZlxm; }
            set { selectedZlxm = value; }
        }
        private string queryString;
        public string QueryString//使其开放，对外其他地方可以调用
        {
            get { return queryString; }
            set { queryString = value; }
        }
      

        public ZlxmSearch()
        {
            InitializeComponent();
            this.initUI();

        }
       
        private void initUI()
        {
            FormHelper.initFormForToolWindow(this);//以工具窗体的方式初始化此窗体
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_zlxm);
          
        }
        /// <summary>
        /// 初始化分页控件
        /// </summary>
        private void initPageControl_zlxmType()
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
            Jc_zlxm zlxmParamLike = new Jc_zlxm();
            if (flag == StringHelper.字符类型.数字)
            {
                zlxmParamLike.Xmbh = ss;
                //zlxmParamLike.Szm = ss;
            }
            else if (flag == StringHelper.字符类型.字母)
            {
                zlxmParamLike.Pym = ss.ToUpper();//拼音码转换为大写匹配相似项

            }
            else if (flag == StringHelper.字符类型.中文)
            {
                zlxmParamLike.Xmmc = ss;//诊疗项目名称
               
            }
            else
            {
                throw new Exception("检索字符串中有不能识别的字符");
            }
            Jc_zlxm zlxmParam = new Jc_zlxm();
            zlxmParam.Zfbz = CommonCode.代码值_作废标志代码值.启用;
            List<object> objs = zlxmBll.getListByPage(zlxmParam, this.page, zlxmParamLike, null);
            SkinDataGridViewHelper.bindingList(skinDataGridView_zlxm, objs[0]);

            this.page = (PageInfo)objs[1];
            this.initPageControl_zlxmType();

            //隱藏列start
            //.Columns["ID"].Visible = false;//隐藏此列
            //.Columns["ID"].HeaderText = "主键";//设置列名
            //.Columns["ID"].DisplayIndex = 0;//列的顺序
            //.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            #region 隐藏或显示基本字段

            skinDataGridView_zlxm.Columns[Jc_zlxm.ID].Visible = false;//
            skinDataGridView_zlxm.Columns[Jc_zlxm.ID].HeaderText = "";

            // skinDataGridView_zlxm.Columns[Jc_zlxm.XMBH].Visible = false;//项目编码
            skinDataGridView_zlxm.Columns[Jc_zlxm.XMBH].HeaderText = "项目编码";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.XMMC].Visible = false;//项目名称
            skinDataGridView_zlxm.Columns[Jc_zlxm.XMMC].HeaderText = "项目名称";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.DW].Visible = false;//单位
            skinDataGridView_zlxm.Columns[Jc_zlxm.DW].HeaderText = "单位";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.DJ].Visible = false;//单价
            skinDataGridView_zlxm.Columns[Jc_zlxm.DJ].HeaderText = "单价";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.ZGXJ].Visible = false;//最高限价
            skinDataGridView_zlxm.Columns[Jc_zlxm.ZGXJ].HeaderText = "最高限价";

            skinDataGridView_zlxm.Columns[Jc_zlxm.FL_CODE].Visible = false;//分类(关联代码表)
            skinDataGridView_zlxm.Columns[Jc_zlxm.FL_CODE].HeaderText = "分类(关联代码表，诊疗项目分类)";

            skinDataGridView_zlxm.Columns[Jc_zlxm.FYGL_CODE].Visible = false;//费用归类(关联代码表)
            skinDataGridView_zlxm.Columns[Jc_zlxm.FYGL_CODE].HeaderText = "费用归类(关联代码表，诊疗项目费用归类)";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.PYM].Visible = false;//拼音码
            skinDataGridView_zlxm.Columns[Jc_zlxm.PYM].HeaderText = "拼音码";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.SZM].Visible = false;//数字码
            skinDataGridView_zlxm.Columns[Jc_zlxm.SZM].HeaderText = "数字码";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.XMNR].Visible = false;//项目内容
            skinDataGridView_zlxm.Columns[Jc_zlxm.XMNR].HeaderText = "项目内容";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.CWNR].Visible = false;//除外内容
            skinDataGridView_zlxm.Columns[Jc_zlxm.CWNR].HeaderText = "除外内容";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.NOTE].Visible = false;//说明
            skinDataGridView_zlxm.Columns[Jc_zlxm.NOTE].HeaderText = "说明";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.JCFF].Visible = false;//检查方法
            skinDataGridView_zlxm.Columns[Jc_zlxm.JCFF].HeaderText = "检查方法";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.BIAOZHUAN].Visible = false;//标准
            skinDataGridView_zlxm.Columns[Jc_zlxm.BIAOZHUAN].HeaderText = "标准";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.JINJIAN].Visible = false;//禁检
            skinDataGridView_zlxm.Columns[Jc_zlxm.JINJIAN].HeaderText = "禁检";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.YINJI].Visible = false;//应急
            skinDataGridView_zlxm.Columns[Jc_zlxm.YINJI].HeaderText = "应急";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.GBSJ].Visible = false;//公布时间
            skinDataGridView_zlxm.Columns[Jc_zlxm.GBSJ].HeaderText = "公布时间";
            skinDataGridView_zlxm.Columns[Jc_zlxm.GBSJ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            //skinDataGridView_zlxm.Columns[Jc_zlxm.GBJG].Visible = false;//公布机构
            skinDataGridView_zlxm.Columns[Jc_zlxm.GBJG].HeaderText = "公布机构";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.YBBM].Visible = false;//医保编码
            skinDataGridView_zlxm.Columns[Jc_zlxm.YBBM].HeaderText = "医保编码";

            //skinDataGridView_zlxm.Columns[Jc_zlxm.NHBM].Visible = false;//农合编码
            skinDataGridView_zlxm.Columns[Jc_zlxm.NHBM].HeaderText = "农合编码";

            skinDataGridView_zlxm.Columns[Jc_zlxm.NHSFLB_CODE].Visible = false;//农合收费类别(关联代码表)
            skinDataGridView_zlxm.Columns[Jc_zlxm.NHSFLB_CODE].HeaderText = "农合收费类别(关联代码表)";

            skinDataGridView_zlxm.Columns[Jc_zlxm.ZFBZ].Visible = false;//作废
            skinDataGridView_zlxm.Columns[Jc_zlxm.ZFBZ].HeaderText = "作废";
            #endregion

            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_zlxm, "flCode", "flCodeName", "诊疗项目分类", CommonCode.实体类名称.基础_代码字典实体类名);

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_zlxm, "fyglCode", "fyglCodeName", "费用归类", CommonCode.实体类名称.基础_代码字典实体类名);

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_zlxm, "nhsflbCode", "nhsflbCodeName", "农合收费类别", CommonCode.实体类名称.基础_代码字典实体类名);

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            skinDataGridView_zlxm.Columns["flCode"].Visible = false;//诊疗项目分类(关联代码表，诊疗项目分类)

            skinDataGridView_zlxm.Columns["fyglCode"].Visible = false;//费用归类(关联代码表，诊疗项目费用归类)

            skinDataGridView_zlxm.Columns["nhsflbCode"].Visible = false;//农合收费类别（关联代码表）

            #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_zlxm);

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

        private void ZlxmSearch_Load(object sender, EventArgs e)
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

        private void skinDataGridView_zlxm_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.SelectedZlxm = (Jc_zlxm)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_zlxm);
                this.queryString = null;                
                this.Hide();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void ZlxmSearch_Activated(object sender, EventArgs e)
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

        private void ZlxmSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;//取消关闭窗体
            this.Hide();
        }

        private void ZlxmSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Keys key = e.KeyCode;
                if (e.Control != true)
                {//如果没按Ctrl键
                }
                if (key == Keys.Down || key == Keys.Up)
                {
                    skinDataGridView_zlxm.Focus();
                }
                if (key == Keys.Left || key == Keys.Right)
                {
                    textBox_query.Focus();
                }
                if (key == Keys.Enter)
                {
                    this.SelectedZlxm = (Jc_zlxm)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_zlxm);
                    this.queryString = null;
                    this.Hide();
                }
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
