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

        public abstract float CostoLlamada { get; }

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
        /// Compara dos llamadas, segun su tipo, su número de destino y número de origen
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns>TRUE si las llamadas son distintas, FALSE si son iguales</returns>
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        /// <summary>
        /// Compara dos llamadas, segun su tipo, su número de destino y número de origen
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns>TRUE si las llamadas son iguales, FALSE si son distintas</returns>
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1 is not null &&
                l2 is not null &&
                l1.Equals(l2) && 
                l1.nroDestino == l2.nroDestino && 
                l1.nroOrigen == l2.nroOrigen;
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
