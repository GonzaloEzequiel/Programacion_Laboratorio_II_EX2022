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


    }
}
