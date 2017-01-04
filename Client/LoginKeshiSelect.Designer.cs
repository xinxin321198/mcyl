namespace client
{
    partial class LoginKeshiSelect
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinDataGridView_keshi = new CCWin.SkinControl.SkinDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_keshi)).BeginInit();
            this.SuspendLayout();
            // 
            // skinDataGridView_keshi
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView_keshi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.skinDataGridView_keshi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView_keshi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView_keshi.ColumnFont = null;
            this.skinDataGridView_keshi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView_keshi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.skinDataGridView_keshi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView_keshi.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView_keshi.DefaultCellStyle = dataGridViewCellStyle7;
            this.skinDataGridView_keshi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinDataGridView_keshi.EnableHeadersVisualStyles = false;
            this.skinDataGridView_keshi.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridView_keshi.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView_keshi.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_keshi.Location = new System.Drawing.Point(0, 0);
            this.skinDataGridView_keshi.Name = "skinDataGridView_keshi";
            this.skinDataGridView_keshi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView_keshi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_keshi.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.skinDataGridView_keshi.RowTemplate.Height = 23;
            this.skinDataGridView_keshi.Size = new System.Drawing.Size(284, 262);
            this.skinDataGridView_keshi.TabIndex = 0;
            this.skinDataGridView_keshi.TitleBack = null;
            this.skinDataGridView_keshi.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView_keshi.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.skinDataGridView_keshi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.skinDataGridView_keshi_MouseDoubleClick);
            // 
            // LoginKeshiSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.skinDataGridView_keshi);
            this.Name = "LoginKeshiSelect";
            this.Text = "请双击选择当前要登录的科室";
            this.Load += new System.EventHandler(this.LoginKeshiSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_keshi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView skinDataGridView_keshi;
    }
}