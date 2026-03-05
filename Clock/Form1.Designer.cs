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
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.cbShowWeekday = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowControls = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAlarms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAutostart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowDate.Location = new System.Drawing.Point(29, 320);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(253, 55);
            this.cbShowDate.TabIndex = 0;
            this.cbShowDate.Text = "ShowDate";
            this.cbShowDate.UseVisualStyleBackColor = true;
            this.cbShowDate.CheckedChanged += new System.EventHandler(this.ShowDate_CheckedChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ContextMenuStrip = this.contextMenuStrip;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTime.Location = new System.Drawing.Point(12, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(507, 96);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Current time";
            // 
            // cbShowWeekday
            // 
            this.cbShowWeekday.AutoSize = true;
            this.cbShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowWeekday.Location = new System.Drawing.Point(29, 381);
            this.cbShowWeekday.Name = "cbShowWeekday";
            this.cbShowWeekday.Size = new System.Drawing.Size(343, 55);
            this.cbShowWeekday.TabIndex = 4;
            this.cbShowWeekday.Text = "ShowWeekday";
            this.cbShowWeekday.UseVisualStyleBackColor = true;
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.Location = new System.Drawing.Point(29, 442);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(491, 108);
            this.btnHideControls.TabIndex = 3;
            this.btnHideControls.Text = "Hide controls";
            this.btnHideControls.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTopmost,
            this.tsmiShowControls,
            this.tsmiShowDate,
            this.tsmiShowWeekday,
            this.toolStripSeparator1,
            this.tsmiFont,
            this.tsmiColor,
            this.toolStripSeparator3,
            this.tsmiAlarms,
            this.toolStripSeparator4,
            this.tsmiAutostart,
            this.toolStripSeparator5,
            this.tsmiClose});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(247, 370);
            // 
            // tsmiTopmost
            // 
            this.tsmiTopmost.Name = "tsmiTopmost";
            this.tsmiTopmost.Size = new System.Drawing.Size(246, 38);
            this.tsmiTopmost.Text = "Topmost";
            // 
            // tsmiShowControls
            // 
            this.tsmiShowControls.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2});
            this.tsmiShowControls.Name = "tsmiShowControls";
            this.tsmiShowControls.Size = new System.Drawing.Size(246, 38);
            this.tsmiShowControls.Text = "Show controls";
            // 
            // tsmiShowDate
            // 
            this.tsmiShowDate.Name = "tsmiShowDate";
            this.tsmiShowDate.Size = new System.Drawing.Size(246, 38);
            this.tsmiShowDate.Text = "Show date";
            // 
            // tsmiShowWeekday
            // 
            this.tsmiShowWeekday.Name = "tsmiShowWeekday";
            this.tsmiShowWeekday.Size = new System.Drawing.Size(246, 38);
            this.tsmiShowWeekday.Text = "Show weekday";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(356, 6);
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(246, 38);
            this.tsmiFont.Text = "Font";
            // 
            // tsmiColor
            // 
            this.tsmiColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForegroundColor,
            this.tsmiBackgroundColor});
            this.tsmiColor.Name = "tsmiColor";
            this.tsmiColor.Size = new System.Drawing.Size(246, 38);
            this.tsmiColor.Text = "Color";
            // 
            // tsmiForegroundColor
            // 
            this.tsmiForegroundColor.Name = "tsmiForegroundColor";
            this.tsmiForegroundColor.Size = new System.Drawing.Size(359, 44);
            this.tsmiForegroundColor.Text = "Foreground color";
            // 
            // tsmiBackgroundColor
            // 
            this.tsmiBackgroundColor.Name = "tsmiBackgroundColor";
            this.tsmiBackgroundColor.Size = new System.Drawing.Size(359, 44);
            this.tsmiBackgroundColor.Text = "Background color";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(243, 6);
            // 
            // tsmiAlarms
            // 
            this.tsmiAlarms.Name = "tsmiAlarms";
            this.tsmiAlarms.Size = new System.Drawing.Size(246, 38);
            this.tsmiAlarms.Text = "Alarms";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(243, 6);
            // 
            // tsmiAutostart
            // 
            this.tsmiAutostart.Name = "tsmiAutostart";
            this.tsmiAutostart.Size = new System.Drawing.Size(246, 38);
            this.tsmiAutostart.Text = "Autostart";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(243, 6);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(246, 38);
            this.tsmiClose.Text = "Close";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(547, 579);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowWeekday);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.cbShowDate);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Clock";
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
        private System.Windows.Forms.ToolStripMenuItem tsmiTopmost;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowControls;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowWeekday;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiForegroundColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackgroundColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlarms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutostart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
    }
}

