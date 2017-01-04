namespace client.JC.代码字典管理
{
    partial class CodeSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeSearch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_codeTypeName = new System.Windows.Forms.TextBox();
            this.textBox_codeTypeValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_pym = new System.Windows.Forms.TextBox();
            this.textBox_wbm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip_page = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_startPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_prevPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_nextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_endPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_currentPage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_pageCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_pageSize = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_allCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.skinDataGridView_code = new CCWin.SkinControl.SkinDataGridView();
            this.toolStrip_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_code)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前代码类型名称";
            // 
            // textBox_codeTypeName
            // 
            this.textBox_codeTypeName.Location = new System.Drawing.Point(119, 6);
            this.textBox_codeTypeName.Name = "textBox_codeTypeName";
            this.textBox_codeTypeName.Size = new System.Drawing.Size(108, 21);
            this.textBox_codeTypeName.TabIndex = 1;
            // 
            // textBox_codeTypeValue
            // 
            this.textBox_codeTypeValue.Location = new System.Drawing.Point(333, 6);
            this.textBox_codeTypeValue.Name = "textBox_codeTypeValue";
            this.textBox_codeTypeValue.Size = new System.Drawing.Size(108, 21);
            this.textBox_codeTypeValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "当前代码类型值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "拼音码";
            // 
            // textBox_pym
            // 
            this.textBox_pym.Location = new System.Drawing.Point(119, 43);
            this.textBox_pym.Name = "textBox_pym";
            this.textBox_pym.Size = new System.Drawing.Size(108, 21);
            this.textBox_pym.TabIndex = 5;
            this.textBox_pym.TextChanged += new System.EventHandler(this.textBox_pym_TextChanged);
            // 
            // textBox_wbm
            // 
            this.textBox_wbm.Location = new System.Drawing.Point(333, 43);
            this.textBox_wbm.Name = "textBox_wbm";
            this.textBox_wbm.Size = new System.Drawing.Size(108, 21);
            this.textBox_wbm.TabIndex = 7;
            this.textBox_wbm.TextChanged += new System.EventHandler(this.textBox_wbm_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "五笔码";
            // 
            // toolStrip_page
            // 
            this.toolStrip_page.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_page.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_startPage,
            this.toolStripSeparator1,
            this.toolStripButton_prevPage,
            this.toolStripSeparator2,
            this.toolStripButton_nextPage,
            this.toolStripSeparator3,
            this.toolStripButton_endPage,
            this.toolStripSeparator4,
            this.toolStripLabel_currentPage,
            this.toolStripLabel1,
            this.toolStripLabel_pageCount,
            this.toolStripSeparator6,
            this.toolStripLabel2,
            this.toolStripLabel_pageSize,
            this.toolStripLabel4,
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.toolStripLabel_allCount,
            this.toolStripLabel5});
            this.toolStrip_page.Location = new System.Drawing.Point(0, 421);
            this.toolStrip_page.Name = "toolStrip_page";
            this.toolStrip_page.Size = new System.Drawing.Size(454, 25);
            this.toolStrip_page.TabIndex = 35;
            this.toolStrip_page.Text = "toolStrip1";
            // 
            // toolStripButton_startPage
            // 
            this.toolStripButton_startPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_startPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_startPage.Image")));
            this.toolStripButton_startPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_startPage.Name = "toolStripButton_startPage";
            this.toolStripButton_startPage.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton_startPage.Text = "首页";
            this.toolStripButton_startPage.Click += new System.EventHandler(this.toolStripButton_startPage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_prevPage
            // 
            this.toolStripButton_prevPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_prevPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_prevPage.Image")));
            this.toolStripButton_prevPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_prevPage.Name = "toolStripButton_prevPage";
            this.toolStripButton_prevPage.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton_prevPage.Text = "上一页";
            this.toolStripButton_prevPage.Click += new System.EventHandler(this.toolStripButton_prevPage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_nextPage
            // 
            this.toolStripButton_nextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_nextPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_nextPage.Image")));
            this.toolStripButton_nextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_nextPage.Name = "toolStripButton_nextPage";
            this.toolStripButton_nextPage.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton_nextPage.Text = "下一页";
            this.toolStripButton_nextPage.Click += new System.EventHandler(this.toolStripButton_nextPage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_endPage
            // 
            this.toolStripButton_endPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_endPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_endPage.Image")));
            this.toolStripButton_endPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_endPage.Name = "toolStripButton_endPage";
            this.toolStripButton_endPage.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton_endPage.Text = "尾页";
            this.toolStripButton_endPage.Click += new System.EventHandler(this.toolStripButton_endPage_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_currentPage
            // 
            this.toolStripLabel_currentPage.Name = "toolStripLabel_currentPage";
            this.toolStripLabel_currentPage.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel_currentPage.Text = "0";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel1.Text = "/";
            // 
            // toolStripLabel_pageCount
            // 
            this.toolStripLabel_pageCount.Name = "toolStripLabel_pageCount";
            this.toolStripLabel_pageCount.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel_pageCount.Text = "0";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel2.Text = "每页显示";
            // 
            // toolStripLabel_pageSize
            // 
            this.toolStripLabel_pageSize.Name = "toolStripLabel_pageSize";
            this.toolStripLabel_pageSize.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel_pageSize.Text = "0";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel4.Text = "条";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel3.Text = "共";
            // 
            // toolStripLabel_allCount
            // 
            this.toolStripLabel_allCount.Name = "toolStripLabel_allCount";
            this.toolStripLabel_allCount.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel_allCount.Text = "0";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel5.Text = "条";
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
            this.skinDataGridView_code.Location = new System.Drawing.Point(0, 70);
            this.skinDataGridView_code.Name = "skinDataGridView_code";
            this.skinDataGridView_code.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView_code.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_code.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.skinDataGridView_code.RowTemplate.Height = 23;
            this.skinDataGridView_code.Size = new System.Drawing.Size(454, 348);
            this.skinDataGridView_code.TabIndex = 36;
            this.skinDataGridView_code.TitleBack = null;
            this.skinDataGridView_code.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView_code.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.skinDataGridView_code.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // CodeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 446);
            this.Controls.Add(this.skinDataGridView_code);
            this.Controls.Add(this.toolStrip_page);
            this.Controls.Add(this.textBox_wbm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_pym);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_codeTypeValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_codeTypeName);
            this.Controls.Add(this.label1);
            this.Name = "CodeSearch";
            this.Text = "代码查询";
            this.Activated += new System.EventHandler(this.CodeSearch_Activated);
            this.Load += new System.EventHandler(this.CodeSearch_Load);
            this.toolStrip_page.ResumeLayout(false);
            this.toolStrip_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_codeTypeName;
        private System.Windows.Forms.TextBox textBox_codeTypeValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_pym;
        private System.Windows.Forms.TextBox textBox_wbm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip_page;
        private System.Windows.Forms.ToolStripButton toolStripButton_startPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_prevPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_nextPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_endPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_currentPage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_pageCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_pageSize;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_allCount;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView_code;
    }
}