using MqttClient.Mqtt;
using System.Collections.Generic;

namespace MqttClient.Workers
{
    public abstract class BaseWorker
    {
        public BaseWorker()
        {
        }

        public virtual Dictionary<string, object> PrepareConfigPayload(params string[] sensorArgs)
        {
            var friendlyName = Utils.Settings.MqttDiscoveryFriendlyName;
            if ((friendlyName + "").Trim() == "")
                friendlyName = Utils.Settings.MqttTopic;

            var device = new Dictionary<string, object>
            {
                { "name", friendlyName },
                { "identifiers", new List<string> { UniqueId() } },
                { "sw_version", "0.0.1 Win MQTT" }
            };

            var payload = new Dictionary<string, object>
            {
                { "device", device },
            };

            return payload;
        }

        public string StateTopic(string attribute = "") => string.Join("/", Utils.Settings.MqttTopic, GetWorkerType(), attribute);
        public string UniqueId() => string.Join("/", "win-mqtt", Utils.Settings.MqttTopic);
        public string SensorUniqueId(string attribute = "") => string.Join("/", UniqueId(), GetWorkerType(), attribute);
        public string Name(string attribute = "") => string.Join("_", Utils.Settings.MqttTopic, GetWorkerType(), attribute);

        protected string GetWorkerType() => GetType().Name.ToLower();

        public abstract List<MqttMessage> SendDiscovery();
        public abstract List<MqttMessage> UpdateStatus();
        public abstract void HandleCommand(string attribute, string payload);
    }

    public enum SensorType { BinarySensor, Switch, Light, Sensor, MediaPlayer, Climate };
}
