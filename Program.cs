using Project_Z.Splash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Z
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new splash() { Text = Application.ProductName });
            //Application.Run(new View() { Text = Application.ProductName });
            //Application.Run(new faceIDReg() { Text = Application.ProductName });
            //Application.Run(new faceIDAuth() { Text = Application.ProductName });
        }

    }
}
