
namespace C05EI01
{
    partial class FormSaludo
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
            this.labelSaludo = new System.Windows.Forms.Label();
            this.labelNombreSaludo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSaludo
            // 
            this.labelSaludo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelSaludo.Location = new System.Drawing.Point(12, 25);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(120, 25);
            this.labelSaludo.TabIndex = 0;
            this.labelSaludo.Text = "placeHolder";
            // 
            // labelNombreSaludo
            // 
            this.labelNombreSaludo.AutoSize = true;
            this.labelNombreSaludo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombreSaludo.Location = new System.Drawing.Point(12, 92);
            this.labelNombreSaludo.Name = "labelNombreSaludo";
            this.labelNombreSaludo.Size = new System.Drawing.Size(93, 21);
            this.labelNombreSaludo.TabIndex = 1;
            this.labelNombreSaludo.Text = "placeHolder";
            // 
            // FormSaludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 161);
            this.Controls.Add(this.labelNombreSaludo);
            this.Controls.Add(this.labelSaludo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaludo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.Label labelNombreSaludo;
    }
}