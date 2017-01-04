namespace client.JC.代码字典管理
{
    partial class CodeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.label_value = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_parentCodeType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_zfbz = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_remark = new System.Windows.Forms.RichTextBox();
            this.textBox_五笔码 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_拼音码 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.skinButton_save = new CCWin.SkinControl.SkinButton();
            this.skinButton_cancel = new CCWin.SkinControl.SkinButton();
            this.label12 = new System.Windows.Forms.Label();
            this.skinNumericUpDown_排序码 = new CCWin.SkinControl.SkinNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.skinNumericUpDown_排序码)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.Location = new System.Drawing.Point(95, 33);
            this.textBox_name.MaxLength = 20;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(235, 21);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_value
            // 
            this.textBox_value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_value.Location = new System.Drawing.Point(95, 60);
            this.textBox_value.MaxLength = 6;
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(235, 21);
            this.textBox_value.TabIndex = 3;
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(72, 63);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(17, 12);
            this.label_value.TabIndex = 2;
            this.label_value.Text = "值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "所属代码类别";
            // 
            // textBox_parentCodeType
            // 
            this.textBox_parentCodeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_parentCodeType.Location = new System.Drawing.Point(95, 6);
            this.textBox_parentCodeType.Name = "textBox_parentCodeType";
            this.textBox_parentCodeType.ReadOnly = true;
            this.textBox_parentCodeType.Size = new System.Drawing.Size(235, 21);
            this.textBox_parentCodeType.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "作废标志";
            // 
            // comboBox_zfbz
            // 
            this.comboBox_zfbz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_zfbz.Location = new System.Drawing.Point(95, 139);
            this.comboBox_zfbz.Name = "comboBox_zfbz";
            this.comboBox_zfbz.Size = new System.Drawing.Size(235, 20);
            this.comboBox_zfbz.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "备注";
            // 
            // richTextBox_remark
            // 
            this.richTextBox_remark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_remark.Location = new System.Drawing.Point(95, 191);
            this.richTextBox_remark.MaxLength = 50;
            this.richTextBox_remark.Name = "richTextBox_remark";
            this.richTextBox_remark.Size = new System.Drawing.Size(235, 55);
            this.richTextBox_remark.TabIndex = 8;
            this.richTextBox_remark.Text = "";
            // 
            // textBox_五笔码
            // 
            this.textBox_五笔码.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_五笔码.Location = new System.Drawing.Point(95, 114);
            this.textBox_五笔码.MaxLength = 6;
            this.textBox_五笔码.Name = "textBox_五笔码";
            this.textBox_五笔码.Size = new System.Drawing.Size(235, 21);
            this.textBox_五笔码.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "五笔码";
            // 
            // textBox_拼音码
            // 
            this.textBox_拼音码.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_拼音码.Location = new System.Drawing.Point(95, 87);
            this.textBox_拼音码.MaxLength = 20;
            this.textBox_拼音码.Name = "textBox_拼音码";
            this.textBox_拼音码.Size = new System.Drawing.Size(235, 21);
            this.textBox_拼音码.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "拼音码";
            // 
            // skinButton_save
            // 
            this.skinButton_save.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_save.DownBack = null;
            this.skinButton_save.Location = new System.Drawing.Point(95, 269);
            this.skinButton_save.MouseBack = null;
            this.skinButton_save.Name = "skinButton_save";
            this.skinButton_save.NormlBack = null;
            this.skinButton_save.Size = new System.Drawing.Size(75, 23);
            this.skinButton_save.TabIndex = 9;
            this.skinButton_save.Text = "保存";
            this.skinButton_save.UseVisualStyleBackColor = false;
            this.skinButton_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // skinButton_cancel
            // 
            this.skinButton_cancel.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.skinButton_cancel.DownBack = null;
            this.skinButton_cancel.Location = new System.Drawing.Point(176, 269);
            this.skinButton_cancel.MouseBack = null;
            this.skinButton_cancel.Name = "skinButton_cancel";
            this.skinButton_cancel.NormlBack = null;
            this.skinButton_cancel.Size = new System.Drawing.Size(75, 23);
            this.skinButton_cancel.TabIndex = 10;
            this.skinButton_cancel.Text = "取消";
            this.skinButton_cancel.UseVisualStyleBackColor = false;
            this.skinButton_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 28;
            this.label12.Text = "排序码";
            // 
            // skinNumericUpDown_排序码
            // 
            this.skinNumericUpDown_排序码.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinNumericUpDown_排序码.Location = new System.Drawing.Point(95, 165);
            this.skinNumericUpDown_排序码.Name = "skinNumericUpDown_排序码";
            this.skinNumericUpDown_排序码.Size = new System.Drawing.Size(235, 21);
            this.skinNumericUpDown_排序码.TabIndex = 7;
            // 
            // CodeEdit
            // 
            this.AcceptButton = this.skinButton_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.skinButton_cancel;
            this.ClientSize = new System.Drawing.Size(342, 304);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.skinNumericUpDown_排序码);
            this.Controls.Add(this.skinButton_cancel);
            this.Controls.Add(this.skinButton_save);
            this.Controls.Add(this.textBox_五笔码);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_拼音码);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox_remark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_zfbz);
            this.Controls.Add(this.textBox_parentCodeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeEdit";
            this.Text = "代码编辑";
            this.Load += new System.EventHandler(this.CodeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinNumericUpDown_排序码)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_parentCodeType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_zfbz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox_remark;
        private System.Windows.Forms.TextBox textBox_五笔码;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_拼音码;
        private System.Windows.Forms.Label label4;
        private CCWin.SkinControl.SkinButton skinButton_save;
        private CCWin.SkinControl.SkinButton skinButton_cancel;
        private System.Windows.Forms.Label label12;
        private CCWin.SkinControl.SkinNumericUpDown skinNumericUpDown_排序码;
    }
}