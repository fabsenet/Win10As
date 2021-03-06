﻿using System;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using mqttclient.Mqtt;
using System.Globalization;

namespace mqttclient
{
    public partial class FrmMqttMain : Form
    {
        private readonly IMqttPublish _mqttPublish;
        private readonly Func<FrmOptions> frmSettingsFrom;
        private readonly IMqtt _mqtt;
        public FrmMqttMain(IMqtt mqtt, IMqttPublish mqttPublish, MainFormContainer mainFormContainer, Func<FrmOptions> frmSettingsFrom)
        {
            _mqtt = mqtt;
            _mqttPublish = mqttPublish;
            this.frmSettingsFrom = frmSettingsFrom ?? throw new ArgumentNullException(nameof(frmSettingsFrom));
            mainFormContainer.MainForm = this;

            try
            {
                InitializeComponent();
                Version version = Assembly.GetExecutingAssembly().GetName().Version;
                toolStripStatusLabel2.Text = "";
                MqttSettings.Init();
                SetupNotify();
                Properties.Settings.Default.SettingsSaving += (_, __) => ReloadApp();
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
        //private void client_MqttConnectionClosed(object sender, EventArgs e)
        //{
        //    toolStripStatusLabel1.Text = "not connected";
        //}
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
        private void ListBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender != listBox1) return;

            if (e.Control && e.KeyCode == Keys.C)
                try
                {
                    Clipboard.SetText(listBox1.SelectedItems[0].ToString());
                }
                catch (Exception)
                {
                }
        }
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettingsFrom().Show();
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
        private void FrmMqttMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                if (MqttSettings.MinimizeToTray == true)
                {
                    notifyIcon1.Visible = true;
                    this.ShowInTaskbar = false;
                    this.Hide();
                }
            }
            else
            {
                this.Show();
            }
        }
        private void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void FrmMqttMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //hard exit
            Environment.Exit(0);
        }
        private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
        private void FrmMqttMain_Shown(object sender, EventArgs e)
        {
            try
            {
                if (MqttSettings.MqttServer.Length > 3)
                {
                    ReconnectMqtt();
                    if (_mqtt.IsConnected == true)
                    {
                        toolStripStatusLabel1.Text = "connected to " + MqttSettings.MqttServer;
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "not connected";
                    }
                }
                else
                {
                    toolStripStatusLabel1.Text = "not connected";
                    frmSettingsFrom().Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
            SetupTimer();

        }
        private void FrmMqttMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mqtt.Disconnect();
        }
    }
}

