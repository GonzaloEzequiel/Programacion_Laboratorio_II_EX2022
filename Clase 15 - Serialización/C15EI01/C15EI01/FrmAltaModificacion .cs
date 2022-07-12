using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C15EI01
{
    public partial class FrmAltaModificacion : Form
    {
        public string Objeto { get { return this.txtObjeto.Text; } }

        public FrmAltaModificacion(string titulo, string textoObjeto, string textoBoton)
        {
            InitializeComponent();
            this.Text = titulo;
            this.txtObjeto.Text = textoObjeto;
            this.btnConfirmar.Text = textoBoton;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Confirmar();
            }
            else if(e.KeyChar == 27)
            {
                Cancelar();
            }
        }

        // ---------------  Metodos (DRY) ---------------//

        public void Confirmar()
        {
            //string retorno = string.Empty;

            if(!string.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                DialogResult = DialogResult.OK;
                this.Close();
                //retorno = this.txtObjeto.Text;
            }
            else
            {
                MessageBox.Show("No se ingresaron datos", "Error");
            }

            //return retorno;
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
