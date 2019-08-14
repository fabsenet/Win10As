using MqttClient.Mqtt;
using System;
using System.Collections.Generic;
using System.Linq;
using Win10SensorLibrary.HardwareSensors;

namespace MqttClient.Workers
{
    class Volume : BaseWorker
    {
        public Volume() : base() { }

        private readonly string[] ATTRIBUTES = new[] { "level", "mute" };


        public override List<MqttMessage> SendDiscovery()
        {
            if (!Utils.Settings.VolumeControlEnabled)
                return null;

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
                var mqttMsg = new MqttConfigMessage(sensorType, $"{GetWorkerType()}_{attr}", payload);
                result.Add(mqttMsg);
            }

            return result;
        }


        public override List<MqttMessage> UpdateStatus()
        {
            if (!Utils.Settings.VolumeControlEnabled)
                return null;

            var result = new List<MqttMessage>();

            result.Add(new MqttMessage(StateTopic("level"), Audio.GetVolume() + "", true));
            result.Add(new MqttMessage(StateTopic("mute"), Audio.IsMuted() ? "ON" : "OFF", true));

            return result;
        }

        public override void HandleCommand(string attribute, string payload)
        {
            switch (attribute)
            {
                case "level":
                    Audio.Volume(Convert.ToInt32(payload));
                    break;
                case "mute":
                    var setMuteOptions = new[] { "1", "on" };

                    var mute = setMuteOptions.Contains(payload.ToLower());

                    Audio.Mute(mute);
                    break;
                default:
                    break;
            }
        }
    }
}
