using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DotLiquid.test();

            var builder = new ContainerBuilder();
            builder.RegisterType<Form1>();
            builder.RegisterType<FileLogger>().As<ILogger>();
            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var scope = container.BeginLifetimeScope())
            {
                Application.Run(scope.Resolve<Form1>());
            }
        }
    }
}
