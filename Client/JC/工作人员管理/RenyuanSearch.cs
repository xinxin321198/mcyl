using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.JC.基础_工作人员;
using client.Common;
using Model.Common;
using Model.JC;

namespace client.JC.工作人员管理
{
    public partial class RenyuanSearch : Form
    {
         private Jc_renyuanBLL renyuanBll = new Jc_renyuanBLLImp();
        private PageInfo page = null;

        private Jc_renyuan selectedRenyuan = null;

        public Jc_renyuan SelectedRenyuan
        {
            get { return selectedRenyuan; }
            set { selectedRenyuan = value; }
        }
        private string queryString;
        public string QueryString
        {
            get { return queryString; }
            set { queryString = value; }
        }
        public RenyuanSearch()
        {
            InitializeComponent();
            this.initUI();
        }
        private void initUI()
        {
            FormHelper.initFormForToolWindow(this);//以工具窗体的方式初始化此窗体
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_renyuan);

        }
        /// <summary>
        /// 初始化分页控件
        /// </summary>
        private void initPageControl_ryType()
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
            Jc_renyuan renyuanParamLike = new Jc_renyuan();
            if (flag == StringHelper.字符类型.数字)
            {
                renyuanParamLike.Sfzh = ss;//身份证号码
                //renyuanParamLike.Qq = ss;//qq
                
            }
            else if (flag == StringHelper.字符类型.字母)
            {
                renyuanParamLike.Pym = ss.ToUpper();//拼音码转换为大写匹配相似项

            }
            else if (flag == StringHelper.字符类型.中文)
            {
                renyuanParamLike.Xm = ss;//姓名
               
            }
            else
            {
                throw new Exception("检索字符串中有不能识别的字符");
            }
            Jc_renyuan renyuanParam = new Jc_renyuan();
            renyuanParam.Zfbz = CommonCode.代码值_作废标志代码值.启用;
            List<object> objs = renyuanBll.getListByPage(renyuanParam, this.page, renyuanParamLike, null);
            SkinDataGridViewHelper.bindingList(skinDataGridView_renyuan, objs[0]);

            this.page = (PageInfo)objs[1];
            this.initPageControl_ryType();
           

            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //skinDataGridView_renyuan.Columns["ID"].Visible = false;//隐藏此列
            //skinDataGridView_renyuan.Columns["ID"].HeaderText = "主键";//设置列名
            //skinDataGridView_renyuan.Columns["ID"].DisplayIndex = 0;//列的顺序
            //skinDataGridView_renyuan.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_renyuan.Columns[Jc_renyuan.ID].Visible = false;//主键
            skinDataGridView_renyuan.Columns[Jc_renyuan.ID].HeaderText = "主键";

            //skinDataGridView_renyuan.Columns[Jc_renyuan.XM].Visible = false;//姓名
            skinDataGridView_renyuan.Columns[Jc_renyuan.XM].HeaderText = "姓名";

            skinDataGridView_renyuan.Columns[Jc_renyuan.XB_CODE].Visible = false;//性别（关联基础字典表）
            skinDataGridView_renyuan.Columns[Jc_renyuan.XB_CODE].HeaderText = "性别（关联基础字典表）";

            skinDataGridView_renyuan.Columns[Jc_renyuan.MZ_CODE].Visible = false;//民族（关联基础字典表）
            skinDataGridView_renyuan.Columns[Jc_renyuan.MZ_CODE].HeaderText = "民族（关联基础字典表）";

            skinDataGridView_renyuan.Columns[Jc_renyuan.CSRQ].Visible = false;//出生日期
            skinDataGridView_renyuan.Columns[Jc_renyuan.CSRQ].HeaderText = "出生日期";
            skinDataGridView_renyuan.Columns[Jc_renyuan.CSRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_renyuan.Columns[Jc_renyuan.SFZH].Visible = false;//身份证号
            skinDataGridView_renyuan.Columns[Jc_renyuan.SFZH].HeaderText = "身份证号";

            skinDataGridView_renyuan.Columns[Jc_renyuan.ZZMM_CODE].Visible = false;//政治面貌（关联基础字典表）
            skinDataGridView_renyuan.Columns[Jc_renyuan.ZZMM_CODE].HeaderText = "政治面貌（关联基础字典表）";

            skinDataGridView_renyuan.Columns[Jc_renyuan.HYZK_CODE].Visible = false;//婚姻状况（关联基础字典表）
            skinDataGridView_renyuan.Columns[Jc_renyuan.HYZK_CODE].HeaderText = "婚姻状况（关联基础字典表）";

            skinDataGridView_renyuan.Columns[Jc_renyuan.BYXX].Visible = false;//毕业学校
            skinDataGridView_renyuan.Columns[Jc_renyuan.BYXX].HeaderText = "毕业学校";

            skinDataGridView_renyuan.Columns[Jc_renyuan.XL_CODE].Visible = false;//学历（关联基础字典表）
            skinDataGridView_renyuan.Columns[Jc_renyuan.XL_CODE].HeaderText = "学历（关联基础字典表）";

            //skinDataGridView_renyuan.Columns[Jc_renyuan.CJGZSJ].Visible = false;//参加工作时间
            skinDataGridView_renyuan.Columns[Jc_renyuan.CJGZSJ].HeaderText = "参加工作时间";
            skinDataGridView_renyuan.Columns[Jc_renyuan.CJGZSJ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_renyuan.Columns[Jc_renyuan.ZY].Visible = false;//专业
            skinDataGridView_renyuan.Columns[Jc_renyuan.ZY].HeaderText = "专业";

            skinDataGridView_renyuan.Columns[Jc_renyuan.JG].Visible = false;//籍贯
            skinDataGridView_renyuan.Columns[Jc_renyuan.JG].HeaderText = "籍贯";

            skinDataGridView_renyuan.Columns[Jc_renyuan.DZ].Visible = false;//地址
            skinDataGridView_renyuan.Columns[Jc_renyuan.DZ].HeaderText = "地址";

            //skinDataGridView_renyuan.Columns[Jc_renyuan.LXDH].Visible = false;//联系电话
            skinDataGridView_renyuan.Columns[Jc_renyuan.LXDH].HeaderText = "联系电话";

            skinDataGridView_renyuan.Columns[Jc_renyuan.QQ].Visible = false;//qq
            skinDataGridView_renyuan.Columns[Jc_renyuan.QQ].HeaderText = "qq";

            //skinDataGridView_renyuan.Columns[Jc_renyuan.YX].Visible = false;//邮箱
            skinDataGridView_renyuan.Columns[Jc_renyuan.YX].HeaderText = "邮箱";

            //skinDataGridView_renyuan.Columns[Jc_renyuan.BZ].Visible = false;//备注
            skinDataGridView_renyuan.Columns[Jc_renyuan.BZ].HeaderText = "备注";

            skinDataGridView_renyuan.Columns[Jc_renyuan.PYM].Visible = false;//拼音码
            skinDataGridView_renyuan.Columns[Jc_renyuan.PYM].HeaderText = "拼音码";

            skinDataGridView_renyuan.Columns[Jc_renyuan.WBM].Visible = false;//五笔码
            skinDataGridView_renyuan.Columns[Jc_renyuan.WBM].HeaderText = "五笔码";

            skinDataGridView_renyuan.Columns[Jc_renyuan.RYLX_CODE].Visible = false;//人员类型（关联基础字典表）
            skinDataGridView_renyuan.Columns[Jc_renyuan.RYLX_CODE].HeaderText = "人员类型（关联基础字典表）";

            skinDataGridView_renyuan.Columns[Jc_renyuan.ZFBZ].Visible = false;//作废标志（0是禁用，1是启用）
            skinDataGridView_renyuan.Columns[Jc_renyuan.ZFBZ].HeaderText = "作废标志（0是禁用，1是启用）";

            #endregion UI,datagridview隐藏基本字段，end

            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_renyuan, "xbCode", "xbCodeName", "性别", CommonCode.实体类名称.基础_代码字典实体类名);

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_renyuan, "mzCode", "mzCodeName", "民族", CommonCode.实体类名称.基础_代码字典实体类名);

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_renyuan, "zzmmCode", "zzmmCodeName", "政治面貌", CommonCode.实体类名称.基础_代码字典实体类名);

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_renyuan, "hyzkCode", "hyzkCodeName", "婚姻状况", CommonCode.实体类名称.基础_代码字典实体类名);

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_renyuan, "xlCode", "xlCodeName", "学历", CommonCode.实体类名称.基础_代码字典实体类名);

            //SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_renyuan, "rylxCode", "rylxCodeName", "人员类型", CommonCode.实体类名称.基础_代码字典实体类名);

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            skinDataGridView_renyuan.Columns["xbCode"].Visible = false;//性别（关联基础字典表）

            skinDataGridView_renyuan.Columns["mzCode"].Visible = false;//民族（关联基础字典表）

            skinDataGridView_renyuan.Columns["zzmmCode"].Visible = false;//政治面貌（关联基础字典表）

            skinDataGridView_renyuan.Columns["hyzkCode"].Visible = false;//婚姻状况（关联基础字典表）

            skinDataGridView_renyuan.Columns["xlCode"].Visible = false;//学历（关联基础字典表）

            skinDataGridView_renyuan.Columns["rylxCode"].Visible = false;//人员类型（关联基础字典表）

            #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            SkinDataGridViewHelper.endDataGridView(skinDataGridView_renyuan);
        

        }
        private void RenyuanSearch_Load(object sender, EventArgs e)
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
        private void RenyuanSearch_Activated(object sender, EventArgs e)
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

        private void RenyuanSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;//取消关闭窗体
            this.Hide();
        }

        private void RenyuanSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Keys key = e.KeyCode;
                if (e.Control != true)
                {//如果没按Ctrl键
                }
                if (key == Keys.Down || key == Keys.Up)
                {
                    skinDataGridView_renyuan.Focus();
                }
                if (key == Keys.Left || key == Keys.Right)
                {
                    textBox_query.Focus();
                }
                if (key == Keys.Enter)
                {                   
                        this.selectedRenyuan = (Jc_renyuan)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_renyuan);
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

        private void skinDataGridView_renyuan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.selectedRenyuan = (Jc_renyuan)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_renyuan);
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
