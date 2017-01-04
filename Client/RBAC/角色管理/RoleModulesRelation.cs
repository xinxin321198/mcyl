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
using Model.RBAC;
using BLL.RBAC.RBAC_角色;
using BLL.RBAC.RBAC_角色模块关系;
using BLL.RBAC.权限;

namespace client.RBAC.角色管理
{
    public partial class RoleModulesRelation : Form
    {
        private Rbac_role oldRole = null;

        private Rbac_role_modulesBLL roleModulesBll = new Rbac_role_modulesBLLImp();
        private PermissionsBLL permissionsBll = new PermissionsBLLImp();


        public RoleModulesRelation(Rbac_role oldRole)
        {
            this.oldRole = oldRole;
            InitializeComponent();
            FormHelper.initFormForToolWindow(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(this.skinButton_save);//初始化按钮的样式

        }


        /// <summary>
        /// 比较Rbac_role_modules类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldRbac_role_modules"></param>
        /// <param name="newRbac_role_modules"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkRbac_role_modulesIsEqual(Rbac_role_modules oldRbac_role_modules, Rbac_role_modules newRbac_role_modules)
        {
            bool flag = true;

            //角色id
            if (oldRbac_role_modules.Fk_role_id != newRbac_role_modules.Fk_role_id)
            {
                flag = false;
            }

            //模块id
            if (oldRbac_role_modules.Fk_modules_id != newRbac_role_modules.Fk_modules_id)
            {
                flag = false;
            }

            //作废标志
            if (oldRbac_role_modules.Zfbz != newRbac_role_modules.Zfbz)
            {
                flag = false;
            }

            if (!flag)
            {
                throw new Exception("没有修改数据，不需要保存");
            }
            return;
        }


        /// <summary>
        /// 校验Rbac_role_modules类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Rbac_role_modules"></param>
        private void checkRbac_role_modulesIsNull(Rbac_role_modules rbac_role_modules)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            if (null == rbac_role_modules.Id || "" == rbac_role_modules.Id)
            {
                flag = true;
                sb.Append("请指定‘主键’的值\n");
            }

            //角色id
            if (null == rbac_role_modules.Fk_role_id || "" == rbac_role_modules.Fk_role_id)
            {
                flag = true;
                sb.Append("请指定‘角色id’的值\n");
            }

            //模块id
            if (null == rbac_role_modules.Fk_modules_id || "" == rbac_role_modules.Fk_modules_id)
            {
                flag = true;
                sb.Append("请指定‘模块id’的值\n");
            }

            //作废标志
            if (null == rbac_role_modules.Zfbz || "" == rbac_role_modules.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志’的值\n");
            }

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }


        private void RoleModulesRelation_Load(object sender, EventArgs e)
        {
            try
            {
                this.skinLabel2.Text = this.oldRole.Name;
                this.initTreeView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void initTreeView()
        {
            TreeViewHelper.initTreeViewForRbac_modules(this.skinTreeView_modules,Model.Common.CommonCode.代码值_作废标志代码值.启用);
            this.skinTreeView_modules.CheckBoxes = true;

            Rbac_role_modules param = new Rbac_role_modules();
            param.Fk_role_id = this.oldRole.Id;
            List<Rbac_role_modules> roleModulesList = (List<Rbac_role_modules>)roleModulesBll.getList(param, null, null)[0];


            List<TreeNode> nodes = new List<TreeNode>();
            TreeViewHelper.getNodes(skinTreeView_modules.Nodes, nodes);
            for (int i = 0; i < nodes.Count; i++)//树控件所有节点
            {
                TreeNode node = nodes[i];
                for (int j = 0; j < roleModulesList.Count; j++)//角色所拥有的模块
                {
                    Rbac_modules nodeModules = (Rbac_modules)node.Tag;
                    Rbac_role_modules roleModules = roleModulesList[j];
                    if (nodeModules.Id == roleModules.Fk_modules_id)
                    {
                        node.Checked = true;
                    }
                }
            }
        }

        private void skinButton_save_Click(object sender, EventArgs e)
        {
            try
            {
                List<Rbac_role_modules> roleModulesList = new List<Rbac_role_modules>();
                List<TreeNode> checkedNodeList = new List<TreeNode>();
                TreeViewHelper.getNodes(this.skinTreeView_modules.Nodes, checkedNodeList);
                for (int i = 0; i < checkedNodeList.Count; i++)
                {
                    TreeNode node = checkedNodeList[i];
                    if (node.Checked)
                    {
                        Rbac_role_modules roleModlesTmp = new Rbac_role_modules();
                        roleModlesTmp.Fk_role_id = oldRole.Id;
                        Rbac_modules mod = (Rbac_modules)node.Tag;
                        roleModlesTmp.Fk_modules_id = mod.Id;
                        roleModlesTmp.Zfbz = Model.Common.CommonCode.代码值_作废标志代码值.启用;
                        roleModulesList.Add(roleModlesTmp);
                    }

                }
                bool flag = false;
                flag = permissionsBll.refreshRole_modulesByRoleId(roleModulesList, this.oldRole.Id);
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
