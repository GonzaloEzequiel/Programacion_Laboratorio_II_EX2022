using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC12EC01
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase { get { return this.nombreClase; } }
        public string NombreMetodo { get { return this.nombreMetodo; } }

        //public CompetenciaNoDisponibleException() : base() { }
        //public CompetenciaNoDisponibleException(string mensaje) : base(mensaje) { }
        //public CompetenciaNoDisponibleException(string mensaje, Exception inner) : base(mensaje, inner) { }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
        {

        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Excepción en el método {0} de la clase {1}:\n", this.NombreMetodo, this.nombreClase);
            retorno.AppendLine(this.Message);
            retorno.AppendLine($"{this.InnerException}\t");

            return retorno.ToString();
        }
    }
}
