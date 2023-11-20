using ABC_Bakery.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace ABC_Bakery
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new Application());
        }
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
            => services.AddDbContext<DatabaseContext>();
    }
}