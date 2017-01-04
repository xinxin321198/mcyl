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
using Model.JC;
using Model.RBAC;
using Model.Common;
using BLL.RBAC;
using BLL.RBAC.权限;

namespace client.JC.登录用户管理
{
    public partial class UserRole : Form
    {

        private Rbac_user oldUser = null;

        private BLL.RBAC.RBAC_角色.Rbac_roleBLL roleBll = new BLL.RBAC.RBAC_角色.Rbac_roleBLLImp();

        private BLL.RBAC.RBAC_用户角色关系表.Rbac_user_roleBLL userRoleBll = new BLL.RBAC.RBAC_用户角色关系表.Rbac_user_roleBLLImp();

        private PermissionsBLL permissionsBll = new PermissionsBLLImp();

        public UserRole(Rbac_user user)
        {
            InitializeComponent();
            this.oldUser = user;
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(this.skinButton_save);
            SkinListViewHelper.initListView(listView_role);

        }

        private void UserRole_Load(object sender, EventArgs e)
        {
            try
            {
                if (null==this.oldUser)
                {
                    throw new Exception("非法打开窗体，请选择一个用户对象");
                }
                this.skinTextBox_username.ReadOnly = true;
                this.skinTextBox_renyuanName.ReadOnly = true;
                this.skinTextBox_username.Text = this.oldUser.Name;
                this.initListView_role();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }


        private void initListView_role()
        {


            Rbac_role roleParam = new Rbac_role();
            roleParam.Zfbz = CommonCode.代码值_作废标志代码值.启用;
            List<Rbac_role> roleList = (List<Rbac_role>)roleBll.getList(roleParam, null, null)[0];

            //准备listview的列
            ColumnHeader chIndex = new ColumnHeader();
            ColumnHeader chName = new ColumnHeader();
            ColumnHeader chRemark = new ColumnHeader();
            ColumnHeader chZfbz = new ColumnHeader();
            chIndex.Text = "索引";
            chIndex.Width = 50;
            chName.Text = "角色名称";
            chRemark.Text = "备注";
            chRemark.Width = 150;
            //chId.Text = "ID";
            //chZfbz.Text = "作废标志";
            //chZfbz.Name = "Zfbz";
            //把列添加进listview（没有的列头的那一列的值自动隐藏）
            listView_role.Columns.Add(chIndex);
            listView_role.Columns.Add(chName);
            listView_role.Columns.Add(chRemark);
            for (int i = 0; i < roleList.Count; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = i.ToString();//0
                listItem.SubItems.Add(roleList[i].Name);//1
                listItem.SubItems.Add(roleList[i].Remark);//2
                listItem.SubItems.Add(roleList[i].Zfbz);//3
                listItem.Tag = roleList[i];
                listView_role.Items.Add(listItem);//列值添加进listview
            }
            //判断是否禁用，禁用的话背景色设为红色
            SkinListViewHelper.setForeColorForControl(listView_role);


            //让用户所属的模块为选中
            List<Rbac_user_role> userRoleList = new List<Rbac_user_role>();
            Rbac_user_role userRoleParam = new Rbac_user_role();
            userRoleParam.Fk_user_id = this.oldUser.Id;
            userRoleList = (List<Rbac_user_role>)userRoleBll.getListContactObject(userRoleParam, null, null)[0];

            for (int i = 0; i < userRoleList.Count; i++)
            {
                Rbac_user_role userRole = userRoleList[i];
                for (int j = 0; j < listView_role.Items.Count; j++)
                {
                    ListViewItem item = listView_role.Items[j];
                    Rbac_role role = (Rbac_role)item.Tag;
                    if (userRole.Fk_role_id==role.Id)
                    {
                        listView_role.Items[j].Checked = true;
                    }
                }
            }
        }

        private void skinButton_save_Click(object sender, EventArgs e)
        {
            try
            {
                List<Rbac_user_role> userRoleSaveList = new List<Rbac_user_role>();
                for (int i = 0; i < listView_role.CheckedItems.Count; i++)
                {
                    Rbac_role selectedRole = (Rbac_role)listView_role.CheckedItems[i].Tag;
                    Rbac_user_role userRoleSave = new Rbac_user_role();
                    userRoleSave.Fk_role_id = selectedRole.Id;
                    userRoleSave.Fk_user_id = this.oldUser.Id;
                    userRoleSave.Zfbz = CommonCode.代码值_作废标志代码值.启用;
                    userRoleSaveList.Add(userRoleSave);
                }
                bool flag = permissionsBll.refreshUserRole(userRoleSaveList, this.oldUser.Id);

                if (flag)
                {
                    MyMessageBox.Show("保存成功");
                }
                else
                {
                    MyMessageBox.Show("保存失败");
                }
                this.Close();
                
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }
    }
}
