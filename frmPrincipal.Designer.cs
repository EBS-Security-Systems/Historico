
namespace Encription_Master_v3._0
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.chkRascunho = new System.Windows.Forms.CheckBox();
            this.nupFont = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tpEncripts = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.nupCriptValue = new System.Windows.Forms.NumericUpDown();
            this.btnDescript = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAES = new System.Windows.Forms.RadioButton();
            this.rbASCII = new System.Windows.Forms.RadioButton();
            this.tpHashs = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDescriptHash = new System.Windows.Forms.Button();
            this.btnCriptHash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtRascunho = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tcPrincipal.SuspendLayout();
            this.tpHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFont)).BeginInit();
            this.tpEncripts.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCriptValue)).BeginInit();
            this.tpHashs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpHome);
            this.tcPrincipal.Controls.Add(this.tpEncripts);
            this.tcPrincipal.Controls.Add(this.tpHashs);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcPrincipal.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPrincipal.ItemSize = new System.Drawing.Size(89, 27);
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(1350, 100);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.BackgroundImage = global::Encription_Master_v3._0.Properties.Resources.Fundo;
            this.tpHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpHome.Controls.Add(this.btnSave);
            this.tpHome.Controls.Add(this.btnUse);
            this.tpHome.Controls.Add(this.btnLimpar);
            this.tpHome.Controls.Add(this.chkRascunho);
            this.tpHome.Controls.Add(this.nupFont);
            this.tpHome.Controls.Add(this.label2);
            this.tpHome.Location = new System.Drawing.Point(4, 31);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(1342, 65);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Página Inicial";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(972, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 59);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Salvar no rascunho";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUse
            // 
            this.btnUse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUse.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUse.Location = new System.Drawing.Point(1122, 3);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(150, 59);
            this.btnUse.TabIndex = 7;
            this.btnUse.Text = "Ultilizar rascunho";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLimpar.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(1272, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(67, 59);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "🚮";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // chkRascunho
            // 
            this.chkRascunho.AutoSize = true;
            this.chkRascunho.Font = new System.Drawing.Font("Consolas", 16F);
            this.chkRascunho.ForeColor = System.Drawing.Color.Black;
            this.chkRascunho.Location = new System.Drawing.Point(3, 2);
            this.chkRascunho.Name = "chkRascunho";
            this.chkRascunho.Size = new System.Drawing.Size(223, 30);
            this.chkRascunho.TabIndex = 0;
            this.chkRascunho.Text = "Mostrar rascunho";
            this.chkRascunho.UseVisualStyleBackColor = true;
            this.chkRascunho.CheckedChanged += new System.EventHandler(this.chkRascunho_CheckedChanged);
            // 
            // nupFont
            // 
            this.nupFont.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupFont.Location = new System.Drawing.Point(213, 30);
            this.nupFont.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupFont.Name = "nupFont";
            this.nupFont.Size = new System.Drawing.Size(58, 32);
            this.nupFont.TabIndex = 1;
            this.nupFont.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nupFont.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tamanho da fonte:";
            // 
            // tpEncripts
            // 
            this.tpEncripts.BackgroundImage = global::Encription_Master_v3._0.Properties.Resources.Fundo;
            this.tpEncripts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpEncripts.Controls.Add(this.panel1);
            this.tpEncripts.Controls.Add(this.label3);
            this.tpEncripts.Controls.Add(this.rbAES);
            this.tpEncripts.Controls.Add(this.rbASCII);
            this.tpEncripts.Location = new System.Drawing.Point(4, 31);
            this.tpEncripts.Name = "tpEncripts";
            this.tpEncripts.Padding = new System.Windows.Forms.Padding(3);
            this.tpEncripts.Size = new System.Drawing.Size(1342, 65);
            this.tpEncripts.TabIndex = 1;
            this.tpEncripts.Text = "Criptografias";
            this.tpEncripts.ToolTipText = "Algumas cripttografias";
            this.tpEncripts.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCriptografar);
            this.panel1.Controls.Add(this.nupCriptValue);
            this.panel1.Controls.Add(this.btnDescript);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(561, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 59);
            this.panel1.TabIndex = 5;
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriptografar.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptografar.Location = new System.Drawing.Point(386, -4);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(200, 65);
            this.btnCriptografar.TabIndex = 3;
            this.btnCriptografar.Text = "🔒\r\nCriptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // nupCriptValue
            // 
            this.nupCriptValue.Location = new System.Drawing.Point(305, 29);
            this.nupCriptValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCriptValue.Name = "nupCriptValue";
            this.nupCriptValue.Size = new System.Drawing.Size(81, 31);
            this.nupCriptValue.TabIndex = 2;
            this.nupCriptValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDescript
            // 
            this.btnDescript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDescript.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescript.Location = new System.Drawing.Point(586, -4);
            this.btnDescript.Name = "btnDescript";
            this.btnDescript.Size = new System.Drawing.Size(200, 65);
            this.btnDescript.TabIndex = 4;
            this.btnDescript.Text = "🔓\r\nDescriptografar";
            this.btnDescript.UseVisualStyleBackColor = true;
            this.btnDescript.Click += new System.EventHandler(this.btnDescript_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Múltiplo de Criptografia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Criptografias";
            // 
            // rbAES
            // 
            this.rbAES.AutoSize = true;
            this.rbAES.Location = new System.Drawing.Point(97, 35);
            this.rbAES.Name = "rbAES";
            this.rbAES.Size = new System.Drawing.Size(61, 27);
            this.rbAES.TabIndex = 1;
            this.rbAES.Text = "AES";
            this.rbAES.UseVisualStyleBackColor = true;
            // 
            // rbASCII
            // 
            this.rbASCII.AutoSize = true;
            this.rbASCII.Checked = true;
            this.rbASCII.Location = new System.Drawing.Point(8, 35);
            this.rbASCII.Name = "rbASCII";
            this.rbASCII.Size = new System.Drawing.Size(83, 27);
            this.rbASCII.TabIndex = 0;
            this.rbASCII.TabStop = true;
            this.rbASCII.Text = "ASCII";
            this.rbASCII.UseVisualStyleBackColor = true;
            // 
            // tpHashs
            // 
            this.tpHashs.BackgroundImage = global::Encription_Master_v3._0.Properties.Resources.Fundo;
            this.tpHashs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpHashs.Controls.Add(this.panel2);
            this.tpHashs.Controls.Add(this.label4);
            this.tpHashs.Controls.Add(this.radioButton1);
            this.tpHashs.Controls.Add(this.radioButton2);
            this.tpHashs.Location = new System.Drawing.Point(4, 31);
            this.tpHashs.Name = "tpHashs";
            this.tpHashs.Padding = new System.Windows.Forms.Padding(3);
            this.tpHashs.Size = new System.Drawing.Size(1342, 65);
            this.tpHashs.TabIndex = 2;
            this.tpHashs.Text = "Hashs";
            this.tpHashs.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(293, 25);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(81, 31);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Múltiplo de Criptografia:";
            // 
            // btnDescriptHash
            // 
            this.btnDescriptHash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDescriptHash.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescriptHash.Location = new System.Drawing.Point(574, -8);
            this.btnDescriptHash.Name = "btnDescriptHash";
            this.btnDescriptHash.Size = new System.Drawing.Size(200, 65);
            this.btnDescriptHash.TabIndex = 7;
            this.btnDescriptHash.Text = "🔓\r\nDescriptografar";
            this.btnDescriptHash.UseVisualStyleBackColor = true;
            // 
            // btnCriptHash
            // 
            this.btnCriptHash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriptHash.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptHash.Location = new System.Drawing.Point(374, -8);
            this.btnCriptHash.Name = "btnCriptHash";
            this.btnCriptHash.Size = new System.Drawing.Size(200, 65);
            this.btnCriptHash.TabIndex = 6;
            this.btnCriptHash.Text = "🔒\r\nCriptografar";
            this.btnCriptHash.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hashs";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(75, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 27);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "MD4";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 27);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "MD5";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.BackColor = System.Drawing.Color.Black;
            this.txtPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrincipal.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipal.ForeColor = System.Drawing.Color.Green;
            this.txtPrincipal.Location = new System.Drawing.Point(0, 100);
            this.txtPrincipal.Multiline = true;
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrincipal.Size = new System.Drawing.Size(1350, 629);
            this.txtPrincipal.TabIndex = 0;
            // 
            // txtRascunho
            // 
            this.txtRascunho.BackColor = System.Drawing.Color.Black;
            this.txtRascunho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtRascunho.Font = new System.Drawing.Font("Consolas", 16F);
            this.txtRascunho.ForeColor = System.Drawing.Color.Green;
            this.txtRascunho.Location = new System.Drawing.Point(0, 309);
            this.txtRascunho.Multiline = true;
            this.txtRascunho.Name = "txtRascunho";
            this.txtRascunho.Size = new System.Drawing.Size(1350, 420);
            this.txtRascunho.TabIndex = 1;
            this.txtRascunho.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.btnCriptHash);
            this.panel2.Controls.Add(this.btnDescriptHash);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(564, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 59);
            this.panel2.TabIndex = 10;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txtRascunho);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.tcPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "frmPrincipal";
            this.Text = "Encription Master v3.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tcPrincipal.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFont)).EndInit();
            this.tpEncripts.ResumeLayout(false);
            this.tpEncripts.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCriptValue)).EndInit();
            this.tpHashs.ResumeLayout(false);
            this.tpHashs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpEncripts;
        private System.Windows.Forms.TabPage tpHashs;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.RadioButton rbASCII;
        private System.Windows.Forms.NumericUpDown nupCriptValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDescript;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.RadioButton rbAES;
        private System.Windows.Forms.TextBox txtRascunho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkRascunho;
        private System.Windows.Forms.NumericUpDown nupFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDescriptHash;
        private System.Windows.Forms.Button btnCriptHash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

