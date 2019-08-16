using Autofac;
using MqttClient.Forms;
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

            return builder.Build();
        }
    }
}