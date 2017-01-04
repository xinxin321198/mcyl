using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.YPKC.药品库存_库存表;
using client.Common;
using Model.Common;
using Model.YPKC;
using Model.JC;
using BLL.YPKC.药品库存;

namespace client.YPKC.药品库存
{
    public partial class YpKuCunSearch : Form
    {


        private string queryString;
        public string QueryString
        {
            get { return queryString; }
            set { queryString = value; }
        }
        /// <summary>
        /// 药品分类的code对象
        /// </summary>
        private Jc_code ypflCode;
        /// <summary>
        /// 药品分类的code对象
        /// </summary>
        public Jc_code YpflCode
        {
            get { return ypflCode; }
            set { ypflCode = value; }
        }

        private PageInfo page = null;

        private Ypkc_kc selectedYpkc_kc;
        public Ypkc_kc SelectedYpkc_kc//对调用它的界面开放的方法，使其定义的方法能在其他地方调用
        {
            get { return selectedYpkc_kc; }
            set { selectedYpkc_kc = value; }
        }

        private YpkcBLL ypkcBll = new YpkcBLLImp();

        private Jc_kswh ks = null;//要查询库存的科室对象

        public Jc_kswh Ks//开放的方法
        {
            get { return ks; }
            set { ks = value; }
        }

        /// <summary>
        /// 构造这个查询窗体
        /// </summary>
        /// <param name="ks"></param>
        public YpKuCunSearch()
        {
            InitializeComponent();
            this.initUI();
        }



        /// <summary>
        /// 传入一个要查询的库存的科室对象，构造这个查询窗体
        /// </summary>
        /// <param name="ks"></param>
        //public YpKuCunSearch(Jc_kswh ks)
        //{
        //    this.ks = ks;//把传进来的科室对象赋值给此窗体的全局科室对象
        //    InitializeComponent();
        //    this.initUI();
        //}

        private void initUI()
        {
            FormHelper.initFormForToolWindow(this);//以工具窗体的方式初始化此窗体
            SkinDataGridViewHelper.initDataGridView(skinDataGridView1);
            LabelHelper.initTitleLabel(this.label_keshi);
        }

        private void initDataGridView(string ss)
        {
            if (null == ss || "" == ss)
            {
                return;
            }
            if (this.ks==null)
            {
                throw new Exception("请传入科室的对象");
            }
            StringHelper.字符类型 flag = StringHelper.judgeStringFirstCharType(ss);
            Ypkc_kc kcParamLike = new Ypkc_kc();
            if (flag == StringHelper.字符类型.数字)
            {
                kcParamLike.Ypbh = ss;
            }
            else if (flag == StringHelper.字符类型.字母)
            {
                kcParamLike.Pym = ss.ToUpper();//拼音码转换为大写匹配相似项

            }
            else if (flag == StringHelper.字符类型.中文)
            {
                kcParamLike.Ypmc = ss;//药品名称
                kcParamLike.Yptymc = ss;//药品通用名称
            }
            else
            {
                throw new Exception("检索字符串中有不能识别的字符");
            }
            Ypkc_kc kcParam = new Ypkc_kc();
            kcParam.Zfbz = CommonCode.代码值_作废标志代码值.启用;
            kcParam.Fk_keshi_id = ks.Id;
            kcParam.Ypfl_code = this.YpflCode.Value;
            List<object> objs = ypkcBll.getListByPageForFast(kcParam, this.page, kcParamLike, null);
            SkinDataGridViewHelper.bindingList(skinDataGridView1, objs[0]);

            this.page = (PageInfo)objs[1];
            this.initPageControl();

            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //skinDataGridView1.Columns["ID"].Visible = false;//隐藏此列
            //skinDataGridView1.Columns["ID"].HeaderText = "主键";//设置列名
            //skinDataGridView1.Columns["ID"].DisplayIndex = 0;//列的顺序
            //skinDataGridView1.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）
            if (null == skinDataGridView1.DataSource)
            {
                return;
            }

            skinDataGridView1.Columns[Ypkc_kc.ID].Visible = false;//主键
            skinDataGridView1.Columns[Ypkc_kc.ID].HeaderText = "主键";

            skinDataGridView1.Columns[Ypkc_kc.FK_KESHI_ID].Visible = false;//科室外键（关联科室表）
            skinDataGridView1.Columns[Ypkc_kc.FK_KESHI_ID].HeaderText = "科室外键（关联科室表）";

            skinDataGridView1.Columns[Ypkc_kc.KSBH].Visible = false;//科室编号（冗余）
            skinDataGridView1.Columns[Ypkc_kc.KSBH].HeaderText = "科室编号（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.KSMC].Visible = false;//科室名称（冗余）
            skinDataGridView1.Columns[Ypkc_kc.KSMC].HeaderText = "科室名称（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.FK_YP_ID].Visible = false;//药品字典外键（关联药品字典表）
            skinDataGridView1.Columns[Ypkc_kc.FK_YP_ID].HeaderText = "药品字典外键（关联药品字典表）";

            //skinDataGridView1.Columns[Ypkc_kc.YPBH].Visible = false;//药品编号（冗余）
            skinDataGridView1.Columns[Ypkc_kc.YPBH].HeaderText = "药品编号（冗余）";

            //skinDataGridView1.Columns[Ypkc_kc.YPMC].Visible = false;//药品名称（冗余）
            skinDataGridView1.Columns[Ypkc_kc.YPMC].HeaderText = "药品名称（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.YPTYMC].Visible = false;//药品通用名称（冗余）
            skinDataGridView1.Columns[Ypkc_kc.YPTYMC].HeaderText = "药品通用名称（冗余）";

            //skinDataGridView1.Columns[Ypkc_kc.YPGG].Visible = false;//药品规格（冗余）
            skinDataGridView1.Columns[Ypkc_kc.YPGG].HeaderText = "药品规格（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.JX].Visible = false;//剂型（冗余）
            skinDataGridView1.Columns[Ypkc_kc.JX].HeaderText = "剂型（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.PYM].Visible = false;//拼音码（冗余）
            skinDataGridView1.Columns[Ypkc_kc.PYM].HeaderText = "拼音码（冗余）";

            //skinDataGridView1.Columns[Ypkc_kc.DDW].Visible = false;//大单位（冗余）
            skinDataGridView1.Columns[Ypkc_kc.DDW].HeaderText = "大单位（冗余）";

            //skinDataGridView1.Columns[Ypkc_kc.XDW].Visible = false;//小单位（冗余）
            skinDataGridView1.Columns[Ypkc_kc.XDW].HeaderText = "小单位（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.DWLX_CODE].Visible = false;//药品单位类型（关联代码表，单位类型）
            skinDataGridView1.Columns[Ypkc_kc.DWLX_CODE].HeaderText = "药品单位类型（关联代码表，单位类型）";

            skinDataGridView1.Columns[Ypkc_kc.HSBL].Visible = false;//换算比例（冗余）
            skinDataGridView1.Columns[Ypkc_kc.HSBL].HeaderText = "换算比例（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.PZWH].Visible = false;//批准文号（冗余）
            skinDataGridView1.Columns[Ypkc_kc.PZWH].HeaderText = "批准文号（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.GYZZ].Visible = false;//国药准字（冗余）
            skinDataGridView1.Columns[Ypkc_kc.GYZZ].HeaderText = "国药准字（冗余）";

            skinDataGridView1.Columns[Ypkc_kc.CJMC].Visible = false;//生产厂家名称（冗余）
            skinDataGridView1.Columns[Ypkc_kc.CJMC].HeaderText = "生产厂家名称（冗余）";

            //skinDataGridView1.Columns[Ypkc_kc.PH].Visible = false;//批号
            skinDataGridView1.Columns[Ypkc_kc.PH].HeaderText = "批号";

            //skinDataGridView1.Columns[Ypkc_kc.YXQ].Visible = false;//有效期
            skinDataGridView1.Columns[Ypkc_kc.YXQ].HeaderText = "有效期";
            skinDataGridView1.Columns[Ypkc_kc.YXQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            //skinDataGridView1.Columns[Ypkc_kc.JJ].Visible = false;//进价
            skinDataGridView1.Columns[Ypkc_kc.JJ].HeaderText = "进价";

            skinDataGridView1.Columns[Ypkc_kc.LSJ].Visible = false;//零售价
            skinDataGridView1.Columns[Ypkc_kc.LSJ].HeaderText = "零售价";

            //skinDataGridView1.Columns[Ypkc_kc.SL].Visible = false;//数量
            skinDataGridView1.Columns[Ypkc_kc.SL].HeaderText = "数量";

            skinDataGridView1.Columns[Ypkc_kc.YKSL].Visible = false;//预扣数量
            skinDataGridView1.Columns[Ypkc_kc.YKSL].HeaderText = "预扣数量";

            skinDataGridView1.Columns[Ypkc_kc.ZFBZ].Visible = false;//作废标志
            skinDataGridView1.Columns[Ypkc_kc.ZFBZ].HeaderText = "作废标志";
            skinDataGridView1.Columns[Ypkc_kc.YPFL_CODE].Visible = false;//药品类型（关联代码表，西药、成药、中药、卫材）
            skinDataGridView1.Columns[Ypkc_kc.YPFL_CODE].HeaderText = "药品类型（关联代码表，西药、成药、中药、卫材）";


            #endregion UI,datagridview隐藏基本字段，end

            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换
            skinDataGridView1.Columns["dwlxCode"].Visible = false;//药品单位类型（关联代码表，单位类型）
            skinDataGridView1.Columns["ypflCode"].Visible = false;//药品类型（关联代码表，西药、成药、中药、卫材）
            #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换
            SkinDataGridViewHelper.endDataGridView(skinDataGridView1);

            
        }


        private void textBox_query_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.YpflCode == null)
                {
                    return;
                }
                if (this.textBox_query.Text.Trim()==null||this.textBox_query.Text.Trim()=="")
                {
                    return;
                }
                this.QueryString = this.textBox_query.Text.Trim().ToUpper() ;
                this.page = null;
                this.initDataGridView(QueryString);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 初始化分页控件
        /// </summary>
        private void initPageControl()
        {
            toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();//当前页码
            toolStripLabel_pageCount.Text = this.page.PageCount.ToString();//总页数
            toolStripLabel_pageSize.Text = this.page.PageSize.ToString();//每页显示多少条
            toolStripLabel_allCount.Text = this.page.AllCount.ToString();//数据总数
        }

        //首页按钮的点击事件
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
                this.initDataGridView(this.queryString);//构建好page对象后刷新列表
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
                this.initDataGridView(this.queryString);//构建好page对象后刷新列表
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
                this.initDataGridView(this.queryString);//构建好page对象后刷新列表
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }



        private void YpKuCunSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;//取消关闭窗体
            this.Hide();
        }

        private void YpKuCunSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Keys key = e.KeyCode;
                if (e.Control != true)
                {//如果没按Ctrl键
                }
                if (key == Keys.Down || key == Keys.Up)
                {
                    skinDataGridView1.Focus();
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

        /// <summary>
        /// 选中药品，并且关闭窗体
        /// </summary>
        private void selectedYp()
        {
            this.selectedYpkc_kc = (Ypkc_kc)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView1);
                this.queryString = null;
                this.ks = null;
                this.Close();
        }

        private void skinDataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                selectedYp();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void YpKuCunSearch_Activated(object sender, EventArgs e)
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

        private void skinDataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Keys key = e.KeyCode;
                if (e.Control != true)
                {//如果没按Ctrl键
                }

                if (key == Keys.Enter)
                {
                    selectedYp();
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void YpKuCunSearch_Load(object sender, EventArgs e)
        {
            try
            {
                textBox_query.Clear() ;
                this.label_keshi.Text = this.ks.Ksmc;
                textBox_query.Text = this.QueryString;
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
    }
}
