using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Encription_Creator
{
    public partial class frmPrincipal : Form
    {
        Cripts Cript;
        #region Interface
        public bool visibletext = true;
        public string user1;
        public frmPrincipal(string user)
        {
            InitializeComponent();
            user1 = user;
        }
        string Titulo = "Encryption's Builder Studio";
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = lblUsuario.Text + " " + user1;
            this.Text = Titulo;
            int CharText = txtPrincipal.Text.Length;
            lblCharacterText.Text = "N° de caracteres da tela de texto: " + Convert.ToString(CharText);
            int CharRascunho = txtRascunho.Text.Length;
            lblCharacterRascunho.Text = "N° de caracteres do Rascunho: " + Convert.ToString(CharRascunho);
            cboCodefication.SelectedIndex = 0;
            cboCodeCript.SelectedIndex = 3;
            cboCriptografia.SelectedIndex = 0;
            cboCodeHash.SelectedIndex = 3;
            cboHashs.SelectedIndex = 0;
            cboCodKey.SelectedIndex = 3;
            cboCodIV.SelectedIndex = 3;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SFDsave.ShowDialog();
        }
        private void SFDsave_FileOk(object sender, CancelEventArgs e)
        {
            Cript = new Cripts();
            string file = SFDsave.FileName;
            Cript.Salvar(txtPrincipal.Text, file);
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OFDopen.ShowDialog();
        }
        private void OFDopen_FileOk(object sender, CancelEventArgs e)
        {
            Cript = new Cripts();
            string file = OFDopen.FileName;
            txtPrincipal.Text = Cript.Abrir(file);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrincipal.Clear();
            txtRascunho.Clear();
            MessageBox.Show("Componentes de texto limpos!", Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkRascunho_CheckedChanged(object sender, EventArgs e)
        {
            if (visibletext == false)
            {
                gbRascunho.Visible = true;
                visibletext = true;
            }
            else
            {
                gbRascunho.Visible = false;
                visibletext = false;
            }
        }
        int index = 0;
        private void txtPrincipal_TextChanged(object sender, EventArgs e)
        {
            int CharText = txtPrincipal.Text.Length;
            lblCharacterText.Text = "N° de caracteres da tela de texto: " + Convert.ToString(CharText);
            index = index + 1;
            //int i = 0;
            dtgHistorico.Rows.Add(index, txtPrincipal.Text);
            lblRegistryHistory.Text = "N° de Registros no Histórico: " + dtgHistorico.Rows.Count.ToString();
        }

        private void txtRascunho_TextChanged(object sender, EventArgs e)
        {
            int CharRascunho = txtRascunho.Text.Length;
            lblCharacterRascunho.Text = "N° de caracteres do Rascunho: " + Convert.ToString(CharRascunho);
        }

        private void nupRascuho_ValueChanged(object sender, EventArgs e)
        {
            int valueHeight = Convert.ToInt32(nupRascuho.Value);
            gbRascunho.Size = new Size(1904, valueHeight);
        }

        private void nupFont_ValueChanged(object sender, EventArgs e)
        {
            txtPrincipal.Font = new Font("Consolas", (float)nupFont.Value);
            txtRascunho.Font = new Font("Consolas", (float)nupFont.Value);
        }
        bool Historico = false;
        private void chkHistorico_CheckedChanged(object sender, EventArgs e)
        {
            if (Historico == true)
            {
                gbHistorico.Visible = false;
                Historico = false;
            }
            else
            {
                gbHistorico.Visible = true;
                Historico = true;
            }
        }

        private void dtgHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPrincipal.Text = dtgHistorico[1, e.RowIndex].Value.ToString();
            
                //(e.ColumnIndex, e.RowIndex, true);
        }

        private void ClearHistory_Click(object sender, EventArgs e)
        {
            dtgHistorico.Rows.Clear();
            index = 0;
            lblRegistryHistory.Text = "N° de Registros no Histórico: " + dtgHistorico.Rows.Count.ToString();
            MessageBox.Show("Histórico limpo com sucesso!", Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nupHistory_ValueChanged(object sender, EventArgs e)
        {
            int valueWidth = Convert.ToInt32(nupHistory.Value);
            gbHistorico.Size = new Size(valueWidth, 838);
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text == txtRascunho.Text)
            {
                MessageBox.Show("Conteúdos da tela de texto e rascunho idênticos!", Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Conteúdos da tela de texto e rascunho diferentes!", Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearTextWindow_Click(object sender, EventArgs e)
        {
            txtPrincipal.Clear();
            MessageBox.Show("Tela de texto limpa!", Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = txtRascunho.Text;
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            txtRascunho.Text += txtPrincipal.Text;
            txtPrincipal.Clear();
        }

        private void btnClearRascunho_Click(object sender, EventArgs e)
        {
            txtRascunho.Clear();
            MessageBox.Show("Tela de rascunho limpa!", Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Codificação
        public string TextPrincipal
        {
            get { return txtPrincipal.Text; }
            set { txtPrincipal.Text = value; }
        }
        public string TextForm
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        private void cboCodefication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCodefication.Text == "Código Morse")
            {
                nupMultiCodefication.Value = 1;
                nupMultiCodefication.Enabled = false;
            }
            else
            {
                nupMultiCodefication.Enabled = true;
            }
        }
        private void btnCodificar_Click(object sender, EventArgs e)
        {
            int multiCript = Convert.ToInt32(nupMultiCodefication.Value);
            frmSplashs Splash = new frmSplashs(this, true, cboCodefication.Text, 0, multiCript, txtPrincipal.Text, "", txtKey.Text, txtIV.Text, "", "");
            Thread.Sleep(100);
            Splash.ShowDialog();
        }
        
        private void btnDecodificar_Click(object sender, EventArgs e)
        {
            int multiCript = Convert.ToInt32(nupMultiCodefication.Value);
            frmSplashs Splash = new frmSplashs(this, false, cboCodefication.Text, 0, multiCript, txtPrincipal.Text, "", txtKey.Text, txtIV.Text, "", "");
            Thread.Sleep(100);
            Splash.ShowDialog();
        }

        #endregion
        #region Criptografia
        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            frmSplashs Splash = new frmSplashs(this, true, cboCriptografia.Text, 0, Convert.ToInt32(nupCriptMulti.Value), txtPrincipal.Text, cboCodeCript.Text, txtKey.Text, txtIV.Text, cboCodKey.Text, cboCodIV.Text);
            Splash.ShowDialog();
        }
        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            frmSplashs Splash = new frmSplashs(this, false, cboCriptografia.Text, 0, Convert.ToInt32(nupCriptMulti.Value), txtPrincipal.Text, cboCodeCript.Text, txtKey.Text, txtIV.Text, cboCodKey.Text, cboCodIV.Text);
            Splash.ShowDialog();
        }
        #endregion
        #region Hasheamento
        private void btnHashear_Click(object sender, EventArgs e)
        {
            frmSplashs Splash = new frmSplashs(this, true, cboHashs.Text, 0, Convert.ToInt32(nupMultiHash.Value), txtPrincipal.Text, cboCodeHash.Text, txtKey.Text, txtIV.Text, "", "");
            Splash.ShowDialog();
        }
        #endregion
    }
}
