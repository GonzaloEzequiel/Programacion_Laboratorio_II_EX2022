using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public class Local : Llamada, IGuardar<string>
    {
        protected float costo;

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {

        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public override float CostoLlamada { get { return this.CalcularCosto(); } }




        public string RutaDeArchivo
        {
            get { return ""; }
            set { string none = value; }
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public string Leer(string ruta)
        {
            throw new NotImplementedException();
        }




        /// <summary>
        /// Retorna el valor de la llamada a partir de la duración y el costo de la misma.
        /// </summary>
        /// <returns>El valor de la llamada local</returns>
        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Compara el objeto dado con su tipo, verificando que sea del tipo Local
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>TRUE si el objeto que recibe es de tipo Local</returns>
        public override bool Equals(object obj)
        {
            return obj.GetType().Name == "Local";
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

        /// <summary>
        /// Reutiliza el código del método Mostrar
        /// </summary>
        /// <returns>Todos los datos de una llamada local</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
