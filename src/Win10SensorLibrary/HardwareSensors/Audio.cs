using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Win10SensorLibrary.HardwareSensors
{
    public static class Audio
    {
        static CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

        public static void Mute(bool Enable)
        {
            defaultPlaybackDevice.Mute(Enable);
        }
        public static bool IsMuted()
        {
            return defaultPlaybackDevice.IsMuted;
        }
        public static void Volume(int level)
        {
            defaultPlaybackDevice.Volume = Convert.ToDouble(level);
        }
        public static double GetVolume()
        {
            return defaultPlaybackDevice.Volume;
        }

        static public List<string> GetAudioDevices()
        {
            CoreAudioController cac = new CoreAudioController();
            List<string> tmp = new List<string>();

            foreach (CoreAudioDevice de in cac.GetPlaybackDevices())
                tmp.Add(de.FullName);

            return tmp;

        }

        public static void ChangeOutputDevice(string DeviceFullname)
        {
            CoreAudioController cac = new CoreAudioController();
            foreach (CoreAudioDevice de in cac.GetPlaybackDevices())
            {
                if (de.FullName.ToLower(CultureInfo.CurrentCulture) == DeviceFullname.ToLower(CultureInfo.CurrentCulture))
                    defaultPlaybackDevice = de;
            }
        }
    }
}
