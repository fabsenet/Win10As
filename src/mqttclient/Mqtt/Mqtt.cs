using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;
using MqttClient.HardwareSensors;
using Newtonsoft.Json;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using Win10SensorLibrary.HardwareSensors;

namespace MqttClient.Mqtt
{
    public class Mqtt : IMqtt
    {
        private readonly IToastMessage _toastMessage;

        private uPLibrary.Networking.M2Mqtt.MqttClient _client;
        public string GMqtttopic { get; set; }
        public bool IsConnected
        {
            get
            {
                if (_client == null)
                    return false;
                return _client.IsConnected;
            }
        }

        public Mqtt(IToastMessage toastMessage)
        {
            _toastMessage = toastMessage;
        }

        public void PublishImage(string topic, string file)
        {
            if (File.Exists(file))
            {
                if (_client.IsConnected)
                {
                    _client.Publish(topic, File.ReadAllBytes(file));
                    Log.Add("image published:" + topic);
                }
            }
        }
        public void PublishByte(string topic, byte[] bytes)
        {
            if (_client.IsConnected)
            {
                _client.Publish(topic, bytes);
                Log.Add("bytes published:" + topic);
            }
        }
        public void Publish(string topic, string message, bool retain = false)
        {
            if (_client.IsConnected)
            {
                _client.Publish(topic, Encoding.UTF8.GetBytes(message), 0, retain);
                Log.Add("message published:" + topic + " value " + message);
            }
        }
        public bool Connect(string hostname, int portNumber, string username, string password)
        {
            try
            {
                if (hostname + "" != "")
                {
                    try
                    {

                        _client = new uPLibrary.Networking.M2Mqtt.MqttClient(hostname, portNumber, false, null, null, MqttSslProtocols.None, null);

                        if (username + "" == "")
                            _client.Connect(Guid.NewGuid().ToString());
                        else
                            _client.Connect(Guid.NewGuid().ToString(), username, password);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"not connected, check connection settings error: {ex.Message}");
                    }

                    try
                    {

                        if (_client.IsConnected)
                        {

                            _client.MqttMsgPublishReceived += ClientMqttMsgPublishReceived;
                            _client.MqttMsgSubscribed += ClientMqttMsgSubscribed;
                            _client.MqttMsgPublished += ClientMqttMsgPublished;
                            _client.ConnectionClosed += ClientMqttConnectionClosed;

                            Log.Add("connected");

                            GMqtttopic = Utils.Settings["mqtttopic"].ToString() + "/#";

                            var r = new List<string>
                            {
                                GMqtttopic
                            };
                            _client.Subscribe(r.ToArray(), new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

                            return true;
                        }
                    }

                    catch
                    {
                        throw;
                    }
                }
                else
                {
                    //throw new Exception("not connected, check settings mqttservername not entered");
                }
            }

            catch (Exception ex)
            {
                throw new Exception("not connected,check settings. Error: {ex.InnerException.ToString()}");
            }
            return false;
        }

        public void Disconnect()
        {
            if (_client != null)
            {
                if (IsConnected)
                {
                    _client.Disconnect();
                }
            }
        }
        private void ClientMqttMsgPublished(object sender, MqttMsgPublishedEventArgs e)
        {
            try
            {
                Log.Add("MessageId = " + e.MessageId + " Published = " + e.IsPublished);
            }
            catch (Exception ex)
            {
                Log.Add("error: " + ex.Message);
            }
            catch
            {
                throw;
            }

        }
        private void ClientMqttConnectionClosed(object sender, System.EventArgs e)
        {
            try
            {
                Log.Add("Mqtt Connection closed");
            }
            catch (Exception ex)
            {
                Log.Add("error: " + ex.Message);
            }

        }
        private void ClientMqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            try
            {
                Log.Add($"Subscribed for id = {e.MessageId}");
            }
            catch (Exception ex)
            {
                Log.Add($"error: {ex.Message}");
            }

        }
        private void ClientMqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            try
            {
                string message = Encoding.UTF8.GetString(e.Message);
                Log.Add("Message recived " + e.Topic + " value " + message);

                string TopLevel = GMqtttopic.Replace("/#", "");
                string subtopic = e.Topic.Replace(TopLevel + "/", "");

                MessageReceived(subtopic, message);

            }
            catch (Exception ex)
            {
                Log.Add("error: " + ex.Message);
            }

        }
        private void MessageReceived(string subtopic, string message)
        {
            try
            {
                switch (subtopic)
                {
                    case "app/running":

                        var isRunning = JsonConvert.DeserializeObject<Win10MqttLibrary.Models.IsRunning>(message);

                        switch (isRunning.Action)
                        {

                            case "1":
                                Publish($"app/running/{isRunning.ApplicationName}", Process.IsRunning(message, ""));
                                break;
                            case "0":
                                //close the app
                                Process.Close(isRunning.ApplicationName);
                                Publish($"app/running/{isRunning.ApplicationName}", "0");
                                break;
                            default:
                                Publish($"app/running/{isRunning.ApplicationName}", Process.IsRunning(message, ""));
                                break;

                        }
                        break;

                    case "app/close":
                        Publish($"app/running/{message}", Process.Close(message));
                        break;

                    case "monitor/set":
                        if (message == "1" || message == "on")
                        {
                            Monitor.TurnOn();
                            Publish("monitor", "1");
                        }
                        else if (message == "0" || message == "off")
                        {
                            Monitor.TurnOff();
                            Publish("monitor", "0");
                        }
                        break;

                    case "mute/set":
                        if (message == "1" || message == "on")
                        {
                            Audio.Mute(true);
                        }
                        else if (message == "0" || message == "off")
                        {
                            Audio.Mute(false);
                        }
                        Publish("mute", message);
                        break;

                    case "volume/set":
                        Audio.Volume(Convert.ToInt32(message, CultureInfo.CurrentCulture));
                        break;

                    case "hibernate":
                        Application.SetSuspendState(PowerState.Hibernate, true, true);
                        break;

                    case "suspend":
                        Application.SetSuspendState(PowerState.Suspend, true, true);
                        break;

                    case "reboot":
                        System.Diagnostics.Process.Start("shutdown.exe", $"-r -t {GetDelay(message)}");
                        break;

                    case "shutdown":
                        System.Diagnostics.Process.Start("shutdown.exe", $"-s -t {GetDelay(message)}");
                        break;

                    case "tts":
                        SpeechSynthesizer synthesizer = new SpeechSynthesizer
                        {
                            Volume = 100
                        };
                        synthesizer.SpeakAsync(message);
                        break;

                    case "toast":
                        string[] words = message.Split(',');
                        if (words.Length >= 3)
                        {
                            string imageUrl = words[words.Length - 1];
                            _toastMessage.ShowImage(words, imageUrl);
                        }
                        else
                        {
                            _toastMessage.ShowText(words);
                        }
                        break;

                    case "cmd":

                        ProcessWindowStyle processWindowStyle = new ProcessWindowStyle();

                        var commandParameters = JsonConvert.DeserializeObject<Win10MqttLibrary.Models.CommandParameters>(message);

                        switch (Convert.ToInt16(commandParameters.WindowStyle))
                        {
                            case 0:
                                processWindowStyle = ProcessWindowStyle.Normal;
                                break;
                            case 1:
                                processWindowStyle = ProcessWindowStyle.Hidden;
                                break;
                            case 2:
                                processWindowStyle = ProcessWindowStyle.Minimized;
                                break;
                            case 3:
                                processWindowStyle = ProcessWindowStyle.Maximized;
                                break;
                            default:
                                processWindowStyle = ProcessWindowStyle.Normal;
                                break;
                        }


                        ProcessStartInfo startInfo = new ProcessStartInfo(commandParameters.CommandString, commandParameters.ExecParameters)
                        {
                            WindowStyle = processWindowStyle

                        };

                        System.Diagnostics.Process.Start(startInfo);

                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static int GetDelay(string message)
        {
            var result = int.TryParse(message, out var delay);
            return result ? delay : 10;
        }
    }
}