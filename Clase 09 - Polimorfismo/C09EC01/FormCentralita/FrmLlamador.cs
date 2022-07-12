using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaCentralita;

namespace FormCentralita
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralitaPasada;
        private Random random;

        public FrmLlamador(Centralita unaCentralita)
        {
            InitializeComponent();

            this.centralitaPasada = unaCentralita;
            this.random = new Random();
        }

        public Centralita MostrarCentralita
        {
            get
            {
                return this.centralitaPasada;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.EFranja));
            // Lectura
            Provincial.EFranja franjas;
            Enum.TryParse<Provincial.EFranja>(cmbFranja.SelectedValue.ToString(), out franjas);            
        }

        #region CLICK EN PAD NUMERICO       

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "9";
        }
        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "*";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "0";
        }
        private void btnNumeral_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "#";
        }

        #endregion

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNroDestino.Text != String.Empty && this.txtNroDestino.Text[0] is not '#')
                this.cmbFranja.Enabled = false;
            else
                this.cmbFranja.Enabled = true;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            //genera duacion entre 1 y 50
            float duracion = random.Next(1, 50);
            
            //genera costo entre 0,5 y 5,6
            float costo;
            do
            {
                //         parte entera         parte decimal
                costo = random.Next(0, 5) + (float)random.NextDouble();

            } while (costo < 0.5 || costo > 5.6);

            Llamada llamada;



            if(this.txtNroDestino.Text.StartsWith('#'))
            {
                llamada = new Provincial(this.txtNroOrigen.Text, (Provincial.EFranja)this.cmbFranja.SelectedItem, duracion, this.txtNroDestino.Text);
            }
            else
            {
                llamada = new Local(this.txtNroOrigen.Text, duracion, this.txtNroDestino.Text, costo);
            }

            this.centralitaPasada += llamada;

            MessageBox.Show("Llamada realizada y registrada");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = String.Empty;
            this.txtNroOrigen.Text = String.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
