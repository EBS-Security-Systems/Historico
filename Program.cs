using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encription_Master_v3._0
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
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK && login.user == "Thiago Sousa" && login.pass == "25F9E794323B453885F5181F1B624D0B")
            {
                Application.Run(new frmPrincipal());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
