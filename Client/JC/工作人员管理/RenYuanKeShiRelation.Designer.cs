namespace client.JC.工作人员管理
{
    partial class RenYuanKeShiRelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenYuanKeShiRelation));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_xm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_sfzh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.skinButton_save = new CCWin.SkinControl.SkinButton();
            this.listView_keshi = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "人员姓名：";
            // 
            // textBox_xm
            // 
            this.textBox_xm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_xm.Location = new System.Drawing.Point(83, 6);
            this.textBox_xm.Name = "textBox_xm";
            this.textBox_xm.Size = new System.Drawing.Size(265, 21);
            this.textBox_xm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "身份证号：";
            // 
            // textBox_sfzh
            // 
            this.textBox_sfzh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_sfzh.Location = new System.Drawing.Point(83, 33);
            this.textBox_sfzh.Name = "textBox_sfzh";
            this.textBox_sfzh.Size = new System.Drawing.Size(265, 21);
            this.textBox_sfzh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "所属科室：";
            // 
            // skinButton_save
            // 
            this.skinButton_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skinButton_save.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_save.DownBack = null;
            this.skinButton_save.Location = new System.Drawing.Point(157, 327);
            this.skinButton_save.MouseBack = null;
            this.skinButton_save.Name = "skinButton_save";
            this.skinButton_save.NormlBack = null;
            this.skinButton_save.Size = new System.Drawing.Size(75, 23);
            this.skinButton_save.TabIndex = 7;
            this.skinButton_save.Text = "保存";
            this.skinButton_save.UseVisualStyleBackColor = false;
            this.skinButton_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // listView_keshi
            // 
            this.listView_keshi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_keshi.Location = new System.Drawing.Point(83, 60);
            this.listView_keshi.Name = "listView_keshi";
            this.listView_keshi.Size = new System.Drawing.Size(265, 261);
            this.listView_keshi.TabIndex = 8;
            this.listView_keshi.UseCompatibleStateImageBehavior = false;
            // 
            // RenYuanKeShiRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 362);
            this.Controls.Add(this.listView_keshi);
            this.Controls.Add(this.skinButton_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_sfzh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_xm);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RenYuanKeShiRelation";
            this.Text = "人员所属科室";
            this.Load += new System.EventHandler(this.RenYuanKeShiRelation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_xm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_sfzh;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinButton skinButton_save;
        private System.Windows.Forms.ListView listView_keshi;
    }
}