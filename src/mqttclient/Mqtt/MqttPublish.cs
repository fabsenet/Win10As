using WinMqtt.HardwareSensors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMqtt.Mqtt
{
    public class MqttPublish
    {
        private readonly string GLocalScreetshotFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "primonitor.jpg");
        private readonly string GLocalWebcamFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "webcam.png");

        public async void SendWorkerUpdates()
        {
            return;

            List<Task> task = new List<Task>();

            if (Mqtt.IsConnected == false)
                Mqtt.Connect();
            
            if (Mqtt.IsConnected)
            {
                if (Utils.Settings.SensorIsComputerUsedEnabled)
                    task.Add(Task.Run(() => PublishStatus()));
                if (Utils.Settings.SensorBatteryEnabled)
                    task.Add(Task.Run(() => PublishBattery()));
                if (Utils.Settings.WebCamPublishEnabled)
                    task.Add(Task.Run(() => PublishCamera()));
                if (Utils.Settings.ScreenshotEnable)
                    task.Add(Task.Run(() => PublishScreenshot()));
            }
            await Task.WhenAll(task).ConfigureAwait(false);
        }

        private void PublishStatus()
        {
            //Mqtt.Publish("binary_sensor/inUse", UsingComputer.IsUsing() ? "on" : "off");
        }

        private void PublishBattery()
        {
            //Mqtt.Publish("Power/BatteryChargeStatus", Power.BatteryChargeStatus());
            //Mqtt.Publish("Power/BatteryFullLifetime", Power.BatteryFullLifetime());
            //Mqtt.Publish("Power/BatteryLifePercent", Power.BatteryLifePercent());
            //Mqtt.Publish("Power/BatteryLifeRemaining", Power.BatteryLifeRemaining());
            //Mqtt.Publish("Power/PowerLineStatus", Power.PowerLineStatus());
        }

        private static bool NetworkUp()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }

        private void PublishScreenshot()
        {
            if (NetworkUp())
            {
                using (var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb))
                {
                    using (var gfxScreenshot = Graphics.FromImage(bmpScreenshot))
                    {
                        gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);


                        bmpScreenshot.Save(GLocalScreetshotFile, ImageFormat.Png);

                        Mqtt.Publish(new MqttImageMessage("screenshot", GLocalWebcamFile));

                    }
                }
            }
        }

        private void PublishCamera()
        {
            if (Camera.Save(GLocalWebcamFile))
                Mqtt.Publish(new MqttImageMessage("webcamera", GLocalWebcamFile));
            else
                MessageBox.Show($"Failed to save image");
        }
    }
}