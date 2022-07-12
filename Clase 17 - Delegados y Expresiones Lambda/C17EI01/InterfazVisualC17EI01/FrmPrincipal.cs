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
    public partial class FrmPrincipal : Form
    {
        private FrmTestDelegados frmTestDelegados;
        private FrmMostrar frmMostrar;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.frmMostrar = new FrmMostrar();
            this.frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {            
            this.frmMostrar.MdiParent = this;            
            this.frmTestDelegados.MdiParent = this;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmMostrar.Show();
        }
        
    }
}
