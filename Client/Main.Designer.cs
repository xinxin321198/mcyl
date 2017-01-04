namespace client
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip_bottom = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton_skin = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_loginUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_renyuanName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_keshiName = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_start = new System.Windows.Forms.Timer(this.components);
            this.skinSplitContainer_main = new CCWin.SkinControl.SkinSplitContainer();
            this.skinTabControl_main = new CCWin.SkinControl.SkinTabControl();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.statusStrip_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer_main)).BeginInit();
            this.skinSplitContainer_main.Panel2.SuspendLayout();
            this.skinSplitContainer_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip_bottom
            // 
            this.statusStrip_bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripDropDownButton_skin,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_loginUser,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel_renyuanName,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel_keshiName});
            this.statusStrip_bottom.Location = new System.Drawing.Point(0, 605);
            this.statusStrip_bottom.Name = "statusStrip_bottom";
            this.statusStrip_bottom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip_bottom.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip_bottom.SizingGrip = false;
            this.statusStrip_bottom.TabIndex = 6;
            this.statusStrip_bottom.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel3.Text = "皮肤更换:";
            // 
            // toolStripDropDownButton_skin
            // 
            this.toolStripDropDownButton_skin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripDropDownButton_skin.Enabled = false;
            this.toolStripDropDownButton_skin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_skin.Image")));
            this.toolStripDropDownButton_skin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_skin.Name = "toolStripDropDownButton_skin";
            this.toolStripDropDownButton_skin.Size = new System.Drawing.Size(13, 20);
            this.toolStripDropDownButton_skin.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton_skin.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripDropDownButton_skin_DropDownItemClicked);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(643, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "欢迎使用美创科技医疗系统";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "用户名：";
            // 
            // toolStripStatusLabel_loginUser
            // 
            this.toolStripStatusLabel_loginUser.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusLabel_loginUser.Name = "toolStripStatusLabel_loginUser";
            this.toolStripStatusLabel_loginUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel_loginUser.Size = new System.Drawing.Size(20, 17);
            this.toolStripStatusLabel_loginUser.Text = "无";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel5.Text = "工作人员姓名：";
            // 
            // toolStripStatusLabel_renyuanName
            // 
            this.toolStripStatusLabel_renyuanName.Name = "toolStripStatusLabel_renyuanName";
            this.toolStripStatusLabel_renyuanName.Size = new System.Drawing.Size(20, 17);
            this.toolStripStatusLabel_renyuanName.Text = "无";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel7.Text = "所属科室：";
            // 
            // toolStripStatusLabel_keshiName
            // 
            this.toolStripStatusLabel_keshiName.Name = "toolStripStatusLabel_keshiName";
            this.toolStripStatusLabel_keshiName.Size = new System.Drawing.Size(20, 17);
            this.toolStripStatusLabel_keshiName.Text = "无";
            // 
            // timer_start
            // 
            this.timer_start.Interval = 10;
            this.timer_start.Tick += new System.EventHandler(this.timer_start_Tick);
            // 
            // skinSplitContainer_main
            // 
            this.skinSplitContainer_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinSplitContainer_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinSplitContainer_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer_main.LineBack2 = System.Drawing.SystemColors.ControlLight;
            this.skinSplitContainer_main.Location = new System.Drawing.Point(0, 61);
            this.skinSplitContainer_main.Name = "skinSplitContainer_main";
            // 
            // skinSplitContainer_main.Panel2
            // 
            this.skinSplitContainer_main.Panel2.Controls.Add(this.skinTabControl_main);
            this.skinSplitContainer_main.Size = new System.Drawing.Size(1028, 538);
            this.skinSplitContainer_main.SplitterDistance = 244;
            this.skinSplitContainer_main.SplitterWidth = 10;
            this.skinSplitContainer_main.TabIndex = 9;
            this.skinSplitContainer_main.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.skinSplitContainer_main_SplitterMoved);
            // 
            // skinTabControl_main
            // 
            this.skinTabControl_main.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl_main.CloseRect = new System.Drawing.Rectangle(2, 2, 18, 18);
            this.skinTabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl_main.DrawType = CCWin.SkinControl.DrawStyle.Draw;
            this.skinTabControl_main.HeadBack = null;
            this.skinTabControl_main.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl_main.ItemSize = new System.Drawing.Size(150, 36);
            this.skinTabControl_main.Location = new System.Drawing.Point(0, 0);
            this.skinTabControl_main.Name = "skinTabControl_main";
            this.skinTabControl_main.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl_main.PageArrowDown")));
            this.skinTabControl_main.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl_main.PageArrowHover")));
            this.skinTabControl_main.PageBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinTabControl_main.PageBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinTabControl_main.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl_main.PageCloseHover")));
            this.skinTabControl_main.PageCloseLeftToRight = false;
            this.skinTabControl_main.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl_main.PageCloseNormal")));
            this.skinTabControl_main.PageCloseVisble = true;
            this.skinTabControl_main.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl_main.PageDown")));
            this.skinTabControl_main.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl_main.PageHover")));
            this.skinTabControl_main.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl_main.PageNorml = null;
            this.skinTabControl_main.Size = new System.Drawing.Size(772, 536);
            this.skinTabControl_main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl_main.TabIndex = 0;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPictureBox1.Image = global::client.Properties.Resources.mcyllogo;
            this.skinPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(1028, 55);
            this.skinPictureBox1.TabIndex = 10;
            this.skinPictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 627);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.skinSplitContainer_main);
            this.Controls.Add(this.statusStrip_bottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "美创科技医疗系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.statusStrip_bottom.ResumeLayout(false);
            this.statusStrip_bottom.PerformLayout();
            this.skinSplitContainer_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer_main)).EndInit();
            this.skinSplitContainer_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_bottom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_loginUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_skin;
        private System.Windows.Forms.Timer timer_start;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer_main;
        private CCWin.SkinControl.SkinTabControl skinTabControl_main;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_renyuanName;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_keshiName;


    }
}