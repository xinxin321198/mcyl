namespace client.RBAC.模块管理
{
    partial class ModulesMgr
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
            this.skinTreeView_modules = new CCWin.SkinControl.SkinTreeView();
            this.skinContextMenuStrip_treeView = new CCWin.SkinControl.SkinContextMenuStrip();
            this.删除模块及下级子模块ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinTextBox_模块名称 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinButton_add = new CCWin.SkinControl.SkinButton();
            this.skinButton_save = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_窗体完全限定名 = new CCWin.SkinControl.SkinTextBox();
            this.skinComboBox_模块类型 = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel_模块类型 = new CCWin.SkinControl.SkinLabel();
            this.skinCheckBox_是否允许直接打开窗体 = new CCWin.SkinControl.SkinCheckBox();
            this.rtfRichTextBox_备注 = new CCWin.SkinControl.RtfRichTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_zfbz = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_p_modules = new CCWin.SkinControl.SkinTextBox();
            this.skinNumericUpDown_sort = new CCWin.SkinControl.SkinNumericUpDown();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.imageList_icon = new System.Windows.Forms.ImageList(this.components);
            this.skinTextBox_iconName = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinContextMenuStrip_treeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinNumericUpDown_sort)).BeginInit();
            this.SuspendLayout();
            // 
            // skinTreeView_modules
            // 
            this.skinTreeView_modules.ContextMenuStrip = this.skinContextMenuStrip_treeView;
            this.skinTreeView_modules.Location = new System.Drawing.Point(12, 31);
            this.skinTreeView_modules.Name = "skinTreeView_modules";
            this.skinTreeView_modules.Size = new System.Drawing.Size(261, 406);
            this.skinTreeView_modules.TabIndex = 1;
            this.skinTreeView_modules.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.skinTreeView_modules_AfterSelect);
            this.skinTreeView_modules.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.skinTreeView_modules_NodeMouseDoubleClick);
            this.skinTreeView_modules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.skinTreeView_modules_MouseUp);
            // 
            // skinContextMenuStrip_treeView
            // 
            this.skinContextMenuStrip_treeView.Arrow = System.Drawing.Color.Black;
            this.skinContextMenuStrip_treeView.Back = System.Drawing.Color.White;
            this.skinContextMenuStrip_treeView.BackRadius = 4;
            this.skinContextMenuStrip_treeView.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinContextMenuStrip_treeView.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinContextMenuStrip_treeView.Fore = System.Drawing.Color.Black;
            this.skinContextMenuStrip_treeView.HoverFore = System.Drawing.Color.White;
            this.skinContextMenuStrip_treeView.ItemAnamorphosis = true;
            this.skinContextMenuStrip_treeView.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip_treeView.ItemBorderShow = true;
            this.skinContextMenuStrip_treeView.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip_treeView.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip_treeView.ItemRadius = 4;
            this.skinContextMenuStrip_treeView.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip_treeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除模块及下级子模块ToolStripMenuItem});
            this.skinContextMenuStrip_treeView.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip_treeView.Name = "skinContextMenuStrip_treeView";
            this.skinContextMenuStrip_treeView.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip_treeView.Size = new System.Drawing.Size(197, 26);
            this.skinContextMenuStrip_treeView.SkinAllColor = true;
            this.skinContextMenuStrip_treeView.TitleAnamorphosis = true;
            this.skinContextMenuStrip_treeView.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinContextMenuStrip_treeView.TitleRadius = 4;
            this.skinContextMenuStrip_treeView.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 删除模块及下级子模块ToolStripMenuItem
            // 
            this.删除模块及下级子模块ToolStripMenuItem.Name = "删除模块及下级子模块ToolStripMenuItem";
            this.删除模块及下级子模块ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.删除模块及下级子模块ToolStripMenuItem.Text = "删除模块和下级子模块";
            this.删除模块及下级子模块ToolStripMenuItem.Click += new System.EventHandler(this.删除模块及下级子模块ToolStripMenuItem_Click);
            // 
            // skinTextBox_模块名称
            // 
            this.skinTextBox_模块名称.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_模块名称.DownBack = null;
            this.skinTextBox_模块名称.Icon = null;
            this.skinTextBox_模块名称.IconIsButton = false;
            this.skinTextBox_模块名称.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_模块名称.IsPasswordChat = '\0';
            this.skinTextBox_模块名称.IsSystemPasswordChar = false;
            this.skinTextBox_模块名称.Lines = new string[0];
            this.skinTextBox_模块名称.Location = new System.Drawing.Point(381, 48);
            this.skinTextBox_模块名称.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_模块名称.MaxLength = 32767;
            this.skinTextBox_模块名称.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_模块名称.MouseBack = null;
            this.skinTextBox_模块名称.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_模块名称.Multiline = false;
            this.skinTextBox_模块名称.Name = "skinTextBox_模块名称";
            this.skinTextBox_模块名称.NormlBack = null;
            this.skinTextBox_模块名称.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_模块名称.ReadOnly = false;
            this.skinTextBox_模块名称.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_模块名称.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBox_模块名称.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_模块名称.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_模块名称.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_模块名称.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_模块名称.SkinTxt.Name = "BaseText";
            this.skinTextBox_模块名称.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.skinTextBox_模块名称.SkinTxt.TabIndex = 0;
            this.skinTextBox_模块名称.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_模块名称.SkinTxt.WaterText = "";
            this.skinTextBox_模块名称.TabIndex = 2;
            this.skinTextBox_模块名称.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_模块名称.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_模块名称.WaterText = "";
            this.skinTextBox_模块名称.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(315, 48);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "模块名称";
            // 
            // skinButton_add
            // 
            this.skinButton_add.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_add.DownBack = null;
            this.skinButton_add.Location = new System.Drawing.Point(12, 2);
            this.skinButton_add.MouseBack = null;
            this.skinButton_add.Name = "skinButton_add";
            this.skinButton_add.NormlBack = null;
            this.skinButton_add.Size = new System.Drawing.Size(75, 23);
            this.skinButton_add.TabIndex = 4;
            this.skinButton_add.Text = "新增";
            this.skinButton_add.UseVisualStyleBackColor = false;
            this.skinButton_add.Click += new System.EventHandler(this.skinButton_add_Click);
            // 
            // skinButton_save
            // 
            this.skinButton_save.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_save.DownBack = null;
            this.skinButton_save.Location = new System.Drawing.Point(414, 400);
            this.skinButton_save.MouseBack = null;
            this.skinButton_save.Name = "skinButton_save";
            this.skinButton_save.NormlBack = null;
            this.skinButton_save.Size = new System.Drawing.Size(75, 23);
            this.skinButton_save.TabIndex = 5;
            this.skinButton_save.Text = "保存";
            this.skinButton_save.UseVisualStyleBackColor = false;
            this.skinButton_save.Click += new System.EventHandler(this.skinButton_save_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(279, 97);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(92, 17);
            this.skinLabel2.TabIndex = 7;
            this.skinLabel2.Text = "窗体完全限定名";
            // 
            // skinTextBox_窗体完全限定名
            // 
            this.skinTextBox_窗体完全限定名.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_窗体完全限定名.DownBack = null;
            this.skinTextBox_窗体完全限定名.Icon = null;
            this.skinTextBox_窗体完全限定名.IconIsButton = false;
            this.skinTextBox_窗体完全限定名.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_窗体完全限定名.IsPasswordChat = '\0';
            this.skinTextBox_窗体完全限定名.IsSystemPasswordChar = false;
            this.skinTextBox_窗体完全限定名.Lines = new string[0];
            this.skinTextBox_窗体完全限定名.Location = new System.Drawing.Point(381, 86);
            this.skinTextBox_窗体完全限定名.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_窗体完全限定名.MaxLength = 32767;
            this.skinTextBox_窗体完全限定名.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_窗体完全限定名.MouseBack = null;
            this.skinTextBox_窗体完全限定名.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_窗体完全限定名.Multiline = false;
            this.skinTextBox_窗体完全限定名.Name = "skinTextBox_窗体完全限定名";
            this.skinTextBox_窗体完全限定名.NormlBack = null;
            this.skinTextBox_窗体完全限定名.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_窗体完全限定名.ReadOnly = false;
            this.skinTextBox_窗体完全限定名.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_窗体完全限定名.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBox_窗体完全限定名.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_窗体完全限定名.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_窗体完全限定名.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_窗体完全限定名.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_窗体完全限定名.SkinTxt.Name = "BaseText";
            this.skinTextBox_窗体完全限定名.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.skinTextBox_窗体完全限定名.SkinTxt.TabIndex = 0;
            this.skinTextBox_窗体完全限定名.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_窗体完全限定名.SkinTxt.WaterText = "";
            this.skinTextBox_窗体完全限定名.TabIndex = 6;
            this.skinTextBox_窗体完全限定名.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_窗体完全限定名.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_窗体完全限定名.WaterText = "";
            this.skinTextBox_窗体完全限定名.WordWrap = true;
            // 
            // skinComboBox_模块类型
            // 
            this.skinComboBox_模块类型.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_模块类型.FormattingEnabled = true;
            this.skinComboBox_模块类型.Location = new System.Drawing.Point(381, 163);
            this.skinComboBox_模块类型.Name = "skinComboBox_模块类型";
            this.skinComboBox_模块类型.Size = new System.Drawing.Size(185, 22);
            this.skinComboBox_模块类型.TabIndex = 8;
            this.skinComboBox_模块类型.WaterText = "";
            // 
            // skinLabel_模块类型
            // 
            this.skinLabel_模块类型.AutoSize = true;
            this.skinLabel_模块类型.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_模块类型.BorderColor = System.Drawing.Color.White;
            this.skinLabel_模块类型.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_模块类型.Location = new System.Drawing.Point(315, 168);
            this.skinLabel_模块类型.Name = "skinLabel_模块类型";
            this.skinLabel_模块类型.Size = new System.Drawing.Size(56, 17);
            this.skinLabel_模块类型.TabIndex = 9;
            this.skinLabel_模块类型.Text = "模块类型";
            // 
            // skinCheckBox_是否允许直接打开窗体
            // 
            this.skinCheckBox_是否允许直接打开窗体.AutoSize = true;
            this.skinCheckBox_是否允许直接打开窗体.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox_是否允许直接打开窗体.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox_是否允许直接打开窗体.DownBack = null;
            this.skinCheckBox_是否允许直接打开窗体.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox_是否允许直接打开窗体.Location = new System.Drawing.Point(381, 193);
            this.skinCheckBox_是否允许直接打开窗体.MouseBack = null;
            this.skinCheckBox_是否允许直接打开窗体.Name = "skinCheckBox_是否允许直接打开窗体";
            this.skinCheckBox_是否允许直接打开窗体.NormlBack = null;
            this.skinCheckBox_是否允许直接打开窗体.SelectedDownBack = null;
            this.skinCheckBox_是否允许直接打开窗体.SelectedMouseBack = null;
            this.skinCheckBox_是否允许直接打开窗体.SelectedNormlBack = null;
            this.skinCheckBox_是否允许直接打开窗体.Size = new System.Drawing.Size(147, 21);
            this.skinCheckBox_是否允许直接打开窗体.TabIndex = 10;
            this.skinCheckBox_是否允许直接打开窗体.Text = "是否允许直接打开窗体";
            this.skinCheckBox_是否允许直接打开窗体.UseVisualStyleBackColor = false;
            // 
            // rtfRichTextBox_备注
            // 
            this.rtfRichTextBox_备注.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBox_备注.Location = new System.Drawing.Point(381, 279);
            this.rtfRichTextBox_备注.Name = "rtfRichTextBox_备注";
            this.rtfRichTextBox_备注.Size = new System.Drawing.Size(187, 87);
            this.rtfRichTextBox_备注.TabIndex = 12;
            this.rtfRichTextBox_备注.Text = "";
            this.rtfRichTextBox_备注.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(341, 279);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 13;
            this.skinLabel3.Text = "备注";
            // 
            // skinComboBox_zfbz
            // 
            this.skinComboBox_zfbz.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_zfbz.FormattingEnabled = true;
            this.skinComboBox_zfbz.Location = new System.Drawing.Point(383, 372);
            this.skinComboBox_zfbz.Name = "skinComboBox_zfbz";
            this.skinComboBox_zfbz.Size = new System.Drawing.Size(185, 22);
            this.skinComboBox_zfbz.TabIndex = 14;
            this.skinComboBox_zfbz.WaterText = "";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(321, 372);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(56, 17);
            this.skinLabel4.TabIndex = 15;
            this.skinLabel4.Text = "作废标志";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(327, 138);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(44, 17);
            this.skinLabel5.TabIndex = 17;
            this.skinLabel5.Text = "父模块";
            // 
            // skinTextBox_p_modules
            // 
            this.skinTextBox_p_modules.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_p_modules.DownBack = null;
            this.skinTextBox_p_modules.Icon = null;
            this.skinTextBox_p_modules.IconIsButton = false;
            this.skinTextBox_p_modules.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_p_modules.IsPasswordChat = '\0';
            this.skinTextBox_p_modules.IsSystemPasswordChar = false;
            this.skinTextBox_p_modules.Lines = new string[0];
            this.skinTextBox_p_modules.Location = new System.Drawing.Point(381, 127);
            this.skinTextBox_p_modules.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_p_modules.MaxLength = 32767;
            this.skinTextBox_p_modules.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_p_modules.MouseBack = null;
            this.skinTextBox_p_modules.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_p_modules.Multiline = false;
            this.skinTextBox_p_modules.Name = "skinTextBox_p_modules";
            this.skinTextBox_p_modules.NormlBack = null;
            this.skinTextBox_p_modules.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_p_modules.ReadOnly = false;
            this.skinTextBox_p_modules.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_p_modules.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBox_p_modules.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_p_modules.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_p_modules.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_p_modules.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_p_modules.SkinTxt.Name = "BaseText";
            this.skinTextBox_p_modules.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.skinTextBox_p_modules.SkinTxt.TabIndex = 0;
            this.skinTextBox_p_modules.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_p_modules.SkinTxt.WaterText = "";
            this.skinTextBox_p_modules.TabIndex = 16;
            this.skinTextBox_p_modules.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_p_modules.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_p_modules.WaterText = "";
            this.skinTextBox_p_modules.WordWrap = true;
            // 
            // skinNumericUpDown_sort
            // 
            this.skinNumericUpDown_sort.Location = new System.Drawing.Point(381, 222);
            this.skinNumericUpDown_sort.Name = "skinNumericUpDown_sort";
            this.skinNumericUpDown_sort.Size = new System.Drawing.Size(183, 21);
            this.skinNumericUpDown_sort.TabIndex = 18;
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(331, 225);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(44, 17);
            this.skinLabel6.TabIndex = 19;
            this.skinLabel6.Text = "排序码";
            // 
            // imageList_icon
            // 
            this.imageList_icon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_icon.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_icon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // skinTextBox_iconName
            // 
            this.skinTextBox_iconName.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_iconName.DownBack = null;
            this.skinTextBox_iconName.Icon = null;
            this.skinTextBox_iconName.IconIsButton = false;
            this.skinTextBox_iconName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_iconName.IsPasswordChat = '\0';
            this.skinTextBox_iconName.IsSystemPasswordChar = false;
            this.skinTextBox_iconName.Lines = new string[0];
            this.skinTextBox_iconName.Location = new System.Drawing.Point(383, 248);
            this.skinTextBox_iconName.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_iconName.MaxLength = 32767;
            this.skinTextBox_iconName.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_iconName.MouseBack = null;
            this.skinTextBox_iconName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_iconName.Multiline = false;
            this.skinTextBox_iconName.Name = "skinTextBox_iconName";
            this.skinTextBox_iconName.NormlBack = null;
            this.skinTextBox_iconName.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_iconName.ReadOnly = false;
            this.skinTextBox_iconName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_iconName.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBox_iconName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_iconName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_iconName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_iconName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_iconName.SkinTxt.Name = "BaseText";
            this.skinTextBox_iconName.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.skinTextBox_iconName.SkinTxt.TabIndex = 0;
            this.skinTextBox_iconName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_iconName.SkinTxt.WaterText = "";
            this.skinTextBox_iconName.TabIndex = 3;
            this.skinTextBox_iconName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_iconName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_iconName.WaterText = "";
            this.skinTextBox_iconName.WordWrap = true;
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(297, 254);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(80, 17);
            this.skinLabel7.TabIndex = 20;
            this.skinLabel7.Text = "图标资源名称";
            // 
            // ModulesMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 449);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinTextBox_iconName);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinNumericUpDown_sort);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinTextBox_p_modules);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinComboBox_zfbz);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.rtfRichTextBox_备注);
            this.Controls.Add(this.skinCheckBox_是否允许直接打开窗体);
            this.Controls.Add(this.skinLabel_模块类型);
            this.Controls.Add(this.skinComboBox_模块类型);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinTextBox_窗体完全限定名);
            this.Controls.Add(this.skinButton_save);
            this.Controls.Add(this.skinButton_add);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinTextBox_模块名称);
            this.Controls.Add(this.skinTreeView_modules);
            this.Name = "ModulesMgr";
            this.Text = "模块管理";
            this.Load += new System.EventHandler(this.ModulesMgr_Load);
            this.skinContextMenuStrip_treeView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinNumericUpDown_sort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTreeView skinTreeView_modules;
        private CCWin.SkinControl.SkinTextBox skinTextBox_模块名称;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton skinButton_add;
        private CCWin.SkinControl.SkinButton skinButton_save;
        private CCWin.SkinControl.SkinTextBox skinTextBox_窗体完全限定名;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinComboBox skinComboBox_模块类型;
        private CCWin.SkinControl.SkinLabel skinLabel_模块类型;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox_是否允许直接打开窗体;
        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBox_备注;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinComboBox skinComboBox_zfbz;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinTextBox skinTextBox_p_modules;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinContextMenuStrip skinContextMenuStrip_treeView;
        private System.Windows.Forms.ToolStripMenuItem 删除模块及下级子模块ToolStripMenuItem;
        private CCWin.SkinControl.SkinNumericUpDown skinNumericUpDown_sort;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.ImageList imageList_icon;
        private CCWin.SkinControl.SkinTextBox skinTextBox_iconName;
        private CCWin.SkinControl.SkinLabel skinLabel7;

    }
}