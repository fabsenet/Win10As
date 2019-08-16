using WinMqtt.Mqtt;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace WinMqtt.Workers
{
    class PerformanceWorker : BaseWorker
    {
        private readonly string[] ATTRIBUTES = new[] { "cpu", "ram" };

        protected override bool IsEnabled => Utils.Settings.WorkerPerformanceInfoEnabled;
        protected override decimal UpdateInterval => Utils.Settings.WorkerPerformanceInfoInterval;

        public override List<MqttMessage> PrepareDiscoveryMessages()
        {
            if (!IsEnabled) return null;

            var result = new List<MqttMessage>();

            foreach (var attr in ATTRIBUTES)
            {
                var payload = PrepareConfigPayload();
                payload.Add("unique_id", SensorUniqueId(attr));
                payload.Add("state_topic", StateTopic(attr));

                if (attr == "cpu")
                {
                    // payload.Add("icon", "mdi:cpu");
                    payload.Add("name", $"{FriendlyName()} - CPU usage");
                    payload.Add("unit_of_measurement", "%");
                }
                else if (attr == "ram")
                {
                    payload.Add("icon", "mdi:memory");
                    payload.Add("name", $"{FriendlyName()} - Free RAM");
                    payload.Add("unit_of_measurement", "MB");
                }

                var sensorType = SensorType.Sensor;
                var mqttMsg = new MqttConfigMessage(sensorType, $"{WorkerType}_{attr}", payload);
                result.Add(mqttMsg);
            }

            return result;
        }

        public override List<MqttMessage> PrepareUpdateStatusMessages()
        {
            if (!IsEnabled) return null;

            var result = new List<MqttMessage>();

            result.Add(new MqttMessage(StateTopic("cpu"), GetCpuProcessorTime()));
            result.Add(new MqttMessage(StateTopic("ram"), GetFreeMemory()));

            return result;
        }

        public override void HandleCommand(string attribute, string payload)
        {
            return;
        }

        private float GetFreeMemory()
        {
            var ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            return ramCounter.NextValue();
        }

        // If having errors - try this: https://stackoverflow.com/a/24404034
        private decimal GetCpuProcessorTime()
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuCounter.NextValue();

            Thread.Sleep(1000);

            return Math.Round(Convert.ToDecimal(cpuCounter.NextValue() + ""), 2);
        }
    }
}
