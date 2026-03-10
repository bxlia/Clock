namespace Clock
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.cbShowWeekday = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowControls = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutostart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();

            // labelTime
            this.labelTime.AutoSize = false;
            this.labelTime.BackColor = System.Drawing.Color.Black;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.Lime;
            this.labelTime.Location = new System.Drawing.Point(0, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(300, 100);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);

            // timer
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);

            // cbShowDate
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbShowDate.ForeColor = System.Drawing.Color.White;
            this.cbShowDate.Location = new System.Drawing.Point(12, 12); this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(78, 17);
            this.cbShowDate.TabIndex = 1;
            this.cbShowDate.Text = "Show Date";
            this.cbShowDate.UseVisualStyleBackColor = false;
            this.cbShowDate.CheckedChanged += new System.EventHandler(this.cbShowDate_CheckedChanged);

            // cbShowWeekday
            this.cbShowWeekday.AutoSize = true;
            this.cbShowWeekday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbShowWeekday.ForeColor = System.Drawing.Color.White;
            this.cbShowWeekday.Location = new System.Drawing.Point(12, 35);
            this.cbShowWeekday.Name = "cbShowWeekday";
            this.cbShowWeekday.Size = new System.Drawing.Size(101, 17);
            this.cbShowWeekday.TabIndex = 2;
            this.cbShowWeekday.Text = "Show Weekday";
            this.cbShowWeekday.UseVisualStyleBackColor = false;
            this.cbShowWeekday.CheckedChanged += new System.EventHandler(this.cbShowWeekday_CheckedChanged);

            // btnHideControls
            this.btnHideControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHideControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideControls.ForeColor = System.Drawing.Color.White;
            this.btnHideControls.Location = new System.Drawing.Point(12, 58);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(120, 23);
            this.btnHideControls.TabIndex = 3;
            this.btnHideControls.Text = "Hide Controls";
            this.btnHideControls.UseVisualStyleBackColor = false;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);

            // notifyIcon
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Clock";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);

            // contextMenuStrip
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiShowControls,
                this.tsmiTopmost,
                this.tsmiAutostart,
                this.tsmiShowDate,
                this.tsmiShowWeekday,
                this.tsmiBackgroundColor,
                this.tsmiForegroundColor,
                this.tsmiClose});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 202);

            // tsmiShowControls
            this.tsmiShowControls.CheckOnClick = true;
            this.tsmiShowControls.Name = "tsmiShowControls";
            this.tsmiShowControls.Size = new System.Drawing.Size(180, 22);
            this.tsmiShowControls.Text = "Show Controls";
            this.tsmiShowControls.CheckedChanged += new System.EventHandler(this.tsmiShowControls_CheckedChanged);

            // tsmiTopmost
            this.tsmiTopmost.CheckOnClick = true;
            this.tsmiTopmost.Name = "tsmiTopmost";
            this.tsmiTopmost.Size = new System.Drawing.Size(180, 22);
            this.tsmiTopmost.Text = "Topmost";
            this.tsmiTopmost.CheckedChanged += new System.EventHandler(this.tsmiTopmost_CheckedChanged);

            // tsmiAutostart
            this.tsmiAutostart.CheckOnClick = true;
            this.tsmiAutostart.Name = "tsmiAutostart";
            this.tsmiAutostart.Size = new System.Drawing.Size(180, 22);
            this.tsmiAutostart.Text = "Autostart";
            this.tsmiAutostart.CheckedChanged += new System.EventHandler(this.tsmiAutostart_CheckedChanged);// tsmiShowDate
            this.tsmiShowDate.CheckOnClick = true;
            this.tsmiShowDate.Name = "tsmiShowDate";
            this.tsmiShowDate.Size = new System.Drawing.Size(180, 22);
            this.tsmiShowDate.Text = "Show Date";
            this.tsmiShowDate.CheckedChanged += new System.EventHandler(this.tsmiShowDate_CheckedChanged);

            // tsmiShowWeekday
            this.tsmiShowWeekday.CheckOnClick = true;
            this.tsmiShowWeekday.Name = "tsmiShowWeekday";
            this.tsmiShowWeekday.Size = new System.Drawing.Size(180, 22);
            this.tsmiShowWeekday.Text = "Show Weekday";
            this.tsmiShowWeekday.CheckedChanged += new System.EventHandler(this.tsmiShowWeekday_CheckedChanged);

            // tsmiBackgroundColor
            this.tsmiBackgroundColor.Name = "tsmiBackgroundColor";
            this.tsmiBackgroundColor.Size = new System.Drawing.Size(180, 22);
            this.tsmiBackgroundColor.Text = "Background Color";
            this.tsmiBackgroundColor.Click += new System.EventHandler(this.tsmiBackgroundColor_Click);

            // tsmiForegroundColor
            this.tsmiForegroundColor.Name = "tsmiForegroundColor";
            this.tsmiForegroundColor.Size = new System.Drawing.Size(180, 22);
            this.tsmiForegroundColor.Text = "Foreground Color";
            this.tsmiForegroundColor.Click += new System.EventHandler(this.tsmiForegroundColor_Click);

            // tsmiClose
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(180, 22);
            this.tsmiClose.Text = "Close";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.ControlBox = false;
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowWeekday);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.CheckBox cbShowWeekday;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowControls;
        private System.Windows.Forms.ToolStripMenuItem tsmiTopmost;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutostart;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowWeekday;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiForegroundColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
    }
}