using DAO;
using System;
using System.Windows.Forms;

namespace DuzgunUygulama
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static bool loginSuccess = false;
        [STAThread]
        static void Main()
         {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new RenkTablosuEkle());
            Application.Run(new Login());
            if (Parameters.ConnectionActive)
                Application.Run(new Anasayfa());
            Application.Exit();

        }
    }
}
