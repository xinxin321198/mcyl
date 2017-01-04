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
using BLL.RBAC.RBAC_用户;
using Model.RBAC;
using BLL.RBAC.权限;


namespace client.JC.登录用户管理
{
    public partial class UserMgr : Form
    {
        Rbac_userBLL userBLL = new Rbac_userBLLImp();
        private PermissionsBLL permissionsBll = new PermissionsBLLImp();

        PageInfo page = null;
        private Main main = null;//主窗体引用

        public UserMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(this.skinButton_add, this.skinButton_role);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_user);
        }

        private void UserMgr_Load(object sender, EventArgs e)
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

        /// <summary>
        /// 初始化界面
        /// </summary>
        private void initUI()
        {

            this.initDataGridViewUser();
        }
        private void initPageControl()
        {
            //分页控件
            toolStripLabel_currentPage.Text = page.CurrentPage.ToString();
            toolStripLabel_allCount.Text = page.AllCount.ToString();
            toolStripLabel_pageCount.Text = page.PageCount.ToString(); ;
            toolStripLabel_pageSize.Text = page.PageSize.ToString();
            toolStrip_page.Dock = DockStyle.Bottom;
        }
        /// <summary>
        /// 初始化datagridview
        /// </summary>
        private void initDataGridViewUser()
        {
            List<object> objs = userBLL.getListContactObjectByPage(null, this.page, null, null);
            SkinDataGridViewHelper.bindingList(skinDataGridView_user, objs[0]);

            this.page = (PageInfo)objs[1];
            this.initPageControl();

            if (skinDataGridView_user.DataSource == null)
            {
                return;
            }

            #region UI,datagridview隐藏基本字段，start
        //隱藏列start
        //.Columns["ID"].Visible = false;//隐藏此列
        //.Columns["ID"].HeaderText = "主键";//设置列名
        //.Columns["ID"].DisplayIndex = 0;//列的顺序
        //.Columns["CSRQ"].DefaultCellStyle.Format = BLL.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

        skinDataGridView_user.Columns[Rbac_user.ID].Visible = false;//主键
        skinDataGridView_user.Columns[Rbac_user.ID].HeaderText = "主键";
        //dataGridView_user.Columns[Rbac_user.NAME].Visible = false;//账号
        skinDataGridView_user.Columns[Rbac_user.NAME].HeaderText = "账号";
        skinDataGridView_user.Columns[Rbac_user.PWD].Visible = false;//密码
        skinDataGridView_user.Columns[Rbac_user.PWD].HeaderText = "密码";
        skinDataGridView_user.Columns[Rbac_user.LX_CODE].Visible = false;//账户类型（关联代码表）
        skinDataGridView_user.Columns[Rbac_user.LX_CODE].HeaderText = "账户类型（关联代码表）";
        skinDataGridView_user.Columns[Rbac_user.ZFBZ].Visible = false;//作废标志（0为禁用，1为启用）
        skinDataGridView_user.Columns[Rbac_user.ZFBZ].HeaderText = "作废标志（0为禁用，1为启用）";
        //dataGridView_user.Columns[Rbac_user.CJRQ].Visible = false;//创建日期
        skinDataGridView_user.Columns[Rbac_user.CJRQ].HeaderText = "创建日期";
        skinDataGridView_user.Columns[Rbac_user.REMARK].Visible = false;//密码
        skinDataGridView_user.Columns[Rbac_user.REMARK].HeaderText = "备注";
        skinDataGridView_user.Columns[Rbac_user.CJRQ].DefaultCellStyle.Format = Model.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

        #endregion UI,datagridview隐藏基本字段，end

        #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）


        SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_user, "lxCode", "lxCodeName", "账户类型（关联代码表）", CommonCode.实体类名称.基础_代码字典实体类名);

        #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

        #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

        //.Columns["jc_renyuan"].Visible = false;//所属人员(人员表外键)

        //.Columns["lxCode"].Visible = false;//账户类型（关联代码表）

        #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换


        SkinDataGridViewHelper.endDataGridView(skinDataGridView_user);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            UserEdit userEdit = new UserEdit();
            userEdit.ShowDialog();
            this.page = null;
            this.initDataGridViewUser();
        }


        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Rbac_user userDel = (Rbac_user)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_user);
                DialogResult dr = MessageBox.Show(@"是否删除""" + userDel.Name + @"""", "提示", MessageBoxButtons.YesNo);
                if ("Yes" != dr.ToString())//如果用户点击NO，就不删除
                {
                    return;
                }
                bool flag = permissionsBll.deleteAndRelationByUserId(userDel.Id);
                if (flag)
                {
                    MyMessageBox.Show("删除成功");
                }
                else
                {
                    MyMessageBox.Show("删除失败");
                }
                this.page = null;
                this.initDataGridViewUser();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }



        private void dataGridView_user_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Rbac_user user = (Rbac_user)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_user);
                UserEdit userEdit = new UserEdit(user);
                userEdit.ShowDialog();
                this.initUI();
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
                this.initDataGridViewUser();
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

                this.initDataGridViewUser();
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
                this.initDataGridViewUser();
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
                this.initDataGridViewUser();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void button_role_Click(object sender, EventArgs e)
        {
            try
            {
                Rbac_user user = Rbac_user.ConvertToRbac_user(SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_user));
                UserRole ur = new UserRole(user);
                ur.ShowDialog();
            }
            catch (Exception ex)
            {
                
                MyMessageBox.Show(ex.Message);

            }
        }




    }
}
