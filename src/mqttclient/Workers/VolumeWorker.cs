using WinMqtt.Mqtt;
using System;
using System.Collections.Generic;
using Win10SensorLibrary.HardwareSensors;

namespace WinMqtt.Workers
{
    class VolumeWorker : BaseWorker
    {
        public VolumeWorker() : base() { }

        protected override bool IsEnabled => Utils.Settings.WorkerVolumeControlEnabled;
        protected override decimal UpdateInterval => Utils.Settings.WorkerVolumeControlInterval;

        private readonly string[] ATTRIBUTES = new[] { "level", "level_01", "mute" };

        public override List<MqttMessage> PrepareDiscoveryMessages()
        {
            if (!IsEnabled) return null;

            var result = new List<MqttMessage>();

            foreach (var attr in ATTRIBUTES)
            {
                var payload = PrepareConfigPayload();
                payload.Add("unique_id", SensorUniqueId(attr));
                payload.Add("name", $"{FriendlyName()} - {WorkerFriendlyType} - {attr.ToUppercaseFirst()}");
                payload.Add("state_topic", StateTopic(attr));

                if (attr == "level")
                {
                    payload.Add("unit_of_measurement", "%");
                    payload.Add("icon", "mdi:volume-medium");
                }
                else if (attr == "level_01")
                {
                    // Used for Media Player - there is no option to pass volume_level in universal platform as a template.
                    payload["state_topic"] = StateTopic("level");
                    payload.Add("value_template", "{{ (value|float) / 100 }}");
                    payload.Add("unit_of_measurement", "%");
                    payload.Add("icon", "mdi:volume-medium");
                }
                else if (attr == "mute")
                {
                    payload.Add("command_topic", CommandTopic(attr));
                    payload.Add("icon", "mdi:volume-off");
                }

                var sensorType = attr == "mute" ? SensorType.Switch : SensorType.Sensor;
                var mqttMsg = new MqttConfigMessage(sensorType, $"{WorkerType}_{attr}", payload);
                result.Add(mqttMsg);
            }

            return result;
        }


        public override List<MqttMessage> PrepareUpdateStatusMessages()
        {
            if (!IsEnabled) return null;

            var result = new List<MqttMessage>();

            result.Add(AudioVolumeMqttMessage());
            result.Add(AudioMuteMqttMessage());

            return result;
        }

        public override void HandleCommand(string attribute, string payload)
        {
            if (!IsEnabled) return;

            var step = 1;
            switch (attribute)
            {
                case "up":
                    step = $"{payload}" != "" ? payload.Convert<int>() : 1;
                    Audio.Volume(Audio.GetVolume() + step);
                    MqttConnection.Publish(AudioVolumeMqttMessage());
                    break;
                case "down":
                    step = $"{payload}" != "" ? payload.Convert<int>() : 1;
                    Audio.Volume(Audio.GetVolume() - step);
                    MqttConnection.Publish(AudioVolumeMqttMessage());
                    break;
                case "level":
                    Audio.Volume(payload.Convert<int>());
                    MqttConnection.Publish(AudioVolumeMqttMessage());
                    break;
                case "mute":
                    switch (payload.ToLower())
                    {
                        case "1": case "on":
                            Audio.Mute(true);
                            break;
                        case "0": case "off":
                            Audio.Mute(false);
                            break;
                    }
                    MqttConnection.Publish(AudioMuteMqttMessage());
                    break;
                case "mute_toggle":
                    Audio.Mute(!Audio.IsMuted());
                    MqttConnection.Publish(AudioMuteMqttMessage());
                    break;
                default:
                    break;
            }
        }

        private MqttMessage AudioVolumeMqttMessage() => new MqttMessage(StateTopic("level"), Convert.ToInt32(Audio.GetVolume()), true);
        private MqttMessage AudioMuteMqttMessage() => new MqttMessage(StateTopic("mute"), Audio.IsMuted() ? "ON" : "OFF", true);
    }
}
