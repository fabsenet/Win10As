using WinMqtt.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace WinMqtt
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new MainForm();
            Application.ThreadException += new ThreadExceptionEventHandler(form.UnhandledThreadExceptionHandler);
            Application.Run(form);
        }
    }
}