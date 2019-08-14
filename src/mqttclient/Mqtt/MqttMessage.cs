using MqttClient.Workers;
using System.Collections.Generic;

namespace MqttClient.Mqtt
{
    public class MqttMessage
    {
        public string Topic;
        public object Payload;
        public bool Retain;

        public MqttMessage(string topic, object payload, bool retain = true)
        {
            Topic = topic;
            Payload = payload;
            Retain = retain;
        }
    }

    public class MqttConfigMessage : MqttMessage
    {
        public MqttConfigMessage(SensorType sensorType, string name, Dictionary<string, object> payload, bool retain = true) : base("", payload, retain)
        {
            Topic = $"{Utils.Settings.MqttTopic}/{name}/config";
            if (Utils.Settings.MqttDiscoveryEnabled && Utils.Settings.MqttDiscoveryPrefix.Length > 0)
                Topic = $"{Utils.Settings.MqttDiscoveryPrefix}/{sensorType.Name()}/{Topic}";
        }
    }
}
