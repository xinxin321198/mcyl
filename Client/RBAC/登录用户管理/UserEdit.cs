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
using Model.JC;

namespace client.JC.登录用户管理
{
    public partial class UserEdit : Form
    {

        private Rbac_userBLL jc_userBLL = new Rbac_userBLLImp();
        private Rbac_user oldUser = null;

        public UserEdit()
        {
            InitializeComponent();

        }
        public UserEdit(Rbac_user user)
        {
            InitializeComponent();
            this.oldUser = user;

        }

        private void UserEdit_Load(object sender, EventArgs e)
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

        private void initUI()
        {
            FormHelper.initForm(this);//初始化form窗体的一些属性
            SkinButtonHelper.initButton(this.skinButton_cancel, this.skinButton_save);

            ComboBoxHelper.initComboBoxForZfbz(comboBox_zfbz);


            ComboBoxHelper.initComboBoxForCode(comboBox_userType, CommonCode.代码类型值.账户类别, CommonCode.代码值_作废标志代码值.启用);

            //textBox_userName.Enabled = false;
            if (null == oldUser)
            {

            }
            else//修改
            {
                textBox_userName.Text = oldUser.Name;
                comboBox_userType.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_userType, oldUser.LxCode.Value, Model.Common.CommonCode.实体类名称.基础_代码字典实体类名);
                comboBox_zfbz.SelectedIndex = ComboBoxHelper.getComboBoxIndexByValue(comboBox_zfbz, oldUser.Zfbz, Model.Common.CommonCode.实体类名称.基础_代码字典实体类名);
            }
        }


        private void comboBox_zfbz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jc_code code = (Jc_code)comboBox_zfbz.SelectedItem;
        }

        private void textBox_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                Rbac_user userSave = new Rbac_user();
                userSave.Name = textBox_userName.Text;
                userSave.Pwd =MD5Helper.getEncryption( textBox_pwd.Text);
                userSave.Lx_code = Jc_code.ConvertToJc_code(comboBox_userType.SelectedItem).Value;
                userSave.Zfbz = Jc_code.ConvertToJc_code(comboBox_zfbz.SelectedItem).Value;
                userSave.Remark = richTextBox_remark.Text.Trim();
                this.checkRbac_userIsNull(userSave);

                bool flag = false;
                if (null == oldUser)
                {
                    flag = jc_userBLL.save(userSave);
                }
                else
                {
                    this.checkRbac_userIsEqual(this.oldUser,userSave);
                    userSave.Id = oldUser.Id;
                    flag = jc_userBLL.save(userSave);
                }

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


        /// <summary>
        /// 比较Rbac_user类型的两个对象里的值是否相等，允不允许修改
        /// </summary>
        /// <param name="oldRbac_user"></param>
        /// <param name="newRbac_user"></param>
        /// <returns>相等true，不相等false</returns>
        private void checkRbac_userIsEqual(Rbac_user oldRbac_user, Rbac_user newRbac_user)
        {
            bool flag = false;

            //账号
            if (oldRbac_user.Name != newRbac_user.Name)
            {
                flag = true;
            }

            //密码
            if (oldRbac_user.Pwd != newRbac_user.Pwd)
            {
                flag = true;
            }

            //账户类型（关联代码表）
            if (oldRbac_user.Lx_code != newRbac_user.Lx_code)
            {
                flag = true;
            }

            //
            if (oldRbac_user.Remark != newRbac_user.Remark)
            {
                flag = true;
            }

            //作废标志（0为禁用，1为启用）
            if (oldRbac_user.Zfbz != newRbac_user.Zfbz)
            {
                flag = true;
            }

            //创建日期
            if (oldRbac_user.Cjrq != newRbac_user.Cjrq)
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
        /// 校验Rbac_user类型的对象是否有空值（根据实际逻辑增减修改判断项）
        /// </summary>
        /// <param name="Rbac_user"></param>
        private void checkRbac_userIsNull(Rbac_user rbac_user)
        {
            bool flag = false;
            StringBuilder sb = new StringBuilder();


            //账号
            if (null == rbac_user.Name || "" == rbac_user.Name)
            {
                flag = true;
                sb.Append("请指定‘账号’的值\n");
            }

            //密码
            if (null == rbac_user.Pwd || "" == rbac_user.Pwd)
            {
                flag = true;
                sb.Append("请指定‘密码’的值\n");
            }

            //账户类型（关联代码表）
            if (null == rbac_user.Lx_code || "" == rbac_user.Lx_code)
            {
                flag = true;
                sb.Append("请指定‘账户类型（关联代码表）’的值\n");
            }

            //
            if (null == rbac_user.Remark || "" == rbac_user.Remark)
            {
                flag = true;
                sb.Append("请指定‘备注’的值\n");
            }

            //作废标志（0为禁用，1为启用）
            if (null == rbac_user.Zfbz || "" == rbac_user.Zfbz)
            {
                flag = true;
                sb.Append("请指定‘作废标志（0为禁用，1为启用）’的值\n");
            }

            //创建日期
            //if (null == rbac_user.Cjrq || DateTime.MinValue == rbac_user.Cjrq)
            //{
            //    flag = true;
            //    sb.Append("请指定‘创建日期’的值\n");
            //}

            if (flag)
            {
                throw new Exception(sb.ToString());
            }
        }


        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
