using WinMqtt.Workers;
using System.Collections.Generic;
using System.IO;
using System;

namespace WinMqtt.Mqtt
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

    public class MqttImageMessage : MqttMessage
    {
        public MqttImageMessage(string topic, string filePath, bool retain = true) : base(topic, null, retain)
        {
            if (!File.Exists(filePath))
                throw new Exception($"File {filePath} does not exist!");

            Payload = File.ReadAllBytes(filePath);
        }
    }
}
