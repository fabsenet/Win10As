using MqttClient.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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

    // https://stackoverflow.com/a/6944605
    public static class ReflectiveEnumerator
    {
        static ReflectiveEnumerator() { }

        public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class
        {
            List<T> objects = new List<T>();
            foreach (Type type in Assembly.GetAssembly(typeof(T)).GetTypes().Where(myType => 
                myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))
            ))
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));

            return objects;
        }
    }
}
