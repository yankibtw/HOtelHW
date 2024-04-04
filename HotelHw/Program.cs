using Serilog;
using System;
using System.Windows.Forms;

namespace HotelHw
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File("../../Logs/logs.txt")
            .CreateLogger();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HotelForm());
        }
    }
}
