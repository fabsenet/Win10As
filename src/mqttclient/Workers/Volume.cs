using WinMqtt.Mqtt;
using System;
using System.Collections.Generic;
using Win10SensorLibrary.HardwareSensors;

namespace WinMqtt.Workers
{
    class Volume : BaseWorker
    {
        public Volume() : base() { }

        protected override bool IsEnabled => Utils.Settings.WorkerVolumeControlEnabled;
        protected override decimal UpdateInterval => Utils.Settings.WorkerVolumeControlInterval;

        private readonly string[] ATTRIBUTES = new[] { "level", "mute" };

        public override List<MqttMessage> PrepareDiscoveryMessages()
        {
            if (!IsEnabled) return null;

            var result = new List<MqttMessage>();

            foreach (var attr in ATTRIBUTES)
            {
                var payload = PrepareConfigPayload();
                payload.Add("unique_id", SensorUniqueId(attr));
                payload.Add("name", $"{GetType().Name} - {attr.ToUppercaseFirst()}");
                payload.Add("state_topic", StateTopic(attr));

                if (attr == "level")
                {
                    payload.Add("icon", "mdi:volume-medium");
                }
                else if (attr == "mute")
                {
                    payload.Add("icon", "mdi:volume-off");
                }

                var sensorType = attr == "level" ? SensorType.Sensor : SensorType.BinarySensor;
                var mqttMsg = new MqttConfigMessage(sensorType, $"{WorkerType}_{attr}", payload);
                result.Add(mqttMsg);
            }

            return result;
        }


        public override List<MqttMessage> PrepareUpdateStatusMessages()
        {
            if (!IsEnabled) return null;

            var result = new List<MqttMessage>();

            result.Add(new MqttMessage(StateTopic("level"), Audio.GetVolume() + "", true));
            result.Add(new MqttMessage(StateTopic("mute"), Audio.IsMuted() ? "ON" : "OFF", true));

            return result;
        }

        public override void HandleCommand(string attribute, string payload)
        {
            if (!IsEnabled) return;

            switch (attribute)
            {
                case "level":
                    Audio.Volume(Convert.ToInt32(payload));
                    break;
                case "mute":
                    switch (payload)
                    {
                        case "1": case "on":
                            Audio.Mute(true);
                            break;
                        case "0": case "off":
                            Audio.Mute(false);
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
