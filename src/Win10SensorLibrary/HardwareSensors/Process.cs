using System;
using System.Linq;

namespace WinMqtt
{
    public static class _Process
    {
        public static string IsRunning(string exename, string location)
        {
            try
            {
                bool isRunning = System.Diagnostics.Process.GetProcessesByName(exename)
                    .FirstOrDefault(p => p.MainModule.FileName.StartsWith(location)) != default(System.Diagnostics.Process);

                return isRunning ? "1" : "0";
            }
            catch (Exception)
            {
                return "0";
            }
        }

        public static string Close(string exename)
        {
            try
            {
                foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName(exename))
                {
                    proc.Kill();
                }
                return "1";
            }
            catch
            {
                return "0";
            }
        }
    }
}