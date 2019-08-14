using MqttClient.Mqtt;
using MqttClient.Mqtt.Workers;
using System.Collections.Generic;
using Win10SensorLibrary.HardwareSensors;

namespace MqttClient.Workers
{
    class Volume : BaseWorker
    {
        public Volume() : base() { }

        private readonly string[] ATTRIBUTES = new[] { "level", "mute" };


        public override List<MqttMessage> SendDiscovery()
        {
            var result = new List<MqttMessage>();

            foreach (var attr in ATTRIBUTES)
            {
                var payload = PrepareConfigPayload();
                payload.Add("unique_id", SensorUniqueId(attr));
                payload.Add("name", $"{GetType().Name} - {attr.ToUppercaseFirst()}");
                payload.Add("state_topic", StateTopic(attr));

                var sensorType = attr == "level" ? SensorType.Sensor : SensorType.BinarySensor;
                var mqttMsg = new MqttConfigMessage(sensorType, $"{GetWorkerType()}_{attr}", payload);
                result.Add(mqttMsg);
            }

            return result;
        }


        public override List<MqttMessage> UpdateStatus()
        {
            var result = new List<MqttMessage>();

            result.Add(new MqttMessage(StateTopic("level"), Audio.GetVolume() + "", true));
            result.Add(new MqttMessage(StateTopic("mute"), Audio.IsMuted() ? "ON" : "OFF", true));

            return result;
        }
    }
}
