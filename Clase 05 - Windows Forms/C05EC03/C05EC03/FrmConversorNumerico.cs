using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilbiotecaC04EC01;

namespace C05EC03
{
    public partial class FrmConversorNumerico : Form
    {
        NumeroBinario auxBinario;
        NumeroDecimal auxDecimal;
        double auxDouble;

        public FrmConversorNumerico()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtBinarioCantidad.Text, out auxDouble))
            {
                auxBinario = (NumeroBinario)auxDouble.ToString();

                this.txtResultadoDec.Text = Conversor.ConvertirBinarioADecimal(double.Parse(auxBinario.Numero)).ToString();
            }
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtDecimalCantidad.Text, out auxDouble))
            {
                auxDecimal = (NumeroDecimal)auxDouble;

                this.txtResultadoBin.Text = Conversor.ConvertirDecimalABinario(auxDecimal.Numero).ToString();
            }
        }
    }
}
