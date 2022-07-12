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
    public partial class FrmMenu : Form
    {
        private Centralita centralita;
        private FrmMostrar facturacion;

        public FrmMenu()
        {
            InitializeComponent();

            this.centralita = new Centralita("CentralitaComun");
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(centralita);
            llamador.ShowDialog();            
        }        

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            this.facturacion = new FrmMostrar(centralita, ETipoLlamada.Todas);
            this.facturacion.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            this.facturacion = new FrmMostrar(centralita, ETipoLlamada.Local);
            this.facturacion.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            this.facturacion = new FrmMostrar(centralita, ETipoLlamada.Provincial);
            this.facturacion.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
