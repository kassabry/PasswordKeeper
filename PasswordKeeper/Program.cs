using System;
using System.Linq;
using System.Windows.Forms;

namespace PasswordKeeper
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
            Application.Run(new RadForm1());
            Application.Run(new CurrentPasswordForm());
            Application.Run(new AddPasswordForm());
            Application.Run(new RemovePasswordForm());
            Application.Run(new CheckStrengthForm());
        }
    }
}