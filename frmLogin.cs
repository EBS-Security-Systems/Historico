using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encription_Creator
{
    public partial class frmLogin : Form
    {
        Hashs Hash = new Hashs();
        public bool LoginSuceful = false;
        public string user;
        public frmLogin()
        {
            InitializeComponent();
        }
        string titulo = "Encryption's Builder Studio";
        Point DragForm;
        Point DragCursor;
        bool Dragging;
        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void barraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void barraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string User1 = "DC7EEA5A34FCFB6E14B92CFC365E97AF937A3A427886C6DCDCBDA5C73F263A31414275BF4F60A3E0C5FF7FB8F678177CECB4BB6B5FD3C09A7196513081D2BB1B",
                PassWord1 = "A6B91B3A0E2BC5464425575EBF40D98E5A24DFE325050000A54D6FF49CA11969112FA13F68B290FAAF4EE753DCE67B06578247DC40DF3F93516AC73E6C2E0681",
                User2 = "8FBCDAAD878D8AF072F17C876B140CCE0C9797ADD72C17EA34AD229654187A715B2281C07AEE2CA0D2FADCED2E9D3343C12922EAE377E421705F11AB247DDBA2",
                PassWord2 = "A6B91B3A0E2BC5464425575EBF40D98E5A24DFE325050000A54D6FF49CA11969112FA13F68B290FAAF4EE753DCE67B06578247DC40DF3F93516AC73E6C2E0681";
            user = txtUser.Text;
            string UserCript = Hash.sha512encrypt(txtUser.Text, "UTF-32");
            string PassWordCript = Hash.sha512encrypt(txtPassword.Text, "UTF-32");
            if (UserCript == User1 && PassWordCript == PassWord1)
            {
                LoginSuceful = true;
                MessageBox.Show("Olá " + txtUser.Text + "! Seja bem vindo!", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                if (UserCript == User2 && PassWordCript == PassWord2)
            {
                LoginSuceful = true;
                MessageBox.Show("Olá " + txtUser.Text + "! Seja bem vindo!", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!\nEncerrando o programa por tentativa de invasão!", titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {/*
            txtUser.Text = "Thiago";
            txtPassword.Text = "123456789";*/
        }

        private void lblTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }
    }
}
