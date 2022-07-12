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

namespace InterfazVisualC14EI03
{
    public partial class FrmNotepad : Form
    {
        private OpenFileDialog abrir;
        private SaveFileDialog guardar;
        private string ultimoArchivo;

        private string UltimoArchivo
        {
            get { return ultimoArchivo; }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    ultimoArchivo = value;
                }    
            }
        }

        public FrmNotepad()
        {
            InitializeComponent();
            abrir = new OpenFileDialog();
            guardar = new SaveFileDialog();
            guardar.Filter = "Archivo de texto|.txt";
            ultimoArchivo = string.Empty;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = $"{this.richTextBox1.TextLength} caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ultimoArchivo = abrir.FileName;
                    using StreamReader streamReader = new StreamReader(ultimoArchivo);
                    richTextBox1.Text = streamReader.ReadToEnd();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UltimoArchivo = SeleccionarUbicacionGuardado();

            GuardarArchivo(UltimoArchivo);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(UltimoArchivo))
            {
                UltimoArchivo = SeleccionarUbicacionGuardado();
            }

            GuardarArchivo(UltimoArchivo);
        }

        private string SeleccionarUbicacionGuardado()
        {
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                return guardar.FileName;
            }

            return string.Empty;
        }

        private void GuardarArchivo(string ruta)
        {
            using StreamWriter sw = new StreamWriter(ultimoArchivo);

            try
            {
                if (!string.IsNullOrWhiteSpace(ruta))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
