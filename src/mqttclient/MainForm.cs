﻿using System;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using mqttclient.Mqtt;
using System.Globalization;

namespace mqttclient
{
    public partial class MainForm : Form
    {
        private readonly IMqttPublish _mqttPublish;
        private readonly IMqtt _mqtt;

        public MainForm(IMqtt mqtt, IMqttPublish mqttPublish)
        {
            Utils.MainForm = this;

            _mqtt = mqtt;
            _mqttPublish = mqttPublish;

            try
            {
                InitializeComponent();
                Version version = Assembly.GetExecutingAssembly().GetName().Version;
                toolStripStatusLabel2.Text = "";
                MqttSettings.Init();
                SetupNotify();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void SetupTimer()
        {
            try
            {
                timer1.Interval = Convert.ToInt32(MqttSettings.MqttTimerInterval, CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                timer1.Interval = 6000;
            }

            timer1.Start();
        }

        delegate void SetTextCallback(string text);

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _mqttPublish.PublishSystemData();
        }

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

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSettingsFrom = new OptionsForm();
            frmSettingsFrom.Show();
        }

        public void ReloadApp()
        {
            ReconnectMqtt();
            SetupTimer();
        }

        public void ReconnectMqtt()
        {
            _mqtt.Connect(MqttSettings.MqttServer, MqttSettings.MqttPort, MqttSettings.MqttUsername, MqttSettings.MqttPassword);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (MqttSettings.MinimizeToTray)
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
            try
            {
                if (MqttSettings.MqttServer.Length > 3)
                {
                    ReconnectMqtt();
                    if (_mqtt.IsConnected)
                        toolStripStatusLabel1.Text = "connected to " + MqttSettings.MqttServer;
                    else
                        toolStripStatusLabel1.Text = "not connected";
                }
                else
                {
                    toolStripStatusLabel1.Text = "not connected";
                    var frmSettingsFrom = new OptionsForm();
                    frmSettingsFrom.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }

            SetupTimer();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mqtt.Disconnect();
        }
    }
}