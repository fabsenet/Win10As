namespace MqttClient.Mqtt
{
    public interface IMqttPublish
    {
        void SendDiscoveryInfo();
        void SendWorkerUpdates();
    }
}