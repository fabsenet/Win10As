namespace MqttClient.Mqtt
{
    class MqttConfig
    {
        public string name { set; get; }
        public string device_class { set; get; }
        public string state_topic { get; set; }
        public string unit_of_measurement { get; set; }
        public string value_template { get; set; }
        public string payload () {


            return "";

        }

    }
}
