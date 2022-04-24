using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public class Provincial : Llamada
    {
        public enum EFranja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected EFranja franjaHoraria;

        public Provincial(EFranja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {

        }

        public Provincial(string origen, EFranja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        /// <summary>
        /// Retorna el valor de la llamada a partir de la duración y el costo de la misma
        /// </summary>
        /// <returns>El valor de la llamada, según la duracion y la franja horaria</returns>
        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case EFranja.Franja_1:
                    return base.Duracion * 0.99f;
                case EFranja.Franja_2:
                    return base.Duracion * 1.25f;
                case EFranja.Franja_3:
                    return base.Duracion * 0.66f;
                default:
                    return -1;
            }
        }

        /// <summary>
        /// Compara el objeto dado con su tipo, verificando que sea del tipo Provincial
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>TRUE si el objeto que recibe es de tipo Local</returns>
        public override bool Equals(object obj)
        {
            return obj.GetType().Name == "Provincial";
        }

        /// <summary>
        /// Retorna como texto todos los datos de la clase base y agrega el costo de la llamada y la franja horaria
        /// </summary>
        /// <returns>Todos los datos de una llamada provincial</returns>
        protected string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.Mostrar());
            retorno.AppendLine($"Costo de llamada: ${this.CostoLlamada}");
            retorno.AppendLine($"Franja horaria: {this.franjaHoraria}");

            return retorno.ToString();
        }

        /// <summary>
        /// Reutiliza el código del método Mostrar
        /// </summary>
        /// <returns>Todos los datos de una llamada provincial</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
