using System;
using System.Collections.Generic;
using System.Globalization;
using AudioSwitcher.AudioApi.CoreAudio;

namespace mqttclient.HardwareSensors
{
    public class Audio : IAudio, IDisposable
    {
        /// <summary>
        /// Creating the CoreAudioController is somehow a very intensive operation so only do it, it you have to
        /// </summary>
        Lazy<CoreAudioController> cac = new Lazy<CoreAudioController>();

        public void Mute(Boolean Enable)
        {
            try
            {
                cac.Value.DefaultPlaybackDevice.Mute(Enable);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public Boolean IsMuted()
        {
            try
            {
                return cac.Value.DefaultPlaybackDevice.IsMuted;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Volume(int level)
        {
            try
            {
                cac.Value.DefaultPlaybackDevice.Volume = Convert.ToDouble(level);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public string GetVolume()
        {
            try
            {
                return cac.Value.DefaultPlaybackDevice.Volume + "%";
            }
            catch (Exception)
            {
                throw;
            }

        }
        public List<string> GetAudioDevices()
        {
            List<string> tmp = new List<string>();

            foreach (CoreAudioDevice de in cac.Value.GetPlaybackDevices())
            {
                tmp.Add(de.FullName);
            }

            return tmp;
        }

        public void ChangeOutputDevice(string DeviceFullname)
        {
            foreach (CoreAudioDevice de in cac.Value.GetPlaybackDevices())
            {
                if (de.FullName.ToLower(CultureInfo.CurrentCulture) == DeviceFullname.ToLower(CultureInfo.CurrentCulture))
                {
                    cac.Value.DefaultPlaybackDevice = de;
                }

            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    cac.Value.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Audio()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}