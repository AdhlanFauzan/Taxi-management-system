using System;
using System.Windows.Forms;
using Taxi_management_system.Login_form;

namespace Taxi_management_system
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

            var frmLogin = new LoginForm();
            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Application.Run(MainForm.Instance);
        }
    }
}
