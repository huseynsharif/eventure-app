using EventureApp.Models;
using EventureApp.UI;

namespace EventureApp
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
            MyDbContext dbContext = new MyDbContext();
            LoginPage loginPage = new LoginPage(dbContext);
            if (loginPage.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new HomePage(dbContext));
            }
        }
    }
}