namespace client
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param Name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_service_login = new System.Windows.Forms.Button();
            this.skinTextBox__username = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox__password = new CCWin.SkinControl.SkinTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Sample = new System.Windows.Forms.Button();
            this.skinButton_login = new CCWin.SkinControl.SkinButton();
            this.skinButton_tuichu = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(34, 31);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(53, 12);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "用户名：";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(46, 61);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(41, 12);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "密码：";
            // 
            // button_service_login
            // 
            this.button_service_login.Enabled = false;
            this.button_service_login.Location = new System.Drawing.Point(143, 128);
            this.button_service_login.Name = "button_service_login";
            this.button_service_login.Size = new System.Drawing.Size(86, 23);
            this.button_service_login.TabIndex = 6;
            this.button_service_login.Text = "WCF远程登录";
            this.button_service_login.UseVisualStyleBackColor = true;
            this.button_service_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // skinTextBox__username
            // 
            this.skinTextBox__username.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox__username.DownBack = null;
            this.skinTextBox__username.Icon = null;
            this.skinTextBox__username.IconIsButton = false;
            this.skinTextBox__username.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox__username.IsPasswordChat = '\0';
            this.skinTextBox__username.IsSystemPasswordChar = false;
            this.skinTextBox__username.Lines = new string[] {
        "skinTextBox1"};
            this.skinTextBox__username.Location = new System.Drawing.Point(90, 21);
            this.skinTextBox__username.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox__username.MaxLength = 32767;
            this.skinTextBox__username.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox__username.MouseBack = null;
            this.skinTextBox__username.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox__username.Multiline = false;
            this.skinTextBox__username.Name = "skinTextBox__username";
            this.skinTextBox__username.NormlBack = null;
            this.skinTextBox__username.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox__username.ReadOnly = false;
            this.skinTextBox__username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox__username.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBox__username.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox__username.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox__username.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox__username.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox__username.SkinTxt.Name = "BaseText";
            this.skinTextBox__username.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.skinTextBox__username.SkinTxt.TabIndex = 0;
            this.skinTextBox__username.SkinTxt.Text = "skinTextBox1";
            this.skinTextBox__username.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox__username.SkinTxt.WaterText = "";
            this.skinTextBox__username.TabIndex = 7;
            this.skinTextBox__username.Text = "skinTextBox1";
            this.skinTextBox__username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox__username.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox__username.WaterText = "";
            this.skinTextBox__username.WordWrap = true;
            // 
            // skinTextBox__password
            // 
            this.skinTextBox__password.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox__password.DownBack = null;
            this.skinTextBox__password.Icon = null;
            this.skinTextBox__password.IconIsButton = false;
            this.skinTextBox__password.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox__password.IsPasswordChat = '\0';
            this.skinTextBox__password.IsSystemPasswordChar = false;
            this.skinTextBox__password.Lines = new string[] {
        "skinTextBox2"};
            this.skinTextBox__password.Location = new System.Drawing.Point(90, 53);
            this.skinTextBox__password.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox__password.MaxLength = 32767;
            this.skinTextBox__password.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox__password.MouseBack = null;
            this.skinTextBox__password.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox__password.Multiline = false;
            this.skinTextBox__password.Name = "skinTextBox__password";
            this.skinTextBox__password.NormlBack = null;
            this.skinTextBox__password.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox__password.ReadOnly = false;
            this.skinTextBox__password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox__password.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBox__password.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox__password.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox__password.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox__password.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox__password.SkinTxt.Name = "BaseText";
            this.skinTextBox__password.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.skinTextBox__password.SkinTxt.TabIndex = 0;
            this.skinTextBox__password.SkinTxt.Text = "skinTextBox2";
            this.skinTextBox__password.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox__password.SkinTxt.WaterText = "";
            this.skinTextBox__password.TabIndex = 8;
            this.skinTextBox__password.Text = "skinTextBox2";
            this.skinTextBox__password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox__password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox__password.WaterText = "";
            this.skinTextBox__password.WordWrap = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(293, 64);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(293, 64);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_Sample
            // 
            this.button_Sample.Location = new System.Drawing.Point(415, 12);
            this.button_Sample.Name = "button_Sample";
            this.button_Sample.Size = new System.Drawing.Size(75, 23);
            this.button_Sample.TabIndex = 13;
            this.button_Sample.Text = "示例代码";
            this.button_Sample.UseVisualStyleBackColor = true;
            this.button_Sample.Click += new System.EventHandler(this.button_Sample_Click);
            // 
            // skinButton_login
            // 
            this.skinButton_login.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_login.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_login.DownBack = null;
            this.skinButton_login.Location = new System.Drawing.Point(48, 128);
            this.skinButton_login.MouseBack = null;
            this.skinButton_login.Name = "skinButton_login";
            this.skinButton_login.NormlBack = null;
            this.skinButton_login.Size = new System.Drawing.Size(75, 23);
            this.skinButton_login.TabIndex = 14;
            this.skinButton_login.Text = "登录";
            this.skinButton_login.UseVisualStyleBackColor = false;
            this.skinButton_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // skinButton_tuichu
            // 
            this.skinButton_tuichu.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_tuichu.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_tuichu.DownBack = null;
            this.skinButton_tuichu.Location = new System.Drawing.Point(246, 128);
            this.skinButton_tuichu.MouseBack = null;
            this.skinButton_tuichu.Name = "skinButton_tuichu";
            this.skinButton_tuichu.NormlBack = null;
            this.skinButton_tuichu.Size = new System.Drawing.Size(75, 23);
            this.skinButton_tuichu.TabIndex = 15;
            this.skinButton_tuichu.Text = "退出";
            this.skinButton_tuichu.UseVisualStyleBackColor = false;
            this.skinButton_tuichu.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.skinButton_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 173);
            this.Controls.Add(this.skinButton_tuichu);
            this.Controls.Add(this.skinButton_login);
            this.Controls.Add(this.button_Sample);
            this.Controls.Add(this.skinTextBox__password);
            this.Controls.Add(this.skinTextBox__username);
            this.Controls.Add(this.button_service_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_service_login;
        private CCWin.SkinControl.SkinTextBox skinTextBox__username;
        private CCWin.SkinControl.SkinTextBox skinTextBox__password;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_Sample;
        private CCWin.SkinControl.SkinButton skinButton_login;
        private CCWin.SkinControl.SkinButton skinButton_tuichu;
    }
}

