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
using Model.Common;
using BLL.JC.基础_工作人员账户关系表;
using Model.RBAC;
using BLL.RBAC.RBAC_用户;
using BLL.JC.工作人员;
using BLL.RBAC.权限;

namespace client.JC.工作人员管理
{
    public partial class RenyuanUserRelation : Form
    {
        private Jc_renyuan oldRenyuan = null;
        private Jc_renyuan_userBLL renyuan_userBll = new Jc_renyuan_userBLLImp();
        private Rbac_userBLL userBLL = new Rbac_userBLLImp();
        private RenyuanBLL renyuanBll = new RenyuanBLLImp();
        private PermissionsBLL permissionsBll = new PermissionsBLLImp();


        public RenyuanUserRelation(Jc_renyuan renyuan)
        {
            this.oldRenyuan = renyuan;
            InitializeComponent();
            FormHelper.initFormForToolWindow(this);
            SkinListViewHelper.initListViewCheckBoxSingleSelection(listView_user);
            SkinListViewHelper.initListViewDataForUser(listView_user);
            
        }

        private void RenyuanUserRelation_Load(object sender, EventArgs e)
        {
            try
            {
                textBox_xm.ReadOnly = true;
                textBox_xm.Text = this.oldRenyuan.Xm;
                textBox_sfzh.ReadOnly = true;
                textBox_sfzh.Text = this.oldRenyuan.Sfzh;
                this.initListView();
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message);
            }
        }

        private void initListView()
        {

            //让用户所拥有的账户为选中
            List<Jc_renyuan_user> renyuanUserList = new List<Jc_renyuan_user>();
            Jc_renyuan_user renyuanUserParam = new Jc_renyuan_user();
            renyuanUserParam.Fk_renyuan_id = oldRenyuan.Id;
            renyuanUserList = (List<Jc_renyuan_user>)renyuan_userBll.getListContactObjectByPage(renyuanUserParam, null, null, null)[0];

            for (int i = 0; i < renyuanUserList.Count; i++)
            {
                Jc_renyuan_user renyuanUser = renyuanUserList[i];
                for (int j = 0; j < listView_user.Items.Count; j++)
                {
                    ListViewItem item = listView_user.Items[j];
                    Rbac_user user = (Rbac_user)item.Tag;
                    if (renyuanUser.Fk_user_id == user.Id)
                    {
                        item.Checked = true;
                    }
                }
            }

            System.Drawing.Color color = AppConfigHelper.getGreenColor();
            //设置关联过人员的账户颜色为绿色
            List<Rbac_user> setOffUserList = permissionsBll.getSetOffRenyuan_user();
            for (int i = 0; i < listView_user.Items.Count; i++)
            {
                Rbac_user user = (Rbac_user)listView_user.Items[i].Tag;
                for (int j = 0; j < setOffUserList.Count; j++)
                {
                    Rbac_user setOffUser = setOffUserList[j];
                    if (user.Id == setOffUser.Id)
                    {
                        for (int z = 0; z < listView_user.Items[i].SubItems.Count; z++)
                        {
                            listView_user.Items[i].SubItems[z].ForeColor = color;
                        }
                    }
                }
            }

        }
      

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                //得到所选择的用户
                List<Rbac_user> checkedUserList = new List<Rbac_user>();
                for (int i = 0; i < listView_user.CheckedIndices.Count; i++)
                {
                    int index = listView_user.CheckedIndices[i];
                    Rbac_user user = new Rbac_user();
                    user.Id = Rbac_user.ConvertToRbac_user(listView_user.Items[index].Tag).Id;
                    checkedUserList.Add(user);
                }

                if (checkedUserList.Count > 1)
                {
                    throw new Exception(" 不允许选择多个账户");
                }


                //构建保存的对象
                List<Jc_renyuan_user> renyuanUserList = new List<Jc_renyuan_user>();
                for (int i = 0; i < checkedUserList.Count; i++)
                {
                    Jc_renyuan_user renyuanUserSave = new Jc_renyuan_user();
                    renyuanUserSave.Fk_renyuan_id = this.oldRenyuan.Id;
                    renyuanUserSave.Fk_user_id = checkedUserList[i].Id;
                    renyuanUserSave.Zfbz = CommonCode.代码值_作废标志代码值.启用;
                    renyuanUserList.Add(renyuanUserSave);
                }

                bool flag = renyuanBll.refreshRenyuanUserByRenyuanId(renyuanUserList, this.oldRenyuan.Id);
                if (flag)
                {
                    MyMessageBox.Show("添加成功");
                }
                else
                {
                    MyMessageBox.Show("添加失败");

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
