using System;
using System.Globalization;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using WinMqtt.Workers;

namespace WinMqtt.Forms
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();

            var topic = Utils.Settings.MqttTopic + "";
            if (topic.Length == 0)
                topic = (Environment.MachineName + "").ToLower();

            if (topic.Contains("#"))
                topic = topic.Replace("/#", "");

            Utils.Settings.MqttTopic = topic;

            cbbVolumeDevice.DataSource = Audio.GetDevices();
            cbbVolumeDevice.SelectedItem = Utils.Settings.WorkerVolumeControlDevice;
            cbbCameraDevice.DataSource = Camera.GetDevices();
            cbbCameraDevice.SelectedItem = Utils.Settings.WorkerCameraDevice;
            cbbTTSSpeaker.DataSource = HardwareSensors.Speaker.GetSpeakers();
            cbbTTSSpeaker.SelectedItem = Utils.Settings.TTSSpeaker;
        }

        private void SaveComboBoxSettings()
        {
            Utils.Settings.TTSSpeaker = $"{cbbTTSSpeaker.SelectedItem}";
            Utils.Settings.WorkerCameraDevice = $"{cbbCameraDevice.SelectedItem}";
            Utils.Settings.WorkerVolumeControlDevice = $"{cbbVolumeDevice.SelectedItem}";

            Utils.Settings.Save();
        }

        private void btnTTSTest_Click(object sender, EventArgs e)
        {
            if ($"{cbbTTSSpeaker.SelectedItem}" != "")
                HardwareSensors.Speaker.Speak("Test", $"{cbbTTSSpeaker.SelectedItem}");
        }

        private void ChkStartUp_CheckedChanged(object sender, EventArgs e)
        {
            var rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (chkStartUp.Checked)
                rk.SetValue(Utils.AppId, Application.ExecutablePath.ToString(CultureInfo.CurrentCulture));
            else
                rk.DeleteValue(Utils.AppId, false);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (cbbCameraDevice.SelectedValue.ToString().Length > 0)
                Camera.Save("preview", true);
        }

        private void ChkTtsEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTTSEnabled.Checked)
            {
                cbbTTSSpeaker.DataSource = HardwareSensors.Speaker.GetSpeakers();
                cbbTTSSpeaker.SelectedItem = Utils.Settings.TTSSpeaker;
            }
        }

        private void btnTestMqttConnection_Click(object sender, EventArgs e)
        {
            var client = new MqttClient(tbMqttServer.Text, Utils.Settings.MqttPort.Convert<int>(), false, null, null, MqttSslProtocols.None, null);
            client.Connect(Guid.NewGuid().ToString(), tbMqttUsername.Text, tbMqttPassword.Text);

            if (client.IsConnected)
                MessageBox.Show("Connection settings are correct.");
            else
                MessageBox.Show("Failed to connect to selected server.");
        }

        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveComboBoxSettings();
            Utils.MainForm.ReloadApp();
        }

        private void BtnWebcamBrowseSaveDir_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    Utils.Settings.WorkerCameraSaveLocation = fbd.SelectedPath;
            }
        }
    }
}
