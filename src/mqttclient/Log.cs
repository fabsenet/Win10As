using System;
using System.Windows.Forms;

namespace WinMqtt
{
    public static class Log
    {
        public static void Add(string message)
        {
            var mainForm = Utils.MainForm;

            mainForm.Invoke((MethodInvoker)(() =>
            {
                mainForm.lbLogs.Items.Insert(0, $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {message}");
                if (mainForm.lbLogs.Items.Count > 100)
                    mainForm.lbLogs.Items.RemoveAt(100);
            }));
        }
    }
}
