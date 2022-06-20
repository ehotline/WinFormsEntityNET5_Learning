using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinFormsEntityNET5_Learning.Models;
using WinFormsEntityNET5_Learning.Services;
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
            var configurationBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration configuration = configurationBuilder.Build();

            var services = new ServiceCollection();

            services.AddSingleton(configuration);
            services.AddDbContextFactory<DataContext>(options =>
                        options.UseNpgsql(configuration["ConnectionStrings:PSQL"])
                        );
            services.AddScoped<IPatientRepo, PatientRepo>();
            services.AddScoped<PatientsBrowser>();
            services.AddScoped<PatientForm>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
