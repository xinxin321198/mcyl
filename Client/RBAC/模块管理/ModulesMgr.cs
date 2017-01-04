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
using CCWin.SkinControl;
using BLL.RBAC.权限;

namespace client.RBAC.模块管理
{
    public partial class ModulesMgr : Form
    {
        private Main main = null;//主窗体引用


        /// <summary>
        /// 父模块
        /// </summary>
        private Rbac_modules p_modules = null;

        /// <summary>
        /// 当前的打开的模块对象
        /// </summary>
        private Rbac_modules oldModules = null;


        private BLL.RBAC.RBAC_模块.Rbac_modulesBLL modulesBll = new BLL.RBAC.RBAC_模块.Rbac_modulesBLLImp();

        private PermissionsBLL permissionsBll = new PermissionsBLLImp();


        public ModulesMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);
            SkinButtonHelper.initButton(this.skinButton_save, this.skinButton_add);//初始化按钮的样式
            ComboBoxHelper.initComboBoxForCode(this.skinComboBox_模块类型, CommonCode.代码类型值.RBAC_模块类型, CommonCode.代码值_作废标志代码值.启用);
            ComboBoxHelper.initComboBoxForZfbz(this.skinComboBox_zfbz);
            NumericUpDownHelper.initNumericUpDown(skinNumericUpDown_sort, NumericUpDownHelper.数值控件模式.整型);

        }





        /// <summary>
        /// 比较Rbac_modules类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldRbac_modules"></param>
        /// <param name="newRbac_modules"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkRbac_modulesIsEqual(Rbac_modules oldRbac_modules, Rbac_modules newRbac_modules)
        {
            bool flag = false;

            //父id
            if (oldRbac_modules.Pid != newRbac_modules.Pid)
            {
                flag = true;
            }

            //模块名称
            if (oldRbac_modules.Name != newRbac_modules.Name)
            {
                flag = true;
            }

            //块要打开的窗体完全限定名称（包括命名空间）
            if (oldRbac_modules.Window_name != newRbac_modules.Window_name)
            {
                flag = true;
            }

            //模块类型，菜单还是功能点（关联代码表）
            if (oldRbac_modules.Type_code != newRbac_modules.Type_code)
            {
                flag = true;
            }

            //菜单是否允许直接打开窗体（功能点必须允许,菜单可选，关联代码表，是否）
            if (oldRbac_modules.Is_open_window_code != newRbac_modules.Is_open_window_code)
            {
                flag = true;
            }

            //排序码
            if (oldRbac_modules.Sort != newRbac_modules.Sort)
            {
                flag = true;
            }

            //图标名称
            if (oldRbac_modules.Icon != newRbac_modules.Icon)
            {
                flag = true;
            }

            //备注
            if (oldRbac_modules.Remark != newRbac_modules.Remark)
            {
                flag = true;
            }

            //作废标志
            if (oldRbac_modules.Zfbz != newRbac_modules.Zfbz)
            {
                flag = true;
            }

            if (!flag)
            {
                throw new Exception("没有修改数据，不需要保存");
            }
            return;
        }








        /// <summary>
        /// 校验Rbac_modules类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Rbac_modules"></param>
        private void checkRbac_modulesIsNull(Rbac_modules rbac_modules)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            //if (null == rbac_modules.Id || "" == rbac_modules.Id)
            //{
            //    flag = true;
            //    sb.Append("请指定‘主键’的值\n");
            //}

            //父id
            //if (null == rbac_modules.Pid || "" == rbac_modules.Pid)
            //{
            //    flag = true;
            //    sb.Append("请指定‘父id’的值\n");
            //}

            //模块名称
            if (null == rbac_modules.Name || "" == rbac_modules.Name)
            {
                flag = true;
                sb.Append("请指定‘模块名称’的值\n");
            }

            //块要打开的窗体完全限定名称（包括命名空间）
            if (null == rbac_modules.Window_name || "" == rbac_modules.Window_name)
            {
                flag = true;
                sb.Append("请指定‘块要打开的窗体完全限定名称（包括命名空间）’的值\n");
            }

            //模块类型，菜单还是功能点（关联代码表）
            if (null == rbac_modules.Type_code || "" == rbac_modules.Type_code)
            {
                flag = true;
                sb.Append("请指定‘模块类型，菜单还是功能点（关联代码表）’的值\n");
            }

            //菜单是否允许直接打开窗体（功能点必须允许,菜单可选，关联代码表，是否）
            if (null == rbac_modules.Is_open_window_code || "" == rbac_modules.Is_open_window_code)
            {
                flag = true;
                sb.Append("请指定‘菜单是否允许直接打开窗体（功能点必须允许,菜单可选，关联代码表，是否）’的值\n");
            }

            //排序码
            if (null == rbac_modules.Sort || 0 == rbac_modules.Sort)
            {
                flag = true;
                sb.Append("请指定‘排序码’的值\n");
            }

            ////图标名称
            //if (null == rbac_modules.Icon || "" == rbac_modules.Icon)
            //{
            //    flag = true;
            //    sb.Append("请指定‘图标名称’的值\n");
            //}

            //备注
            if (null == rbac_modules.Remark || "" == rbac_modules.Remark)
            {
                flag = true;
                sb.Append("请指定‘备注’的值\n");
            }

            //作废标志
            if (null == rbac_modules.Zfbz || "" == rbac_modules.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志’的值\n");
            }

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }




        private void ModulesMgr_Load(object sender, EventArgs e)
        {
            try
            {



                this.initTreeView(skinTreeView_modules);
                this.initUI();

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 初始化树控件
        /// </summary>
        private void initTreeView(SkinTreeView treeView)
        {
            TreeViewHelper.initTreeViewForRbac_modules(this.skinTreeView_modules,null);
        }

        private void skinButton_cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void skinButton_add_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = skinTreeView_modules.SelectedNode;
                this.clearUI();
                this.enabledUI(true);

                if (null == node)//菜单
                {
                    this.enabledUI(true);
                    skinComboBox_模块类型.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_模块类型, CommonCode.RBAC_模块类型.菜单, CommonCode.实体类名称.基础_代码字典实体类名);
                    skinCheckBox_是否允许直接打开窗体.Enabled = true;
                }
                else
                {
                    Rbac_modules selectedModules = (Rbac_modules)node.Tag;//当前选中的额节点
                    if (selectedModules.Type_code==CommonCode.RBAC_模块类型.功能点)
                    {
                        throw new Exception("功能点类型的节点下不允许再添加子级节点");
                    }

                    this.p_modules = selectedModules;
                    skinTextBox_p_modules.Text = selectedModules.Name;
                    skinComboBox_模块类型.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_模块类型, CommonCode.RBAC_模块类型.功能点, CommonCode.实体类名称.基础_代码字典实体类名);
                    skinCheckBox_是否允许直接打开窗体.Enabled = false;
                    skinCheckBox_是否允许直接打开窗体.Checked = true;
                }
                this.oldModules = null;
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
           
                
        }


        private void clearUI()
        {
            skinTextBox_模块名称.Text = "";
            skinTextBox_窗体完全限定名.Text = "";
            skinTextBox_p_modules.Text = "";
            skinComboBox_模块类型.SelectedIndex = -1;
            skinComboBox_zfbz.SelectedIndex = -1;
            skinCheckBox_是否允许直接打开窗体.Checked = false;
            skinNumericUpDown_sort.Value = 0;
            skinTextBox_iconName.Text = "";
            rtfRichTextBox_备注.Text = "";

        }

        private void skinButton_save_Click(object sender, EventArgs e)
        {
            try
            {
                Rbac_modules modulesSave = new Rbac_modules();
                modulesSave.Is_open_window_code = skinCheckBox_是否允许直接打开窗体.Checked?CommonCode.代码值_是否.是:CommonCode.代码值_是否.否;
                modulesSave.Name = skinTextBox_模块名称.Text;
                if (null != this.p_modules)
                {
                    modulesSave.Pid = this.p_modules.Id;
                    if (this.p_modules.Type_code==CommonCode.RBAC_模块类型.功能点)
                    {
                        throw new Exception("功能点类型的节点下不允许再添加子级节点，保存");
                    }
                    
                }

                modulesSave.Remark = rtfRichTextBox_备注.Text.Trim();
                modulesSave.Type_code = Jc_code.ConvertToJc_code(skinComboBox_模块类型.SelectedItem).Value;
                modulesSave.Window_name = skinTextBox_窗体完全限定名.Text.Trim();
                modulesSave.Sort = skinNumericUpDown_sort.Value;
                modulesSave.Icon = skinTextBox_iconName.Text.Trim();
                modulesSave.Zfbz = Jc_code.ConvertToJc_code(skinComboBox_zfbz.SelectedItem).Value;
                this.checkRbac_modulesIsNull(modulesSave);

                bool flag = false;
                if (null == this.oldModules)
                {
                    flag = modulesBll.save(modulesSave);
                }
                else
                {
                    this.checkRbac_modulesIsEqual(this.oldModules, modulesSave);
                    modulesSave.Id = this.oldModules.Id;
                    flag = modulesBll.save(modulesSave);
                }

                if (flag)
                {
                    MyMessageBox.Show("保存成功");
                }
                else
                {
                    MyMessageBox.Show("保存失败");

                }

                this.initTreeView(skinTreeView_modules);
                this.initUI();
                this.clearUI();

            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);

            }
        }

      

       

        private void skinTreeView_modules_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                SkinTreeView treeView = (SkinTreeView)sender;

                if (treeView.SelectedNode != null)
                {
                    Rbac_modules selectedModules = (Rbac_modules)treeView.SelectedNode.Tag;
                    if (selectedModules.Type_code == CommonCode.RBAC_模块类型.菜单)
                    {
                        skinButton_add.Enabled = true;
                    }
                    else if (selectedModules.Type_code == CommonCode.RBAC_模块类型.功能点)
                    {
                        skinButton_add.Enabled = false;
                    }
                    else
                    {
                        throw new Exception("未知的模块类型");
                    }
                }


            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinTreeView_modules_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                TreeNode node = skinTreeView_modules.SelectedNode;
                if (null==node)
                {
                    throw new Exception("请选择一个节点");
                }
                this.oldModules = (Rbac_modules)node.Tag;
                if (this.oldModules.Type_code != CommonCode.RBAC_模块类型.菜单)
                {
                    this.p_modules = (Rbac_modules)skinTreeView_modules.SelectedNode.Parent.Tag;
                    this.skinTextBox_p_modules.Text = this.p_modules.Name;
                    skinCheckBox_是否允许直接打开窗体.Enabled = false;
                }
                else
                {
                    skinCheckBox_是否允许直接打开窗体.Enabled = true;

                }
                this.skinTextBox_模块名称.Text = this.oldModules.Name;
                this.skinTextBox_窗体完全限定名.Text = this.oldModules.Window_name;
                this.skinComboBox_模块类型.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_模块类型, this.oldModules.Type_code, CommonCode.实体类名称.基础_代码字典实体类名);
                this.skinComboBox_zfbz.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(skinComboBox_zfbz, this.oldModules.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名);
                this.skinCheckBox_是否允许直接打开窗体.Checked = this.oldModules.Is_open_window_code == CommonCode.代码值_是否.是 ? true :false;
                this.skinNumericUpDown_sort.Value = (decimal)this.oldModules.Sort;
                this.skinTextBox_iconName.Text = this.oldModules.Icon;
                this.rtfRichTextBox_备注.Text = this.oldModules.Remark;

                this.enabledUI(true);
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);   
            }
        }

        private void 删除模块及下级子模块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = skinTreeView_modules.SelectedNode;
                if (null==node)
                {
                    throw new Exception("请选择一个节点");
                }
                Rbac_modules m = (Rbac_modules)node.Tag;
                bool flag = permissionsBll.deleteChildNodeAndRoleRelationByModulesId(m.Id);
                if (flag)
                {
                    MyMessageBox.Show("删除成功");
                }
                else
                {
                    MyMessageBox.Show("删除失败");
                }
                this.initTreeView(skinTreeView_modules);
                this.initUI();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void initUI()
        {
            skinTextBox_p_modules.Enabled = false;
            skinComboBox_模块类型.Enabled = false;
            skinCheckBox_是否允许直接打开窗体.Enabled = false;
            skinNumericUpDown_sort.ReadOnly = true;
            this.enabledUI(false);
        }

        private void enabledUI(bool isEnable)
        {
            skinTextBox_模块名称.Enabled = isEnable;
            skinTextBox_窗体完全限定名.Enabled = isEnable;
            skinNumericUpDown_sort.Enabled = isEnable;
            rtfRichTextBox_备注.Enabled = isEnable;
            skinComboBox_zfbz.Enabled = isEnable;
            skinTextBox_iconName.Enabled = isEnable;
        }

        private void skinTreeView_modules_MouseUp(object sender, MouseEventArgs e)
        {
            TreeNode selectnode = skinTreeView_modules.GetNodeAt(e.Location);
            if (selectnode == null)
            {
                this.skinTreeView_modules.SelectedNode = null;
                this.p_modules = null;
                this.skinButton_add.Enabled = true;
            }  
 
        }




    }
}
