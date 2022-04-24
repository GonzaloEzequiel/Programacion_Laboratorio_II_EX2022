using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05EI02
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            this.lstbPais.Items.Add("Argentina");
            this.lstbPais.Items.Add("Uruguay");
            this.lstbPais.Items.Add("Chile");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine($"Nombre: {this.txbNombre.Text}");
            info.AppendLine($"Direccion: {this.txbDireccion.Text}");
            info.AppendLine($"Edad: {this.nudEdad.Value}");
            info.AppendLine($"Género: {this.grbGenero.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text}");
            info.AppendLine($"País: {this.lstbPais.SelectedItem}");
            info.AppendLine($"Curso/s:");

            foreach(CheckBox box in grbCursos.Controls.OfType<CheckBox>())
            {
                if (box.Checked == true)
                    info.AppendLine(box.Text);
            }

            MessageBox.Show($"{info.ToString()}");
        }

        private void FrmRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult salir = MessageBox.Show("¿Desea salir?", "Cierre", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (salir != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
    }
}
