using System.Collections.Generic;
using System.Speech.Synthesis;

namespace WinMqtt.HardwareSensors
{
    public static class Speaker
    {
        public static List<string> GetSpeakers()
        {
            var result = new List<string>() ;
            var synthesizer = new SpeechSynthesizer();
            foreach (var i in synthesizer.GetInstalledVoices())
                result.Add((i.VoiceInfo.Name));

            synthesizer.Dispose();
            return result;
        }
        public static void Speak(string Text,string Device)
        {
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoice(Device);
            synthesizer.Speak(Text);
            synthesizer.Dispose();
        }
    }
}
