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

namespace Encription_Creator
{
    public partial class frmSplashs : Form
    {//https://www.ti-enxame.com/pt/c%23/como-acessar-um-controle-de-formulario-para-outro-formulario/972094824/
        string Titulo = "Encryption's Builder Studio";
        bool Criptografando = false;
        string Criptografia, TextForCript, Cod, Key, IV, CodKey, CodIV;
        int MultiAndamento, MutiCompleto;
        Cripts Cript;
        Hashs Hash;
        public frmSplashs(bool Criptografndo, string Criptografia, int MultiAndamento, int MultiCompleto, string textForEncrypt, string Cod, string Key, string IV, string CodKey, string CodIV)
        {
            InitializeComponent();
            Criptografando = Criptografndo;
            this.Criptografia = Criptografia;
            this.MultiAndamento = MultiAndamento;
            this.MutiCompleto = MultiCompleto;
            this.TextForCript = textForEncrypt;
            this.Cod = Cod;
            this.Key = Key;
            this.IV = IV;
            this.CodKey = CodKey;
            this.CodIV = CodIV;

        }
        private frmPrincipal mainForm = null;
        public frmSplashs(Form callingform, bool Criptografndo, string Criptografia, int MultiAndamento, int MultiCompleto, string textForEncrypt, string Cod, string Key, string IV, string CodKey, string CodIV)
        {
            mainForm = callingform as frmPrincipal;
            InitializeComponent();
            Criptografando = Criptografndo;
            this.Criptografia = Criptografia;
            this.MultiAndamento = MultiAndamento;
            this.MutiCompleto = MultiCompleto;
            this.TextForCript = textForEncrypt;
            this.Cod = Cod;
            this.Key = Key;
            this.IV = IV;
            this.CodKey = CodKey;
            this.CodIV = CodIV;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            try
            {
                Cript = new Cripts();
                Hash = new Hashs();

                pbPrincipal.Maximum = MutiCompleto;

                //lblCript.Text = "Criptografia: " + Criptografia;
                //lblStatus.Text = "Estamos no múltiplo " + Convert.ToString(MultiAndamento) + " de " + Convert.ToString(MutiCompleto);
                this.Text = Titulo;
                pbPrincipal.Value = MultiAndamento;
                #region Codifição
                if (Criptografia == "ASCII" && Criptografando == true)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.CriptASCII(TextForCript);
                        mainForm.TextPrincipal = TextForCript;                        
                        this.Text = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "ANSI" && Criptografando == true)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.CriptANSI(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "UTF-7" && Criptografando == true)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.CriptUTF7(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "UTF-8" && Criptografando == true)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.CriptUTF8(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "UTF-32" && Criptografando == true)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.CriptUTF32(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "Unicode (Little Endian)" && Criptografando == true)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.CriptUnicode(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "Unicode (Big Endian)" && Criptografando == true)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.CriptUTF16(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "Código Morse" && Criptografando == true)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.EncriptMoorse(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                #endregion
                #region Decodificação
                else
                    if (Criptografia == "ASCII" && Criptografando == false)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.DescriptASCII(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Descriptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "ANSI" && Criptografando == false)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.DescriptANSI(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Descriptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "UTF-7" && Criptografando == false)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.DescriptUTF7(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Descriptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "UTF-8" && Criptografando == false)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.DescriptUTF8(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Descriptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "UTF-32" && Criptografando == false)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.DescriptUTF32(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Descriptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "Unicode (Little Endian)" && Criptografando == false)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.DescriptUnicode(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Descriptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "Unicode (Big Endian)" && Criptografando == false)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.DescriptUTF16(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Descriptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "Código Morse" && Criptografando == false)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.DescriptMoorse(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Descriptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                #endregion
                #region Criptografia
                else
                    if (Criptografia == "AES" && Criptografando == true)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.EncryptAES(TextForCript, Key, IV, Cod, CodKey, CodIV);//, Cod, "UTF-8", "UTF-8");
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "DES" && Criptografando == true)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.EncryptDES(TextForCript, Key, IV, Cod, CodKey, CodIV);//, Cod, "UTF-8", "UTF-8");
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "3DES" && Criptografando == true)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.Encrypt3DES(TextForCript, Key, IV, Cod, CodKey, CodIV);//, Cod, "UTF-8", "UTF-8");
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "RC2" && Criptografando == true)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.EncryptRC2(TextForCript, Key, IV, Cod, CodKey, CodIV);//, Cod, "UTF-8", "UTF-8");
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                #endregion
                #region Descriptografia
                else
                    if (Criptografia == "AES" && Criptografando == false)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.DecryptAES(TextForCript, Key, IV, Cod, CodKey, CodIV);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Descriptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "DES" && Criptografando == false)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.DecryptDES(TextForCript, Key, IV, Cod, CodKey, CodIV);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Descriptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "3DES" && Criptografando == false)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.Decrypt3DES(TextForCript, Key, IV, Cod, CodKey, CodIV);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Descriptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "RC2" && Criptografando == false)
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.DecryptRC2(TextForCript, Key, IV, Cod, CodKey, CodIV);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Descriptografando) (Múltiplo: " + MultiAndamento + ") (Criptografia: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                #endregion
                #region Hasheamento
                else
                    if (Criptografia == "MD5")
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Hash.CriptografarMD5(TextForCript, Cod);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Hasheando) (Múltiplo: " + MultiAndamento + ") (Hash: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "SHA-1")
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Hash.sha1encrypt(TextForCript, Cod);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Hasheando) (Múltiplo: " + MultiAndamento + ") (Hash: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "SHA-256")
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Hash.sha256encrypt(TextForCript, Cod);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Hasheando) (Múltiplo: " + MultiAndamento + ") (Hash: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "SHA-384")
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Hash.sha384encrypt(TextForCript, Cod);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Hasheando) (Múltiplo: " + MultiAndamento + ") (Hash: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;
                    Task.Delay(1000);
                    timer2.Start();
                }
                else
                    if (Criptografia == "SHA-512")
                {
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Hash.sha512encrypt(TextForCript, Cod);
                        mainForm.TextPrincipal = TextForCript;
                        this.Text = Titulo + " (Hasheando) (Múltiplo: " + MultiAndamento + ") (Hash: " + Criptografia + ")";
                        pbPrincipal.Value = MultiAndamento;
                    }
                    mainForm.TextForm = Titulo;
                    pbPrincipal.Value = MutiCompleto;

                    Task.Delay(1000);
                    timer2.Start();
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nImpossível continuar!", Titulo + " - Erro no múltiplo " + MultiAndamento, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pbPrincipal.Value = MutiCompleto;
            timer2.Stop();
            this.Close();
        }

        private void frmSplashs_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                fechar = true;
                MessageBox.Show("Interrompido no múltiplo " + Convert.ToString(MultiAndamento) + ".", Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }*/
        }

        /* pbPrincipal.Maximum = MutiCompleto;
            lblCript.Text = "Criptografia: " + Criptografia;
            if (Criptografando == false)
            {
                lblTitulo.Text = "Encryption's Builder Studio - Decifrando";
            }
            else
            {
                lblTitulo.Text = "Encryption's Builder Studio - Encriptando";
            }
            lblStatus.Text = "Estamos no múltiplo " + Convert.ToString(MultiAndamento) + " de " + Convert.ToString(MutiCompleto);
            pbPrincipal.Value = MultiAndamento;

            if (Criptografia == "ASCII" && Criptografando == true)
            {
                try
                {
                    Cript = new Cripts();
                    for (int i = 0; i < MutiCompleto; i++)
                    {
                        MultiAndamento = MultiAndamento + 1;
                        TextForCript = Cript.CriptASCII(TextForCript);
                        mainForm.TextPrincipal = TextForCript;
                        mainForm.TextForm = Titulo + " (Criptografando) (Múltiplo: " + MultiAndamento + ")";
                        lblStatus.Text = "Estamos no múltiplo " + Convert.ToString(MultiAndamento) + " de " + Convert.ToString(MutiCompleto);
                        pbPrincipal.Value = MultiAndamento;
                        if (fechar == true)
                        {
                            break;
                        }
                    }

                    mainForm.TextForm = Titulo;
                    //Thread.Sleep(1000);
                    this.Close();
                }
                catch (Exception ex)
                {
                    mainForm.TextForm = Titulo;
                    MessageBox.Show(ex.Message, Titulo + " - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    timer1.Stop();
                }*/
        
        private void frmSplashs_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }  
    }
}
