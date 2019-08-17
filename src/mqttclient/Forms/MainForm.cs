using System;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using WinMqtt.Mqtt;
using WinMqtt.HardwareSensors;
using WinMqtt.Workers;

namespace WinMqtt.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Utils.MainForm = this;

            InitializeComponent();
            //Version version = Assembly.GetExecutingAssembly().GetName().Version;
            toolStripStatusLabel2.Text = "";
            SetupNotify();

            //var vol = Audio.GetVolume();
            //var BatteryChargeStatus = SystemInformation.PowerStatus.BatteryChargeStatus;
            //var BatteryFullLifetime = SystemInformation.PowerStatus.BatteryFullLifetime;
            //var BatteryLifePercent = SystemInformation.PowerStatus.BatteryLifePercent;
            //var BatteryLifeRemaining = SystemInformation.PowerStatus.BatteryLifeRemaining;
            //var PowerLineStatus = SystemInformation.PowerStatus.PowerLineStatus;


            //var idleTime = IdleTimeFinder.GetIdleTime();
            //var ts = idleTime.TotalSeconds;
        }

        private void SetupNotify()
        {
            string NotifyIconText = "Mqtt client";
            string NotifyIconBalloonTipText = "Mqtt client minimized to systemtray";
            int NotifyIconBalloonTipTimer = 200;

            notifyIcon1.Visible = false;
            notifyIcon1.Text = NotifyIconText;
            notifyIcon1.BalloonTipText = NotifyIconBalloonTipText;
            notifyIcon1.ShowBalloonTip(NotifyIconBalloonTipTimer);
        }

        delegate void SetTextCallback(string text);

        public static void HandleUnhandledException(Exception e)
        {
            if (MessageBox.Show("An unexpected error has occurred. details:" + e.Message + "innerException:" + e.InnerException + "Continue?",
                    "MqttClient" + e.Message + " inner:" + e.InnerException, MessageBoxButtons.YesNo, MessageBoxIcon.Stop,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                Application.Exit();
            }
        }

        public void UnhandledThreadExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            HandleUnhandledException(e.Exception);
        }

        private void lbLogs_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender != lbLogs) return;

            if (e.Control && e.KeyCode == Keys.C)
                Clipboard.SetText(lbLogs.SelectedItems[0].ToString());
        }

        private void OpenSettings()
        {
            var form = new OptionsForm();
            form.ShowDialog();
            form.Dispose();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e) => OpenSettings();

        public void ReloadApp()
        {
            var wasConnected = MqttConnection.IsConnected;
            MqttConnection.Connect();

            // Reinitialize workers only if client was connected to the server before
            if (wasConnected)
                MqttConnection.InitializeWorkers();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (Utils.Settings.ApplicationMinimizeToTray)
                {
                    notifyIcon1.Visible = true;
                    ShowInTaskbar = false;
                    Hide();
                }
            }
            else
                Show();
        }

        private void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //hard exit
            Environment.Exit(0);
        }

        private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (Utils.Settings.MqttServer.Length > 3)
            {
                MqttConnection.Connect();
                if (MqttConnection.IsConnected)
                    toolStripStatusLabel1.Text = "connected to " + Utils.Settings.MqttServer;
                else
                    toolStripStatusLabel1.Text = "not connected";
            }
            else
            {
                toolStripStatusLabel1.Text = "not connected";
                OpenSettings();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MqttConnection.Disconnect();
        }
    }
}