using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaC04EA01;

namespace C05EC02
{
    public partial class FrmConversor : Form
    {
        double auxDouble;
        Fahrenheit auxFahrenheit;
        Celsius auxCelsius;
        Kelvin auxKelvin;

        public FrmConversor()
        {
            InitializeComponent();
        }

        private void btnConversorFahrenheit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtFahrenheitCantidad.Text, out auxDouble))
            {
                auxFahrenheit = new Fahrenheit(double.Parse(this.txtFahrenheitCantidad.Text));

                this.txtFaF.Text = auxFahrenheit.GetCantidad().ToString();
                this.txtFaC.Text = ((Celsius)auxFahrenheit).GetCantidad().ToString();
                this.txtFaK.Text = ((Kelvin)auxFahrenheit).GetCantidad().ToString();
            }
        }

        private void btnConversorCelsius_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtCelsiusCantidad.Text, out auxDouble))
            {
                auxCelsius = new Celsius(double.Parse(this.txtCelsiusCantidad.Text));

                this.txtCaC.Text = auxCelsius.GetCantidad().ToString();
                this.txtCaF.Text = ((Fahrenheit)auxCelsius).GetCantidad().ToString();
                this.txtCaK.Text = ((Kelvin)auxCelsius).GetCantidad().ToString();
            }
        }

        private void btnConversorKelvin_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtKelvinCantidad.Text, out auxDouble))
            {
                auxKelvin = new Kelvin(double.Parse(this.txtKelvinCantidad.Text));

                this.txtKaK.Text = auxKelvin.GetCantidad().ToString();
                this.txtKaC.Text = ((Celsius)auxKelvin).GetCantidad().ToString();
                this.txtKaF.Text = ((Fahrenheit)auxKelvin).GetCantidad().ToString();
            }
        }
    }
}
