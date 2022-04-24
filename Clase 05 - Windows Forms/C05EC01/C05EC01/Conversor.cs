using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace C05EC01
{
    public partial class frmConversor : Form
    {
        private bool candado;
        double auxDouble;
        Dolar auxDolar;
        Euro auxEuro;
        Peso auxPeso;

        public frmConversor()
        {
            InitializeComponent();
        }

        private void frmConversor_Load(object sender, EventArgs e)
        {
            this.candado = false;
            this.txtDolarCotizacion.Text = "1";
            this.txtEuroCotizacion.Text = Euro.GetCotizacion().ToString();
            this.txtPesoCotizacion.Text = Peso.GetCotizacion().ToString();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if(!candado)
            {
                candado = true;
                this.txtDolarCotizacion.Enabled = false;
                this.txtEuroCotizacion.Enabled = false;
                this.txtPesoCotizacion.Enabled = false;
                btnLock.Image = System.Drawing.Image.FromFile(@"..\..\..\..\resources\CandadoCerrado26x26.png");
            }
            else
            {
                candado = false;
                this.txtDolarCotizacion.Enabled = true;
                this.txtEuroCotizacion.Enabled = true;
                this.txtPesoCotizacion.Enabled = true;
                btnLock.Image = System.Drawing.Image.FromFile(@"..\..\..\..\resources\CandadoAbierto26x26.png");
            }
        }

        private void btnConversorEuro_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtEuroCotizacion.Text, out auxDouble))
                Euro.SetCotizacion(auxDouble);

            if (double.TryParse(this.txtEuroCantidad.Text, out auxDouble))
            {

                auxEuro = new Euro(double.Parse(this.txtEuroCantidad.Text));

                this.txtResultadoEuroEuro.Text = auxEuro.GetCantidad().ToString();
                this.txtResultadoEuroDolar.Text = ((Dolar)auxEuro).GetCantidad().ToString();
                this.txtResultadoEuroPeso.Text = ((Peso)auxEuro).GetCantidad().ToString();
            }            
        }

        private void btnConversorDolar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtDolarCantidad.Text, out auxDouble))
            {
                auxDolar = new Dolar(double.Parse(this.txtDolarCantidad.Text));

                this.txtResultadoDolarDolar.Text = auxDolar.GetCantidad().ToString();
                this.txtResultadoDolarEuro.Text = ((Euro)auxDolar).GetCantidad().ToString();
                this.txtResultadoDolarPeso.Text = ((Peso)auxDolar).GetCantidad().ToString();
            }            
        }

        private void btnConversorPeso_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtPesoCotizacion.Text, out auxDouble))
                Peso.SetCotizacion(auxDouble);

            if (double.TryParse(this.txtPesoCantidad.Text, out auxDouble))
            {
                auxPeso = new Peso(double.Parse(this.txtPesoCantidad.Text));

                this.txtResultadoPesoPeso.Text = auxPeso.GetCantidad().ToString();
                this.txtResultadoPesoEuro.Text = ((Euro)auxPeso).GetCantidad().ToString();
                this.txtResultadoPesoDolar.Text = ((Dolar)auxPeso).GetCantidad().ToString();
            }
        }

        /// <summary>
        /// NO SE COMO IMPLEMENTAR EL EVENTO LOSTFOCUS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDolarCotizacion_TextChanged(object sender, EventArgs e)
        {
            this.txtDolarCotizacion.Text = "1";
        }
    }
}
