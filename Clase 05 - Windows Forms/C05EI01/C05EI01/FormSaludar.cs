using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05EI01
{
    public partial class FormSaludar : Form
    {
        public FormSaludar()
        {
            InitializeComponent();
        }       

        private void FormDatos_Load(object sender, EventArgs e)
        {
            this.cmbMateriaFavorita.Items.Add("Programación II");
            this.cmbMateriaFavorita.Items.Add("Laboratorio II");
            this.cmbMateriaFavorita.SelectedIndex = 0;
        }

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtNombre.Text) && !string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                FormSaludo frm = new FormSaludo("¡Hola Windows Forms!", $"Soy {this.txtNombre.Text} {this.txtApellido.Text}, y mi materia favorita es {this.cmbMateriaFavorita.SelectedItem}");
                frm.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(this.txtNombre.Text) && !string.IsNullOrWhiteSpace(this.txtApellido.Text) )
                MessageBox.Show("Se debe completar los siguientes campos: \nNombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(this.txtApellido.Text) && !string.IsNullOrWhiteSpace(this.txtNombre.Text))
                MessageBox.Show("Se debe completar los siguientes campos: \nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Se debe completar los siguientes campos: \nNombre \nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
