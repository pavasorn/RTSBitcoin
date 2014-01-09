using System;
using System.Windows.Forms;

namespace RTSBitcoinProject
{
    internal static class Program
    {
        /// The main entry point for the application.
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new LoginPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}