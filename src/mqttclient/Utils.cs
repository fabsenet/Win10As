using MqttClient.Mqtt.Workers;

namespace MqttClient
{
    public static class Utils
    {
        public static MainForm MainForm;
        public static string AppId => "Win Mqtt Client";
        public static Properties.Settings Settings => Properties.Settings.Default;
        public static string ToUppercaseFirst(this string str) => str + "" == "" ? "" : char.ToUpper(str[0]) + str.Substring(1);

        public static string Name(this SensorType sensorType)
        {
            switch (sensorType)
            {
                case SensorType.BinarySensor:
                    return "binary_sensor";
                case SensorType.Switch:
                    return "switch";
                case SensorType.Light:
                    return "light";
                case SensorType.Sensor:
                    return "sensor";
                case SensorType.MediaPlayer:
                    return "media_player";
                case SensorType.Climate:
                    return "climate";
            }

            return "UNSUPPORTED";
        }
    }
}
