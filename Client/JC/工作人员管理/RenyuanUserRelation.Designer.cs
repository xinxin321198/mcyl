namespace client.JC.工作人员管理
{
    partial class RenyuanUserRelation
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_xm = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_msg = new System.Windows.Forms.Label();
            this.skinButton_save = new CCWin.SkinControl.SkinButton();
            this.listView_user = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_sfzh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "人员姓名：";
            // 
            // textBox_xm
            // 
            this.textBox_xm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_xm.Location = new System.Drawing.Point(93, 6);
            this.textBox_xm.Name = "textBox_xm";
            this.textBox_xm.Size = new System.Drawing.Size(265, 21);
            this.textBox_xm.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // label_msg
            // 
            this.label_msg.AutoSize = true;
            this.label_msg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_msg.ForeColor = System.Drawing.Color.Maroon;
            this.label_msg.Location = new System.Drawing.Point(21, 142);
            this.label_msg.Name = "label_msg";
            this.label_msg.Size = new System.Drawing.Size(0, 16);
            this.label_msg.TabIndex = 8;
            // 
            // skinButton_save
            // 
            this.skinButton_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skinButton_save.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_save.DownBack = null;
            this.skinButton_save.Location = new System.Drawing.Point(159, 324);
            this.skinButton_save.MouseBack = null;
            this.skinButton_save.Name = "skinButton_save";
            this.skinButton_save.NormlBack = null;
            this.skinButton_save.Size = new System.Drawing.Size(75, 23);
            this.skinButton_save.TabIndex = 9;
            this.skinButton_save.Text = "保存";
            this.skinButton_save.UseVisualStyleBackColor = false;
            this.skinButton_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // listView_user
            // 
            this.listView_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_user.Location = new System.Drawing.Point(93, 60);
            this.listView_user.Name = "listView_user";
            this.listView_user.Size = new System.Drawing.Size(265, 245);
            this.listView_user.TabIndex = 14;
            this.listView_user.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "拥有的账号：";
            // 
            // textBox_sfzh
            // 
            this.textBox_sfzh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_sfzh.Location = new System.Drawing.Point(93, 33);
            this.textBox_sfzh.Name = "textBox_sfzh";
            this.textBox_sfzh.Size = new System.Drawing.Size(265, 21);
            this.textBox_sfzh.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "身份证号：";
            // 
            // RenyuanUserRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 362);
            this.Controls.Add(this.listView_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_sfzh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skinButton_save);
            this.Controls.Add(this.label_msg);
            this.Controls.Add(this.textBox_xm);
            this.Controls.Add(this.label1);
            this.Name = "RenyuanUserRelation";
            this.Text = "人员的账户";
            this.Load += new System.EventHandler(this.RenyuanUserRelation_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_xm;
        private System.Windows.Forms.Label label_msg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private CCWin.SkinControl.SkinButton skinButton_save;
        private System.Windows.Forms.ListView listView_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_sfzh;
        private System.Windows.Forms.Label label2;
    }
}