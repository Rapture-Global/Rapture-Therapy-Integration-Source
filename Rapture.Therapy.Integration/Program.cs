using Microsoft.Extensions.Configuration;
using Rapture.Therapy.Integration.Configuration;

namespace Rapture.Therapy.Integration
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Get values from the config given their key and their target type.
            RaptureTherapyIntegrationSettings appSettings = config.GetSection(RaptureTherapyIntegrationSettings.SectionName).Get<RaptureTherapyIntegrationSettings>();

            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(appSettings));
        }
    }
}