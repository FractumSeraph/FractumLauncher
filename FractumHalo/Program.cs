using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Windows.Forms;

namespace FractumHalo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppCenter.Start("08c73938-4f15-45cb-adf5-4fd6ea173349",
                   typeof(Analytics), typeof(Crashes));

            Application.Run(new Fractum());
        }
    }
}
