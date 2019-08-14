using MqttClient.Mqtt;
using MqttClient.Mqtt.Workers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace MqttClient.Workers
{
    class Performance : BaseWorker
    {
        public Performance() : base() { }

        private readonly string[] ATTRIBUTES = new[] { "cpu", "ram" };


        public override List<MqttMessage> SendDiscovery()
        {
            var result = new List<MqttMessage>();

            foreach (var attr in ATTRIBUTES)
            {
                var payload = PrepareConfigPayload();
                payload.Add("unique_id", SensorUniqueId(attr));
                payload.Add("state_topic", StateTopic(attr));

                if (attr == "cpu")
                {
                    payload.Add("name", $"CPU usage");
                    payload.Add("unit_of_measurement", "%");
                }
                else if (attr == "ram")
                {
                    payload.Add("name", $"Free RAM");
                    payload.Add("unit_of_measurement", "MB");
                }

                var sensorType = SensorType.Sensor;
                var mqttMsg = new MqttConfigMessage(sensorType, $"{GetWorkerType()}_{attr}", payload);
                result.Add(mqttMsg);
            }

            return result;
        }

        public override List<MqttMessage> UpdateStatus()
        {
            var result = new List<MqttMessage>();

            result.Add(new MqttMessage(StateTopic("cpu"), GetCpuProcessorTime() + "", true));
            result.Add(new MqttMessage(StateTopic("ram"), GetFreeMemory(), true));

            return result;
        }

        private float GetFreeMemory()
        {
            var ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            return ramCounter.NextValue();
        }

        private decimal GetCpuProcessorTime()
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuCounter.NextValue();

            Thread.Sleep(1000);

            return Math.Round(Convert.ToDecimal(cpuCounter.NextValue() + ""), 2);
        }
    }
}
