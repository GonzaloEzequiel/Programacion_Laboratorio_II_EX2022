using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C06EI03
{
    public partial class FrmContador : Form
    {
        private Dictionary<string, int> diccionario;
        private List<string> auxLista;

        public FrmContador()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
            auxLista = new List<string>();
        }
    
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.ContarPalabras(rtbTexto.Text);
            MessageBox.Show($"Resultados:\n\n{this.Mostrar()}", "Conteo Completo");
        }

        public void ContarPalabras(string texto)
        {
            char[] separacion = new char[] { ' ', ',', '.', ':', '\t' };
            this.auxLista.AddRange(texto.Split(separacion, StringSplitOptions.RemoveEmptyEntries));

            foreach(string palabra in auxLista)
            {
                if (!this.diccionario.ContainsKey(palabra) && palabra is not " ")
                    this.diccionario.Add(palabra, 1);
                else
                    this.diccionario[palabra] += 1;
            }
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            for(int i=0; i<3; i++)
            {
                foreach (KeyValuePair<string, int> palabra in this.diccionario)
                {
                    if (diccionario.Values.Max() == palabra.Value)
                    {
                        retorno.AppendLine($"Palabra: \"{palabra.Key}\" --> Cantidad: {palabra.Value}");
                        this.diccionario.Remove(palabra.Key);
                        break;
                    }
                }
            }

            return retorno.ToString();
        }


    }
}
