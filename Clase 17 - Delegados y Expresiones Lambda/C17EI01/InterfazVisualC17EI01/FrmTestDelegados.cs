using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C17EI01
{
    public partial class FrmTestDelegados : Form
    {
        private ActualizarNombreDelegate actualizador;

        public delegate void ActualizarNombreDelegate(string nombre);

        public FrmTestDelegados(ActualizarNombreDelegate delegado)
        {
            InitializeComponent();
            actualizador = delegado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.actualizador.Invoke(this.txtNombre.Text);
        }
    }
}
