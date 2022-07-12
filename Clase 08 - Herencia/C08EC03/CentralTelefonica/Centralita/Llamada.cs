using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public enum ETipoLlamada
    {
        Local,
        Provincial,
        Todas
    }

    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion { get { return this.duracion; } }

        public string NroDestino { get { return this.nroDestino; } }

        public string NroOrigen { get { return this.nroOrigen; } }

        /// <summary>
        /// Retorna todos los datos de la llamada como texto
        /// </summary>
        /// <returns>Los datos de la instancia llamada</returns>
        protected virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Número de origen: {this.NroOrigen}");
            retorno.AppendLine($"Número de destino: {this.NroDestino}");
            retorno.AppendLine($"Duración de llamada: {this.Duracion} minutos");
            retorno.AppendLine($"---------------------------------------------------------");

            return retorno.ToString();
        }        

        /// <summary>
        /// Se utiliza para ordenar una lista de llamadas de forma ascendente.
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns></returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)    //??
        {
            return (int)(llamada2.Duracion - llamada1.duracion);
        }
    }
}
