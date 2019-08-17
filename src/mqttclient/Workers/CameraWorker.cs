using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.IO;
using WinMqtt.Mqtt;

namespace WinMqtt.Workers
{
    class CameraWorker : BaseWorker
    {
        protected override bool IsEnabled => Utils.Settings.WorkerCameraEnabled;
        protected override decimal UpdateInterval => Utils.Settings.WorkerCameraInterval;

        protected override List<MqttMessage> PrepareDiscoveryMessages()
        {
            var result = new List<MqttMessage>();

            return result;
        }

        protected override List<MqttMessage> PrepareUpdateStatusMessages()
        {
            var result = new List<MqttMessage>();

            result.Add(new MqttImageMessage("snapshot", ""));

            return result;
        }

        public override void HandleCommand(string attribute, string payload)
        {
            //if (Camera.Save(GLocalWebcamFile))
            //    Mqtt.Publish(new MqttImageMessage("webcamera", GLocalWebcamFile));
            //else
            //    MessageBox.Show($"Failed to save image");

            throw new NotImplementedException();
        }
    }

    static class Camera
    {
        private static VideoCaptureDevice _videoDevice;

        public static List<string> GetDevices()
        {
            var result = new List<string>();
            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
                result.Add(device.Name);

            return result;
        }

        public static void SetDevice(string name)
        {
            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (_videoDevice != null)
            {
                _videoDevice.NewFrame -= video_NewFrame;
                _videoDevice.SignalToStop();
            }
            foreach (FilterInfo device in videoDevices)
            {
                if (device.Name != name) continue;
                _videoDevice = new VideoCaptureDevice(device.MonikerString);
                _videoDevice.NewFrame += video_NewFrame;
            }
        }

        public static bool Save()
        {
            SetDevice(Utils.Settings.WorkerCameraDevice);
            _videoDevice.Start();

            return true;
        }

        private static void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            _videoDevice.SignalToStop();

            var img = eventArgs.Frame;

            var path = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid().ToString()}.jpg");
            img.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);

            img.Dispose();
        }
    }
}
