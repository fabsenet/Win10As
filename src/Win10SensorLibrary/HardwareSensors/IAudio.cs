using System.Collections.Generic;

namespace mqttclient.HardwareSensors
{
    public interface IAudio
    {
        double GetVolume();
        bool IsMuted();
        void Mute(bool Enable);
        void Volume(int level);
        void ChangeOutputDevice(string DeviceFullname);
    }
}