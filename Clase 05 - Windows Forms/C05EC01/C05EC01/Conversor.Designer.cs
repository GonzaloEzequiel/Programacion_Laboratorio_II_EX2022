
namespace C05EC01
{
    partial class frmConversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversor));
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblEuroColumna = new System.Windows.Forms.Label();
            this.lblDolarColumna = new System.Windows.Forms.Label();
            this.lblPesoColumna = new System.Windows.Forms.Label();
            this.lblEuroFila = new System.Windows.Forms.Label();
            this.lblDolarFila = new System.Windows.Forms.Label();
            this.lblPesoFila = new System.Windows.Forms.Label();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnConversorEuro = new System.Windows.Forms.Button();
            this.btnConversorDolar = new System.Windows.Forms.Button();
            this.btnConversorPeso = new System.Windows.Forms.Button();
            this.txtEuroCantidad = new System.Windows.Forms.TextBox();
            this.txtDolarCantidad = new System.Windows.Forms.TextBox();
            this.txtPesoCantidad = new System.Windows.Forms.TextBox();
            this.txtResultadoEuroEuro = new System.Windows.Forms.TextBox();
            this.txtResultadoDolarEuro = new System.Windows.Forms.TextBox();
            this.txtResultadoPesoEuro = new System.Windows.Forms.TextBox();
            this.txtResultadoEuroDolar = new System.Windows.Forms.TextBox();
            this.txtResultadoDolarDolar = new System.Windows.Forms.TextBox();
            this.txtResultadoPesoDolar = new System.Windows.Forms.TextBox();
            this.txtResultadoEuroPeso = new System.Windows.Forms.TextBox();
            this.txtResultadoDolarPeso = new System.Windows.Forms.TextBox();
            this.txtResultadoPesoPeso = new System.Windows.Forms.TextBox();
            this.txtEuroCotizacion = new System.Windows.Forms.TextBox();
            this.txtDolarCotizacion = new System.Windows.Forms.TextBox();
            this.txtPesoCotizacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCotizacion.Location = new System.Drawing.Point(44, 11);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(98, 25);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "Cotización";
            // 
            // lblEuroColumna
            // 
            this.lblEuroColumna.AutoSize = true;
            this.lblEuroColumna.Location = new System.Drawing.Point(234, 41);
            this.lblEuroColumna.Name = "lblEuroColumna";
            this.lblEuroColumna.Size = new System.Drawing.Size(31, 15);
            this.lblEuroColumna.TabIndex = 1;
            this.lblEuroColumna.Text = "Euro";
            // 
            // lblDolarColumna
            // 
            this.lblDolarColumna.AutoSize = true;
            this.lblDolarColumna.Location = new System.Drawing.Point(335, 42);
            this.lblDolarColumna.Name = "lblDolarColumna";
            this.lblDolarColumna.Size = new System.Drawing.Size(35, 15);
            this.lblDolarColumna.TabIndex = 2;
            this.lblDolarColumna.Text = "Dólar";
            // 
            // lblPesoColumna
            // 
            this.lblPesoColumna.AutoSize = true;
            this.lblPesoColumna.Location = new System.Drawing.Point(443, 41);
            this.lblPesoColumna.Name = "lblPesoColumna";
            this.lblPesoColumna.Size = new System.Drawing.Size(32, 15);
            this.lblPesoColumna.TabIndex = 3;
            this.lblPesoColumna.Text = "Peso";
            // 
            // lblEuroFila
            // 
            this.lblEuroFila.AutoSize = true;
            this.lblEuroFila.Location = new System.Drawing.Point(8, 63);
            this.lblEuroFila.Name = "lblEuroFila";
            this.lblEuroFila.Size = new System.Drawing.Size(31, 15);
            this.lblEuroFila.TabIndex = 4;
            this.lblEuroFila.Text = "Euro";
            // 
            // lblDolarFila
            // 
            this.lblDolarFila.AutoSize = true;
            this.lblDolarFila.Location = new System.Drawing.Point(8, 92);
            this.lblDolarFila.Name = "lblDolarFila";
            this.lblDolarFila.Size = new System.Drawing.Size(35, 15);
            this.lblDolarFila.TabIndex = 5;
            this.lblDolarFila.Text = "Dólar";
            // 
            // lblPesoFila
            // 
            this.lblPesoFila.AutoSize = true;
            this.lblPesoFila.Location = new System.Drawing.Point(8, 121);
            this.lblPesoFila.Name = "lblPesoFila";
            this.lblPesoFila.Size = new System.Drawing.Size(32, 15);
            this.lblPesoFila.TabIndex = 6;
            this.lblPesoFila.Text = "Peso";
            // 
            // btnLock
            // 
            this.btnLock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLock.Image = ((System.Drawing.Image)(resources.GetObject("btnLock.Image")));
            this.btnLock.Location = new System.Drawing.Point(150, 6);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(41, 35);
            this.btnLock.TabIndex = 7;
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnConversorEuro
            // 
            this.btnConversorEuro.Location = new System.Drawing.Point(150, 60);
            this.btnConversorEuro.Name = "btnConversorEuro";
            this.btnConversorEuro.Size = new System.Drawing.Size(41, 23);
            this.btnConversorEuro.TabIndex = 8;
            this.btnConversorEuro.Text = "->";
            this.btnConversorEuro.UseVisualStyleBackColor = true;
            this.btnConversorEuro.Click += new System.EventHandler(this.btnConversorEuro_Click);
            // 
            // btnConversorDolar
            // 
            this.btnConversorDolar.Location = new System.Drawing.Point(150, 89);
            this.btnConversorDolar.Name = "btnConversorDolar";
            this.btnConversorDolar.Size = new System.Drawing.Size(41, 23);
            this.btnConversorDolar.TabIndex = 9;
            this.btnConversorDolar.Text = "->";
            this.btnConversorDolar.UseVisualStyleBackColor = true;
            this.btnConversorDolar.Click += new System.EventHandler(this.btnConversorDolar_Click);
            // 
            // btnConversorPeso
            // 
            this.btnConversorPeso.Location = new System.Drawing.Point(150, 118);
            this.btnConversorPeso.Name = "btnConversorPeso";
            this.btnConversorPeso.Size = new System.Drawing.Size(41, 23);
            this.btnConversorPeso.TabIndex = 10;
            this.btnConversorPeso.Text = "->";
            this.btnConversorPeso.UseVisualStyleBackColor = true;
            this.btnConversorPeso.Click += new System.EventHandler(this.btnConversorPeso_Click);
            // 
            // txtEuroCantidad
            // 
            this.txtEuroCantidad.Location = new System.Drawing.Point(44, 60);
            this.txtEuroCantidad.Name = "txtEuroCantidad";
            this.txtEuroCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtEuroCantidad.TabIndex = 11;
            // 
            // txtDolarCantidad
            // 
            this.txtDolarCantidad.Location = new System.Drawing.Point(44, 89);
            this.txtDolarCantidad.Name = "txtDolarCantidad";
            this.txtDolarCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtDolarCantidad.TabIndex = 12;
            // 
            // txtPesoCantidad
            // 
            this.txtPesoCantidad.Location = new System.Drawing.Point(44, 118);
            this.txtPesoCantidad.Name = "txtPesoCantidad";
            this.txtPesoCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtPesoCantidad.TabIndex = 13;
            // 
            // txtResultadoEuroEuro
            // 
            this.txtResultadoEuroEuro.Enabled = false;
            this.txtResultadoEuroEuro.Location = new System.Drawing.Point(197, 60);
            this.txtResultadoEuroEuro.Name = "txtResultadoEuroEuro";
            this.txtResultadoEuroEuro.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoEuroEuro.TabIndex = 14;
            // 
            // txtResultadoDolarEuro
            // 
            this.txtResultadoDolarEuro.Enabled = false;
            this.txtResultadoDolarEuro.Location = new System.Drawing.Point(197, 89);
            this.txtResultadoDolarEuro.Name = "txtResultadoDolarEuro";
            this.txtResultadoDolarEuro.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoDolarEuro.TabIndex = 15;
            // 
            // txtResultadoPesoEuro
            // 
            this.txtResultadoPesoEuro.Enabled = false;
            this.txtResultadoPesoEuro.Location = new System.Drawing.Point(197, 118);
            this.txtResultadoPesoEuro.Name = "txtResultadoPesoEuro";
            this.txtResultadoPesoEuro.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoPesoEuro.TabIndex = 16;
            // 
            // txtResultadoEuroDolar
            // 
            this.txtResultadoEuroDolar.Enabled = false;
            this.txtResultadoEuroDolar.Location = new System.Drawing.Point(303, 60);
            this.txtResultadoEuroDolar.Name = "txtResultadoEuroDolar";
            this.txtResultadoEuroDolar.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoEuroDolar.TabIndex = 17;
            // 
            // txtResultadoDolarDolar
            // 
            this.txtResultadoDolarDolar.Enabled = false;
            this.txtResultadoDolarDolar.Location = new System.Drawing.Point(303, 89);
            this.txtResultadoDolarDolar.Name = "txtResultadoDolarDolar";
            this.txtResultadoDolarDolar.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoDolarDolar.TabIndex = 18;
            // 
            // txtResultadoPesoDolar
            // 
            this.txtResultadoPesoDolar.Enabled = false;
            this.txtResultadoPesoDolar.Location = new System.Drawing.Point(303, 118);
            this.txtResultadoPesoDolar.Name = "txtResultadoPesoDolar";
            this.txtResultadoPesoDolar.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoPesoDolar.TabIndex = 19;
            // 
            // txtResultadoEuroPeso
            // 
            this.txtResultadoEuroPeso.Enabled = false;
            this.txtResultadoEuroPeso.Location = new System.Drawing.Point(409, 59);
            this.txtResultadoEuroPeso.Name = "txtResultadoEuroPeso";
            this.txtResultadoEuroPeso.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoEuroPeso.TabIndex = 20;
            // 
            // txtResultadoDolarPeso
            // 
            this.txtResultadoDolarPeso.Enabled = false;
            this.txtResultadoDolarPeso.Location = new System.Drawing.Point(409, 88);
            this.txtResultadoDolarPeso.Name = "txtResultadoDolarPeso";
            this.txtResultadoDolarPeso.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoDolarPeso.TabIndex = 21;
            // 
            // txtResultadoPesoPeso
            // 
            this.txtResultadoPesoPeso.Enabled = false;
            this.txtResultadoPesoPeso.Location = new System.Drawing.Point(409, 117);
            this.txtResultadoPesoPeso.Name = "txtResultadoPesoPeso";
            this.txtResultadoPesoPeso.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoPesoPeso.TabIndex = 22;
            // 
            // txtEuroCotizacion
            // 
            this.txtEuroCotizacion.Location = new System.Drawing.Point(197, 12);
            this.txtEuroCotizacion.Name = "txtEuroCotizacion";
            this.txtEuroCotizacion.Size = new System.Drawing.Size(100, 23);
            this.txtEuroCotizacion.TabIndex = 23;
            // 
            // txtDolarCotizacion
            // 
            this.txtDolarCotizacion.Location = new System.Drawing.Point(303, 12);
            this.txtDolarCotizacion.Name = "txtDolarCotizacion";
            this.txtDolarCotizacion.Size = new System.Drawing.Size(100, 23);
            this.txtDolarCotizacion.TabIndex = 24;
            this.txtDolarCotizacion.TextChanged += new System.EventHandler(this.txtDolarCotizacion_TextChanged);
            // 
            // txtPesoCotizacion
            // 
            this.txtPesoCotizacion.Location = new System.Drawing.Point(409, 12);
            this.txtPesoCotizacion.Name = "txtPesoCotizacion";
            this.txtPesoCotizacion.Size = new System.Drawing.Size(100, 23);
            this.txtPesoCotizacion.TabIndex = 25;
            // 
            // frmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 158);
            this.Controls.Add(this.txtPesoCotizacion);
            this.Controls.Add(this.txtDolarCotizacion);
            this.Controls.Add(this.txtEuroCotizacion);
            this.Controls.Add(this.txtResultadoPesoPeso);
            this.Controls.Add(this.txtResultadoDolarPeso);
            this.Controls.Add(this.txtResultadoEuroPeso);
            this.Controls.Add(this.txtResultadoPesoDolar);
            this.Controls.Add(this.txtResultadoDolarDolar);
            this.Controls.Add(this.txtResultadoEuroDolar);
            this.Controls.Add(this.txtResultadoPesoEuro);
            this.Controls.Add(this.txtResultadoDolarEuro);
            this.Controls.Add(this.txtResultadoEuroEuro);
            this.Controls.Add(this.txtPesoCantidad);
            this.Controls.Add(this.txtDolarCantidad);
            this.Controls.Add(this.txtEuroCantidad);
            this.Controls.Add(this.btnConversorPeso);
            this.Controls.Add(this.btnConversorDolar);
            this.Controls.Add(this.btnConversorEuro);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.lblPesoFila);
            this.Controls.Add(this.lblDolarFila);
            this.Controls.Add(this.lblEuroFila);
            this.Controls.Add(this.lblPesoColumna);
            this.Controls.Add(this.lblDolarColumna);
            this.Controls.Add(this.lblEuroColumna);
            this.Controls.Add(this.lblCotizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.frmConversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label lblEuroColumna;
        private System.Windows.Forms.Label lblDolarColumna;
        private System.Windows.Forms.Label lblPesoColumna;
        private System.Windows.Forms.Label lblEuroFila;
        private System.Windows.Forms.Label lblDolarFila;
        private System.Windows.Forms.Label lblPesoFila;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnConversorEuro;
        private System.Windows.Forms.Button btnConversorDolar;
        private System.Windows.Forms.Button btnConversorPeso;
        private System.Windows.Forms.TextBox txtEuroCantidad;
        private System.Windows.Forms.TextBox txtDolarCantidad;
        private System.Windows.Forms.TextBox txtPesoCantidad;
        private System.Windows.Forms.TextBox txtResultadoEuroEuro;
        private System.Windows.Forms.TextBox txtResultadoDolarEuro;
        private System.Windows.Forms.TextBox txtResultadoPesoEuro;
        private System.Windows.Forms.TextBox txtResultadoEuroDolar;
        private System.Windows.Forms.TextBox txtResultadoDolarDolar;
        private System.Windows.Forms.TextBox txtResultadoPesoDolar;
        private System.Windows.Forms.TextBox txtResultadoEuroPeso;
        private System.Windows.Forms.TextBox txtResultadoDolarPeso;
        private System.Windows.Forms.TextBox txtResultadoPesoPeso;
        private System.Windows.Forms.TextBox txtEuroCotizacion;
        private System.Windows.Forms.TextBox txtDolarCotizacion;
        private System.Windows.Forms.TextBox txtPesoCotizacion;
    }
}

