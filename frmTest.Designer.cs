
namespace Encription_Creator
{
    partial class frmTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.gbCriptografia = new System.Windows.Forms.GroupBox();
            this.nupMultiCript = new System.Windows.Forms.NumericUpDown();
            this.btnDescript = new System.Windows.Forms.Button();
            this.btnCript = new System.Windows.Forms.Button();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.gbCriptografia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMultiCript)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCriptografia
            // 
            this.gbCriptografia.Controls.Add(this.nupMultiCript);
            this.gbCriptografia.Controls.Add(this.btnDescript);
            this.gbCriptografia.Controls.Add(this.btnCript);
            this.gbCriptografia.Controls.Add(this.txtKey);
            this.gbCriptografia.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbCriptografia.Location = new System.Drawing.Point(0, 0);
            this.gbCriptografia.Name = "gbCriptografia";
            this.gbCriptografia.Size = new System.Drawing.Size(202, 162);
            this.gbCriptografia.TabIndex = 0;
            this.gbCriptografia.TabStop = false;
            this.gbCriptografia.Text = "Criptografia";
            // 
            // nupMultiCript
            // 
            this.nupMultiCript.Location = new System.Drawing.Point(144, 11);
            this.nupMultiCript.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupMultiCript.Name = "nupMultiCript";
            this.nupMultiCript.Size = new System.Drawing.Size(58, 20);
            this.nupMultiCript.TabIndex = 6;
            this.nupMultiCript.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDescript
            // 
            this.btnDescript.Location = new System.Drawing.Point(5, 66);
            this.btnDescript.Name = "btnDescript";
            this.btnDescript.Size = new System.Drawing.Size(188, 23);
            this.btnDescript.TabIndex = 5;
            this.btnDescript.Text = "Descriptografar";
            this.btnDescript.UseVisualStyleBackColor = true;
            this.btnDescript.Click += new System.EventHandler(this.btnDescript_Click);
            // 
            // btnCript
            // 
            this.btnCript.Location = new System.Drawing.Point(5, 37);
            this.btnCript.Name = "btnCript";
            this.btnCript.Size = new System.Drawing.Size(188, 23);
            this.btnCript.TabIndex = 4;
            this.btnCript.Text = "Criptografar";
            this.btnCript.UseVisualStyleBackColor = true;
            this.btnCript.Click += new System.EventHandler(this.btnCript_Click);
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(231, 86);
            this.txtIV.MaxLength = 1000;
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(188, 20);
            this.txtIV.TabIndex = 3;
            this.txtIV.Text = "14725836";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(5, 95);
            this.txtKey.MaxLength = 1000;
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(188, 61);
            this.txtKey.TabIndex = 2;
            this.txtKey.Text = resources.GetString("txtKey.Text");
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrincipal.Location = new System.Drawing.Point(202, 0);
            this.txtPrincipal.Multiline = true;
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(388, 162);
            this.txtPrincipal.TabIndex = 1;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 162);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.gbCriptografia);
            this.Controls.Add(this.txtIV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTest";
            this.Text = "Teste de Criptografia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTest_FormClosing);
            this.gbCriptografia.ResumeLayout(false);
            this.gbCriptografia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMultiCript)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCriptografia;
        private System.Windows.Forms.NumericUpDown nupMultiCript;
        private System.Windows.Forms.Button btnDescript;
        private System.Windows.Forms.Button btnCript;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtPrincipal;
    }
}