using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {

        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        /// <summary>
        /// Retorna como texto todos los datos de la clase base y agrega el costo de la llamada.
        /// </summary>
        /// <returns>Todos los datos de una llamada local</returns>
        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.Mostrar());
            retorno.AppendLine($"Costo de llamada: ${this.CostoLlamada}");

            return retorno.ToString();
        }
    }
}
