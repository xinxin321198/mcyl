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
using Model.RBAC;

namespace client.JC.供应商
{
    public partial class GysMgr : Form
    {
        private Jc_gysBLL gysBLL = new Jc_gysBLLImp();
        private Main main = null;//主窗体引用

        private PageInfo page = null;

        public GysMgr()
        {
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_gys);
            SkinButtonHelper.initButton(skinButton新增);
        }
        public GysMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            this.initUI();

        }

       
        private void GysMgr_Load(object sender, EventArgs e)
        {
            try
            {
                this.initDataGridView_gys();
                
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
         private void initUI()
        {
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_gys);
            SkinButtonHelper.initButton(skinButton新增);

            
            
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

        private void initDataGridView_gys()
        {
            //Jc_gys gysLike = new Jc_gys();//模糊查询参数
            //gysLike.Pym = "df";

            //List<SortInfo> sortList = new List<SortInfo>();//排序参数
            //sortList.Add(new SortInfo("DZ", "desc"));

            List<object> objs = gysBLL.getListContactObjectByPage(null, this.page, null, null);
            List<Jc_gys> gysList = (List<Jc_gys>)objs[0];
            this.page = (PageInfo)objs[1];//分页
            SkinDataGridViewHelper.bindingList(skinDataGridView_gys, gysList);
            this.initPageControl();

            if (skinDataGridView_gys.DataSource == null)
            {
                return;
            }
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

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_gys, "lxCode", "lxCodeName", "供应商类型", CommonCode.实体类名称.基础_代码字典实体类名);

            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）
            SkinDataGridViewHelper.endDataGridView(skinDataGridView_gys);
        }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MyMessageBox.Show("工作人员不允许删除，请设为禁用");
            try
            {
                Jc_gys gys = (Jc_gys)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_gys);
                DialogResult dr = MessageBox.Show(@"是否删除""" + gys.Gysbh + @"""", "提示", MessageBoxButtons.YesNo);
                if ("Yes" != dr.ToString())//如果用户点击NO，就不删除
                {
                    return;
                }
                bool flag = gysBLL.deleteById(gys.Id);
                if (flag)
                {
                    MyMessageBox.Show("删除成功");
                }
                else
                {
                    MyMessageBox.Show("删除失败");
                }
                this.page = null;
                this.initDataGridView_gys();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
        private void button新增_Click(object sender, EventArgs e)
        {
            GysEdit gysedit = new GysEdit();
            gysedit.ShowDialog();
            this.page = null;
            initDataGridView_gys();
        }

        private void dataGridView_gys_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Jc_gys gys = (Jc_gys)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_gys);
                GysEdit gysEdit = new GysEdit(gys);
                gysEdit.ShowDialog();
                this.initDataGridView_gys();
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
                this.initDataGridView_gys();
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

                this.initDataGridView_gys();
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
                this.initDataGridView_gys();
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
                this.initDataGridView_gys();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)//测试模糊查询时使用
        {
            GysSearch gysSearch = new GysSearch();
            gysSearch.ShowDialog();
            //this.page = null;
            initDataGridView_gys();
        }





    }
}
