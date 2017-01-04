namespace client.JC.登录用户管理
{
    partial class UserEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_zfbz = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_userType = new System.Windows.Forms.ComboBox();
            this.textBox_pwdCheck = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_remark = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.skinButton_save = new CCWin.SkinControl.SkinButton();
            this.skinButton_cancel = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(94, 40);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(215, 21);
            this.textBox_userName.TabIndex = 1;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(94, 67);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PasswordChar = '*';
            this.textBox_pwd.Size = new System.Drawing.Size(215, 21);
            this.textBox_pwd.TabIndex = 3;
            this.textBox_pwd.TextChanged += new System.EventHandler(this.textBox_pwd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // comboBox_zfbz
            // 
            this.comboBox_zfbz.Location = new System.Drawing.Point(94, 147);
            this.comboBox_zfbz.Name = "comboBox_zfbz";
            this.comboBox_zfbz.Size = new System.Drawing.Size(215, 20);
            this.comboBox_zfbz.TabIndex = 4;
            this.comboBox_zfbz.SelectedIndexChanged += new System.EventHandler(this.comboBox_zfbz_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "是否启用：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "类别：";
            // 
            // comboBox_userType
            // 
            this.comboBox_userType.FormattingEnabled = true;
            this.comboBox_userType.Items.AddRange(new object[] {
            "医生",
            "护士",
            "收费",
            "财务",
            "医技",
            "行政"});
            this.comboBox_userType.Location = new System.Drawing.Point(94, 121);
            this.comboBox_userType.Name = "comboBox_userType";
            this.comboBox_userType.Size = new System.Drawing.Size(215, 20);
            this.comboBox_userType.TabIndex = 8;
            // 
            // textBox_pwdCheck
            // 
            this.textBox_pwdCheck.Location = new System.Drawing.Point(94, 94);
            this.textBox_pwdCheck.Name = "textBox_pwdCheck";
            this.textBox_pwdCheck.PasswordChar = '*';
            this.textBox_pwdCheck.Size = new System.Drawing.Size(215, 21);
            this.textBox_pwdCheck.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "密码确认：";
            // 
            // richTextBox_remark
            // 
            this.richTextBox_remark.Location = new System.Drawing.Point(94, 173);
            this.richTextBox_remark.Name = "richTextBox_remark";
            this.richTextBox_remark.Size = new System.Drawing.Size(215, 96);
            this.richTextBox_remark.TabIndex = 14;
            this.richTextBox_remark.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "备注：";
            // 
            // skinButton_save
            // 
            this.skinButton_save.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_save.DownBack = null;
            this.skinButton_save.Location = new System.Drawing.Point(94, 292);
            this.skinButton_save.MouseBack = null;
            this.skinButton_save.Name = "skinButton_save";
            this.skinButton_save.NormlBack = null;
            this.skinButton_save.Size = new System.Drawing.Size(75, 23);
            this.skinButton_save.TabIndex = 16;
            this.skinButton_save.Text = "保存";
            this.skinButton_save.UseVisualStyleBackColor = false;
            this.skinButton_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // skinButton_cancel
            // 
            this.skinButton_cancel.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_cancel.DownBack = null;
            this.skinButton_cancel.Location = new System.Drawing.Point(234, 292);
            this.skinButton_cancel.MouseBack = null;
            this.skinButton_cancel.Name = "skinButton_cancel";
            this.skinButton_cancel.NormlBack = null;
            this.skinButton_cancel.Size = new System.Drawing.Size(75, 23);
            this.skinButton_cancel.TabIndex = 17;
            this.skinButton_cancel.Text = "取消";
            this.skinButton_cancel.UseVisualStyleBackColor = false;
            this.skinButton_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 327);
            this.Controls.Add(this.skinButton_cancel);
            this.Controls.Add(this.skinButton_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox_remark);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_pwdCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_userType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_zfbz);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserEdit";
            this.Text = "用户编辑";
            this.Load += new System.EventHandler(this.UserEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_zfbz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_userType;
        private System.Windows.Forms.TextBox textBox_pwdCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox_remark;
        private System.Windows.Forms.Label label4;
        private CCWin.SkinControl.SkinButton skinButton_save;
        private CCWin.SkinControl.SkinButton skinButton_cancel;
    }
}