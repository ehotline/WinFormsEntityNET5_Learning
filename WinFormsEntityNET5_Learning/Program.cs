using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WinFormsEntityNET5_Learning
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(ServiceProvider.GetService<PatientsForm>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            var host = Host.CreateDefaultBuilder();
            
            return host;
        }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<PatientsForm>();
            
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
