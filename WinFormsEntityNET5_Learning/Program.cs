using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinFormsEntityNET5_Learning.Models;
using WinFormsEntityNET5_Learning.Views;

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
            Application.Run(ServiceProvider.GetService<PatientsBrowser>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<PatientsBrowser>();
            services.AddScoped<PatientForm>();
            //services.AddScoped<Func<PatientForm, int>>((provider) =>
            //{
            //    return new Func<PatientForm, int>(
            //        (patientId) => new PatientForm(patientId)
            //    );
            //});

            services.AddScoped<DataContext>();
            
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
