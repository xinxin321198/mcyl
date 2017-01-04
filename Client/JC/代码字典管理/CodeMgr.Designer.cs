namespace client.JC.代码字典管理
{
    partial class CodeMgr
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeMgr));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip_codeDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_codeTypeListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_codeTypeName = new System.Windows.Forms.TextBox();
            this.textBox_codeTypeValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_zfbz = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_remark = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_codeCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_五笔码 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_拼音码 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_typecount = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.skinListView_codeType = new CCWin.SkinControl.SkinListView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.skinButton_codeTypeSave = new CCWin.SkinControl.SkinButton();
            this.skinButton_add = new CCWin.SkinControl.SkinButton();
            this.skinDataGridView_code = new CCWin.SkinControl.SkinDataGridView();
            this.skinButton_addCode = new CCWin.SkinControl.SkinButton();
            this.skinButton_importExcel = new CCWin.SkinControl.SkinButton();
            this.skinNumericUpDown_排序码 = new CCWin.SkinControl.SkinNumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.contextMenuStrip_codeDataGridView.SuspendLayout();
            this.contextMenuStrip_codeTypeListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinNumericUpDown_排序码)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "代码类别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "代码值";
            // 
            // contextMenuStrip_codeDataGridView
            // 
            this.contextMenuStrip_codeDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem1});
            this.contextMenuStrip_codeDataGridView.Name = "contextMenuStrip_codeDataGridView";
            this.contextMenuStrip_codeDataGridView.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem1
            // 
            this.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1";
            this.删除ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem1.Text = "删除";
            this.删除ToolStripMenuItem1.Click += new System.EventHandler(this.删除ToolStripMenuItem1_Click);
            // 
            // contextMenuStrip_codeTypeListView
            // 
            this.contextMenuStrip_codeTypeListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip_codeTypeListView.Name = "contextMenuStrip_codeTypeListView";
            this.contextMenuStrip_codeTypeListView.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // textBox_codeTypeName
            // 
            this.textBox_codeTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_codeTypeName.Location = new System.Drawing.Point(65, 32);
            this.textBox_codeTypeName.MaxLength = 20;
            this.textBox_codeTypeName.Name = "textBox_codeTypeName";
            this.textBox_codeTypeName.Size = new System.Drawing.Size(580, 21);
            this.textBox_codeTypeName.TabIndex = 7;
            this.textBox_codeTypeName.TextChanged += new System.EventHandler(this.textBox_codeTypeName_TextChanged);
            this.textBox_codeTypeName.VisibleChanged += new System.EventHandler(this.textBox_codeTypeName_VisibleChanged);
            // 
            // textBox_codeTypeValue
            // 
            this.textBox_codeTypeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_codeTypeValue.Location = new System.Drawing.Point(65, 70);
            this.textBox_codeTypeValue.MaxLength = 20;
            this.textBox_codeTypeValue.Name = "textBox_codeTypeValue";
            this.textBox_codeTypeValue.Size = new System.Drawing.Size(580, 21);
            this.textBox_codeTypeValue.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "类别名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "类别值";
            // 
            // comboBox_zfbz
            // 
            this.comboBox_zfbz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_zfbz.Location = new System.Drawing.Point(65, 151);
            this.comboBox_zfbz.Name = "comboBox_zfbz";
            this.comboBox_zfbz.Size = new System.Drawing.Size(580, 20);
            this.comboBox_zfbz.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "作废标志";
            // 
            // richTextBox_remark
            // 
            this.richTextBox_remark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_remark.Location = new System.Drawing.Point(65, 214);
            this.richTextBox_remark.MaxLength = 50;
            this.richTextBox_remark.Name = "richTextBox_remark";
            this.richTextBox_remark.Size = new System.Drawing.Size(580, 75);
            this.richTextBox_remark.TabIndex = 10;
            this.richTextBox_remark.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "备注";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "共：";
            // 
            // label_codeCount
            // 
            this.label_codeCount.AutoSize = true;
            this.label_codeCount.Location = new System.Drawing.Point(110, 20);
            this.label_codeCount.Name = "label_codeCount";
            this.label_codeCount.Size = new System.Drawing.Size(0, 12);
            this.label_codeCount.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "条";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "五笔码";
            // 
            // textBox_五笔码
            // 
            this.textBox_五笔码.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_五笔码.Location = new System.Drawing.Point(65, 124);
            this.textBox_五笔码.MaxLength = 20;
            this.textBox_五笔码.Name = "textBox_五笔码";
            this.textBox_五笔码.Size = new System.Drawing.Size(580, 21);
            this.textBox_五笔码.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "拼音码";
            // 
            // textBox_拼音码
            // 
            this.textBox_拼音码.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_拼音码.Location = new System.Drawing.Point(65, 97);
            this.textBox_拼音码.MaxLength = 20;
            this.textBox_拼音码.Name = "textBox_拼音码";
            this.textBox_拼音码.Size = new System.Drawing.Size(580, 21);
            this.textBox_拼音码.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "数量：";
            // 
            // label_typecount
            // 
            this.label_typecount.AutoSize = true;
            this.label_typecount.Location = new System.Drawing.Point(128, 11);
            this.label_typecount.Name = "label_typecount";
            this.label_typecount.Size = new System.Drawing.Size(47, 12);
            this.label_typecount.TabIndex = 24;
            this.label_typecount.Text = "label12";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.skinListView_codeType);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label_typecount);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(988, 720);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 25;
            // 
            // skinListView_codeType
            // 
            this.skinListView_codeType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinListView_codeType.ContextMenuStrip = this.contextMenuStrip_codeTypeListView;
            this.skinListView_codeType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.skinListView_codeType.Location = new System.Drawing.Point(5, 26);
            this.skinListView_codeType.Name = "skinListView_codeType";
            this.skinListView_codeType.OwnerDraw = true;
            this.skinListView_codeType.RowBackColor2 = System.Drawing.Color.PapayaWhip;
            this.skinListView_codeType.Size = new System.Drawing.Size(319, 689);
            this.skinListView_codeType.TabIndex = 25;
            this.skinListView_codeType.UseCompatibleStateImageBehavior = false;
            this.skinListView_codeType.View = System.Windows.Forms.View.Details;
            this.skinListView_codeType.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_codeType_MouseDoubleClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.skinNumericUpDown_排序码);
            this.splitContainer2.Panel1.Controls.Add(this.skinButton_codeTypeSave);
            this.splitContainer2.Panel1.Controls.Add(this.skinButton_add);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_codeTypeName);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_codeTypeValue);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_拼音码);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_五笔码);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox_zfbz);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.richTextBox_remark);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.skinDataGridView_code);
            this.splitContainer2.Panel2.Controls.Add(this.skinButton_addCode);
            this.splitContainer2.Panel2.Controls.Add(this.skinButton_importExcel);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.label_codeCount);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Size = new System.Drawing.Size(653, 718);
            this.splitContainer2.SplitterDistance = 331;
            this.splitContainer2.TabIndex = 0;
            // 
            // skinButton_codeTypeSave
            // 
            this.skinButton_codeTypeSave.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_codeTypeSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_codeTypeSave.DownBack = null;
            this.skinButton_codeTypeSave.Location = new System.Drawing.Point(120, 3);
            this.skinButton_codeTypeSave.MouseBack = null;
            this.skinButton_codeTypeSave.Name = "skinButton_codeTypeSave";
            this.skinButton_codeTypeSave.NormlBack = null;
            this.skinButton_codeTypeSave.Size = new System.Drawing.Size(106, 23);
            this.skinButton_codeTypeSave.TabIndex = 24;
            this.skinButton_codeTypeSave.Text = "保存";
            this.skinButton_codeTypeSave.UseVisualStyleBackColor = false;
            this.skinButton_codeTypeSave.Click += new System.EventHandler(this.button_codeTypeSave_Click);
            // 
            // skinButton_add
            // 
            this.skinButton_add.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_add.DownBack = null;
            this.skinButton_add.Location = new System.Drawing.Point(8, 3);
            this.skinButton_add.MouseBack = null;
            this.skinButton_add.Name = "skinButton_add";
            this.skinButton_add.NormlBack = null;
            this.skinButton_add.Size = new System.Drawing.Size(106, 23);
            this.skinButton_add.TabIndex = 23;
            this.skinButton_add.Text = "新增";
            this.skinButton_add.UseVisualStyleBackColor = false;
            this.skinButton_add.Click += new System.EventHandler(this.button_add_Click);
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
            this.skinDataGridView_code.ContextMenuStrip = this.contextMenuStrip_codeDataGridView;
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
            this.skinDataGridView_code.Location = new System.Drawing.Point(8, 44);
            this.skinDataGridView_code.Name = "skinDataGridView_code";
            this.skinDataGridView_code.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView_code.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView_code.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.skinDataGridView_code.RowTemplate.Height = 23;
            this.skinDataGridView_code.Size = new System.Drawing.Size(642, 336);
            this.skinDataGridView_code.TabIndex = 21;
            this.skinDataGridView_code.TitleBack = null;
            this.skinDataGridView_code.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView_code.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.skinDataGridView_code.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_code_MouseDoubleClick);
            // 
            // skinButton_addCode
            // 
            this.skinButton_addCode.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_addCode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_addCode.DownBack = null;
            this.skinButton_addCode.Location = new System.Drawing.Point(180, 15);
            this.skinButton_addCode.MouseBack = null;
            this.skinButton_addCode.Name = "skinButton_addCode";
            this.skinButton_addCode.NormlBack = null;
            this.skinButton_addCode.Size = new System.Drawing.Size(75, 23);
            this.skinButton_addCode.TabIndex = 20;
            this.skinButton_addCode.Text = "添加代码";
            this.skinButton_addCode.UseVisualStyleBackColor = false;
            this.skinButton_addCode.Click += new System.EventHandler(this.button_addCode_Click);
            // 
            // skinButton_importExcel
            // 
            this.skinButton_importExcel.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_importExcel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_importExcel.DownBack = null;
            this.skinButton_importExcel.Location = new System.Drawing.Point(261, 15);
            this.skinButton_importExcel.MouseBack = null;
            this.skinButton_importExcel.Name = "skinButton_importExcel";
            this.skinButton_importExcel.NormlBack = null;
            this.skinButton_importExcel.Size = new System.Drawing.Size(75, 23);
            this.skinButton_importExcel.TabIndex = 19;
            this.skinButton_importExcel.Text = "excel导入";
            this.skinButton_importExcel.UseVisualStyleBackColor = false;
            this.skinButton_importExcel.Click += new System.EventHandler(this.button_importExcel_Click);
            // 
            // skinNumericUpDown_排序码
            // 
            this.skinNumericUpDown_排序码.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinNumericUpDown_排序码.Location = new System.Drawing.Point(65, 177);
            this.skinNumericUpDown_排序码.Name = "skinNumericUpDown_排序码";
            this.skinNumericUpDown_排序码.Size = new System.Drawing.Size(580, 21);
            this.skinNumericUpDown_排序码.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "排序码";
            // 
            // CodeMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 720);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeMgr";
            this.Text = "代码管理";
            this.Load += new System.EventHandler(this.CodeMgr_Load);
            this.contextMenuStrip_codeDataGridView.ResumeLayout(false);
            this.contextMenuStrip_codeTypeListView.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinNumericUpDown_排序码)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_codeTypeName;
        private System.Windows.Forms.TextBox textBox_codeTypeValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_zfbz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_remark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_codeTypeListView;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_codeDataGridView;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_codeCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_五笔码;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_拼音码;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_typecount;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private CCWin.SkinControl.SkinButton skinButton_codeTypeSave;
        private CCWin.SkinControl.SkinButton skinButton_add;
        private CCWin.SkinControl.SkinButton skinButton_addCode;
        private CCWin.SkinControl.SkinButton skinButton_importExcel;
        private CCWin.SkinControl.SkinListView skinListView_codeType;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView_code;
        private System.Windows.Forms.Label label12;
        private CCWin.SkinControl.SkinNumericUpDown skinNumericUpDown_排序码;
    }
}