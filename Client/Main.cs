using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using client;
using client.Common;
using Model.JC;
using Model.RBAC;
using System.Resources;
using System.Reflection;
using BLL.RBAC.RBAC_用户角色关系表;
using BLL.RBAC.RBAC_模块;
using BLL.JC.基础_工作人员账户关系表;
using CCWin.SkinControl;
using Model.Common;
using BLL.RBAC.权限;

namespace client
{
    public partial class Main : Form
    {

        #region 常量



        /// <summary>
        /// 菜单按钮的高度
        /// </summary>
        private const int MENU_BUTTON_HEIGHT = 40;

        /// <summary>
        /// 菜单按钮的背景颜色
        /// </summary>
        //Color MENU_BACKGROUND_COLOR = Color.AliceBlue;
        Color MENU_BACKGROUND_COLOR = ColorTranslator.FromHtml("#DCE6EC");//传入hex方式的值

        Color BUTTON_FOCUS_COLOR = Color.PaleGoldenrod;
        /// <summary>
        /// 功能按钮的高度
        /// </summary>
        private const int FUN_BUTTON_HEIGHT = 60;
        /// <summary>
        /// 功能按钮的右边距
        /// </summary>
        private const int FUN_BUTTON_RIGHT_MARGIN = 25;

        /// <summary>
        /// 主界面从透明到显示的速度（数值越大越快）
        /// </summary>
        private const double TIMER_START_STEP = 0.1;

        /// <summary>
        /// 分离器距离左边缘或上边缘的位置
        /// </summary>
        private const int SPLITTER_DISTANCE = 200;
        #endregion 







        /// <summary>
        /// 当前的登录信息对象
        /// </summary>
        private LoginModel loginModel = null;

        public LoginModel LoginModel
        {
            get { return loginModel; }
            set { loginModel = value; }
        }




        private Rbac_modules adminModules = null;//最高管理员的模块信息

        private Rbac_modulesBLL modulesBll = new Rbac_modulesBLLImp();

        private Jc_renyuan_userBLL renyuanUserBll = new Jc_renyuan_userBLLImp();
        private PermissionsBLL permissionsBll = new PermissionsBLLImp();
        #region 加载皮肤
        //Sunisoft.IrisSkin.SkinEngine irisSkin = new Sunisoft.IrisSkin.SkinEngine();
        string skinPath = null;
        string[] skinFiles;
        int m_numFiles = 0;        //文件总数
        ArrayList m_pathList = new ArrayList();//包含所有文件路径的数组
        #endregion 

        //菜单权限点
        List<Rbac_modules> menuModulesList = new List<Rbac_modules>();
        //管理菜单按钮
        List<SkinButton> menuButtonList = new List<SkinButton>();
        //功能按钮权限点
        List<Rbac_modules> funModulesList = new List<Rbac_modules>();

        //功能按钮
        List<SkinButton> funButtonList = new List<SkinButton>();


        List<FlowLayoutPanel> flowLayoutPanelList = new List<FlowLayoutPanel>();





        public Main(LoginModel loginModelParam)
        {
            this.loginModel = loginModelParam;
            InitializeComponent();
            //窗体弹出效果
            //AnimateWindow(this.Handle, 300, AW_HOR_POSITIVE);
            this.Opacity = 0;

        }


        /// <summary>
        /// 初始化管理员的功能点按钮
        /// </summary>
        private void initAdminFunButton()
        {
            Rbac_modules modules = new Rbac_modules();
            modules.Id = "mokuaiguanli";
            modules.Name = "模块管理";
            modules.Type_code = Model.Common.CommonCode.RBAC_模块类型.功能点;//功能点
            modules.Window_name = "client.RBAC.模块管理.ModulesMgr";
            modules.Is_open_window_code = Model.Common.CommonCode.代码值_是否.是;//0是不允许
            modules.P_modules = this.adminModules;
            funModulesList.Add(modules);

            Rbac_modules role = new Rbac_modules();
            role.Id = "jueseguanli";
            role.Name = "角色管理";
            role.Type_code = Model.Common.CommonCode.RBAC_模块类型.功能点;//功能点
            role.Window_name = "client.RBAC.角色管理.RoleMgr";
            role.Is_open_window_code = Model.Common.CommonCode.代码值_是否.是;//0是不允许
            role.P_modules = this.adminModules;
            funModulesList.Add(role);



            Rbac_modules user = new Rbac_modules();
            user.Id="yonghuguanli";
            user.Name = "用户管理";
            user.Type_code = Model.Common.CommonCode.RBAC_模块类型.功能点;//功能点
            user.Window_name = "client.JC.登录用户管理.UserMgr";
            user.Is_open_window_code = Model.Common.CommonCode.代码值_是否.是;//0是不允许
            user.P_modules = this.adminModules;
            funModulesList.Add(user);

            Rbac_modules renyuan = new Rbac_modules();
            renyuan.Id ="gongzuorenyuanguanli";
            renyuan.Name = "工作人员管理";
            renyuan.Type_code = Model.Common.CommonCode.RBAC_模块类型.功能点;//功能点
            renyuan.Window_name = "client.JC.工作人员管理.RenYuanMgr";
            renyuan.Is_open_window_code = Model.Common.CommonCode.代码值_是否.是;//0是不允许
            renyuan.P_modules = this.adminModules;
            funModulesList.Add(renyuan);

            Rbac_modules keshi = new Rbac_modules();
            keshi.Id="kehsiguanli";
            keshi.Name = "科室管理";
            keshi.Type_code = Model.Common.CommonCode.RBAC_模块类型.功能点;//功能点
            keshi.Window_name = "client.JC.科室管理.KswhMgr";
            keshi.Is_open_window_code = Model.Common.CommonCode.代码值_是否.是;//0是不允许
            keshi.P_modules = this.adminModules;
            funModulesList.Add(keshi);

            Rbac_modules code = new Rbac_modules();
            code.Id="daimazidianguanli";
            code.Name = "代码字典管理";
            code.Type_code = Model.Common.CommonCode.RBAC_模块类型.功能点;//功能点
            code.Window_name = "client.JC.代码字典管理.CodeMgr";
            code.Is_open_window_code = Model.Common.CommonCode.代码值_是否.是;//0是不允许
            code.P_modules = this.adminModules;
            funModulesList.Add(code);

            Rbac_modules login = new Rbac_modules();
            login.Id="yonghudenglurizhi";
            login.Name = "用户登陆日志";
            login.Type_code = Model.Common.CommonCode.RBAC_模块类型.功能点;//功能点
            login.Window_name = "client.JC.登录日志管理.LoginMgr";
            login.Is_open_window_code = Model.Common.CommonCode.代码值_是否.是;//0是不允许
            login.P_modules = this.adminModules;
            funModulesList.Add(login);
        }


        //载入皮肤文件的方法
        #region
        string[] CreatePathList()
        {
            if (m_numFiles <= 0)
            {
                return null;
            }

            string[] str = new string[m_numFiles];
            int index = 0;

            IEnumerator pathIter = m_pathList.GetEnumerator();
            while (pathIter.MoveNext())
            {
                string[] ar = (string[])(pathIter.Current);
                IEnumerator fileIter = ar.GetEnumerator();
                while (fileIter.MoveNext())
                {
                    str[index] = (string)(fileIter.Current);
                    ++index;
                }
            }


            return str;
        }

        void ParseDirectory(string path, string filter)
        {
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            string[] dirs = Directory.GetDirectories(path);//得到子目录
            IEnumerator iter = dirs.GetEnumerator();
            while (iter.MoveNext())
            {
                string str = (string)(iter.Current);
                ParseDirectory(str, filter);
            }
            string[] files = Directory.GetFiles(path, filter);
            if (files.Length > 0)
            {
                m_numFiles += files.Length;
                m_pathList.Add(files);
            }
        }
        #endregion




        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormHelper.closeForm(this);
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.LoginModel == null)
                {
                    MyMessageBox.Show("非法登录");
                    Application.Exit();
                    return;
                }

                if (this.LoginModel.IsAdmin)//当前是否是管理员登录
                {
                    MyMessageBox.Show("当前为最高管理员登录");
                }
                else
                {
                    Rbac_modules menuModulesParam = new Rbac_modules();
                    menuModulesParam.Type_code = Model.Common.CommonCode.RBAC_模块类型.菜单;
                    this.menuModulesList = permissionsBll.getModulesByUserId(this.LoginModel.LoginUser.Id, menuModulesParam);

                    Rbac_modules funModulesParam = new Rbac_modules();
                    funModulesParam.Type_code = Model.Common.CommonCode.RBAC_模块类型.功能点;
                    this.funModulesList = permissionsBll.getModulesByUserId(this.LoginModel.LoginUser.Id, funModulesParam);
                }


                this.initSplitPanel();//初始化分割面板
                this.initStatusStrip_bottom();//初始化状态栏
                this.initMenuButton();//初始化大菜单(使用list管理)
                this.initFlowLayoutPanel();//初始化功能点面板（使用list管理）
                this.initFunButton();//初始化功能按钮（使用list管理）
                this.timer_start.Start();

                //点击角色管理菜单
                if (this.LoginModel.IsAdmin)
                {
                    clickMenu(this.adminModules, e);
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.ToString());
            }

        }

        private void clickMenu(Model.RBAC.Rbac_modules modules, EventArgs e)
        {
            for (int i = 0; i < menuButtonList.Count; i++)
            {
                Button b = menuButtonList[i];
                Rbac_modules b_m = (Rbac_modules)b.Tag;
                if (modules.Id == b_m.Id)
                {
                    this.menuButtonClick(b, e);
                }
            }
        }

        /// <summary>
        /// 初始化分割面板
        /// </summary>
        private void initSplitPanel()
        {
            skinSplitContainer_main.SplitterDistance = SPLITTER_DISTANCE;//分离器距离左边缘或上边缘的位置

        }

        /// <summary>
        /// 初始化菜单按钮（增加新菜单请添加登记）
        /// </summary>
        private void initMenuButton()
        {
            menuButtonList.Clear();

            //如果是管理员.添加一个系统管理的菜单
            if (this.LoginModel.IsAdmin)
            {
                Rbac_modules modules = new Rbac_modules();
                modules.Name = "管理员菜单";
                modules.Type_code = Model.Common.CommonCode.RBAC_模块类型.菜单;//菜单
                modules.Is_open_window_code = Model.Common.CommonCode.代码值_是否.否;//0是不允许
                menuModulesList.Add(modules);
                this.adminModules = modules;
            }

            //根据菜单模块的list，生成相应的菜单
            for (int i = 0; i < menuModulesList.Count; i++)
            {
                Rbac_modules m = menuModulesList[i];
                SkinButton b_temp = new SkinButton();
                b_temp.UseVisualStyleBackColor = true;
                b_temp.Dock = DockStyle.Top;
                b_temp.Text = m.Name;
                b_temp.Name = "button_" + m.Name;
                b_temp.Height = MENU_BUTTON_HEIGHT;
                b_temp.BackColor = MENU_BACKGROUND_COLOR;

                b_temp.Tag = m;

                b_temp.Click += new System.EventHandler(menuButtonClick);
                b_temp.Enter += new System.EventHandler(this.buttoEnter);
                b_temp.Leave += new System.EventHandler(this.buttoLeave);
                menuButtonList.Add(b_temp);
            }
            SkinButtonHelper.initMenuButton(menuButtonList.ToArray());
            //从list中取出button添加进panel
            for (int i = menuButtonList.Count - 1; i >= 0; i--)
            {
                Button b = menuButtonList[i];
                this.skinSplitContainer_main.Panel1.Controls.Add(b);

            }
        }

        /// <summary>
        /// 菜单按钮的事件
        /// </summary>
        /// <param Name="sender"></param>
        /// <param Name="e"></param>
        private void menuButtonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Rbac_modules m = (Rbac_modules)b.Tag;

            Button senderButton = (Button)sender;
            //隐藏显示功能点流布局panel
            for (int i = 0; i < flowLayoutPanelList.Count; i++)
            {
                FlowLayoutPanel flp = flowLayoutPanelList[i];
                Rbac_modules flpModuldes = (Rbac_modules)flp.Tag;
                Rbac_modules displayModuldes = (Rbac_modules)senderButton.Tag;
                if (flpModuldes.Id == displayModuldes.Id)//如果当前点击的菜单项模块名称与流布局panel名称相同，说明显示这个，其它隐藏
                {
                    flp.Visible = true;
                }
                else
                {
                    flp.Visible = false;
                }
            }


            this.refreshFunButtonSize();//刷新功能按钮的宽高


            //是否允许打开窗体，
            if (Model.Common.CommonCode.代码值_是否.否 == m.Is_open_window_code)
            {
                this.changeMenu(sender);//点击后更改菜单按钮的排列方式
            }
            else if (Model.Common.CommonCode.代码值_是否.是 == m.Is_open_window_code)
            {
                MyMessageBox.Show("此处应直接打开工作窗体");
            }
            else
            {
                throw new Exception("未知的Is_open_window_code代码" + m.Is_open_window_code);
            }


        }


        /// <summary>
        /// 新添加功能按钮面板（增加新面板请添加）
        /// </summary>
        private void initFlowLayoutPanel()
        {
            flowLayoutPanelList.Clear();





            //生成与菜单对应的功能点流布局panel
            for (int i = 0; i < menuModulesList.Count; i++)
            {
                Rbac_modules m = menuModulesList[i];
                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.AutoScroll = true;//滚动条
                flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;//顶部流到底部
                //flp.Location = new System.Drawing.Point(270, 154);
                flp.Name = "flowLayoutPanel_" + m.Name;
                //flp.Size = new System.Drawing.Size(112, 125);
                //flp.TabIndex = 0;
                flp.WrapContents = false;//禁止横向滚动条
                flp.Dock = DockStyle.Fill;//填充满父控件
                //flp.BorderStyle = BorderStyle.FixedSingle;
                flp.Visible = false;//隐藏

                flp.Tag = m;

                flowLayoutPanelList.Add(flp);
                this.skinSplitContainer_main.Panel1.Controls.Add(flp);//添加进panel中
            }



        }


        /// <summary>
        /// 初始化功能按钮（新添加按钮请登记）
        /// </summary>
        private void initFunButton()
        {
            funButtonList.Clear();

            //如果是管理员.添加一个系统管理的菜单
            if (this.LoginModel.IsAdmin)
            {
                this.initAdminFunButton();
            }

            //据功能点类型模块的list，生成功能点按钮，根据按钮的tag中pid得到按钮所属的菜单，对比后添加进相应的菜单中
            for (int i = 0; i < funModulesList.Count; i++)
            {
                Rbac_modules m = funModulesList[i];
                Rbac_modules p_m = m.P_modules;
                SkinButton b = new SkinButton();
                if (m.Icon != null || "" == m.Icon)
                {
                    Bitmap image = (Bitmap)Properties.Resources.ResourceManager.GetObject(m.Icon, Properties.Resources.Culture);//背景图片
                    b.Image = image;
                    b.TextImageRelation = TextImageRelation.ImageAboveText;
                }
                b.Name = "button_" + m.Name;
                b.Text = m.Name;
                b.UseVisualStyleBackColor = true;

                Size size = b.Size;
                size.Height = FUN_BUTTON_HEIGHT;
                b.Size = size;
                b.Click += new System.EventHandler(this.funButtonClick);
                b.Enter += new System.EventHandler(this.buttoEnter);
                b.Leave += new System.EventHandler(this.buttoLeave);

                b.Tag = m;
                for (int j = 0; j < flowLayoutPanelList.Count; j++)
                {
                    FlowLayoutPanel flp = flowLayoutPanelList[j];
                    Rbac_modules flpModules = (Rbac_modules)flp.Tag;
                    if (flpModules.Id == p_m.Id)//如果按钮的父模块等于某流布局panel的模块名称，就把按钮添加进此panel
                    {
                        flp.Controls.Add(b);
                        funButtonList.Add(b);

                    }
                }

            }
            SkinButtonHelper.initButton(funButtonList.ToArray());
            refreshFunButtonSize();
        }

        /// <summary>
        /// 功能点按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void funButtonClick(object sender, EventArgs e)
        {
            try
            {


                Button b = (Button)sender;
                Model.RBAC.Rbac_modules m = (Rbac_modules)b.Tag;
                string formName = m.Window_name;//form的完全限定名，包括命名空间
                string flag = m.Is_open_window_code;//是否允许打开窗体
                if (Model.Common.CommonCode.代码值_是否.是 == flag)//允许打开窗体（正确）
                {
                    Form form = FormHelper.CreateWinForm(formName, new object[] { this });//工厂方法创建form
                    form.Tag = m;
                    this.openForm(form);
                }
                else if (Model.Common.CommonCode.代码值_是否.否 == flag)
                {
                    return;
                }
                else
                {
                    throw new Exception("未知的Is_open_window_code代码：" + flag);
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.Show(ex.Message); ;
            }







        }

        /// <summary>
        /// 按钮获得焦点的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttoEnter(object sender, EventArgs e)
        {
            SkinButton sb = (SkinButton)sender;
            sb.BaseColor = BUTTON_FOCUS_COLOR;
        }

        /// <summary>
        /// 按钮失去焦点的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttoLeave(object sender, EventArgs e)
        {
            SkinButton sb = (SkinButton)sender;
            sb.BaseColor = SystemColors.ActiveCaption;
        }

        /// <summary>
        /// 改变过功能按钮的大小
        /// </summary>
        private void refreshFunButtonSize()
        {
            for (int i = 0; i < funButtonList.Count; i++)
            {
                Button b = funButtonList[i];
                Size newSize = new Size();
                newSize.Width = b.Parent.Width - Main.FUN_BUTTON_RIGHT_MARGIN;
                newSize.Height = Main.FUN_BUTTON_HEIGHT;
                b.Size = newSize;
            }
        }






        /// <summary>
        /// 初始化StatusStrip_bottom
        /// </summary>
        private void initStatusStrip_bottom()
        {
            this.toolStripStatusLabel_loginUser.Text = this.LoginModel.LoginUser.Name;//当前登录账号
            if (this.LoginModel.IsAdmin)
            {
                this.toolStripStatusLabel_renyuanName.Text = "管理员";
            }
            else
            {
                this.toolStripStatusLabel_renyuanName.Text = this.LoginModel.LoginRenyuan.Xm;//人员
                this.toolStripStatusLabel_keshiName.Text = this.LoginModel.LoginKeShi.Ksmc;//登录科室

            }




            this.skinPath = System.Environment.CurrentDirectory + "\\IrisSkins\\";
            ParseDirectory(skinPath, "*.ssk");
            skinFiles = CreatePathList();        //生成文件名数组

            this.toolStripDropDownButton_skin.DropDownItems.Add("原始");
            //this.toolStripDropDownButton_skin.se = 0;
            if (skinFiles == null)
            {
                //throw new Exception(String.Concat("No file found in ", skinPath));
                return;
            }
            for (int i = 0; i < skinFiles.Length; i++)
            {
                string filePath = skinFiles[i];
                int IrisSkinsPathIndex = filePath.IndexOf("IrisSkins");
                string fileName = filePath.Substring(IrisSkinsPathIndex + 10, filePath.Length - 48);
                toolStripDropDownButton_skin.DropDownItems.Add(fileName);
            }
        }

        private void toolStripDropDownButton_skin_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            //irisSkin.SkinFile = this.skinPath + e.ClickedItem.Text;
            //irisSkin.Active = true;
            //if (e.ClickedItem.Text == "原始")
            //{
            //    irisSkin.Active = false;
            //}
        }






        private void button1_Click(object sender, EventArgs e)
        {
            this.changeMenu(sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.changeMenu(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.changeMenu(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.changeMenu(sender);
        }

        /// <summary>
        /// 改变菜单位置
        /// </summary>
        /// <param Name="sender"></param>
        private void changeMenu(object sender)
        {
            List<Button> topButtons = new List<Button>();//要置顶的菜单按钮
            List<Button> bottomButtons = new List<Button>();//要直底的菜单按钮
            Button senderButton = (Button)sender;

            //循环所有菜单按钮与当前点击的按钮对比
            for (int i = 0; i < menuButtonList.Count; i++)
            {
                Button b = menuButtonList[i];
                if (b.Location.Y <= senderButton.Location.Y)//如果Y坐标小于等于当前的按钮，就是置顶按钮
                {
                    topButtons.Add(b);
                }
                else
                {
                    bottomButtons.Add(b);//如果Y坐标大于当前点击的按钮，就是置底按钮
                }
            }


            for (int i = topButtons.Count - 1; i >= 0; i--)//坐标往上的,后添加的在上(数组是正的)
            {
                Button b = topButtons[i];
                b.SendToBack();
                b.Dock = DockStyle.Top;
            }

            for (int i = 0; i < bottomButtons.Count; i++)//坐标往下的，正向的，后添加的在下(数组是正的)
            {
                Button b = bottomButtons[i];
                b.SendToBack();
                b.Dock = DockStyle.Bottom;
            }


        }



        /// <summary>
        /// 隐藏显示菜单栏
        /// </summary>
        /// <param Name="sender"></param>
        /// <param Name="e"></param>
        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {
            if (skinSplitContainer_main.Panel1Collapsed == false)
            {
                skinSplitContainer_main.Panel1Collapsed = true;//隐藏
                //toolStripStatusLabel_displayMenu.Image = client.Properties.Resources.forward;

            }
            else
            {
                skinSplitContainer_main.Panel1Collapsed = false;//显示
                //toolStripStatusLabel_displayMenu.Image = client.Properties.Resources.back;
            }
        }



        private void splitContainer_main_SplitterMoved(object sender, SplitterEventArgs e)
        {
            this.refreshFunButtonSize();
        }



        private void Main_Resize(object sender, EventArgs e)
        {
            this.refreshFunButtonSize();
            //   this.refreshOpenedWindowSize();
        }



        /// <summary>
        /// 打开窗体
        /// </summary>
        /// <param Name="form"></param>
        private void openForm(Form form)
        {
            //if (0==this.FormList.Count)//没有打开窗口，不会产生循环，就给他添加一个窗体
            //{
            //    this.addForm(form);//添加窗体在list中
            //    this.showForm(form);
            //}

            //bool flag = false;//是否打开了当前点击的窗口，false打开，true没有打开

            //for (int j = 0; j < this.FormList.Count; j++)
            //{
            //    Form tmp = this.FormList[j];
            //    if (tmp.Name == form.Name)//如果点击的窗口已经在list中了，就打开
            //    {
            //        showForm(tmp);
            //        flag = false;//如果打开
            //        break;
            //    }
            //    if (tmp.Name != form.Name)//判断有没有打开此窗口
            //    {
            //        flag = true;
            //    }
            //}
            //if (flag)//遍历了list之后如果此窗体没有在list中，就添加，并且显示
            //{
            //    this.addForm(form);
            //    this.showForm(form);

            //}

            //this.label_openform.Text = this.FormList.Count.ToString();

            Model.RBAC.Rbac_modules formModules = (Rbac_modules)form.Tag;



            bool isOpen = false;//是否打开,true打开，false没打开
            for (int i = 0; i < skinTabControl_main.TabCount; i++)//检测已经有的tab，是否是我想打开的这个tab，如果是就设置ISOPEN为true
            {
                TabPage tp = (TabPage)skinTabControl_main.TabPages[i];
                Model.RBAC.Rbac_modules tabPageModules = (Rbac_modules)tp.Tag;
                if (tabPageModules.Id == formModules.Id)
                {
                    skinTabControl_main.SelectedTab = tp;

                    isOpen = true;
                }
            }

            if (!isOpen || skinTabControl_main.TabPages.Count == 0)
            {

                //设置form属性
                form.TopLevel = false;
                form.Show();//先show窗体，不然新增的字段不会显示在panel中，待父控件都建好以后，添加好form，再设置form的最大化和边框属性，不然的话窗体会大掉，覆盖住翻页控件



                //设置选项卡属性
                TabPage tp = new TabPage();
                tp.Tag = formModules;
                tp.Name = "TabPage_" + formModules.Name;
                tp.Text = formModules.Name;
                tp.AutoScroll = true;



                tp.Controls.Add(form);
                skinTabControl_main.TabPages.Add(tp);

                skinTabControl_main.SelectedTab = tp;


            }
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            //form.WindowState = FormWindowState.Maximized;
            form.AutoScroll = true;
            form.Focus();
            form.BringToFront();


        }





        private void timer_start_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + TIMER_START_STEP;
            if (1 == this.Opacity)
            {
                this.timer_start.Stop();
            }
        }





        private void skinSplitContainer_main_SplitterMoved(object sender, SplitterEventArgs e)
        {
            this.refreshFunButtonSize();

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }






    }
}
