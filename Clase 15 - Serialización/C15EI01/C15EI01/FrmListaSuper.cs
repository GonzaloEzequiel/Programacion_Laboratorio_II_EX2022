using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace C15EI01
{
    public partial class FrmListaSuper : Form
    {
        private static List<string> listaSupermercado;
        private static string ruta;
        private ToolTip toolTip;
        private FrmAltaModificacion frmAltaModificacion;

        static FrmListaSuper()
        {
            listaSupermercado = new List<string>();
            ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\listaSupermercado.xml"; //C:\Users\geppe\AppData\Roaming
        }

        public FrmListaSuper()
        {
            InitializeComponent();
            toolTip = new ToolTip();
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.btnAgregar, "Agregar objeto");
            toolTip.SetToolTip(this.btnEliminar, "Eliminar objeto");
            toolTip.SetToolTip(this.btnModificar, "Modificar objeto");

            if(File.Exists(ruta))
            {
                using(StreamReader streamReader = new StreamReader(ruta))
                {
                    try
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                        listaSupermercado = xmlSerializer.Deserialize(streamReader) as List<string>;
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Hubo un error", "Error?");
                    }
                }
            }

            this.RefrescarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaModificacion = new FrmAltaModificacion("Agregar objeto", string.Empty, "Agregar");
            frmAltaModificacion.ShowDialog();
            
            if(frmAltaModificacion.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(frmAltaModificacion.Objeto);
            }

            this.RefrescarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = lstObjetos.SelectedItem as string;

            if (objetoSeleccionado is not null)
            {
                listaSupermercado.Remove(objetoSeleccionado);
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un elemento de la lista", "Error");
            }

            this.RefrescarLista();
        }        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = lstObjetos.SelectedItem as string;

            if (objetoSeleccionado is not null)
            {
                frmAltaModificacion = new FrmAltaModificacion("Modificar  objeto", objetoSeleccionado, "Modificar");
                frmAltaModificacion.ShowDialog();

                if (frmAltaModificacion.DialogResult == DialogResult.OK)
                {
                    int indice = listaSupermercado.IndexOf(objetoSeleccionado);
                    listaSupermercado[indice] = frmAltaModificacion.Objeto;
                }
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un elemento de la lista", "Error");
            }

            RefrescarLista();
        }

        private void RefrescarLista()
        {
            //this.lstObjetos.Items.Clear();
            //foreach (string item in this.listaSupermercado)
            //    this.lstObjetos.Items.Add(item);

            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaSupermercado;

            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                    xmlSerializer.Serialize(streamWriter, listaSupermercado);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo otro error", "Error??");
                }
            }
        }
    }
}
