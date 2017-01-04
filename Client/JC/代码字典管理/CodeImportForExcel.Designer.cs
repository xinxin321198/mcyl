namespace client.JC.代码字典管理
{
    partial class CodeImportForExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeImportForExcel));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_IsPinyinWuBi = new System.Windows.Forms.CheckBox();
            this.skinButton__选择文件 = new CCWin.SkinControl.SkinButton();
            this.skinButton__import = new CCWin.SkinControl.SkinButton();
            this.skinDataGridView_code = new CCWin.SkinControl.SkinDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_code)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择文件前请先清除excel中的格式";
            // 
            // checkBox_IsPinyinWuBi
            // 
            this.checkBox_IsPinyinWuBi.AutoSize = true;
            this.checkBox_IsPinyinWuBi.Location = new System.Drawing.Point(486, 18);
            this.checkBox_IsPinyinWuBi.Name = "checkBox_IsPinyinWuBi";
            this.checkBox_IsPinyinWuBi.Size = new System.Drawing.Size(180, 16);
            this.checkBox_IsPinyinWuBi.TabIndex = 4;
            this.checkBox_IsPinyinWuBi.Text = "是否自动生成拼音码及五笔码";
            this.checkBox_IsPinyinWuBi.UseVisualStyleBackColor = true;
            this.checkBox_IsPinyinWuBi.CheckedChanged += new System.EventHandler(this.checkBox_IsPinyinWuBi_CheckedChanged);
            // 
            // skinButton__选择文件
            // 
            this.skinButton__选择文件.BackColor = System.Drawing.Color.Transparent;
            this.skinButton__选择文件.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton__选择文件.DownBack = null;
            this.skinButton__选择文件.Location = new System.Drawing.Point(12, 12);
            this.skinButton__选择文件.MouseBack = null;
            this.skinButton__选择文件.Name = "skinButton__选择文件";
            this.skinButton__选择文件.NormlBack = null;
            this.skinButton__选择文件.Size = new System.Drawing.Size(114, 23);
            this.skinButton__选择文件.TabIndex = 5;
            this.skinButton__选择文件.Text = "选择excel文件";
            this.skinButton__选择文件.UseVisualStyleBackColor = false;
            this.skinButton__选择文件.Click += new System.EventHandler(this.button_选择文件_Click);
            // 
            // skinButton__import
            // 
            this.skinButton__import.BackColor = System.Drawing.Color.Transparent;
            this.skinButton__import.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton__import.DownBack = null;
            this.skinButton__import.Location = new System.Drawing.Point(132, 13);
            this.skinButton__import.MouseBack = null;
            this.skinButton__import.Name = "skinButton__import";
            this.skinButton__import.NormlBack = null;
            this.skinButton__import.Size = new System.Drawing.Size(114, 23);
            this.skinButton__import.TabIndex = 6;
            this.skinButton__import.Text = "导入到数据库";
            this.skinButton__import.UseVisualStyleBackColor = false;
            this.skinButton__import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // skinDataGridView_code
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView_code.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.skinDataGridView_code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinDataGridView_code.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView_code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView_code.ColumnFont = null;
            this.skinDataGridView_code.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView_code.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.skinDataGridView_code.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView_code.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView_code.DefaultCellStyle = dataGridViewCellStyle3;
            this.skinDataGridView_code.EnableHeadersVisualStyles = false;
            this.skinDataGridView_code.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridView_code.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView_code.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_code.Location = new System.Drawing.Point(6, 42);
            this.skinDataGridView_code.Name = "skinDataGridView_code";
            this.skinDataGridView_code.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView_code.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_code.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.skinDataGridView_code.RowTemplate.Height = 23;
            this.skinDataGridView_code.Size = new System.Drawing.Size(674, 352);
            this.skinDataGridView_code.TabIndex = 7;
            this.skinDataGridView_code.TitleBack = null;
            this.skinDataGridView_code.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView_code.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // CodeImportForExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 406);
            this.Controls.Add(this.skinDataGridView_code);
            this.Controls.Add(this.skinButton__import);
            this.Controls.Add(this.skinButton__选择文件);
            this.Controls.Add(this.checkBox_IsPinyinWuBi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeImportForExcel";
            this.Text = "代码从excel导入";
            this.Load += new System.EventHandler(this.CodeImportForExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_IsPinyinWuBi;
        private CCWin.SkinControl.SkinButton skinButton__选择文件;
        private CCWin.SkinControl.SkinButton skinButton__import;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView_code;
    }
}