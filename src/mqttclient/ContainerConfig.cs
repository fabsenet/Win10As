using Autofac;
using MqttClient.Mqtt;

namespace MqttClient
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainForm>().AsSelf().SingleInstance();
            builder.RegisterType<Mqtt.Mqtt>().As<IMqtt>().SingleInstance();
            builder.RegisterType<MqttPublish>().As<IMqttPublish>();
            builder.RegisterType<ToastMessage>().As<IToastMessage>();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(mqttclient)))
            //    .Where(t => t.Namespace.Contains("HardwareSensors"))
            //    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}