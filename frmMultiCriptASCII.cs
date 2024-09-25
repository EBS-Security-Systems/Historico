using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encript_Master_v2._0
{
    public partial class frmMultiCriptASCII : Form
    {
        ASCII ASCII;
        public frmMultiCriptASCII()
        {
            InitializeComponent();
        }

        string Titulo = "Encryption Master v2.0 Criptografia Múltipla (ASCII)";

        private void Animacao()
        {
            wmpPrincipal.Ctlcontrols.play();
        }

        private void frmMultiCriptASCII_Load(object sender, EventArgs e)
        {
            Animacao();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Text = Titulo + " (Limpando)";
            txtPrincipal.Clear();
            this.Text = Titulo;
            Animacao();
        }

        private void btnCriptASCII_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nupCriptValue.Value; i++)
            {
                try
                {
                    ASCII = new ASCII();
                    txtPrincipal.Text = ASCII.Criptografar(txtPrincipal.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro na " + i + "º tentativa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDescriptASCII_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nupCriptValue.Value; i++)
            {
                try
                {
                    ASCII = new ASCII();
                    txtPrincipal.Text = ASCII.Descriptografar(txtPrincipal.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro na " + i + "º tentativa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nupFontValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Text = Titulo + " (Aumentando Fonte)";
                float tamanhofonte = (Convert.ToInt32(nupFontValue.Value));
                this.txtPrincipal.Font = new Font("Consolas", tamanhofonte, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                this.Text = Titulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
