using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encription_Creator
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
            frmTest Test = new frmTest();
            Test.ShowDialog();*/
            frmLogin Login = new frmLogin();
            Login.ShowDialog();
            if (Login.LoginSuceful == true)
            {
                Application.Run(new frmPrincipal(Login.user));
            }
        }
    }
}
