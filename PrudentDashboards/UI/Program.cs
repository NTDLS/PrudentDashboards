using System.Data;

namespace UI
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
            //Application.Run(new FormMain());

            var chart = Library.Models.ChartModelCollection.Load().First();
            using (var formChart = new FormChart(chart))
            {
                formChart.ShowDialog();
            }
        }
    }
}