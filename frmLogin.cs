using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encription_Master_v3._0
{
    public partial class frmLogin : Form
    {
        Hashs Cript;
        public frmLogin()
        {
            InitializeComponent();
        }
        public string user, pass;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*txtUser.Text = "Thiago Sousa";
            txtPassword.Text = "123456789";*/
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senhaCript = "25F9E794323B453885F5181F1B624D0B";
            string usuario = txtUser.Text, senha = txtPassword.Text;
            Cript = new Hashs();
            user = usuario;
            pass = senhaCript;
            string senhaEncripted = Cript.CriptografarMD5(senha);
            if (senhaEncripted == senhaCript && usuario == "Thiago Sousa")
            {
                MessageBox.Show("Olá " + usuario + "! Seja bem vindo!", "Encription Master v3.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!\nEncerrando o programa por tentativa de invasão!", "Encription Master v3.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
