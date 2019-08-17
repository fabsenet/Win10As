using WinMqtt.Mqtt;
using System;
using System.Collections.Generic;
using AudioSwitcher.AudioApi.CoreAudio;

namespace WinMqtt.Workers
{
    class VolumeWorker : BaseWorker
    {
        public VolumeWorker() : base() { }

        protected override bool IsEnabled => Utils.Settings.WorkerVolumeControlEnabled;
        protected override decimal UpdateInterval => Utils.Settings.WorkerVolumeControlInterval;

        private readonly string[] ATTRIBUTES = new[] { "level", "level_01", "mute" };

        protected override List<MqttMessage> PrepareDiscoveryMessages()
        {
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

        protected override List<MqttMessage> PrepareUpdateStatusMessages()
        {
            var result = new List<MqttMessage>();

            result.Add(AudioVolumeMqttMessage());
            result.Add(AudioMuteMqttMessage());

            return result;
        }

        public override void HandleCommand(string attribute, string payload)
        {
            if (!IsEnabled) return;

            int step;
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

        private MqttMessage AudioVolumeMqttMessage() => new MqttMessage(StateTopic("level"), Convert.ToInt32(Audio.GetVolume()));
        private MqttMessage AudioMuteMqttMessage() => new MqttMessage(StateTopic("mute"), Audio.IsMuted() ? "ON" : "OFF");
    }
    
    static class Audio
    {
        private static CoreAudioDevice _defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        static Audio() => SetDevice(Utils.Settings.WorkerVolumeControlDevice);

        public static void Mute(bool Enable) => _defaultPlaybackDevice.SetMuteAsync(Enable).Wait();
        public static bool IsMuted() => _defaultPlaybackDevice.IsMuted;
        public static void Volume(double level) => _defaultPlaybackDevice.SetVolumeAsync(level).Wait();
        public static double GetVolume() => _defaultPlaybackDevice.Volume;

        static public List<string> GetDevices()
        {
            var cac = new CoreAudioController();
            List<string> tmp = new List<string>();

            foreach (CoreAudioDevice de in cac.GetPlaybackDevices())
                tmp.Add(de.FullName);

            cac.Dispose();
            return tmp;

        }

        public static void SetDevice(string deviceFullName = "")
        {
            var cac = new CoreAudioController();
            if ($"{deviceFullName}" == "")
            {
                _defaultPlaybackDevice = cac.DefaultPlaybackDevice;
                return;
            }

            foreach (var de in cac.GetPlaybackDevices())
            {
                if (de.FullName.ToLower() != deviceFullName.ToLower())
                    continue;

                _defaultPlaybackDevice = de;
                break;
            }
        }
    }
}
