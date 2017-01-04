namespace client.JC.发票管理
{
    partial class FplyEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FplyEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox起始号 = new System.Windows.Forms.TextBox();
            this.textBox终止号 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox类型 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_xm = new System.Windows.Forms.TextBox();
            this.skinButton_save = new CCWin.SkinControl.SkinButton();
            this.skinButton_cancel = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始号";
            // 
            // textBox起始号
            // 
            this.textBox起始号.Location = new System.Drawing.Point(117, 97);
            this.textBox起始号.Name = "textBox起始号";
            this.textBox起始号.Size = new System.Drawing.Size(121, 21);
            this.textBox起始号.TabIndex = 1;
            // 
            // textBox终止号
            // 
            this.textBox终止号.Location = new System.Drawing.Point(360, 97);
            this.textBox终止号.Name = "textBox终止号";
            this.textBox终止号.Size = new System.Drawing.Size(123, 21);
            this.textBox终止号.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "终止号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "发票类型";
            // 
            // comboBox类型
            // 
            this.comboBox类型.FormattingEnabled = true;
            this.comboBox类型.Items.AddRange(new object[] {
            "1、门诊发票",
            "2、住院发票"});
            this.comboBox类型.Location = new System.Drawing.Point(117, 47);
            this.comboBox类型.Name = "comboBox类型";
            this.comboBox类型.Size = new System.Drawing.Size(121, 20);
            this.comboBox类型.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "领票人";
            // 
            // textBox_xm
            // 
            this.textBox_xm.Location = new System.Drawing.Point(360, 46);
            this.textBox_xm.Name = "textBox_xm";
            this.textBox_xm.ReadOnly = true;
            this.textBox_xm.Size = new System.Drawing.Size(123, 21);
            this.textBox_xm.TabIndex = 9;
            // 
            // skinButton_save
            // 
            this.skinButton_save.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_save.DownBack = null;
            this.skinButton_save.Location = new System.Drawing.Point(163, 176);
            this.skinButton_save.MouseBack = null;
            this.skinButton_save.Name = "skinButton_save";
            this.skinButton_save.NormlBack = null;
            this.skinButton_save.Size = new System.Drawing.Size(75, 23);
            this.skinButton_save.TabIndex = 10;
            this.skinButton_save.Text = "保存";
            this.skinButton_save.UseVisualStyleBackColor = false;
            this.skinButton_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // skinButton_cancel
            // 
            this.skinButton_cancel.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_cancel.DownBack = null;
            this.skinButton_cancel.Location = new System.Drawing.Point(300, 176);
            this.skinButton_cancel.MouseBack = null;
            this.skinButton_cancel.Name = "skinButton_cancel";
            this.skinButton_cancel.NormlBack = null;
            this.skinButton_cancel.Size = new System.Drawing.Size(75, 23);
            this.skinButton_cancel.TabIndex = 11;
            this.skinButton_cancel.Text = "取消";
            this.skinButton_cancel.UseVisualStyleBackColor = false;
            this.skinButton_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // FplyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 229);
            this.Controls.Add(this.skinButton_cancel);
            this.Controls.Add(this.skinButton_save);
            this.Controls.Add(this.textBox_xm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox类型);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox终止号);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox起始号);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FplyEdit";
            this.Text = "领取发票";
            this.Load += new System.EventHandler(this.FplyEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox起始号;
        private System.Windows.Forms.TextBox textBox终止号;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox类型;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_xm;
        private CCWin.SkinControl.SkinButton skinButton_save;
        private CCWin.SkinControl.SkinButton skinButton_cancel;
    }
}