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
    public partial class FormSaludo : Form
    {
        public FormSaludo(string titulo, string mensaje)
        {
            InitializeComponent();

            this.labelSaludo.Text = titulo.Trim();
            this.labelNombreSaludo.Text = mensaje.Trim();
        }
    }
}
