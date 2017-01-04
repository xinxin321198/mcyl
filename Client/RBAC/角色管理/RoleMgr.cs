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
using BLL.RBAC.RBAC_角色;
using Model.Common;
using BLL.RBAC.RBAC_角色模块关系;
using BLL.RBAC.权限;

namespace client.RBAC.角色管理
{
    public partial class RoleMgr : Form
    {
        private Main main = null;//主窗体引用

        private Rbac_role oldRole = null;

        private Rbac_roleBLL roleBll = new Rbac_roleBLLImp();
        private Rbac_role_modulesBLL roleModulesBll = new Rbac_role_modulesBLLImp();
        private PermissionsBLL permissionsBll = new PermissionsBLLImp();


        public RoleMgr(Main main)
        {
            this.main = main;
            InitializeComponent();
            FormHelper.initForm(this);
            SkinButtonHelper.initButton(this.skinButton_addModules,this.skinButton_addRole,this.skinButton_saverole);//初始化按钮的样式
            ComboBoxHelper.initComboBoxForZfbz(skinComboBox_zfbz);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_modules);
            SkinDataGridViewHelper.initDataGridView(skinDataGridView_role);


        }

        /// <summary>
        /// 比较Rbac_role类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldRbac_role"></param>
        /// <param name="newRbac_role"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkRbac_roleIsEqual(Rbac_role oldRbac_role, Rbac_role newRbac_role)
        {
            bool flag = false;

            //角色名称
            if (oldRbac_role.Name != newRbac_role.Name)
            {
                flag = true;
            }

            //备注
            if (oldRbac_role.Remark != newRbac_role.Remark)
            {
                flag = true;
            }

            //作废标志
            if (oldRbac_role.Zfbz != newRbac_role.Zfbz)
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
        /// 校验Rbac_role类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Rbac_role"></param>
        private void checkRbac_roleIsNull(Rbac_role rbac_role)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();

            //主键
            //if (null == rbac_role.Id || "" == rbac_role.Id)
            //{
            //    flag = true;
            //    sb.Append("请指定‘主键’的值\n");
            //}

            //角色名称
            if (null == rbac_role.Name || "" == rbac_role.Name)
            {
                flag = true;
                sb.Append("请指定‘角色名称’的值\n");
            }

            //备注
            if (null == rbac_role.Remark || "" == rbac_role.Remark)
            {
                flag = true;
                sb.Append("请指定‘备注’的值\n");
            }

            //作废标志
            if (null == rbac_role.Zfbz || "" == rbac_role.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志’的值\n");
            }

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }

        private void RoleMgr_Load(object sender, EventArgs e)
        {
            try
            {

                this.enabledUI(false);
    
                this.initDataGridView_role();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void initDataGridView_RoleModules()
        {
            
            Rbac_role_modules param = new Rbac_role_modules();
            param.Fk_role_id = this.oldRole.Id;
            List<Rbac_role_modules> roleModulesList = (List<Rbac_role_modules>)roleModulesBll.getListContactObject(param, null, null)[0];
            SkinDataGridViewHelper.bindingList(skinDataGridView_modules, roleModulesList);

            if (skinDataGridView_modules.DataSource == null)
            {
                return;
            }

            #region UI,datagridview隐藏基本字段，start
            //隱藏列start
            //skinDataGridView_modules.Columns["ID"].Visible = false;//隐藏此列
            //skinDataGridView_modules.Columns["ID"].HeaderText = "主键";//设置列名
            //skinDataGridView_modules.Columns["ID"].DisplayIndex = 0;//列的顺序
            //skinDataGridView_modules.Columns["CSRQ"].DefaultCellStyle.Format = BLL.Common.AppConfigHelper.GetAppConfigFordateFormat();//从配置文件中取时间格式设置到此列（用于时间列）

            skinDataGridView_modules.Columns[Rbac_role_modules.ID].Visible = false;//主键
            skinDataGridView_modules.Columns[Rbac_role_modules.ID].HeaderText = "主键";

            skinDataGridView_modules.Columns[Rbac_role_modules.FK_ROLE_ID].Visible = false;//角色id
            skinDataGridView_modules.Columns[Rbac_role_modules.FK_ROLE_ID].HeaderText = "角色id";

            skinDataGridView_modules.Columns[Rbac_role_modules.FK_MODULES_ID].Visible = false;//模块id
            skinDataGridView_modules.Columns[Rbac_role_modules.FK_MODULES_ID].HeaderText = "模块id";

            skinDataGridView_modules.Columns[Rbac_role_modules.ZFBZ].Visible = false;//作废标志
            skinDataGridView_modules.Columns[Rbac_role_modules.ZFBZ].HeaderText = "作废标志";

            #endregion UI,datagridview隐藏基本字段，end


            #region UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

           // UIHelper.dataGridViewObjectConvertToValue(skinDataGridView_modules, "rbac_role", "rbac_roleName", "角色id", CommonCode.实体类名称.RBAC_角色实体类名);

            SkinDataGridViewHelper.dataGridViewObjectConvertToValue(skinDataGridView_modules, "rbac_modules", "rbac_modulesName", "模块名称", CommonCode.实体类名称.RBAC_模块实体类名);
            skinDataGridView_modules.Columns["rbac_modulesName"].Width = 250;
            #endregion UI,新增的实体类字段转换（隐藏原来的英文字段，新增一个中文字段，中文字段中放入转换过后的值）

            #region UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换

            skinDataGridView_modules.Columns["rbac_role"].Visible = false;//角色id

            //skinDataGridView_modules.Columns["rbac_modules"].Visible = false;//模块id

            #endregion UI,新增的实体类字段如果不想转换显示，可以直接隐藏，不必转换



            SkinDataGridViewHelper.endDataGridView(skinDataGridView_modules);

        }


        private void initDataGridView_role()
        {
            List<Rbac_role> roleList = (List<Rbac_role>)this.roleBll.getList(null, null, null)[0];
            SkinDataGridViewHelper.bindingList(skinDataGridView_role, roleList);
            if (skinDataGridView_role.DataSource == null)
            {
                return;
            }



            skinDataGridView_role.Columns[Rbac_role.ID].Visible = false;
            skinDataGridView_role.Columns[Rbac_role.REMARK].Visible = false;
            skinDataGridView_role.Columns[Rbac_role.ZFBZ].Visible = false;


            SkinDataGridViewHelper.endDataGridView(skinDataGridView_role);


        }

        private void enabledUI(bool isEnabled)
        {
            skinTextBox_角色名称.Enabled = isEnabled;
            rtfRichTextBox_备注.Enabled = isEnabled;
            skinComboBox_zfbz.Enabled = isEnabled;
            skinButton_saverole.Enabled = isEnabled;
            skinButton_addModules.Enabled = isEnabled;
        }

        private void clearUI()
        {
            skinTextBox_角色名称.Text = "";
            rtfRichTextBox_备注.Text = "";
            skinComboBox_zfbz.SelectedIndex = -1;
            this.skinDataGridView_modules.DataSource = null;
        }

        private void skinButton_addRole_Click(object sender, EventArgs e)
        {
            try
            {
                this.enabledUI(true);
                this.clearUI();
                this.oldRole = null;
                
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);

            }
        }

        private void skinButton_saverole_Click(object sender, EventArgs e)
        {
            try
            {
            Rbac_role roleSave = new Rbac_role();
            roleSave.Name = skinTextBox_角色名称.Text.Trim();
            roleSave.Remark = rtfRichTextBox_备注.Text.Trim();
            roleSave.Zfbz = Jc_code.ConvertToJc_code(skinComboBox_zfbz.SelectedItem).Value;
            bool flag = false;
            this.checkRbac_roleIsNull(roleSave);
            if (null == this.oldRole)
            {
                flag = roleBll.save(roleSave);
            }
            else
            {
                this.checkRbac_roleIsEqual(this.oldRole,roleSave);
                roleSave.Id = this.oldRole.Id;
                flag = roleBll.save(roleSave);
            }

            if (flag)
            {
                MyMessageBox.Show("保存成功");
            }
            else
            {
                MyMessageBox.Show("保存失败");

            }

            this.initDataGridView_role();
            this.enabledUI(false);
            this.clearUI();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
            
        }

        private void skinDataGridView_role_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Rbac_role currentRole = (Rbac_role)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_role);
                this.oldRole = currentRole;
                this.skinTextBox_角色名称.Text = this.oldRole.Name;
                this.rtfRichTextBox_备注.Text = this.oldRole.Remark;
                this.skinComboBox_zfbz.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(this.skinComboBox_zfbz, this.oldRole.Zfbz, CommonCode.实体类名称.基础_代码字典实体类名);

                this.initDataGridView_RoleModules();

                this.enabledUI(true);
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);

            }
        }

        private void 删除角色和角色所拥有的模块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Rbac_role currentRole = (Rbac_role)SkinDataGridViewHelper.getCurrentDataGridViewItem(skinDataGridView_role);
                bool flag = permissionsBll.deleteRoleAndRelationByRoleId(currentRole.Id);
                if (flag)
                {
                    MyMessageBox.Show("删除成功");
                }
                else
                {
                    MyMessageBox.Show("删除失败");
                }
                this.initDataGridView_role();
                this.enabledUI(false);
                this.clearUI();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void skinButton_addModules_Click(object sender, EventArgs e)
        {
            try
            {
                if (null == this.oldRole)
                {
                    throw new Exception("请双击左边的列表选择一个角色");
                }
                RoleModulesRelation rmr = new RoleModulesRelation(this.oldRole);
                rmr.ShowDialog();
                this.initDataGridView_RoleModules();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
                
            }

        }
    }
}
