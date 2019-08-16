using WinMqtt.Mqtt;
using System;
using System.Collections.Generic;
using Win10SensorLibrary.HardwareSensors;
using System.Runtime.InteropServices;

namespace WinMqtt.Workers
{
    class MediaPlayerWorker : BaseWorker
    {
        protected override bool IsEnabled => Utils.Settings.WorkerMediaPlayerEnabled;
        protected override decimal UpdateInterval => 0;

        public override List<MqttMessage> PrepareDiscoveryMessages() => null;
        public override List<MqttMessage> PrepareUpdateStatusMessages() => null;

        public override void HandleCommand(string attribute, string payload)
        {
            if (!IsEnabled) return;

            switch (attribute)
            {
                case "play_pause":
                    keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    break;
                case "stop":
                    keybd_event(VK_MEDIA_STOP, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    break;
                case "next_track":
                    keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    break;
                case "prev_track":
                    keybd_event(VK_MEDIA_PREV_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    break;
                default:
                    break;
            }
        }

        private const int KEYEVENTF_EXTENTEDKEY = 1;
        private const int KEYEVENTF_KEYUP = 0;
        private const int VK_MEDIA_NEXT_TRACK = 0xB0;
        private const int VK_MEDIA_PREV_TRACK = 0xB1;
        private const int VK_MEDIA_STOP = 0xB2;
        private const int VK_MEDIA_PLAY_PAUSE = 0xB3;

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);
    }
}
