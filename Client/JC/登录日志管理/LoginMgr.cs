using client.Common;
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
using BLL.JC.基础_用户登录日志;

namespace client.JC.登录日志管理
{
    public partial class LoginMgr : Form
    {
        private Main main = null;

        private PageInfo page = null;

        private Jc_loginBLL loginBll = new Jc_loginBLLImp();

        public LoginMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView1);
        }

        private void LoginMgr_Load(object sender, EventArgs e)
        {
            try
            {
                this.initDataGridView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void initDataGridView()
        {
            List<SortInfo> sortList = new List<SortInfo>();
            sortList.Add(new SortInfo(Jc_login.LOGIN_DATE,SortInfo.倒序));
            List<object> objs = loginBll.getListByPage(null,this.page, null, sortList);
            List<Jc_login> loginList = (List<Jc_login>)objs[0];
            this.page = (PageInfo)objs[1];
            this.initPageControl();
            SkinDataGridViewHelper.bindingList(skinDataGridView1, loginList);

            if (skinDataGridView1.DataSource == null)
            {
                return;
            }
            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //skinDataGridView1.Columns["ID"].Visible = false;//隐藏此列
            //skinDataGridView1.Columns["ID"].HeaderText = "主键";//设置列名
            //skinDataGridView1.Columns["ID"].DisplayIndex = 0;//列的顺序
            //skinDataGridView1.Columns["CSRQ"].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView1.Columns[Jc_login.ID].Visible = false;//主键
            skinDataGridView1.Columns[Jc_login.ID].HeaderText = "主键";

            skinDataGridView1.Columns[Jc_login.FK_USER_ID].Visible = false;//用户外键
            skinDataGridView1.Columns[Jc_login.FK_USER_ID].HeaderText = "用户外键";

            //skinDataGridView1.Columns[Jc_login.USER_NAME].Visible = false;//登录账户（冗余）
            skinDataGridView1.Columns[Jc_login.USER_NAME].HeaderText = "登录账户";

            skinDataGridView1.Columns[Jc_login.FK_RENYUAN_ID].Visible = false;//人员外键
            skinDataGridView1.Columns[Jc_login.FK_RENYUAN_ID].HeaderText = "人员外键";

            //skinDataGridView1.Columns[Jc_login.RENYUAN_NAME].Visible = false;//人员姓名（冗余）
            skinDataGridView1.Columns[Jc_login.RENYUAN_NAME].HeaderText = "人员姓名";

            //skinDataGridView1.Columns[Jc_login.LOGIN_IP].Visible = false;//登录ip地址
            skinDataGridView1.Columns[Jc_login.LOGIN_IP].HeaderText = "登录ip地址";

            //skinDataGridView1.Columns[Jc_login.LOGIN_DATE].Visible = false;//登录时间
            skinDataGridView1.Columns[Jc_login.LOGIN_DATE].HeaderText = "登录时间";
            skinDataGridView1.Columns[Jc_login.LOGIN_DATE].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateTimeFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView1.Columns[Jc_login.ZFBZ].Visible = false;//作废标志
            skinDataGridView1.Columns[Jc_login.ZFBZ].HeaderText = "作废标志";

            #endregion UI,datagridview隐藏基本字段，end
            SkinDataGridViewHelper.endDataGridView(skinDataGridView1);

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

        private void initPageControl()
        {
            //分页控件
            toolStripLabel_currentPage.Text = this.page.CurrentPage.ToString();
            toolStripLabel_allCount.Text = this.page.AllCount.ToString();
            toolStripLabel_pageCount.Text = this.page.PageCount.ToString();
            toolStripLabel_pageSize.Text = this.page.PageSize.ToString();
            toolStrip_page.Dock = DockStyle.Bottom;
        }
    }
}
