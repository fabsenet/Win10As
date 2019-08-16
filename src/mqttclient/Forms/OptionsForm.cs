using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using Win10SensorLibrary.HardwareSensors;

namespace MqttClient.Forms
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

            if (Utils.Settings.TTSEnabled)
            {
                cmbSpeaker.DataSource = HardwareSensors.Speaker.GetSpeakers();
                cmbSpeaker.SelectedItem = Utils.Settings.TTSSpeaker;
            }

            if (ChkEnableWebCamPublish.Checked)
            {
                LoadCameraDevices();
                if (Convert.ToString(Utils.Settings["WebCamToPublish"], CultureInfo.CurrentCulture).Length > 0)
                    cmbWebcam.SelectedText = Convert.ToString(Utils.Settings["WebCamToPublish"], CultureInfo.CurrentCulture);
            }

            LoadAudioDevices();
        }

        private void SaveSettings()
        {
            Utils.Settings.Save();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Utils.MainForm.ReloadApp();
            Close();
        }

        private void CmdTestSpeaker_Click(object sender, EventArgs e)
        {
            if (cmbSpeaker.SelectedItem.ToString().Length > 0)
            {
                HardwareSensors.Speaker.Speak("testing", cmbSpeaker.SelectedItem.ToString());
            }
        }

        private void ChkStartUp_CheckedChanged(object sender, EventArgs e)
        {
            {
                Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (chkStartUp.Checked)
                    rk.SetValue(Utils.AppId, Application.ExecutablePath.ToString(CultureInfo.CurrentCulture));
                else
                    rk.DeleteValue(Utils.AppId, false);

                Utils.Settings["RunAtStart"] = chkStartUp.Checked;
            }
        }

        private void LoadAudioDevices()
        {
            cmbAudioOutput.DataSource = Audio.GetAudioDevices();
        }

        private void LoadCameraDevices()
        {
            cmbWebcam.DataSource = HardwareSensors.Camera.GetDevices();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (cmbWebcam.SelectedValue.ToString().Length > 0)
            {
                try
                {
                    string Filename = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\cameratest.jpeg";

                    if (HardwareSensors.Camera.Save(Filename))
                    {
                        MessageBox.Show($"camera image saved to {Filename}");
                    }
                    else
                    {
                        MessageBox.Show($"Failed to save image");
                    }

                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void ChkEnableWebCamPublish_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEnableWebCamPublish.Checked)
                LoadCameraDevices();
            else
                cmbWebcam.DataSource = null;
        }

        private void ChkTtsEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTtsEnabled.Checked)
            {
                cmbSpeaker.DataSource = HardwareSensors.Speaker.GetSpeakers();
                cmbSpeaker.SelectedItem = Utils.Settings["TTSSpeaker"];
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var client = new uPLibrary.Networking.M2Mqtt.MqttClient(tbMqttServer.Text, Convert.ToInt16(Utils.Settings.MqttPort, CultureInfo.CurrentCulture), false, null, null, MqttSslProtocols.None, null);

                if (tbMqttUsername.Text.Length == 0)
                {
                    byte code = client.Connect(Guid.NewGuid().ToString());
                }
                else
                {
                    byte code = client.Connect(Guid.NewGuid().ToString(), tbMqttUsername.Text, tbMqttPassword.Text);
                }
                MessageBox.Show($"connection ok id: {client.ClientId}");
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed");
                //throw;
            }
        }

        private void CmdSelectSlideShowPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                Utils.Settings.SlideshowFolder = folderBrowserDialog1.SelectedPath;
        }
    }
}
