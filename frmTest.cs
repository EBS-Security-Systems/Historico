using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Encription_Creator
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;

        public void RsaEnc()
        {
            _privateKey = csp.ExportParameters(true);
            _publicKey = csp.ExportParameters(false);
        }

        public string PublicKeySring()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, _publicKey);
            return sw.ToString();
        }
        public string Encrypt(string plainText)
        {
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(_publicKey);

            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = csp.Encrypt(data, false);
            return Convert.ToBase64String(cypher);
        }
        public string Decrypt(string cypherText)
        {
            var dataBytes = Convert.FromBase64String(cypherText);
            csp.ImportParameters(_privateKey);
            var plaintext = csp.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(plaintext);
        }
        //https://duanbrito.net/2016/11/11/criptografia-rsa-em-c-usando-uma-chave-publica/
        private void btnCript_Click(object sender, EventArgs e)
        {
            try
            {
                RsaEnc();
                PublicKeySring();
                txtPrincipal.Text = this.Encrypt(txtPrincipal.Text);
                /*
                var rsaPublic = new RSACryptoServiceProvider();
                
                rsaPublic.FromXmlString(txtKey.Text);
                byte[] textoCript = Encoding.UTF8.GetBytes(txtPrincipal.Text);
                var encryptedRSA = rsaPublic.Encrypt(textoCript, false);
                txtPrincipal.Text = Convert.ToBase64String(encryptedRSA);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescript_Click(object sender, EventArgs e)
        {
            try
            {
                
                PublicKeySring();
                txtPrincipal.Text = this.Decrypt(txtPrincipal.Text);
                /*
                var rsaPublic = new RSACryptoServiceProvider();

                rsaPublic.FromXmlString(txtKey.Text);
                byte[] textoCript = Encoding.UTF8.GetBytes(txtPrincipal.Text);
                var descryptedRSA = rsaPublic.Decrypt(textoCript, false);
                txtPrincipal.Text = Convert.ToBase64String(descryptedRSA);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
