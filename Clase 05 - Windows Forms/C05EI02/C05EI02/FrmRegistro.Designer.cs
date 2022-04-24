
namespace C05EI02
{
    partial class FrmRegistro
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
            this.grbUsuario = new System.Windows.Forms.GroupBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.grbCursos = new System.Windows.Forms.GroupBox();
            this.chbJavaScript = new System.Windows.Forms.CheckBox();
            this.chbCplusplus = new System.Windows.Forms.CheckBox();
            this.chbCsharp = new System.Windows.Forms.CheckBox();
            this.lstbPais = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.grbGenero.SuspendLayout();
            this.grbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUsuario
            // 
            this.grbUsuario.Controls.Add(this.nudEdad);
            this.grbUsuario.Controls.Add(this.lblEdad);
            this.grbUsuario.Controls.Add(this.lblDireccion);
            this.grbUsuario.Controls.Add(this.txbDireccion);
            this.grbUsuario.Controls.Add(this.txbNombre);
            this.grbUsuario.Controls.Add(this.lblNombre);
            this.grbUsuario.Location = new System.Drawing.Point(12, 12);
            this.grbUsuario.Name = "grbUsuario";
            this.grbUsuario.Size = new System.Drawing.Size(244, 155);
            this.grbUsuario.TabIndex = 0;
            this.grbUsuario.TabStop = false;
            this.grbUsuario.Text = "Detalles del usuario";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(90, 119);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(135, 23);
            this.nudEdad.TabIndex = 2;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(22, 121);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(22, 75);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(90, 72);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.PlaceholderText = "Calle Falsa 123";
            this.txbDireccion.Size = new System.Drawing.Size(135, 23);
            this.txbDireccion.TabIndex = 1;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(90, 26);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PlaceholderText = "Lautaro";
            this.txbNombre.Size = new System.Drawing.Size(135, 23);
            this.txbNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Tag = "";
            this.lblNombre.Text = "Nombre";
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.rbNoBinario);
            this.grbGenero.Controls.Add(this.rbFemenino);
            this.grbGenero.Controls.Add(this.rbMasculino);
            this.grbGenero.Location = new System.Drawing.Point(281, 12);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(127, 108);
            this.grbGenero.TabIndex = 1;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Género";
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(19, 73);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rbNoBinario.TabIndex = 5;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "No Binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(19, 47);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbFemenino.TabIndex = 4;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(19, 22);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 3;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // grbCursos
            // 
            this.grbCursos.Controls.Add(this.chbJavaScript);
            this.grbCursos.Controls.Add(this.chbCplusplus);
            this.grbCursos.Controls.Add(this.chbCsharp);
            this.grbCursos.Location = new System.Drawing.Point(280, 133);
            this.grbCursos.Name = "grbCursos";
            this.grbCursos.Size = new System.Drawing.Size(127, 124);
            this.grbCursos.TabIndex = 2;
            this.grbCursos.TabStop = false;
            this.grbCursos.Text = "Cursos";
            // 
            // chbJavaScript
            // 
            this.chbJavaScript.AutoSize = true;
            this.chbJavaScript.Location = new System.Drawing.Point(19, 84);
            this.chbJavaScript.Name = "chbJavaScript";
            this.chbJavaScript.Size = new System.Drawing.Size(78, 19);
            this.chbJavaScript.TabIndex = 8;
            this.chbJavaScript.Text = "JavaScript";
            this.chbJavaScript.UseVisualStyleBackColor = true;
            // 
            // chbCplusplus
            // 
            this.chbCplusplus.AutoSize = true;
            this.chbCplusplus.Location = new System.Drawing.Point(19, 58);
            this.chbCplusplus.Name = "chbCplusplus";
            this.chbCplusplus.Size = new System.Drawing.Size(50, 19);
            this.chbCplusplus.TabIndex = 7;
            this.chbCplusplus.Text = "C++";
            this.chbCplusplus.UseVisualStyleBackColor = true;
            // 
            // chbCsharp
            // 
            this.chbCsharp.AutoSize = true;
            this.chbCsharp.Location = new System.Drawing.Point(19, 32);
            this.chbCsharp.Name = "chbCsharp";
            this.chbCsharp.Size = new System.Drawing.Size(41, 19);
            this.chbCsharp.TabIndex = 6;
            this.chbCsharp.Text = "C#";
            this.chbCsharp.UseVisualStyleBackColor = true;
            // 
            // lstbPais
            // 
            this.lstbPais.FormattingEnabled = true;
            this.lstbPais.ItemHeight = 15;
            this.lstbPais.Location = new System.Drawing.Point(12, 201);
            this.lstbPais.Name = "lstbPais";
            this.lstbPais.Size = new System.Drawing.Size(244, 109);
            this.lstbPais.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(12, 180);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "País";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(281, 286);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(126, 23);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 327);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lstbPais);
            this.Controls.Add(this.grbCursos);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.grbUsuario);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegistro_FormClosing);
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.grbUsuario.ResumeLayout(false);
            this.grbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.grbCursos.ResumeLayout(false);
            this.grbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUsuario;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.GroupBox grbCursos;
        private System.Windows.Forms.CheckBox chbJavaScript;
        private System.Windows.Forms.CheckBox chbCplusplus;
        private System.Windows.Forms.CheckBox chbCsharp;
        private System.Windows.Forms.ListBox lstbPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}

