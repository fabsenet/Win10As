using System;
using System.Windows.Forms;

namespace mqttclient
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            try
            {
                var mainForm = Utils.MainForm;
                mainForm.Invoke((MethodInvoker)(() => mainForm.lbLogs.Items.Insert(0, message)));
                if (mainForm.lbLogs.Items.Count > 20)
                    mainForm.Invoke((MethodInvoker)(() => mainForm.lbLogs.Items.RemoveAt(20)));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
