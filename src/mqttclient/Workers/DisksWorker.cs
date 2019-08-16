using WinMqtt.Mqtt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WinMqtt.Workers
{
    class DisksWorker : BaseWorker
    {
        private readonly string[] ATTRIBUTES = new[] { "free", "free_pct", "total" };

        protected override bool IsEnabled => Utils.Settings.WorkerDiskInfoEnabled;
        protected override decimal UpdateInterval => Utils.Settings.WorkerDiskInfoInterval;

        public override List<MqttMessage> PrepareDiscoveryMessages()
        {
            if (!IsEnabled) return null;

            var result = new List<MqttMessage>();

            foreach (var drive in Drives)
            {
                var diskLetter = drive.Name.Replace(":\\", "").ToLower();
                foreach (var attr in ATTRIBUTES)
                {
                    var payload = PrepareConfigPayload();
                    payload.Add("unique_id", SensorUniqueId(diskLetter, attr));
                    payload.Add("state_topic", StateTopic(diskLetter, attr));

                    switch (attr)
                    {
                        case "free":
                            payload.Add("name", $"Disk {diskLetter.ToUpper()} - free");
                            payload.Add("unit_of_measurement", "GB");
                            break;
                        case "free_pct":
                            payload.Add("name", $"Disk {diskLetter.ToUpper()} - free pct");
                            payload.Add("unit_of_measurement", "%");
                            break;
                        case "total":
                            payload.Add("name", $"Disk {diskLetter.ToUpper()} - total");
                            payload.Add("unit_of_measurement", "GB");
                            break;
                    }

                    var sensorType = SensorType.Sensor;
                    var mqttMsg = new MqttConfigMessage(sensorType, $"{WorkerType}_{diskLetter}_{attr}", payload);
                    result.Add(mqttMsg);
                }
            }

            return result;
        }

        const long BYTES_TO_GBYTES = 1024 * 1024 * 1024;
        public override List<MqttMessage> PrepareUpdateStatusMessages()
        {
            if (!IsEnabled) return null;

            var result = new List<MqttMessage>();

            foreach (var drive in Drives)
            {
                var diskLetter = drive.Name.Replace(":\\", "").ToLower();

                var freeSpace = drive.TotalFreeSpace;
                var totalSpace = drive.TotalSize;
                var percentFree = (((double)freeSpace / totalSpace) * 100);

                result.Add(new MqttMessage(StateTopic(diskLetter, "free"), Math.Round((double)freeSpace / BYTES_TO_GBYTES, 2)));
                result.Add(new MqttMessage(StateTopic(diskLetter, "free_pct"), Math.Round(percentFree, 2)));
                result.Add(new MqttMessage(StateTopic(diskLetter, "total"), Math.Round((double)totalSpace / BYTES_TO_GBYTES, 2)));
            }

            return result;
        }

        public override void HandleCommand(string attribute, string payload)
        {
            return;
        }

        private IEnumerable<DriveInfo> Drives => DriveInfo.GetDrives().Where(x => x.IsReady && x.DriveType == DriveType.Fixed);
    }
}
