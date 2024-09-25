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
    public partial class frmMultiEncodHashMD5 : Form
    {
        HashMD5 HMD5;
        public frmMultiEncodHashMD5()
        {
            InitializeComponent();
        }

        private void frmMultiEncodHashMD5_Load(object sender, EventArgs e)
        {
            wmpPrincipal.Ctlcontrols.play();
        }

        private void btnCriptASCII_Click(object sender, EventArgs e)
        {
            HMD5 = new HashMD5();
            txtPrincipal.Text = HMD5.MultiEncodHashMD5(txtPrincipal.Text, Convert.ToString(nupCriptValue.Value));
        }

        private void btnDescriptASCII_Click(object sender, EventArgs e)
        {
            string Titulo = "Encryption Master  - versão: 2.0";
            MessageBox.Show("Em breve novas atualizações!", Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
