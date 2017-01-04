namespace client.JC.行政区划管理
{
    partial class AreaMgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaMgr));
            this.treeView_area = new System.Windows.Forms.TreeView();
            this.contextMenuStrip_treearea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加下级行政区划ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除当前行政区划及所有下级行政区划ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_parentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_zfbz = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_remark = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_level = new System.Windows.Forms.ComboBox();
            this.textBox_城乡分类 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.skinButton_add = new CCWin.SkinControl.SkinButton();
            this.skinButton_save = new CCWin.SkinControl.SkinButton();
            this.skinButton_exp = new CCWin.SkinControl.SkinButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip_treearea.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView_area
            // 
            this.treeView_area.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView_area.ContextMenuStrip = this.contextMenuStrip_treearea;
            this.treeView_area.Location = new System.Drawing.Point(12, 43);
            this.treeView_area.Name = "treeView_area";
            this.treeView_area.Size = new System.Drawing.Size(222, 410);
            this.treeView_area.TabIndex = 0;
            this.treeView_area.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_area_AfterSelect);
            this.treeView_area.DoubleClick += new System.EventHandler(this.treeView_area_DoubleClick);
            this.treeView_area.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView_area_MouseUp);
            // 
            // contextMenuStrip_treearea
            // 
            this.contextMenuStrip_treearea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加下级行政区划ToolStripMenuItem,
            this.删除当前行政区划及所有下级行政区划ToolStripMenuItem});
            this.contextMenuStrip_treearea.Name = "contextMenuStrip_treearea";
            this.contextMenuStrip_treearea.Size = new System.Drawing.Size(281, 48);
            // 
            // 添加下级行政区划ToolStripMenuItem
            // 
            this.添加下级行政区划ToolStripMenuItem.Name = "添加下级行政区划ToolStripMenuItem";
            this.添加下级行政区划ToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.添加下级行政区划ToolStripMenuItem.Text = "添加下级行政区划";
            this.添加下级行政区划ToolStripMenuItem.Click += new System.EventHandler(this.添加下级行政区划ToolStripMenuItem_Click);
            // 
            // 删除当前行政区划及所有下级行政区划ToolStripMenuItem
            // 
            this.删除当前行政区划及所有下级行政区划ToolStripMenuItem.Name = "删除当前行政区划及所有下级行政区划ToolStripMenuItem";
            this.删除当前行政区划及所有下级行政区划ToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.删除当前行政区划及所有下级行政区划ToolStripMenuItem.Text = "删除当前行政区划及所有下级行政区划";
            this.删除当前行政区划及所有下级行政区划ToolStripMenuItem.Click += new System.EventHandler(this.删除当前行政区划及所有下级行政区划ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "行政区划名称";
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.Location = new System.Drawing.Point(323, 43);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(210, 21);
            this.textBox_name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "行政区划代码";
            // 
            // textBox_code
            // 
            this.textBox_code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_code.Location = new System.Drawing.Point(323, 81);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(210, 21);
            this.textBox_code.TabIndex = 6;
            this.textBox_code.Leave += new System.EventHandler(this.textBox_code_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "上级行政区划";
            // 
            // textBox_parentName
            // 
            this.textBox_parentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_parentName.Location = new System.Drawing.Point(323, 122);
            this.textBox_parentName.Name = "textBox_parentName";
            this.textBox_parentName.Size = new System.Drawing.Size(210, 21);
            this.textBox_parentName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "作废标志";
            // 
            // comboBox_zfbz
            // 
            this.comboBox_zfbz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_zfbz.FormattingEnabled = true;
            this.comboBox_zfbz.Location = new System.Drawing.Point(323, 215);
            this.comboBox_zfbz.Name = "comboBox_zfbz";
            this.comboBox_zfbz.Size = new System.Drawing.Size(210, 20);
            this.comboBox_zfbz.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "备注";
            // 
            // richTextBox_remark
            // 
            this.richTextBox_remark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_remark.Location = new System.Drawing.Point(323, 241);
            this.richTextBox_remark.Name = "richTextBox_remark";
            this.richTextBox_remark.Size = new System.Drawing.Size(210, 96);
            this.richTextBox_remark.TabIndex = 12;
            this.richTextBox_remark.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "行政区划等级";
            // 
            // comboBox_level
            // 
            this.comboBox_level.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_level.FormattingEnabled = true;
            this.comboBox_level.Location = new System.Drawing.Point(323, 162);
            this.comboBox_level.Name = "comboBox_level";
            this.comboBox_level.Size = new System.Drawing.Size(210, 20);
            this.comboBox_level.TabIndex = 17;
            // 
            // textBox_城乡分类
            // 
            this.textBox_城乡分类.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_城乡分类.Location = new System.Drawing.Point(323, 188);
            this.textBox_城乡分类.Name = "textBox_城乡分类";
            this.textBox_城乡分类.Size = new System.Drawing.Size(210, 21);
            this.textBox_城乡分类.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "城乡分类";
            // 
            // skinButton_add
            // 
            this.skinButton_add.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_add.DownBack = null;
            this.skinButton_add.Location = new System.Drawing.Point(12, 14);
            this.skinButton_add.MouseBack = null;
            this.skinButton_add.Name = "skinButton_add";
            this.skinButton_add.NormlBack = null;
            this.skinButton_add.Size = new System.Drawing.Size(75, 23);
            this.skinButton_add.TabIndex = 21;
            this.skinButton_add.Text = "新增";
            this.skinButton_add.UseVisualStyleBackColor = false;
            this.skinButton_add.Click += new System.EventHandler(this.button_addChild_Click);
            // 
            // skinButton_save
            // 
            this.skinButton_save.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_save.DownBack = null;
            this.skinButton_save.Location = new System.Drawing.Point(362, 343);
            this.skinButton_save.MouseBack = null;
            this.skinButton_save.Name = "skinButton_save";
            this.skinButton_save.NormlBack = null;
            this.skinButton_save.Size = new System.Drawing.Size(75, 23);
            this.skinButton_save.TabIndex = 22;
            this.skinButton_save.Text = "保存";
            this.skinButton_save.UseVisualStyleBackColor = false;
            this.skinButton_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // skinButton_exp
            // 
            this.skinButton_exp.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_exp.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_exp.DownBack = null;
            this.skinButton_exp.Location = new System.Drawing.Point(447, 12);
            this.skinButton_exp.MouseBack = null;
            this.skinButton_exp.Name = "skinButton_exp";
            this.skinButton_exp.NormlBack = null;
            this.skinButton_exp.Size = new System.Drawing.Size(86, 23);
            this.skinButton_exp.TabIndex = 23;
            this.skinButton_exp.Text = "导出到excel";
            this.skinButton_exp.UseVisualStyleBackColor = false;
            this.skinButton_exp.Click += new System.EventHandler(this.skinButton_exp_Click);
            // 
            // AreaMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 465);
            this.Controls.Add(this.skinButton_exp);
            this.Controls.Add(this.skinButton_save);
            this.Controls.Add(this.skinButton_add);
            this.Controls.Add(this.textBox_城乡分类);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_level);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox_remark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_zfbz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_parentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView_area);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AreaMgr";
            this.Text = "行政区划管理";
            this.Load += new System.EventHandler(this.AreaMgr_Load);
            this.contextMenuStrip_treearea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_parentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_zfbz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_remark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_level;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_treearea;
        private System.Windows.Forms.ToolStripMenuItem 添加下级行政区划ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除当前行政区划及所有下级行政区划ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_城乡分类;
        private System.Windows.Forms.Label label7;
        private CCWin.SkinControl.SkinButton skinButton_add;
        private CCWin.SkinControl.SkinButton skinButton_save;
        private CCWin.SkinControl.SkinButton skinButton_exp;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}