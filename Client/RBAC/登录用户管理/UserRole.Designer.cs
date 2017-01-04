namespace client.JC.登录用户管理
{
    partial class UserRole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinButton_save = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_username = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox_renyuanName = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.listView_role = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // skinButton_save
            // 
            this.skinButton_save.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_save.DownBack = null;
            this.skinButton_save.Location = new System.Drawing.Point(101, 396);
            this.skinButton_save.MouseBack = null;
            this.skinButton_save.Name = "skinButton_save";
            this.skinButton_save.NormlBack = null;
            this.skinButton_save.Size = new System.Drawing.Size(75, 23);
            this.skinButton_save.TabIndex = 1;
            this.skinButton_save.Text = "确定";
            this.skinButton_save.UseVisualStyleBackColor = false;
            this.skinButton_save.Click += new System.EventHandler(this.skinButton_save_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(12, 9);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "用户名";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(12, 46);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "人员姓名";
            // 
            // skinTextBox_username
            // 
            this.skinTextBox_username.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_username.DownBack = null;
            this.skinTextBox_username.Icon = null;
            this.skinTextBox_username.IconIsButton = false;
            this.skinTextBox_username.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_username.IsPasswordChat = '\0';
            this.skinTextBox_username.IsSystemPasswordChar = false;
            this.skinTextBox_username.Lines = new string[0];
            this.skinTextBox_username.Location = new System.Drawing.Point(84, 3);
            this.skinTextBox_username.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_username.MaxLength = 32767;
            this.skinTextBox_username.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_username.MouseBack = null;
            this.skinTextBox_username.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_username.Multiline = false;
            this.skinTextBox_username.Name = "skinTextBox_username";
            this.skinTextBox_username.NormlBack = null;
            this.skinTextBox_username.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_username.ReadOnly = false;
            this.skinTextBox_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_username.Size = new System.Drawing.Size(173, 28);
            // 
            // 
            // 
            this.skinTextBox_username.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_username.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_username.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_username.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_username.SkinTxt.Name = "BaseText";
            this.skinTextBox_username.SkinTxt.Size = new System.Drawing.Size(163, 18);
            this.skinTextBox_username.SkinTxt.TabIndex = 0;
            this.skinTextBox_username.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_username.SkinTxt.WaterText = "";
            this.skinTextBox_username.TabIndex = 4;
            this.skinTextBox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_username.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_username.WaterText = "";
            this.skinTextBox_username.WordWrap = true;
            // 
            // skinTextBox_renyuanName
            // 
            this.skinTextBox_renyuanName.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_renyuanName.DownBack = null;
            this.skinTextBox_renyuanName.Icon = null;
            this.skinTextBox_renyuanName.IconIsButton = false;
            this.skinTextBox_renyuanName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_renyuanName.IsPasswordChat = '\0';
            this.skinTextBox_renyuanName.IsSystemPasswordChar = false;
            this.skinTextBox_renyuanName.Lines = new string[0];
            this.skinTextBox_renyuanName.Location = new System.Drawing.Point(84, 39);
            this.skinTextBox_renyuanName.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_renyuanName.MaxLength = 32767;
            this.skinTextBox_renyuanName.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_renyuanName.MouseBack = null;
            this.skinTextBox_renyuanName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_renyuanName.Multiline = true;
            this.skinTextBox_renyuanName.Name = "skinTextBox_renyuanName";
            this.skinTextBox_renyuanName.NormlBack = null;
            this.skinTextBox_renyuanName.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_renyuanName.ReadOnly = false;
            this.skinTextBox_renyuanName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_renyuanName.Size = new System.Drawing.Size(173, 31);
            // 
            // 
            // 
            this.skinTextBox_renyuanName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_renyuanName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_renyuanName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_renyuanName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_renyuanName.SkinTxt.Multiline = true;
            this.skinTextBox_renyuanName.SkinTxt.Name = "BaseText";
            this.skinTextBox_renyuanName.SkinTxt.Size = new System.Drawing.Size(163, 21);
            this.skinTextBox_renyuanName.SkinTxt.TabIndex = 0;
            this.skinTextBox_renyuanName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_renyuanName.SkinTxt.WaterText = "";
            this.skinTextBox_renyuanName.TabIndex = 5;
            this.skinTextBox_renyuanName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_renyuanName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_renyuanName.WaterText = "";
            this.skinTextBox_renyuanName.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(12, 79);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(92, 17);
            this.skinLabel3.TabIndex = 7;
            this.skinLabel3.Text = "用户拥有的角色";
            // 
            // listView_role
            // 
            this.listView_role.CheckBoxes = true;
            this.listView_role.Location = new System.Drawing.Point(15, 99);
            this.listView_role.Name = "listView_role";
            this.listView_role.Size = new System.Drawing.Size(242, 291);
            this.listView_role.TabIndex = 8;
            this.listView_role.UseCompatibleStateImageBehavior = false;
            // 
            // UserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 431);
            this.Controls.Add(this.listView_role);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinTextBox_renyuanName);
            this.Controls.Add(this.skinTextBox_username);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinButton_save);
            this.Name = "UserRole";
            this.Text = "用户角色设置";
            this.Load += new System.EventHandler(this.UserRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButton_save;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox skinTextBox_username;
        private CCWin.SkinControl.SkinTextBox skinTextBox_renyuanName;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.ListView listView_role;
    }
}