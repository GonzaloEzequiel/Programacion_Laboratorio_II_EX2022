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
    public partial class FrmMostrar : Form
    {
        private Centralita centralitaPasada;
        private ETipoLlamada tipoLlamada;

        public ETipoLlamada TipoLlamada { set { tipoLlamada = value; } }

        public FrmMostrar(Centralita centralita, ETipoLlamada tipoLlamada)
        {
            InitializeComponent();
            this.centralitaPasada = centralita;
            this.TipoLlamada = tipoLlamada;
        }               

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = this.tipoLlamada.ToString();

            switch(this.tipoLlamada)
            {
                case ETipoLlamada.Local:
                    this.rchFacturacion.Text = $"Total Facturado Local : ${this.centralitaPasada.GananciasPorLocal}";  
                    break;
                case ETipoLlamada.Provincial:
                    this.rchFacturacion.Text = $"Total Facturado Provincial : ${this.centralitaPasada.GananciasPorProvincial}";
                    break;
                case ETipoLlamada.Todas:
                    this.rchFacturacion.Text = $"Total Facturado (Todas) : ${this.centralitaPasada.GananciasPorTotal}";
                    break;
                default:
                    break;
            }        
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
