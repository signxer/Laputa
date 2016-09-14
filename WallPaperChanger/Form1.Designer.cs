namespace WallPaperChanger
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sXRWPC10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BubbleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时间设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.语言LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Laputa";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sXRWPC10ToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.NightToolStripMenuItem,
            this.语言LanguageToolStripMenuItem,
            this.ToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 114);
            this.contextMenuStrip1.Text = "SXR-WPC 1.1";
            // 
            // sXRWPC10ToolStripMenuItem
            // 
            this.sXRWPC10ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.sXRWPC10ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.sXRWPC10ToolStripMenuItem.Name = "sXRWPC10ToolStripMenuItem";
            this.sXRWPC10ToolStripMenuItem.ShowShortcutKeys = false;
            this.sXRWPC10ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.sXRWPC10ToolStripMenuItem.Text = "Laputa V1.2";
            this.sXRWPC10ToolStripMenuItem.Click += new System.EventHandler(this.sXRWPC10ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SoundToolStripMenuItem,
            this.BubbleToolStripMenuItem});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.ToolStripMenuItem1.Text = "气泡与声音提示";
            // 
            // SoundToolStripMenuItem
            // 
            this.SoundToolStripMenuItem.Checked = true;
            this.SoundToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SoundToolStripMenuItem.Name = "SoundToolStripMenuItem";
            this.SoundToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.SoundToolStripMenuItem.Text = "声音提示";
            this.SoundToolStripMenuItem.Click += new System.EventHandler(this.SoundToolStripMenuItem_Click);
            // 
            // BubbleToolStripMenuItem
            // 
            this.BubbleToolStripMenuItem.Checked = true;
            this.BubbleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BubbleToolStripMenuItem.Name = "BubbleToolStripMenuItem";
            this.BubbleToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.BubbleToolStripMenuItem.Text = "气泡提示";
            this.BubbleToolStripMenuItem.Click += new System.EventHandler(this.BubbleToolStripMenuItem_Click);
            // 
            // NightToolStripMenuItem
            // 
            this.NightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.时间设置ToolStripMenuItem});
            this.NightToolStripMenuItem.Name = "NightToolStripMenuItem";
            this.NightToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.NightToolStripMenuItem.Text = "定时免打扰";
            // 
            // 时间设置ToolStripMenuItem
            // 
            this.时间设置ToolStripMenuItem.Name = "时间设置ToolStripMenuItem";
            this.时间设置ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.时间设置ToolStripMenuItem.Text = "时间设置...";
            this.时间设置ToolStripMenuItem.Click += new System.EventHandler(this.时间设置ToolStripMenuItem_Click);
            // 
            // 语言LanguageToolStripMenuItem
            // 
            this.语言LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CHToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.语言LanguageToolStripMenuItem.Name = "语言LanguageToolStripMenuItem";
            this.语言LanguageToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.语言LanguageToolStripMenuItem.Text = "语言/Language";
            // 
            // CHToolStripMenuItem
            // 
            this.CHToolStripMenuItem.Name = "CHToolStripMenuItem";
            this.CHToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.CHToolStripMenuItem.Text = "中文";
            this.CHToolStripMenuItem.Click += new System.EventHandler(this.CHToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(162, 22);
            this.ToolStripMenuItem2.Text = "退出";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox1.Location = new System.Drawing.Point(6, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.comboBox2.Location = new System.Drawing.Point(124, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(74, 20);
            this.comboBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "每小时都提醒";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "时间设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "时";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "时 至";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 107);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem sXRWPC10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BubbleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NightToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem 时间设置ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 语言LanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}

