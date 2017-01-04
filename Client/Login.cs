using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.YW.登录;
using Model.RBAC;
using BLL.RBAC.RBAC_用户;
using client.Common;
using Model.Common;
using BLL.Common;
using Model.JC;
using BLL.JC.基础_用户登录日志;

namespace client
{
    public partial class Login : Form
    {
        private LoginBLL loginBLL = new LoginBLLImp();
        private Rbac_userBLL userBLL = new Rbac_userBLLImp();
        private Jc_loginBLL loginBll = new Jc_loginBLLImp();
        public Login()
        {
            InitializeComponent();
            FormHelper.initForm(this);
            SkinButtonHelper.initButton(this.skinButton_login, this.skinButton_tuichu);

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Rbac_user userParam = new Rbac_user();
            userParam.Name = skinTextBox__username.Text;
            userParam.Pwd = skinTextBox__password.Text;
            try
            {
                LoginModel loginModel = loginBLL.login(userParam);
                loginModel.LoginIp = IPHelper.GetIP();


                //记录到登录记录
                Jc_login loginSave = new Jc_login();
                loginSave.Login_date = loginModel.LoginDateTime;
                loginSave.Login_ip = Convert.ToString(loginModel.LoginIp);
                loginSave.User_name = Convert.ToString(loginModel.LoginUser.Name);
                loginSave.Zfbz = CommonCode.代码值_作废标志代码值.启用;
                if (!loginModel.IsAdmin)
                {
                    loginSave.Fk_user_id = Convert.ToString(loginModel.LoginUser.Id);
                    loginSave.Fk_renyuan_id = Convert.ToString(loginModel.LoginRenyuan.Id);
                    loginSave.Renyuan_name = Convert.ToString(loginModel.LoginRenyuan.Xm);
                }
                bool flag = loginBll.save(loginSave);


                if (!flag)
                {
                    throw new Exception("未记录登录日志，请联系管理员");
                }


                this.Hide();

                if (!loginModel.IsAdmin)
                {
                    //选择科室，把选择后的科室绑定在当前登录科室属性上，如果没有绑定就终止登录
                    if (!fillLoginKeshi(loginModel))
                    {
                        return;
                    }
                }
                
                Main main = new Main(loginModel);
                main.Show();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 如果当前登录人员有多个所属科室，就弹出窗口来选择，当前需要登录哪个科室
        /// 并把选择后的结果赋予selectedKeshi字段
        /// 填充成功返回true,没有填充返回false
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        private bool fillLoginKeshi(LoginModel loginModel)
        {
            if (loginModel.KeshiList.Count > 1)
            {
                LoginKeshiSelect loginKeshi = new LoginKeshiSelect(loginModel.KeshiList);
                DialogResult result = loginKeshi.ShowDialog();
                if (loginKeshi.SelectedKeshi == null)
                {
                    return false;
                }
                loginModel.LoginKeShi = loginKeshi.SelectedKeshi;
                return true;
            }
            else
            {
                loginModel.LoginKeShi = loginModel.KeshiList[0];
                return true;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // LoginService.LoginServiceClient loginService = new LoginService.LoginServiceClient();
            //Jc_user userParam = new Jc_user();
            // userParam.Zh = skinTextBox__username.Text;
            // userParam.Mm = skinTextBox__password.Text;

            // try
            // {
            //     Jc_user LoginUser = loginService.Login(userParam);
            //     if (LoginUser != null)
            //     {
            //         MyMessageBox.Show("登录成功");
            //         this.Hide();
            //         Main main = new Main(LoginUser);
            //         main.Show();

            //     }
            // }
            // catch(Exception ex)
            // {
            //     MyMessageBox.Show(ex.Message);
            // }
        }

        private const int CLOSE_SIZE = 10;
        //tabPage标签图片
        Bitmap image = client.Properties.Resources.block_small;


        private void Login_Load(object sender, EventArgs e)
        {
            //用户名输入窗口获得焦点
            this.ActiveControl = skinTextBox__username;
            this.skinTextBox__username.Text = "1";
            this.skinTextBox__password.Text = "1";

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormHelper.closeForm(this);
        }

        private void button_Sample_Click(object sender, EventArgs e)
        {
            new Sample().ShowDialog();
        }



    }
}
