using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Runtime.InteropServices;
using System.IO; //Input/Output
using System.Diagnostics;

namespace Clock
{
    public partial class MainForm : Form
    {
        ColorDialog backgroundColorDialog;
        ColorDialog foregroundColorDialog;
        PrivateFontCollection privateFonts;
        FontDialog fontDialog;

        public MainForm()
        {
            InitializeComponent();
            AllocConsole();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width - 25, 50);
            backgroundColorDialog = new ColorDialog();
            foregroundColorDialog = new ColorDialog();
            LoadCustomFont();
            //fontDialog = new FontDialog(this);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormFormClosing);
            LoadSettings();
            if(fontDialog == null)fontDialog = new FontDialog(this);
            SetVisibility(tsmiShowControls.Checked);
        }
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        //Установка шрифта
        private void LoadCustomFont()
        {
                privateFonts = new PrivateFontCollection();
                string fontPath = Application.StartupPath + "\\DigitalFont.ttf";
                if (System.IO.File.Exists(fontPath))
                {
                    privateFonts.AddFontFile(fontPath);
                    if (privateFonts.Families.Length > 0)
                    {
                        labelTime.Font = new Font(privateFonts.Families[0], 24, FontStyle.Regular);
                    }
                }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (cbShowDate.Checked)
                labelTime.Text += $"\n{DateTime.Now:yyyy.MM.dd}";
            if (cbShowWeekday.Checked)
                labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
            notifyIcon.Text = labelTime.Text;
        }

        void SetVisibility(bool visible)
        {
            cbShowDate.Visible = visible;
            cbShowWeekday.Visible = visible;
            btnHideControls.Visible = visible;
            ShowInTaskbar = visible;
            FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
            this.TransparencyKey = visible ? Color.Empty : this.BackColor;
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            SetVisibility(tsmiShowControls.Checked = false);
        }

        private void labelTime_DoubleClick(object sender, EventArgs e)
        {
            SetVisibility(tsmiShowControls.Checked = true);
        }

        private void ShowDate_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibility(false);
        }

        //Автонастройка
        private void MainForm_Load(object sender, EventArgs e)
        {
            //SetFormPosition();
            LoadAutostartSetting();
            SetVisibility(false);
        }


        private void tsmiTopmost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = tsmiTopmost.Checked;
        }

        private void tsmiShowControls_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibility(tsmiShowControls.Checked);
        }
        private void tsmiClose_Click(object sender, EventArgs e) => this.Close();

        private void tsmiShowDate_CheckedChanged(object sender, EventArgs e)
        {
            cbShowDate.Checked = tsmiShowDate.Checked;
        }

        private void cbShowDate_CheckedChanged(object sender, EventArgs e)
        {
            tsmiShowDate.Checked = cbShowDate.Checked;
        }

        private void tsmiShowWeekday_CheckedChanged(object sender, EventArgs e)
        {
            cbShowWeekday.Checked = (sender as ToolStripMenuItem).Checked;
        }

        private void cbShowWeekday_CheckedChanged(object sender, EventArgs e)
        {
            tsmiShowWeekday.Checked = (sender as CheckBox).Checked;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!this.TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void tsmiBackgroundColor_Click(object sender, EventArgs e)
        {
            if (backgroundColorDialog.ShowDialog() == DialogResult.OK)
            {
                labelTime.BackColor = backgroundColorDialog.Color;
            }
        }

        private void tsmiForegroundColor_Click(object sender, EventArgs e)
        {
            if (foregroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.ForeColor = foregroundColorDialog.Color;
            }
        }

        private void tsmiAutostart_CheckedChanged(object sender, EventArgs e)
        {
            SetAutostart(tsmiAutostart.Checked);
        }

        private void SetAutostart(bool enable)
        {
                string appName = "Clock";
                string appPath = Application.ExecutablePath;

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (enable)
                    {
                        key.SetValue(appName, appPath);
                    }
                    else
                    {
                        if (key.GetValue(appName) != null)
                            key.DeleteValue(appName);
                    }
                }
        }

        private void LoadAutostartSetting()
        {
            try
            {
                string appName = "Clock";

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", false))
                {
                    tsmiAutostart.Checked = key.GetValue(appName) != null;
                }
            }
            catch
            {
                tsmiAutostart.Checked = false;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.WindowState == FormWindowState.Normal)
            {
                //SetFormPosition();
            }
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            if (this.WindowState == FormWindowState.Normal)
            {
                Screen screen = Screen.FromControl(this);
                if (this.Left != screen.WorkingArea.Width - this.Width ||
                    this.Top != 0)
                {
                    //SetFormPosition();
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
        }
        private void tsmiFont_Click(object sender, EventArgs e)
        {
            if(fontDialog.ShowDialog() == DialogResult.OK)
                labelTime.Font = fontDialog.Font;
        }
        void SaveSettings()
        {
            //string filename = $"{Application.ExecutablePath}\\..\\..\\..\\Settings.ini";
            StreamWriter writer = new StreamWriter(filename); //ini - Init (файл инициализации)
            writer.WriteLine($"{this.Location.X}x{this.Location.Y}");
            writer.WriteLine(tsmiTopmost.Checked);
            writer.WriteLine(tsmiShowControls.Checked);
            writer.WriteLine(tsmiShowDate.Checked);
            writer.WriteLine(tsmiShowWeekday.Checked);
            writer.WriteLine(tsmiAutostart.Checked);
            writer.WriteLine(fontDialog.FontFile);
            writer.WriteLine(fontDialog.NUDFontSize.Value);
            writer.WriteLine(labelTime.BackColor.ToArgb());
            writer.WriteLine(labelTime.ForeColor.ToArgb());
            writer.Close();
            Process.Start("notepad.exe", filename);

        }
                string filename = $"{Application.ExecutablePath}\\..\\..\\..\\Settings.ini";
        void LoadSettings()
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(filename);
                string[] position = reader.ReadLine().Split('x');
                this.Location = new Point(Convert.ToInt16(position.First()), Convert.ToInt16(position.Last()));
                tsmiTopmost.Checked = bool.Parse(reader.ReadLine());
                tsmiShowControls.Checked = bool.Parse(reader.ReadLine());
                tsmiShowDate.Checked = bool.Parse(reader.ReadLine());
                tsmiShowWeekday.Checked = bool.Parse(reader.ReadLine());
                tsmiAutostart.Checked = bool.Parse(reader.ReadLine());
                //fontDialog.FontFile = reader.ReadLine();
                fontDialog = new FontDialog(this, reader.ReadLine(), Convert.ToDecimal(reader.ReadLine()));
                this.labelTime.Font = fontDialog.Font;
                labelTime.BackColor = backgroundColorDialog.Color = Color.FromArgb(Convert.ToInt32(reader.ReadLine()));
                labelTime.ForeColor = foregroundColorDialog.Color = Color.FromArgb(Convert.ToInt32(reader.ReadLine()));
                reader.Close();
            }
            catch (Exception ex)
            {
                reader.Close();
                fontDialog = new FontDialog(this);
                MessageBox.Show(this, ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void MainForm_FormFormClosing(object sender, FormClosingEventArgs e) => SaveSettings();
    }
}