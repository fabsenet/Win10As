using MqttClient.Mqtt.Workers;
using System.Collections.Generic;

namespace MqttClient.Mqtt
{
    class MqttMessage
    {
        public string Topic;
        public object Payload;
        public bool Retain;

        public MqttMessage(string topic, object payload, bool retain = false)
        {
            Topic = topic;
            Payload = payload;
            Retain = retain;
        }
    }

    class MqttConfigMessage : MqttMessage
    {
        public MqttConfigMessage(SensorType sensorType, string name, Dictionary<string, object> payload, bool retain = false) : base("", payload, retain)
        {
            Topic = $"{Utils.Settings.MqttTopic}/{name}/config";
            if (Utils.Settings.MqttDiscoveryEnabled && Utils.Settings.MqttDiscoveryPrefix.Length > 0)
                Topic = $"{Utils.Settings.MqttDiscoveryPrefix}/{sensorType.Name()}/{Topic}";
        }
    }
}
