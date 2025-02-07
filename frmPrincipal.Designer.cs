
namespace Encription_Creator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.gbHome = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnClearTextWindow = new System.Windows.Forms.Button();
            this.btnClearRascunho = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nupHistory = new System.Windows.Forms.NumericUpDown();
            this.chkHistorico = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nupFont = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nupRascuho = new System.Windows.Forms.NumericUpDown();
            this.chkRascunho = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tpCriptografia = new System.Windows.Forms.TabPage();
            this.gbCriptografia = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCodeCript = new System.Windows.Forms.ComboBox();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nupCriptMulti = new System.Windows.Forms.NumericUpDown();
            this.cboCriptografia = new System.Windows.Forms.ComboBox();
            this.gbParameter = new System.Windows.Forms.GroupBox();
            this.cboCodIV = new System.Windows.Forms.ComboBox();
            this.cboCodKey = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.gbCods = new System.Windows.Forms.GroupBox();
            this.btnDecodificar = new System.Windows.Forms.Button();
            this.btnCodificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nupMultiCodefication = new System.Windows.Forms.NumericUpDown();
            this.cboCodefication = new System.Windows.Forms.ComboBox();
            this.tpHash = new System.Windows.Forms.TabPage();
            this.gbHashs = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCodeHash = new System.Windows.Forms.ComboBox();
            this.btnHashear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nupMultiHash = new System.Windows.Forms.NumericUpDown();
            this.cboHashs = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCharacterText = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCharacterRascunho = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRegistryHistory = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtRascunho = new System.Windows.Forms.TextBox();
            this.gbRascunho = new System.Windows.Forms.GroupBox();
            this.gbtextwindow = new System.Windows.Forms.GroupBox();
            this.gbHistorico = new System.Windows.Forms.GroupBox();
            this.dtgHistorico = new System.Windows.Forms.DataGridView();
            this.COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.history = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearHistory = new System.Windows.Forms.Button();
            this.OFDopen = new System.Windows.Forms.OpenFileDialog();
            this.SFDsave = new System.Windows.Forms.SaveFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tcPrincipal.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.gbHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRascuho)).BeginInit();
            this.tpCriptografia.SuspendLayout();
            this.gbCriptografia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCriptMulti)).BeginInit();
            this.gbParameter.SuspendLayout();
            this.gbCods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMultiCodefication)).BeginInit();
            this.tpHash.SuspendLayout();
            this.gbHashs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMultiHash)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.gbRascunho.SuspendLayout();
            this.gbtextwindow.SuspendLayout();
            this.gbHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpHome);
            this.tcPrincipal.Controls.Add(this.tpCriptografia);
            this.tcPrincipal.Controls.Add(this.tpHash);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcPrincipal.Font = new System.Drawing.Font("Maxter Board St", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPrincipal.ItemSize = new System.Drawing.Size(100, 26);
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.Multiline = true;
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(1904, 176);
            this.tcPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.BackColor = System.Drawing.Color.Black;
            this.tpHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpHome.Controls.Add(this.gbHome);
            this.tpHome.Location = new System.Drawing.Point(4, 30);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(1896, 142);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Página Inicial 🏠";
            // 
            // gbHome
            // 
            this.gbHome.Controls.Add(this.btnOpen);
            this.gbHome.Controls.Add(this.btnPaste);
            this.gbHome.Controls.Add(this.btnSalvar);
            this.gbHome.Controls.Add(this.btnCut);
            this.gbHome.Controls.Add(this.btnClearTextWindow);
            this.gbHome.Controls.Add(this.btnClearRascunho);
            this.gbHome.Controls.Add(this.btnComparar);
            this.gbHome.Controls.Add(this.label3);
            this.gbHome.Controls.Add(this.nupHistory);
            this.gbHome.Controls.Add(this.chkHistorico);
            this.gbHome.Controls.Add(this.label2);
            this.gbHome.Controls.Add(this.nupFont);
            this.gbHome.Controls.Add(this.label1);
            this.gbHome.Controls.Add(this.nupRascuho);
            this.gbHome.Controls.Add(this.chkRascunho);
            this.gbHome.Controls.Add(this.btnLimpar);
            this.gbHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHome.ForeColor = System.Drawing.Color.White;
            this.gbHome.Location = new System.Drawing.Point(3, 3);
            this.gbHome.Name = "gbHome";
            this.gbHome.Size = new System.Drawing.Size(1888, 134);
            this.gbHome.TabIndex = 2;
            this.gbHome.TabStop = false;
            this.gbHome.Text = "Opções da tela de Texto";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.Color.Black;
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(1632, 73);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(250, 50);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Abrir 📂";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaste.BackColor = System.Drawing.Color.Black;
            this.btnPaste.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.btnPaste.ForeColor = System.Drawing.Color.White;
            this.btnPaste.Location = new System.Drawing.Point(864, 73);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(250, 50);
            this.btnPaste.TabIndex = 6;
            this.btnPaste.Text = "Colar do rascunho ⤴";
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(1632, 18);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(250, 50);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar 💾";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCut
            // 
            this.btnCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCut.BackColor = System.Drawing.Color.Black;
            this.btnCut.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCut.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.btnCut.ForeColor = System.Drawing.Color.White;
            this.btnCut.Location = new System.Drawing.Point(864, 18);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(250, 50);
            this.btnCut.TabIndex = 5;
            this.btnCut.Text = "Mover ao rascunho ⤵";
            this.btnCut.UseVisualStyleBackColor = false;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnClearTextWindow
            // 
            this.btnClearTextWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearTextWindow.BackColor = System.Drawing.Color.Black;
            this.btnClearTextWindow.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnClearTextWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearTextWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnClearTextWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTextWindow.Font = new System.Drawing.Font("Maxter Board St", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTextWindow.ForeColor = System.Drawing.Color.White;
            this.btnClearTextWindow.Location = new System.Drawing.Point(1120, 73);
            this.btnClearTextWindow.Name = "btnClearTextWindow";
            this.btnClearTextWindow.Size = new System.Drawing.Size(250, 50);
            this.btnClearTextWindow.TabIndex = 8;
            this.btnClearTextWindow.Text = "Limpar tela de texto 🧹";
            this.btnClearTextWindow.UseVisualStyleBackColor = false;
            this.btnClearTextWindow.Click += new System.EventHandler(this.btnClearTextWindow_Click);
            // 
            // btnClearRascunho
            // 
            this.btnClearRascunho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearRascunho.BackColor = System.Drawing.Color.Black;
            this.btnClearRascunho.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnClearRascunho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearRascunho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnClearRascunho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRascunho.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.btnClearRascunho.ForeColor = System.Drawing.Color.White;
            this.btnClearRascunho.Location = new System.Drawing.Point(1376, 73);
            this.btnClearRascunho.Name = "btnClearRascunho";
            this.btnClearRascunho.Size = new System.Drawing.Size(250, 50);
            this.btnClearRascunho.TabIndex = 10;
            this.btnClearRascunho.Text = "Limpar Rascunho 🧹";
            this.btnClearRascunho.UseVisualStyleBackColor = false;
            this.btnClearRascunho.Click += new System.EventHandler(this.btnClearRascunho_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComparar.BackColor = System.Drawing.Color.Black;
            this.btnComparar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnComparar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnComparar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnComparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComparar.Font = new System.Drawing.Font("Maxter Board St", 15F);
            this.btnComparar.ForeColor = System.Drawing.Color.White;
            this.btnComparar.Location = new System.Drawing.Point(1120, 18);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(250, 50);
            this.btnComparar.TabIndex = 7;
            this.btnComparar.Text = "Comparar 🔁";
            this.btnComparar.UseVisualStyleBackColor = false;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Largura do Histórico:";
            // 
            // nupHistory
            // 
            this.nupHistory.BackColor = System.Drawing.Color.Black;
            this.nupHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupHistory.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupHistory.ForeColor = System.Drawing.Color.Green;
            this.nupHistory.Location = new System.Drawing.Point(600, 59);
            this.nupHistory.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nupHistory.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nupHistory.Name = "nupHistory";
            this.nupHistory.Size = new System.Drawing.Size(64, 27);
            this.nupHistory.TabIndex = 4;
            this.nupHistory.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nupHistory.ValueChanged += new System.EventHandler(this.nupHistory_ValueChanged);
            // 
            // chkHistorico
            // 
            this.chkHistorico.AutoSize = true;
            this.chkHistorico.Location = new System.Drawing.Point(335, 28);
            this.chkHistorico.Name = "chkHistorico";
            this.chkHistorico.Size = new System.Drawing.Size(329, 25);
            this.chkHistorico.TabIndex = 3;
            this.chkHistorico.Text = "Mostrar painel Histórico";
            this.chkHistorico.UseVisualStyleBackColor = true;
            this.chkHistorico.CheckedChanged += new System.EventHandler(this.chkHistorico_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tamanho das fontes:";
            // 
            // nupFont
            // 
            this.nupFont.BackColor = System.Drawing.Color.Black;
            this.nupFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupFont.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupFont.ForeColor = System.Drawing.Color.Green;
            this.nupFont.Location = new System.Drawing.Point(247, 95);
            this.nupFont.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupFont.Name = "nupFont";
            this.nupFont.Size = new System.Drawing.Size(64, 27);
            this.nupFont.TabIndex = 2;
            this.nupFont.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nupFont.ValueChanged += new System.EventHandler(this.nupFont_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Altura do rascunho:";
            // 
            // nupRascuho
            // 
            this.nupRascuho.BackColor = System.Drawing.Color.Black;
            this.nupRascuho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupRascuho.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupRascuho.ForeColor = System.Drawing.Color.Green;
            this.nupRascuho.Location = new System.Drawing.Point(247, 59);
            this.nupRascuho.Maximum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            this.nupRascuho.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupRascuho.Name = "nupRascuho";
            this.nupRascuho.Size = new System.Drawing.Size(64, 27);
            this.nupRascuho.TabIndex = 1;
            this.nupRascuho.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.nupRascuho.ValueChanged += new System.EventHandler(this.nupRascuho_ValueChanged);
            // 
            // chkRascunho
            // 
            this.chkRascunho.AutoSize = true;
            this.chkRascunho.Checked = true;
            this.chkRascunho.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRascunho.Location = new System.Drawing.Point(6, 28);
            this.chkRascunho.Name = "chkRascunho";
            this.chkRascunho.Size = new System.Drawing.Size(323, 25);
            this.chkRascunho.TabIndex = 0;
            this.chkRascunho.Text = "Mostrar tela de rascunho";
            this.chkRascunho.UseVisualStyleBackColor = true;
            this.chkRascunho.CheckedChanged += new System.EventHandler(this.chkRascunho_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Maxter Board St", 15F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(1376, 18);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(250, 50);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar Tudo 🚮";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tpCriptografia
            // 
            this.tpCriptografia.BackColor = System.Drawing.Color.Black;
            this.tpCriptografia.Controls.Add(this.gbCriptografia);
            this.tpCriptografia.Controls.Add(this.gbParameter);
            this.tpCriptografia.Controls.Add(this.gbCods);
            this.tpCriptografia.Location = new System.Drawing.Point(4, 30);
            this.tpCriptografia.Name = "tpCriptografia";
            this.tpCriptografia.Padding = new System.Windows.Forms.Padding(3);
            this.tpCriptografia.Size = new System.Drawing.Size(1896, 142);
            this.tpCriptografia.TabIndex = 1;
            this.tpCriptografia.Text = "Criptografia";
            // 
            // gbCriptografia
            // 
            this.gbCriptografia.Controls.Add(this.label6);
            this.gbCriptografia.Controls.Add(this.cboCodeCript);
            this.gbCriptografia.Controls.Add(this.btnDescriptografar);
            this.gbCriptografia.Controls.Add(this.btnCriptografar);
            this.gbCriptografia.Controls.Add(this.label5);
            this.gbCriptografia.Controls.Add(this.nupCriptMulti);
            this.gbCriptografia.Controls.Add(this.cboCriptografia);
            this.gbCriptografia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCriptografia.ForeColor = System.Drawing.Color.White;
            this.gbCriptografia.Location = new System.Drawing.Point(403, 3);
            this.gbCriptografia.Name = "gbCriptografia";
            this.gbCriptografia.Size = new System.Drawing.Size(823, 136);
            this.gbCriptografia.TabIndex = 11;
            this.gbCriptografia.TabStop = false;
            this.gbCriptografia.Text = "Criptografias Disponíveis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Codificação de retorno:";
            // 
            // cboCodeCript
            // 
            this.cboCodeCript.BackColor = System.Drawing.Color.Black;
            this.cboCodeCript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodeCript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCodeCript.Font = new System.Drawing.Font("Consolas", 15F);
            this.cboCodeCript.ForeColor = System.Drawing.Color.Green;
            this.cboCodeCript.FormattingEnabled = true;
            this.cboCodeCript.Items.AddRange(new object[] {
            "ASCII",
            "ANSI",
            "UTF-7",
            "UTF-8",
            "UTF-32",
            "Unicode (Little Endian)",
            "Unicode (Big Endian)"});
            this.cboCodeCript.Location = new System.Drawing.Point(424, 28);
            this.cboCodeCript.Name = "cboCodeCript";
            this.cboCodeCript.Size = new System.Drawing.Size(188, 31);
            this.cboCodeCript.TabIndex = 11;
            // 
            // btnDescriptografar
            // 
            this.btnDescriptografar.BackColor = System.Drawing.Color.Black;
            this.btnDescriptografar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDescriptografar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDescriptografar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnDescriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescriptografar.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.btnDescriptografar.ForeColor = System.Drawing.Color.White;
            this.btnDescriptografar.Location = new System.Drawing.Point(6, 79);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(400, 50);
            this.btnDescriptografar.TabIndex = 10;
            this.btnDescriptografar.Text = "Descriptografar";
            this.btnDescriptografar.UseVisualStyleBackColor = false;
            this.btnDescriptografar.Click += new System.EventHandler(this.btnDescriptografar_Click);
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.BackColor = System.Drawing.Color.Black;
            this.btnCriptografar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCriptografar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCriptografar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnCriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriptografar.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.btnCriptografar.ForeColor = System.Drawing.Color.White;
            this.btnCriptografar.Location = new System.Drawing.Point(417, 79);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(400, 50);
            this.btnCriptografar.TabIndex = 9;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = false;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Múltiplo:";
            // 
            // nupCriptMulti
            // 
            this.nupCriptMulti.BackColor = System.Drawing.Color.Black;
            this.nupCriptMulti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupCriptMulti.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCriptMulti.ForeColor = System.Drawing.Color.Green;
            this.nupCriptMulti.Location = new System.Drawing.Point(753, 32);
            this.nupCriptMulti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCriptMulti.Name = "nupCriptMulti";
            this.nupCriptMulti.Size = new System.Drawing.Size(64, 27);
            this.nupCriptMulti.TabIndex = 7;
            this.nupCriptMulti.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboCriptografia
            // 
            this.cboCriptografia.BackColor = System.Drawing.Color.Black;
            this.cboCriptografia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriptografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCriptografia.Font = new System.Drawing.Font("Consolas", 15F);
            this.cboCriptografia.ForeColor = System.Drawing.Color.Green;
            this.cboCriptografia.FormattingEnabled = true;
            this.cboCriptografia.Items.AddRange(new object[] {
            "AES",
            "DES",
            "3DES",
            "RC2"});
            this.cboCriptografia.Location = new System.Drawing.Point(6, 28);
            this.cboCriptografia.Name = "cboCriptografia";
            this.cboCriptografia.Size = new System.Drawing.Size(105, 31);
            this.cboCriptografia.TabIndex = 0;
            // 
            // gbParameter
            // 
            this.gbParameter.Controls.Add(this.label12);
            this.gbParameter.Controls.Add(this.label11);
            this.gbParameter.Controls.Add(this.cboCodIV);
            this.gbParameter.Controls.Add(this.cboCodKey);
            this.gbParameter.Controls.Add(this.label10);
            this.gbParameter.Controls.Add(this.label9);
            this.gbParameter.Controls.Add(this.txtKey);
            this.gbParameter.Controls.Add(this.txtIV);
            this.gbParameter.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbParameter.ForeColor = System.Drawing.Color.White;
            this.gbParameter.Location = new System.Drawing.Point(1226, 3);
            this.gbParameter.Name = "gbParameter";
            this.gbParameter.Size = new System.Drawing.Size(667, 136);
            this.gbParameter.TabIndex = 13;
            this.gbParameter.TabStop = false;
            this.gbParameter.Text = "Parâmetros de Criptografia (KEY e IV)";
            // 
            // cboCodIV
            // 
            this.cboCodIV.BackColor = System.Drawing.Color.Black;
            this.cboCodIV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCodIV.Font = new System.Drawing.Font("Consolas", 15F);
            this.cboCodIV.ForeColor = System.Drawing.Color.Green;
            this.cboCodIV.FormattingEnabled = true;
            this.cboCodIV.Items.AddRange(new object[] {
            "ASCII",
            "ANSI",
            "UTF-7",
            "UTF-8",
            "UTF-32",
            "Unicode (Little Endian)",
            "Unicode (Big Endian)"});
            this.cboCodIV.Location = new System.Drawing.Point(474, 82);
            this.cboCodIV.Name = "cboCodIV";
            this.cboCodIV.Size = new System.Drawing.Size(188, 31);
            this.cboCodIV.TabIndex = 15;
            // 
            // cboCodKey
            // 
            this.cboCodKey.BackColor = System.Drawing.Color.Black;
            this.cboCodKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCodKey.Font = new System.Drawing.Font("Consolas", 15F);
            this.cboCodKey.ForeColor = System.Drawing.Color.Green;
            this.cboCodKey.FormattingEnabled = true;
            this.cboCodKey.Items.AddRange(new object[] {
            "ASCII",
            "ANSI",
            "UTF-7",
            "UTF-8",
            "UTF-32",
            "Unicode (Little Endian)",
            "Unicode (Big Endian)"});
            this.cboCodKey.Location = new System.Drawing.Point(473, 29);
            this.cboCodKey.Name = "cboCodKey";
            this.cboCodKey.Size = new System.Drawing.Size(188, 31);
            this.cboCodKey.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "IV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Key:";
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.Black;
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.Font = new System.Drawing.Font("Consolas", 16F);
            this.txtKey.ForeColor = System.Drawing.Color.Green;
            this.txtKey.Location = new System.Drawing.Point(61, 27);
            this.txtKey.MaxLength = 1000;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(220, 32);
            this.txtKey.TabIndex = 2;
            this.txtKey.Text = "0000000000000000";
            // 
            // txtIV
            // 
            this.txtIV.BackColor = System.Drawing.Color.Black;
            this.txtIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIV.Font = new System.Drawing.Font("Consolas", 16F);
            this.txtIV.ForeColor = System.Drawing.Color.Green;
            this.txtIV.Location = new System.Drawing.Point(61, 81);
            this.txtIV.MaxLength = 1000;
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(220, 32);
            this.txtIV.TabIndex = 1;
            this.txtIV.Text = "0000000000000000";
            // 
            // gbCods
            // 
            this.gbCods.Controls.Add(this.btnDecodificar);
            this.gbCods.Controls.Add(this.btnCodificar);
            this.gbCods.Controls.Add(this.label4);
            this.gbCods.Controls.Add(this.nupMultiCodefication);
            this.gbCods.Controls.Add(this.cboCodefication);
            this.gbCods.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbCods.ForeColor = System.Drawing.Color.White;
            this.gbCods.Location = new System.Drawing.Point(3, 3);
            this.gbCods.Name = "gbCods";
            this.gbCods.Size = new System.Drawing.Size(400, 136);
            this.gbCods.TabIndex = 3;
            this.gbCods.TabStop = false;
            this.gbCods.Text = "Codificações padrão";
            // 
            // btnDecodificar
            // 
            this.btnDecodificar.BackColor = System.Drawing.Color.Black;
            this.btnDecodificar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDecodificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDecodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnDecodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecodificar.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.btnDecodificar.ForeColor = System.Drawing.Color.White;
            this.btnDecodificar.Location = new System.Drawing.Point(6, 79);
            this.btnDecodificar.Name = "btnDecodificar";
            this.btnDecodificar.Size = new System.Drawing.Size(190, 50);
            this.btnDecodificar.TabIndex = 10;
            this.btnDecodificar.Text = "Decodificar";
            this.btnDecodificar.UseVisualStyleBackColor = false;
            this.btnDecodificar.Click += new System.EventHandler(this.btnDecodificar_Click);
            // 
            // btnCodificar
            // 
            this.btnCodificar.BackColor = System.Drawing.Color.Black;
            this.btnCodificar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCodificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnCodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodificar.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.btnCodificar.ForeColor = System.Drawing.Color.White;
            this.btnCodificar.Location = new System.Drawing.Point(204, 79);
            this.btnCodificar.Name = "btnCodificar";
            this.btnCodificar.Size = new System.Drawing.Size(190, 50);
            this.btnCodificar.TabIndex = 9;
            this.btnCodificar.Text = "Codificar";
            this.btnCodificar.UseVisualStyleBackColor = false;
            this.btnCodificar.Click += new System.EventHandler(this.btnCodificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Múltiplo:";
            // 
            // nupMultiCodefication
            // 
            this.nupMultiCodefication.BackColor = System.Drawing.Color.Black;
            this.nupMultiCodefication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupMultiCodefication.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMultiCodefication.ForeColor = System.Drawing.Color.Green;
            this.nupMultiCodefication.Location = new System.Drawing.Point(330, 33);
            this.nupMultiCodefication.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupMultiCodefication.Name = "nupMultiCodefication";
            this.nupMultiCodefication.Size = new System.Drawing.Size(64, 27);
            this.nupMultiCodefication.TabIndex = 7;
            this.nupMultiCodefication.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboCodefication
            // 
            this.cboCodefication.BackColor = System.Drawing.Color.Black;
            this.cboCodefication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodefication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCodefication.Font = new System.Drawing.Font("Consolas", 15F);
            this.cboCodefication.ForeColor = System.Drawing.Color.Green;
            this.cboCodefication.FormattingEnabled = true;
            this.cboCodefication.Items.AddRange(new object[] {
            "ASCII",
            "ANSI",
            "UTF-7",
            "UTF-8",
            "UTF-32",
            "Unicode (Little Endian)",
            "Unicode (Big Endian)",
            "Código Morse"});
            this.cboCodefication.Location = new System.Drawing.Point(6, 28);
            this.cboCodefication.Name = "cboCodefication";
            this.cboCodefication.Size = new System.Drawing.Size(188, 31);
            this.cboCodefication.TabIndex = 0;
            this.cboCodefication.SelectedIndexChanged += new System.EventHandler(this.cboCodefication_SelectedIndexChanged);
            // 
            // tpHash
            // 
            this.tpHash.BackColor = System.Drawing.Color.Black;
            this.tpHash.Controls.Add(this.gbHashs);
            this.tpHash.Location = new System.Drawing.Point(4, 30);
            this.tpHash.Name = "tpHash";
            this.tpHash.Size = new System.Drawing.Size(1896, 142);
            this.tpHash.TabIndex = 2;
            this.tpHash.Text = "Hash";
            // 
            // gbHashs
            // 
            this.gbHashs.Controls.Add(this.label7);
            this.gbHashs.Controls.Add(this.cboCodeHash);
            this.gbHashs.Controls.Add(this.btnHashear);
            this.gbHashs.Controls.Add(this.label8);
            this.gbHashs.Controls.Add(this.nupMultiHash);
            this.gbHashs.Controls.Add(this.cboHashs);
            this.gbHashs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHashs.ForeColor = System.Drawing.Color.White;
            this.gbHashs.Location = new System.Drawing.Point(0, 0);
            this.gbHashs.Name = "gbHashs";
            this.gbHashs.Size = new System.Drawing.Size(1896, 142);
            this.gbHashs.TabIndex = 12;
            this.gbHashs.TabStop = false;
            this.gbHashs.Text = "Hashs Disponíveis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Codificação de retorno:";
            // 
            // cboCodeHash
            // 
            this.cboCodeHash.BackColor = System.Drawing.Color.Black;
            this.cboCodeHash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodeHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCodeHash.Font = new System.Drawing.Font("Consolas", 15F);
            this.cboCodeHash.ForeColor = System.Drawing.Color.Green;
            this.cboCodeHash.FormattingEnabled = true;
            this.cboCodeHash.Items.AddRange(new object[] {
            "ASCII",
            "ANSI",
            "UTF-7",
            "UTF-8",
            "UTF-32",
            "Unicode (Little Endian)",
            "Unicode (Big Endian)"});
            this.cboCodeHash.Location = new System.Drawing.Point(424, 28);
            this.cboCodeHash.Name = "cboCodeHash";
            this.cboCodeHash.Size = new System.Drawing.Size(188, 31);
            this.cboCodeHash.TabIndex = 11;
            // 
            // btnHashear
            // 
            this.btnHashear.BackColor = System.Drawing.Color.Black;
            this.btnHashear.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnHashear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHashear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnHashear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHashear.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.btnHashear.ForeColor = System.Drawing.Color.White;
            this.btnHashear.Location = new System.Drawing.Point(8, 79);
            this.btnHashear.Name = "btnHashear";
            this.btnHashear.Size = new System.Drawing.Size(809, 50);
            this.btnHashear.TabIndex = 9;
            this.btnHashear.Text = "Iniciar Hasheamento";
            this.btnHashear.UseVisualStyleBackColor = false;
            this.btnHashear.Click += new System.EventHandler(this.btnHashear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Múltiplo:";
            // 
            // nupMultiHash
            // 
            this.nupMultiHash.BackColor = System.Drawing.Color.Black;
            this.nupMultiHash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupMultiHash.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMultiHash.ForeColor = System.Drawing.Color.Green;
            this.nupMultiHash.Location = new System.Drawing.Point(753, 32);
            this.nupMultiHash.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupMultiHash.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupMultiHash.Name = "nupMultiHash";
            this.nupMultiHash.Size = new System.Drawing.Size(64, 27);
            this.nupMultiHash.TabIndex = 7;
            this.nupMultiHash.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboHashs
            // 
            this.cboHashs.BackColor = System.Drawing.Color.Black;
            this.cboHashs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHashs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHashs.Font = new System.Drawing.Font("Consolas", 15F);
            this.cboHashs.ForeColor = System.Drawing.Color.Green;
            this.cboHashs.FormattingEnabled = true;
            this.cboHashs.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "SHA-256",
            "SHA-384",
            "SHA-512"});
            this.cboHashs.Location = new System.Drawing.Point(6, 28);
            this.cboHashs.Name = "cboHashs";
            this.cboHashs.Size = new System.Drawing.Size(105, 31);
            this.cboHashs.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Black;
            this.statusStrip.Font = new System.Drawing.Font("Maxter Board St", 10F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblCharacterText,
            this.lblCharacterRascunho,
            this.lblRegistryHistory});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 1013);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(1904, 28);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblUsuario.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(172, 23);
            this.lblUsuario.Text = "Usuário em uso:";
            // 
            // lblCharacterText
            // 
            this.lblCharacterText.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblCharacterText.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblCharacterText.ForeColor = System.Drawing.Color.White;
            this.lblCharacterText.Name = "lblCharacterText";
            this.lblCharacterText.Size = new System.Drawing.Size(368, 23);
            this.lblCharacterText.Text = "n° de Caracteres da tela de texto:";
            // 
            // lblCharacterRascunho
            // 
            this.lblCharacterRascunho.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblCharacterRascunho.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblCharacterRascunho.ForeColor = System.Drawing.Color.White;
            this.lblCharacterRascunho.Name = "lblCharacterRascunho";
            this.lblCharacterRascunho.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.lblCharacterRascunho.Size = new System.Drawing.Size(320, 23);
            this.lblCharacterRascunho.Spring = true;
            this.lblCharacterRascunho.Text = "n° de Caracteres do rascunho:";
            // 
            // lblRegistryHistory
            // 
            this.lblRegistryHistory.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblRegistryHistory.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblRegistryHistory.ForeColor = System.Drawing.Color.White;
            this.lblRegistryHistory.Name = "lblRegistryHistory";
            this.lblRegistryHistory.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.lblRegistryHistory.Size = new System.Drawing.Size(338, 23);
            this.lblRegistryHistory.Spring = true;
            this.lblRegistryHistory.Text = "n° de Registros no Histórico: 0";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.BackColor = System.Drawing.Color.Black;
            this.txtPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrincipal.Font = new System.Drawing.Font("Consolas", 16F);
            this.txtPrincipal.ForeColor = System.Drawing.Color.Green;
            this.txtPrincipal.Location = new System.Drawing.Point(3, 25);
            this.txtPrincipal.MaxLength = 999999999;
            this.txtPrincipal.Multiline = true;
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrincipal.Size = new System.Drawing.Size(1398, 459);
            this.txtPrincipal.TabIndex = 0;
            this.txtPrincipal.TextChanged += new System.EventHandler(this.txtPrincipal_TextChanged);
            // 
            // txtRascunho
            // 
            this.txtRascunho.BackColor = System.Drawing.Color.Black;
            this.txtRascunho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRascunho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRascunho.Font = new System.Drawing.Font("Consolas", 16F);
            this.txtRascunho.ForeColor = System.Drawing.Color.Green;
            this.txtRascunho.Location = new System.Drawing.Point(3, 25);
            this.txtRascunho.MaxLength = 999999999;
            this.txtRascunho.Multiline = true;
            this.txtRascunho.Name = "txtRascunho";
            this.txtRascunho.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRascunho.Size = new System.Drawing.Size(1398, 322);
            this.txtRascunho.TabIndex = 0;
            this.txtRascunho.TextChanged += new System.EventHandler(this.txtRascunho_TextChanged);
            // 
            // gbRascunho
            // 
            this.gbRascunho.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbRascunho.Controls.Add(this.txtRascunho);
            this.gbRascunho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbRascunho.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.gbRascunho.ForeColor = System.Drawing.Color.White;
            this.gbRascunho.Location = new System.Drawing.Point(0, 663);
            this.gbRascunho.Name = "gbRascunho";
            this.gbRascunho.Size = new System.Drawing.Size(1404, 350);
            this.gbRascunho.TabIndex = 5;
            this.gbRascunho.TabStop = false;
            this.gbRascunho.Text = "Tela de Rascunho";
            // 
            // gbtextwindow
            // 
            this.gbtextwindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbtextwindow.Controls.Add(this.txtPrincipal);
            this.gbtextwindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbtextwindow.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.gbtextwindow.ForeColor = System.Drawing.Color.White;
            this.gbtextwindow.Location = new System.Drawing.Point(0, 176);
            this.gbtextwindow.Name = "gbtextwindow";
            this.gbtextwindow.Size = new System.Drawing.Size(1404, 487);
            this.gbtextwindow.TabIndex = 4;
            this.gbtextwindow.TabStop = false;
            this.gbtextwindow.Text = "Tela de texto principal";
            // 
            // gbHistorico
            // 
            this.gbHistorico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbHistorico.Controls.Add(this.dtgHistorico);
            this.gbHistorico.Controls.Add(this.ClearHistory);
            this.gbHistorico.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbHistorico.Font = new System.Drawing.Font("Maxter Board St", 12F);
            this.gbHistorico.ForeColor = System.Drawing.Color.White;
            this.gbHistorico.Location = new System.Drawing.Point(1404, 176);
            this.gbHistorico.Name = "gbHistorico";
            this.gbHistorico.Size = new System.Drawing.Size(500, 837);
            this.gbHistorico.TabIndex = 5;
            this.gbHistorico.TabStop = false;
            this.gbHistorico.Text = "Histórico de Texto";
            this.gbHistorico.Visible = false;
            // 
            // dtgHistorico
            // 
            this.dtgHistorico.AllowUserToAddRows = false;
            this.dtgHistorico.AllowUserToDeleteRows = false;
            this.dtgHistorico.AllowUserToResizeRows = false;
            this.dtgHistorico.BackgroundColor = System.Drawing.Color.Black;
            this.dtgHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maxter Board St", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorico.ColumnHeadersVisible = false;
            this.dtgHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD,
            this.history});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maxter Board St", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgHistorico.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgHistorico.GridColor = System.Drawing.Color.White;
            this.dtgHistorico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgHistorico.Location = new System.Drawing.Point(3, 65);
            this.dtgHistorico.Name = "dtgHistorico";
            this.dtgHistorico.ReadOnly = true;
            this.dtgHistorico.RowHeadersVisible = false;
            this.dtgHistorico.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 16F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
            this.dtgHistorico.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgHistorico.Size = new System.Drawing.Size(494, 769);
            this.dtgHistorico.TabIndex = 1;
            this.dtgHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHistorico_CellContentClick);
            // 
            // COD
            // 
            this.COD.HeaderText = "Código";
            this.COD.MaxInputLength = 999999999;
            this.COD.Name = "COD";
            this.COD.ReadOnly = true;
            this.COD.Width = 75;
            // 
            // history
            // 
            this.history.HeaderText = "Histórico";
            this.history.MaxInputLength = 999999999;
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.Width = 5000;
            // 
            // ClearHistory
            // 
            this.ClearHistory.BackColor = System.Drawing.Color.Black;
            this.ClearHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearHistory.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.ClearHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.ClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearHistory.Font = new System.Drawing.Font("Maxter Board St", 15F);
            this.ClearHistory.ForeColor = System.Drawing.Color.White;
            this.ClearHistory.Location = new System.Drawing.Point(3, 25);
            this.ClearHistory.Name = "ClearHistory";
            this.ClearHistory.Size = new System.Drawing.Size(494, 40);
            this.ClearHistory.TabIndex = 0;
            this.ClearHistory.Text = "Limpar Histórico 🚮";
            this.ClearHistory.UseVisualStyleBackColor = false;
            this.ClearHistory.Click += new System.EventHandler(this.ClearHistory_Click);
            // 
            // OFDopen
            // 
            this.OFDopen.FileName = "*.txt";
            this.OFDopen.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            this.OFDopen.Title = "Abrir";
            this.OFDopen.FileOk += new System.ComponentModel.CancelEventHandler(this.OFDopen_FileOk);
            // 
            // SFDsave
            // 
            this.SFDsave.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            this.SFDsave.FileOk += new System.ComponentModel.CancelEventHandler(this.SFDsave_FileOk);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "Codificação:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "Codificação:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.gbtextwindow);
            this.Controls.Add(this.gbRascunho);
            this.Controls.Add(this.gbHistorico);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tcPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "Encryption\'s Builder Studio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.gbHome.ResumeLayout(false);
            this.gbHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRascuho)).EndInit();
            this.tpCriptografia.ResumeLayout(false);
            this.gbCriptografia.ResumeLayout(false);
            this.gbCriptografia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCriptMulti)).EndInit();
            this.gbParameter.ResumeLayout(false);
            this.gbParameter.PerformLayout();
            this.gbCods.ResumeLayout(false);
            this.gbCods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMultiCodefication)).EndInit();
            this.tpHash.ResumeLayout(false);
            this.gbHashs.ResumeLayout(false);
            this.gbHashs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMultiHash)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbRascunho.ResumeLayout(false);
            this.gbRascunho.PerformLayout();
            this.gbtextwindow.ResumeLayout(false);
            this.gbtextwindow.PerformLayout();
            this.gbHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpCriptografia;
        private System.Windows.Forms.TabPage tpHash;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.GroupBox gbHome;
        private System.Windows.Forms.TextBox txtRascunho;
        private System.Windows.Forms.GroupBox gbRascunho;
        private System.Windows.Forms.GroupBox gbtextwindow;
        private System.Windows.Forms.CheckBox chkRascunho;
        private System.Windows.Forms.ToolStripStatusLabel lblCharacterText;
        private System.Windows.Forms.ToolStripStatusLabel lblCharacterRascunho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupRascuho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupFont;
        private System.Windows.Forms.CheckBox chkHistorico;
        private System.Windows.Forms.GroupBox gbHistorico;
        private System.Windows.Forms.DataGridView dtgHistorico;
        private System.Windows.Forms.Button ClearHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupHistory;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnClearTextWindow;
        private System.Windows.Forms.Button btnClearRascunho;
        private System.Windows.Forms.GroupBox gbCods;
        private System.Windows.Forms.ComboBox cboCodefication;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupMultiCodefication;
        private System.Windows.Forms.Button btnDecodificar;
        private System.Windows.Forms.Button btnCodificar;
        public System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog OFDopen;
        private System.Windows.Forms.SaveFileDialog SFDsave;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistryHistory;
        private System.Windows.Forms.GroupBox gbCriptografia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCodeCript;
        private System.Windows.Forms.Button btnDescriptografar;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupCriptMulti;
        private System.Windows.Forms.ComboBox cboCriptografia;
        private System.Windows.Forms.GroupBox gbHashs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCodeHash;
        private System.Windows.Forms.Button btnHashear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nupMultiHash;
        private System.Windows.Forms.ComboBox cboHashs;
        private System.Windows.Forms.GroupBox gbParameter;
        public System.Windows.Forms.TextBox txtKey;
        public System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn history;
        private System.Windows.Forms.ComboBox cboCodIV;
        private System.Windows.Forms.ComboBox cboCodKey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

