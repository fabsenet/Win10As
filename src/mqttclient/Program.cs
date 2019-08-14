using Autofac;
using System;
using System.Threading;
using System.Windows.Forms;


namespace MqttClient
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var form1 = scope.Resolve<MainForm>();
                Application.ThreadException += new ThreadExceptionEventHandler(form1.UnhandledThreadExceptionHandler);
                Application.Run(form1);
            }
        }
    }
}