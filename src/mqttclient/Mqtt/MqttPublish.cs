﻿using MqttClient.HardwareSensors;
using MqttClient.Workers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MqttClient.Mqtt
{
    public class MqttPublish : IMqttPublish
    {
        private readonly IMqtt _mqtt;
        private readonly string GLocalScreetshotFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "primonitor.jpg");
        private readonly string GLocalWebcamFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "webcam.png");

        public MqttPublish(IMqtt mqtt)
        {
            _mqtt = mqtt;
        }

        public async void SendDiscoveryInfo()
        {
            List<Task> task = new List<Task>();

            if (_mqtt.IsConnected == false)
                _mqtt.Connect(Utils.Settings.MqttServer, decimal.ToInt32(Utils.Settings.MqttPort), Utils.Settings.MqttUsername, Utils.Settings.MqttPassword);

            if (_mqtt.IsConnected)
            {
                foreach (var kvp in _mqtt.Workers)
                {
                    task.Add(Task.Run(() =>
                    {
                        var worker = kvp.Value;
                        var msgs = worker.SendDiscovery();
                        if (msgs == null) return;
                        foreach (var msg in msgs)
                            _mqtt.Publish(msg.Topic, JsonConvert.SerializeObject(msg.Payload), msg.Retain);
                    }));
                }
                return;
            }

            await Task.WhenAll(task).ConfigureAwait(false);
        }

        public async void SendWorkerUpdates()
        {
            List<Task> task = new List<Task>();

            if (_mqtt.IsConnected == false)
                _mqtt.Connect(Utils.Settings.MqttServer, decimal.ToInt32(Utils.Settings.MqttPort), Utils.Settings.MqttUsername, Utils.Settings.MqttPassword);
            
            if (_mqtt.IsConnected)
            {
                foreach (var kvp in _mqtt.Workers)
                {
                    task.Add(Task.Run(() => {
                        var worker = kvp.Value;
                        var msgs = worker.UpdateStatus();
                        if (msgs == null) return;
                        foreach (var msg in msgs)
                            _mqtt.Publish(msg.Topic, msg.Payload + "", msg.Retain);
                    }));
                }
                return;

                if (Utils.Settings.SensorIsComputerUsedEnabled)
                {
                    task.Add(Task.Run(() => PublishStatus()));
                }
                if (Utils.Settings.SlideshowEnabled)
                {
                    if (Utils.Settings["MqttSlideshowFolder"].ToString().Length > 5)
                    {
                        string folder = @Utils.Settings["MqttSlideshowFolder"].ToString();
                        task.Add(Task.Run(() => MqttCameraSlide(folder)));
                    }
                }
                if (Utils.Settings.SensorBatteryEnabled)
                {
                    task.Add(Task.Run(() => PublishBattery()));
                }
                if (Utils.Settings.WebCamPublishEnabled)
                {
                    task.Add(Task.Run(() => PublishCamera()));
                }
                if (Utils.Settings.ScreenshotEnable)
                {
                    task.Add(Task.Run(() => PublishScreenshot()));
                }
            }
            await Task.WhenAll(task).ConfigureAwait(false);
        }

        private void PublishStatus()
        {
            _mqtt.Publish("binary_sensor/inUse", UsingComputer.IsUsing() ? "on" : "off");
        }

        private void PublishBattery()
        {
            //_mqtt.Publish("Power/BatteryChargeStatus", Power.BatteryChargeStatus());
            //_mqtt.Publish("Power/BatteryFullLifetime", Power.BatteryFullLifetime());
            //_mqtt.Publish("Power/BatteryLifePercent", Power.BatteryLifePercent());
            //_mqtt.Publish("Power/BatteryLifeRemaining", Power.BatteryLifeRemaining());
            //_mqtt.Publish("Power/PowerLineStatus", Power.PowerLineStatus());
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
                        _mqtt.PublishImage("screenshot", GLocalScreetshotFile);

                    }
                }
            }
        }

        private void PublishCamera()
        {
            if (HardwareSensors.Camera.Save(GLocalWebcamFile))
                _mqtt.PublishImage("webcamera", GLocalWebcamFile);
            else
                MessageBox.Show($"Failed to save image");
        }

        private void MqttCameraSlide(string folder)
        {
            var rand = new Random();
            var files = Directory.GetFiles(folder, "*.jpg");
            string topic = "slideshow";
            _mqtt.PublishByte(topic, File.ReadAllBytes(files[rand.Next(files.Length)]));
        }
    }
}