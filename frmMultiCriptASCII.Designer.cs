
namespace Encript_Master_v2._0
{
    partial class frmMultiCriptASCII
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultiCriptASCII));
            this.nupFontValue = new System.Windows.Forms.NumericUpDown();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDescriptASCII = new System.Windows.Forms.Button();
            this.btnCriptASCII = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupCriptValue = new System.Windows.Forms.NumericUpDown();
            this.wmpPrincipal = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.nupFontValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCriptValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // nupFontValue
            // 
            this.nupFontValue.BackColor = System.Drawing.Color.Black;
            this.nupFontValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupFontValue.Font = new System.Drawing.Font("Consolas", 16F);
            this.nupFontValue.ForeColor = System.Drawing.Color.Green;
            this.nupFontValue.Location = new System.Drawing.Point(880, 21);
            this.nupFontValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupFontValue.Name = "nupFontValue";
            this.nupFontValue.Size = new System.Drawing.Size(62, 28);
            this.nupFontValue.TabIndex = 9;
            this.nupFontValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupFontValue.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nupFontValue.ValueChanged += new System.EventHandler(this.nupFontValue_ValueChanged);
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.BackColor = System.Drawing.Color.Black;
            this.txtPrincipal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipal.ForeColor = System.Drawing.Color.Green;
            this.txtPrincipal.Location = new System.Drawing.Point(4, 67);
            this.txtPrincipal.Multiline = true;
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrincipal.Size = new System.Drawing.Size(938, 358);
            this.txtPrincipal.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Consolas", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Green;
            this.btnClear.Location = new System.Drawing.Point(880, 431);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 58);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "🚮";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDescriptASCII
            // 
            this.btnDescriptASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescriptASCII.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDescriptASCII.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescriptASCII.ForeColor = System.Drawing.Color.Green;
            this.btnDescriptASCII.Location = new System.Drawing.Point(213, 431);
            this.btnDescriptASCII.Name = "btnDescriptASCII";
            this.btnDescriptASCII.Size = new System.Drawing.Size(203, 58);
            this.btnDescriptASCII.TabIndex = 5;
            this.btnDescriptASCII.Text = "Descriptografar";
            this.btnDescriptASCII.UseVisualStyleBackColor = true;
            this.btnDescriptASCII.Click += new System.EventHandler(this.btnDescriptASCII_Click);
            // 
            // btnCriptASCII
            // 
            this.btnCriptASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriptASCII.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriptASCII.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptASCII.ForeColor = System.Drawing.Color.Green;
            this.btnCriptASCII.Location = new System.Drawing.Point(4, 431);
            this.btnCriptASCII.Name = "btnCriptASCII";
            this.btnCriptASCII.Size = new System.Drawing.Size(203, 58);
            this.btnCriptASCII.TabIndex = 6;
            this.btnCriptASCII.Text = "Criptografar";
            this.btnCriptASCII.UseVisualStyleBackColor = true;
            this.btnCriptASCII.Click += new System.EventHandler(this.btnCriptASCII_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(652, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tamanho da fonte: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(499, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor de Criptografia: ";
            // 
            // nupCriptValue
            // 
            this.nupCriptValue.BackColor = System.Drawing.Color.Black;
            this.nupCriptValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupCriptValue.Font = new System.Drawing.Font("Consolas", 16F);
            this.nupCriptValue.ForeColor = System.Drawing.Color.Green;
            this.nupCriptValue.Location = new System.Drawing.Point(770, 446);
            this.nupCriptValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCriptValue.Name = "nupCriptValue";
            this.nupCriptValue.Size = new System.Drawing.Size(75, 28);
            this.nupCriptValue.TabIndex = 9;
            this.nupCriptValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupCriptValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // wmpPrincipal
            // 
            this.wmpPrincipal.Enabled = true;
            this.wmpPrincipal.Location = new System.Drawing.Point(-69, -104);
            this.wmpPrincipal.Name = "wmpPrincipal";
            this.wmpPrincipal.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPrincipal.OcxState")));
            this.wmpPrincipal.Size = new System.Drawing.Size(634, 281);
            this.wmpPrincipal.TabIndex = 10;
            // 
            // frmMultiCriptASCII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupCriptValue);
            this.Controls.Add(this.nupFontValue);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDescriptASCII);
            this.Controls.Add(this.btnCriptASCII);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wmpPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 540);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "frmMultiCriptASCII";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Criptografia Múltipla (ASCII)";
            this.Load += new System.EventHandler(this.frmMultiCriptASCII_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupFontValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCriptValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupFontValue;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDescriptASCII;
        private System.Windows.Forms.Button btnCriptASCII;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupCriptValue;
        private AxWMPLib.AxWindowsMediaPlayer wmpPrincipal;
    }
}