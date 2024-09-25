
namespace Encript_Master_v2._0
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpASCII = new System.Windows.Forms.TabPage();
            this.nupFontASCII = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExitASCII = new System.Windows.Forms.TextBox();
            this.txtIntASCII = new System.Windows.Forms.TextBox();
            this.btnLimparASCII = new System.Windows.Forms.Button();
            this.btnDescriptASCII = new System.Windows.Forms.Button();
            this.btnMultiCriptASCII = new System.Windows.Forms.Button();
            this.btnCriptASCII = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tpHashMD5 = new System.Windows.Forms.TabPage();
            this.nupFontMD5 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExitHMD5 = new System.Windows.Forms.TextBox();
            this.txtIntHMD5 = new System.Windows.Forms.TextBox();
            this.btnLimparHMD5 = new System.Windows.Forms.Button();
            this.btnDescriptMD5 = new System.Windows.Forms.Button();
            this.btnMultiCriptMD5 = new System.Windows.Forms.Button();
            this.btnCriptMD5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tpAjuda = new System.Windows.Forms.TabPage();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tpASCII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFontASCII)).BeginInit();
            this.tpHashMD5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFontMD5)).BeginInit();
            this.tpAjuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Controls.Add(this.tpASCII);
            this.tabControl.Controls.Add(this.tpHashMD5);
            this.tabControl.Controls.Add(this.tpAjuda);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(944, 501);
            this.tabControl.TabIndex = 0;
            // 
            // tpASCII
            // 
            this.tpASCII.BackColor = System.Drawing.Color.Black;
            this.tpASCII.Controls.Add(this.nupFontASCII);
            this.tpASCII.Controls.Add(this.label2);
            this.tpASCII.Controls.Add(this.label1);
            this.tpASCII.Controls.Add(this.txtExitASCII);
            this.tpASCII.Controls.Add(this.txtIntASCII);
            this.tpASCII.Controls.Add(this.btnLimparASCII);
            this.tpASCII.Controls.Add(this.btnDescriptASCII);
            this.tpASCII.Controls.Add(this.btnMultiCriptASCII);
            this.tpASCII.Controls.Add(this.btnCriptASCII);
            this.tpASCII.Controls.Add(this.label3);
            this.tpASCII.Location = new System.Drawing.Point(4, 27);
            this.tpASCII.Name = "tpASCII";
            this.tpASCII.Padding = new System.Windows.Forms.Padding(3);
            this.tpASCII.Size = new System.Drawing.Size(936, 470);
            this.tpASCII.TabIndex = 0;
            this.tpASCII.Text = "Criptografia ASCII";
            // 
            // nupFontASCII
            // 
            this.nupFontASCII.BackColor = System.Drawing.Color.Black;
            this.nupFontASCII.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupFontASCII.Font = new System.Drawing.Font("Consolas", 16F);
            this.nupFontASCII.ForeColor = System.Drawing.Color.Green;
            this.nupFontASCII.Location = new System.Drawing.Point(866, 11);
            this.nupFontASCII.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupFontASCII.Name = "nupFontASCII";
            this.nupFontASCII.Size = new System.Drawing.Size(62, 28);
            this.nupFontASCII.TabIndex = 3;
            this.nupFontASCII.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupFontASCII.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nupFontASCII.ValueChanged += new System.EventHandler(this.nupFontASCII_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(474, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saída: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrada: ";
            // 
            // txtExitASCII
            // 
            this.txtExitASCII.BackColor = System.Drawing.Color.Black;
            this.txtExitASCII.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExitASCII.ForeColor = System.Drawing.Color.Green;
            this.txtExitASCII.Location = new System.Drawing.Point(469, 43);
            this.txtExitASCII.Multiline = true;
            this.txtExitASCII.Name = "txtExitASCII";
            this.txtExitASCII.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExitASCII.Size = new System.Drawing.Size(464, 358);
            this.txtExitASCII.TabIndex = 1;
            // 
            // txtIntASCII
            // 
            this.txtIntASCII.BackColor = System.Drawing.Color.Black;
            this.txtIntASCII.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntASCII.ForeColor = System.Drawing.Color.Green;
            this.txtIntASCII.Location = new System.Drawing.Point(3, 43);
            this.txtIntASCII.Multiline = true;
            this.txtIntASCII.Name = "txtIntASCII";
            this.txtIntASCII.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIntASCII.Size = new System.Drawing.Size(464, 358);
            this.txtIntASCII.TabIndex = 1;
            // 
            // btnLimparASCII
            // 
            this.btnLimparASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparASCII.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparASCII.Font = new System.Drawing.Font("Consolas", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparASCII.ForeColor = System.Drawing.Color.Green;
            this.btnLimparASCII.Location = new System.Drawing.Point(409, 407);
            this.btnLimparASCII.Name = "btnLimparASCII";
            this.btnLimparASCII.Size = new System.Drawing.Size(58, 58);
            this.btnLimparASCII.TabIndex = 0;
            this.btnLimparASCII.Text = "🚮";
            this.btnLimparASCII.UseVisualStyleBackColor = true;
            this.btnLimparASCII.Click += new System.EventHandler(this.btnLimparASCII_Click);
            // 
            // btnDescriptASCII
            // 
            this.btnDescriptASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescriptASCII.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDescriptASCII.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescriptASCII.ForeColor = System.Drawing.Color.Green;
            this.btnDescriptASCII.Location = new System.Drawing.Point(206, 407);
            this.btnDescriptASCII.Name = "btnDescriptASCII";
            this.btnDescriptASCII.Size = new System.Drawing.Size(203, 58);
            this.btnDescriptASCII.TabIndex = 0;
            this.btnDescriptASCII.Text = "Descriptografar";
            this.btnDescriptASCII.UseVisualStyleBackColor = true;
            this.btnDescriptASCII.Click += new System.EventHandler(this.btnDescriptASCII_Click);
            // 
            // btnMultiCriptASCII
            // 
            this.btnMultiCriptASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiCriptASCII.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiCriptASCII.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiCriptASCII.ForeColor = System.Drawing.Color.Green;
            this.btnMultiCriptASCII.Location = new System.Drawing.Point(479, 407);
            this.btnMultiCriptASCII.Name = "btnMultiCriptASCII";
            this.btnMultiCriptASCII.Size = new System.Drawing.Size(449, 58);
            this.btnMultiCriptASCII.TabIndex = 0;
            this.btnMultiCriptASCII.Text = "Criptografia Múltipla (ASCII)";
            this.btnMultiCriptASCII.UseVisualStyleBackColor = true;
            this.btnMultiCriptASCII.Click += new System.EventHandler(this.btnMultiCriptASCII_Click);
            // 
            // btnCriptASCII
            // 
            this.btnCriptASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriptASCII.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriptASCII.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptASCII.ForeColor = System.Drawing.Color.Green;
            this.btnCriptASCII.Location = new System.Drawing.Point(3, 407);
            this.btnCriptASCII.Name = "btnCriptASCII";
            this.btnCriptASCII.Size = new System.Drawing.Size(203, 58);
            this.btnCriptASCII.TabIndex = 0;
            this.btnCriptASCII.Text = "Criptografar";
            this.btnCriptASCII.UseVisualStyleBackColor = true;
            this.btnCriptASCII.Click += new System.EventHandler(this.btnCriptASCII_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(632, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tamanho da fonte: ";
            // 
            // tpHashMD5
            // 
            this.tpHashMD5.BackColor = System.Drawing.Color.Black;
            this.tpHashMD5.Controls.Add(this.nupFontMD5);
            this.tpHashMD5.Controls.Add(this.label4);
            this.tpHashMD5.Controls.Add(this.label5);
            this.tpHashMD5.Controls.Add(this.txtExitHMD5);
            this.tpHashMD5.Controls.Add(this.txtIntHMD5);
            this.tpHashMD5.Controls.Add(this.btnLimparHMD5);
            this.tpHashMD5.Controls.Add(this.btnDescriptMD5);
            this.tpHashMD5.Controls.Add(this.btnMultiCriptMD5);
            this.tpHashMD5.Controls.Add(this.btnCriptMD5);
            this.tpHashMD5.Controls.Add(this.label6);
            this.tpHashMD5.Location = new System.Drawing.Point(4, 27);
            this.tpHashMD5.Name = "tpHashMD5";
            this.tpHashMD5.Padding = new System.Windows.Forms.Padding(3);
            this.tpHashMD5.Size = new System.Drawing.Size(936, 470);
            this.tpHashMD5.TabIndex = 1;
            this.tpHashMD5.Text = "Criptografia Hash MD5";
            // 
            // nupFontMD5
            // 
            this.nupFontMD5.BackColor = System.Drawing.Color.Black;
            this.nupFontMD5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupFontMD5.Font = new System.Drawing.Font("Consolas", 16F);
            this.nupFontMD5.ForeColor = System.Drawing.Color.Green;
            this.nupFontMD5.Location = new System.Drawing.Point(866, 10);
            this.nupFontMD5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupFontMD5.Name = "nupFontMD5";
            this.nupFontMD5.Size = new System.Drawing.Size(62, 28);
            this.nupFontMD5.TabIndex = 13;
            this.nupFontMD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupFontMD5.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nupFontMD5.ValueChanged += new System.EventHandler(this.nupFontMD5_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(474, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Saída: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Entrada: ";
            // 
            // txtExitHMD5
            // 
            this.txtExitHMD5.BackColor = System.Drawing.Color.Black;
            this.txtExitHMD5.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtExitHMD5.ForeColor = System.Drawing.Color.Green;
            this.txtExitHMD5.Location = new System.Drawing.Point(469, 42);
            this.txtExitHMD5.Multiline = true;
            this.txtExitHMD5.Name = "txtExitHMD5";
            this.txtExitHMD5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExitHMD5.Size = new System.Drawing.Size(464, 358);
            this.txtExitHMD5.TabIndex = 8;
            // 
            // txtIntHMD5
            // 
            this.txtIntHMD5.BackColor = System.Drawing.Color.Black;
            this.txtIntHMD5.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtIntHMD5.ForeColor = System.Drawing.Color.Green;
            this.txtIntHMD5.Location = new System.Drawing.Point(3, 42);
            this.txtIntHMD5.Multiline = true;
            this.txtIntHMD5.Name = "txtIntHMD5";
            this.txtIntHMD5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIntHMD5.Size = new System.Drawing.Size(464, 358);
            this.txtIntHMD5.TabIndex = 9;
            // 
            // btnLimparHMD5
            // 
            this.btnLimparHMD5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparHMD5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparHMD5.Font = new System.Drawing.Font("Consolas", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparHMD5.ForeColor = System.Drawing.Color.Green;
            this.btnLimparHMD5.Location = new System.Drawing.Point(409, 406);
            this.btnLimparHMD5.Name = "btnLimparHMD5";
            this.btnLimparHMD5.Size = new System.Drawing.Size(58, 58);
            this.btnLimparHMD5.TabIndex = 4;
            this.btnLimparHMD5.Text = "🚮";
            this.btnLimparHMD5.UseVisualStyleBackColor = true;
            this.btnLimparHMD5.Click += new System.EventHandler(this.btnLimparHMD5_Click);
            // 
            // btnDescriptMD5
            // 
            this.btnDescriptMD5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescriptMD5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDescriptMD5.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescriptMD5.ForeColor = System.Drawing.Color.Green;
            this.btnDescriptMD5.Location = new System.Drawing.Point(206, 406);
            this.btnDescriptMD5.Name = "btnDescriptMD5";
            this.btnDescriptMD5.Size = new System.Drawing.Size(203, 58);
            this.btnDescriptMD5.TabIndex = 5;
            this.btnDescriptMD5.Text = "Descriptografar";
            this.btnDescriptMD5.UseVisualStyleBackColor = true;
            this.btnDescriptMD5.Click += new System.EventHandler(this.btnDescriptMD5_Click);
            // 
            // btnMultiCriptMD5
            // 
            this.btnMultiCriptMD5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiCriptMD5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiCriptMD5.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiCriptMD5.ForeColor = System.Drawing.Color.Green;
            this.btnMultiCriptMD5.Location = new System.Drawing.Point(479, 406);
            this.btnMultiCriptMD5.Name = "btnMultiCriptMD5";
            this.btnMultiCriptMD5.Size = new System.Drawing.Size(449, 58);
            this.btnMultiCriptMD5.TabIndex = 6;
            this.btnMultiCriptMD5.Text = "Criptografia Múltipla (Hash MD5)";
            this.btnMultiCriptMD5.UseVisualStyleBackColor = true;
            this.btnMultiCriptMD5.Click += new System.EventHandler(this.btnMultiCriptMD5_Click);
            // 
            // btnCriptMD5
            // 
            this.btnCriptMD5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriptMD5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriptMD5.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptMD5.ForeColor = System.Drawing.Color.Green;
            this.btnCriptMD5.Location = new System.Drawing.Point(3, 406);
            this.btnCriptMD5.Name = "btnCriptMD5";
            this.btnCriptMD5.Size = new System.Drawing.Size(203, 58);
            this.btnCriptMD5.TabIndex = 7;
            this.btnCriptMD5.Text = "Criptografar";
            this.btnCriptMD5.UseVisualStyleBackColor = true;
            this.btnCriptMD5.Click += new System.EventHandler(this.btnCriptMD5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(632, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tamanho da fonte: ";
            // 
            // tpAjuda
            // 
            this.tpAjuda.BackColor = System.Drawing.Color.Black;
            this.tpAjuda.Controls.Add(this.txtHelp);
            this.tpAjuda.Location = new System.Drawing.Point(4, 27);
            this.tpAjuda.Name = "tpAjuda";
            this.tpAjuda.Padding = new System.Windows.Forms.Padding(3);
            this.tpAjuda.Size = new System.Drawing.Size(936, 470);
            this.tpAjuda.TabIndex = 2;
            this.tpAjuda.Text = "Ajuda";
            // 
            // txtHelp
            // 
            this.txtHelp.BackColor = System.Drawing.Color.Black;
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHelp.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtHelp.ForeColor = System.Drawing.Color.Green;
            this.txtHelp.Location = new System.Drawing.Point(3, 3);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHelp.Size = new System.Drawing.Size(930, 464);
            this.txtHelp.TabIndex = 10;
            this.txtHelp.Text = resources.GetString("txtHelp.Text");
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tabControl);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 540);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Encript Master - versão: 2.0";
            this.tabControl.ResumeLayout(false);
            this.tpASCII.ResumeLayout(false);
            this.tpASCII.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFontASCII)).EndInit();
            this.tpHashMD5.ResumeLayout(false);
            this.tpHashMD5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFontMD5)).EndInit();
            this.tpAjuda.ResumeLayout(false);
            this.tpAjuda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpASCII;
        private System.Windows.Forms.TabPage tpHashMD5;
        private System.Windows.Forms.TextBox txtExitASCII;
        private System.Windows.Forms.TextBox txtIntASCII;
        private System.Windows.Forms.Button btnDescriptASCII;
        private System.Windows.Forms.Button btnCriptASCII;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupFontASCII;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimparASCII;
        private System.Windows.Forms.Button btnMultiCriptASCII;
        private System.Windows.Forms.NumericUpDown nupFontMD5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExitHMD5;
        private System.Windows.Forms.TextBox txtIntHMD5;
        private System.Windows.Forms.Button btnLimparHMD5;
        private System.Windows.Forms.Button btnDescriptMD5;
        private System.Windows.Forms.Button btnMultiCriptMD5;
        private System.Windows.Forms.Button btnCriptMD5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tpAjuda;
        private System.Windows.Forms.TextBox txtHelp;
    }
}

