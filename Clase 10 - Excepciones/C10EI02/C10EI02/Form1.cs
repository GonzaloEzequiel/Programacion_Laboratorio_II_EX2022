using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcepcionesC10EI02;

namespace C10EI02
{
    public partial class FrmCalculador : Form
    {
        public FrmCalculador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int auxInt1;
            int auxInt2;
            float resultado;            

            try
            {
                if (txtKilometros.Text == "" || txtLitros.Text == "")
                {
                    throw new ParametrosVaciosException();
                }

                auxInt1 = int.Parse(txtKilometros.Text);
                auxInt2 = int.Parse(txtLitros.Text);
                resultado = Calculador.Calcular(auxInt1, auxInt2);
                this.richTextBox1.Text = $"Rendimiento: {resultado} Kilómetros por Litro";
            }
            catch(ParametrosVaciosException)
            {
                MessageBox.Show("Imposible de calcular, falta ingresar un dato");
            }
            catch(FormatException)
            {
                MessageBox.Show("Imposible de calcular, datos incorrectos");
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Imposible de calcular, no se puede dividir por cero");
            }
            catch(Exception)
            {
                MessageBox.Show("ESTE MENSAJE NUNCA DEBERIA APARECER :D");
            }
        }
    }
}
