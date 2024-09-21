using Avalonia;
using Avalonia.Controls;
using System;
using WinFormsApplication = System.Windows.Forms.Application;

namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppBuilder.Configure<App>()
                .UseWin32()
                .UseSkia()
                .SetupWithoutStarting();

            WinFormsApplication.EnableVisualStyles();
            WinFormsApplication.SetCompatibleTextRenderingDefault(false);
            WinFormsApplication.Run(new MainForm());
        }
    }
}
