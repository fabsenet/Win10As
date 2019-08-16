using MqttClient.Mqtt;
using System;
using System.Collections.Generic;
using System.Timers;

namespace MqttClient.Workers
{
    public abstract class BaseWorker : IDisposable
    {
        protected virtual Dictionary<string, object> PrepareConfigPayload(params string[] sensorArgs)
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

        public string StateTopic(params string[] attributes) => string.Join("/", Utils.Settings.MqttTopic, WorkerType, string.Join("/", attributes));
        public string UniqueId() => string.Join("/", "win-mqtt", Utils.Settings.MqttTopic);
        public string SensorUniqueId(params string[] attributes) => string.Join("/", UniqueId(), WorkerType, string.Join("/", attributes));
        public string Name(string attribute = "") => string.Join("_", Utils.Settings.MqttTopic, WorkerType, attribute);

        protected string WorkerType => GetType().Name.ToLower();

        protected abstract bool IsEnabled { get; }
        protected abstract decimal UpdateInterval { get; }

        public abstract List<MqttMessage> SendDiscovery();
        public abstract List<MqttMessage> UpdateStatus();
        public abstract void HandleCommand(string attribute, string payload);

        private Timer _updateTimer = null;
        public void ProcessUpdateTask()
        {
            if (_updateTimer == null)
            {
                _updateTimer = new Timer();
                _updateTimer.Elapsed += (sender, e) => UpdateStatus();
            }

            _updateTimer.Enabled = IsEnabled;
            _updateTimer.Interval = Math.Max(Convert.ToDouble(UpdateInterval), 100);
        }
        public void StopUpdateTask()
        {
            if (_updateTimer == null)
                return;

            _updateTimer.Stop();
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                if (_updateTimer == null)
                    _updateTimer.Dispose();
            }

            _disposed = true;
        }

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    public enum SensorType { BinarySensor, Switch, Light, Sensor, MediaPlayer, Climate };
}
