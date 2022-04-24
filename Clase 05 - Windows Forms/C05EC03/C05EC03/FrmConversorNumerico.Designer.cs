
namespace C05EC03
{
    partial class FrmConversorNumerico
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBinToDec = new System.Windows.Forms.Label();
            this.lblDecToBin = new System.Windows.Forms.Label();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.txtDecimalCantidad = new System.Windows.Forms.TextBox();
            this.txtBinarioCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBinToDec
            // 
            this.lblBinToDec.AutoSize = true;
            this.lblBinToDec.Location = new System.Drawing.Point(12, 32);
            this.lblBinToDec.Name = "lblBinToDec";
            this.lblBinToDec.Size = new System.Drawing.Size(99, 15);
            this.lblBinToDec.TabIndex = 0;
            this.lblBinToDec.Text = "Binario a Decimal";
            // 
            // lblDecToBin
            // 
            this.lblDecToBin.AutoSize = true;
            this.lblDecToBin.Location = new System.Drawing.Point(12, 60);
            this.lblDecToBin.Name = "lblDecToBin";
            this.lblDecToBin.Size = new System.Drawing.Size(99, 15);
            this.lblDecToBin.TabIndex = 1;
            this.lblDecToBin.Text = "Decimal a Binario";
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.Location = new System.Drawing.Point(226, 29);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(42, 23);
            this.btnBinToDec.TabIndex = 2;
            this.btnBinToDec.Text = "->";
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.Location = new System.Drawing.Point(226, 58);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(42, 23);
            this.btnDecToBin.TabIndex = 3;
            this.btnDecToBin.Text = "->";
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Enabled = false;
            this.txtResultadoBin.Location = new System.Drawing.Point(274, 58);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoBin.TabIndex = 4;
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Enabled = false;
            this.txtResultadoDec.Location = new System.Drawing.Point(274, 29);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoDec.TabIndex = 5;
            // 
            // txtDecimalCantidad
            // 
            this.txtDecimalCantidad.Location = new System.Drawing.Point(120, 58);
            this.txtDecimalCantidad.Name = "txtDecimalCantidad";
            this.txtDecimalCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtDecimalCantidad.TabIndex = 6;
            // 
            // txtBinarioCantidad
            // 
            this.txtBinarioCantidad.Location = new System.Drawing.Point(120, 29);
            this.txtBinarioCantidad.Name = "txtBinarioCantidad";
            this.txtBinarioCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtBinarioCantidad.TabIndex = 7;
            // 
            // FrmConversorNumerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 98);
            this.Controls.Add(this.txtBinarioCantidad);
            this.Controls.Add(this.txtDecimalCantidad);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.lblDecToBin);
            this.Controls.Add(this.lblBinToDec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmConversorNumerico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Numérico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinToDec;
        private System.Windows.Forms.Label lblDecToBin;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.TextBox txtResultadoBin;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.TextBox txtDecimalCantidad;
        private System.Windows.Forms.TextBox txtBinarioCantidad;
    }
}

