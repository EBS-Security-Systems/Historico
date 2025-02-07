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
    public partial class frmPrincipal : Form
    {
        Cripts Cript;
        //Hashs Hash;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #region Propriedades gerais do programa
        string Titulo = "Encription Master v3.0";
        double vez;
        #endregion
        #region Página Inicial
        private void chkRascunho_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRascunho.Checked == true)
            {
                txtRascunho.Visible = true;
            }
            else
            {
                txtRascunho.Visible = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Text = Titulo + " (Aumentando Fonte)";
                float tamanhofonte = (Convert.ToInt32(nupFont.Value));
                this.txtPrincipal.Font = new Font("Consolas", tamanhofonte, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                this.txtRascunho.Font = new Font("Consolas", tamanhofonte, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                this.Text = Titulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Titulo + " - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja limpar a tela de texto?", Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtPrincipal.Clear();
            }
            
            if (MessageBox.Show("Deseja limpar o rascunho?", Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtRascunho.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtRascunho.Text = (txtPrincipal.Text);
            txtRascunho.Visible = true;
            chkRascunho.Checked = true;
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = (txtRascunho.Text);
            txtRascunho.Visible = true;
            chkRascunho.Checked = true;
        }
        #endregion
        #region Criptografias
        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            int multiCript = Convert.ToInt32(nupCriptValue.Value);
            if (txtPrincipal.Text == "")
            {
                MessageBox.Show("Campo de entrada de texto vazio!", Titulo + " - Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                if (multiCript > 20 && MessageBox.Show("É recomendado colocar valores menores que 20 para criptografar, mas você colocou " + multiCript + "! \nDeseja continuar?", Titulo + " - Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {

            }
            else
            {
                if (rbASCII.Checked == true)
                {
                    try
                    {
                        this.Text = Titulo + " (Criptografando)";
                        Cript = new Cripts();
                        for (int i = 0; i < multiCript; i++)
                        {
                            txtPrincipal.Text = Cript.CriptASCII(txtPrincipal.Text);
                        }
                        this.Text = Titulo;
                    }
                    catch (Exception ex)
                    {
                        this.Text = Titulo;
                        MessageBox.Show(ex.Message, Titulo + " - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    if (rbAES.Checked == true)
                {
                    MessageBox.Show("Ainda não temos esta criptografia!", Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        private void btnDescript_Click(object sender, EventArgs e)
        {
            int multiCript = Convert.ToInt32(nupCriptValue.Value);
            if (txtPrincipal.Text == "")
            {
                MessageBox.Show("Campo de entrada de texto vazio!", Titulo + " - Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rbASCII.Checked == true)
                {
                    try
                    {
                        vez = 0;
                        this.Text = Titulo + " (Descriptografando)";
                        Cript = new Cripts();
                        for (int i = 0; i < multiCript; i++)
                        {
                            vez = vez + 1;
                            txtPrincipal.Text = Cript.DescriptASCII(txtPrincipal.Text);
                        }
                        this.Text = Titulo;
                    }
                    catch (Exception ex)
                    {
                        this.Text = Titulo;
                        MessageBox.Show(ex.Message + "\nImpossível decifrar!", Titulo + " - Erro na tentativa nº " + vez + "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    if (rbAES.Checked == true)
                {
                    MessageBox.Show("Ainda não temos esta criptografia!", Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion
    }
}
