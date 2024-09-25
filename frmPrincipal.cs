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
    public partial class frmPrincipal : Form
    {
        ASCII ASCII;
        HashMD5 HMD5;
        public frmPrincipal()
        {
            InitializeComponent();
            this.Text = Titulo;
        }
        private void ComingSoon()
        {
            MessageBox.Show("Em breve novas atualizações!", Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #region ASCII
        string Titulo = "Encryption Master - versão: 2.0";
        private void nupFontASCII_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Text = Titulo + " (Aumentando Fonte)";
                float tamanhofonte = (Convert.ToInt32(nupFontASCII.Value));
                this.txtIntASCII.Font = new Font("Consolas", tamanhofonte, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                this.txtExitASCII.Font = new Font("Consolas", tamanhofonte, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                this.Text = Titulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnLimparASCII_Click(object sender, EventArgs e)
        {
            this.Text = Titulo + " (Limpando)";
            txtIntASCII.Clear();
            txtExitASCII.Clear();
            this.Text = Titulo;
        }

        private void btnCriptASCII_Click(object sender, EventArgs e)
        {
            if (txtIntASCII.Text == "")
            {
                MessageBox.Show("Campo 'Entrada' vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Text = Titulo + " (Criptografando)";
                try
                {
                    ASCII = new ASCII();
                    string textoCript = ASCII.Criptografar(txtIntASCII.Text);
                    txtExitASCII.Text = textoCript;
                }
                catch (Exception ex)
                {
                    this.Text = Titulo;
                    MessageBox.Show(ex.Message, "Erro ao tentar criptografar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Text = Titulo;
            }           
        }

        private void btnDescriptASCII_Click(object sender, EventArgs e)
        {
            if (txtIntASCII.Text == "")
            {
                MessageBox.Show("Campo 'Entrada' vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Text = Titulo + " (Descriptografando)";
                try
                {
                    ASCII = new ASCII();
                    string textoCript = ASCII.Descriptografar(txtIntASCII.Text);
                    txtExitASCII.Text = textoCript;
                }
                catch (Exception ex)
                {
                    this.Text = Titulo;
                    MessageBox.Show(ex.Message + "\n\nTalvez você colocou texto comum no campo 'Entrada'.", "Erro ao tentar descriptografar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Text = Titulo;
            }
        }

        private void btnMultiCriptASCII_Click(object sender, EventArgs e)
        {
            frmMultiCriptASCII MultiCriptASCII = new frmMultiCriptASCII();
            MultiCriptASCII.ShowDialog();
        }
        #endregion
        #region HashMD5
        private void nupFontMD5_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Text = Titulo + " (Aumentando Fonte)";
                float tamanhofonte = (Convert.ToInt32(nupFontMD5.Value));
                this.txtIntHMD5.Font = new Font("Consolas", tamanhofonte, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                this.txtExitHMD5.Font = new Font("Consolas", tamanhofonte, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                this.Text = Titulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparHMD5_Click(object sender, EventArgs e)
        {
            txtIntHMD5.Clear();
            txtExitHMD5.Clear();
        }

        private void btnDescriptMD5_Click(object sender, EventArgs e)
        {
            ComingSoon();
        }


        private void btnCriptMD5_Click(object sender, EventArgs e)
        {
            if (txtIntHMD5.Text == "")
            {
                this.Text = Titulo + " (Criptografando)";
                try
                {
                    HMD5 = new HashMD5();
                    txtExitHMD5.Text = HMD5.Criptografar(txtIntHMD5.Text);
                }
                catch (Exception ex)
                {
                    this.Text = Titulo;
                    MessageBox.Show(ex.Message, "Erro ao criptografar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Text = Titulo;
            }
            else
            {
                this.Text = Titulo + " (Criptografando)";
                try
                {
                    HMD5 = new HashMD5();
                    txtExitHMD5.Text = HMD5.Criptografar(txtIntHMD5.Text);
                }
                catch (Exception ex)
                {
                    this.Text = Titulo;
                    MessageBox.Show(ex.Message, "Erro ao tentar criptografar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Text = Titulo;
            }
        }

        private void btnMultiCriptMD5_Click(object sender, EventArgs e)
        {
            frmMultiEncodHashMD5 HMD5 = new frmMultiEncodHashMD5();
            HMD5.ShowDialog();
        }

        #endregion
    }
}
