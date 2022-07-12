using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaCentralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal { get { return this.CalcularGanancia(ETipoLlamada.Local); } }

        public float GananciasPorProvincial { get { return this.CalcularGanancia(ETipoLlamada.Provincial); } }

        public float GananciasPorTotal { get { return this.CalcularGanancia(ETipoLlamada.Todas); } }

        public List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(ETipoLlamada tipo)
        {
            float acumuladorLocal = 0;
            float acumuladorProvincial = 0;
            float acumuladorTodas = 0;

            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                {
                    acumuladorLocal += ((Local)llamada).CostoLlamada;
                    acumuladorTodas += ((Local)llamada).CostoLlamada;
                }
                else
                {
                    acumuladorProvincial += ((Provincial)llamada).CostoLlamada;
                    acumuladorTodas += ((Provincial)llamada).CostoLlamada;
                }               
            }

            switch (tipo)
            {
                case ETipoLlamada.Local:
                    return acumuladorLocal;
                case ETipoLlamada.Provincial:
                    return acumuladorProvincial;
                case ETipoLlamada.Todas:
                    return acumuladorTodas;
                default:
                    return -1;
            }
        }

        /// <summary>
        /// Expone la razón social, la ganancia total, ganancia por llamados locales y provinciales y el detalle de las llamadas realizadas.
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Razon Social: {this.razonSocial}");
            retorno.AppendLine($"Ganancias por llamadas locales: ${this.GananciasPorLocal}");
            retorno.AppendLine($"Ganancias por llamadas provinciales: ${this.GananciasPorProvincial}");
            retorno.AppendLine($"Ganancias totales: ${this.GananciasPorTotal}");

            return retorno.ToString();
        }        

        /// <summary>
        /// 
        /// </summary>
        public void OrdenarLlamadas()
        {
            //foreach(Llamada llamada in this.Llamadas)
            //{
            //    foreach(Ll)
            //}
        }
    }
}
