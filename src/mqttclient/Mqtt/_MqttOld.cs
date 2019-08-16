using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMqtt.Mqtt
{
    class Mqtt
    {
        private static void MessageReceived(string subtopic, string message)
        {
            // Remains only to finish porting
            return;
            switch (subtopic)
            {
                case "app/running":

                    var isRunning = JsonConvert.DeserializeObject<Win10MqttLibrary.Models.IsRunning>(message);

                    switch (isRunning.Action)
                    {

                        case "0":
                            //close the app
                            Process.Close(isRunning.ApplicationName);
                            Publish($"app/running/{isRunning.ApplicationName}", "0");
                            break;
                        case "1":
                        default:
                            Publish($"app/running/{isRunning.ApplicationName}", Process.IsRunning(message, ""));
                            break;

                    }
                    break;

                case "app/close":
                    Publish($"app/running/{message}", Process.Close(message));
                    break;

                case "monitor/set":
                    switch (message)
                    {
                        case "1":
                        case "on":
                            Monitor.TurnOn();
                            Publish("monitor", "1");
                            break;
                        case "0":
                        case "off":
                            Monitor.TurnOff();
                            Publish("monitor", "0");
                            break;
                    }
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
                        ToastMessage.ShowImage(words, imageUrl);
                    }
                    else
                        ToastMessage.ShowText(words);
                    break;

                case "cmd":
                    var commandParameters = JsonConvert.DeserializeObject<Win10MqttLibrary.Models.CommandParameters>(message);

                    ProcessWindowStyle processWindowStyle;
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
        private static int GetDelay(string message)
        {
            var result = int.TryParse(message, out var delay);
            return result ? delay : 10;
        }
    }
}
