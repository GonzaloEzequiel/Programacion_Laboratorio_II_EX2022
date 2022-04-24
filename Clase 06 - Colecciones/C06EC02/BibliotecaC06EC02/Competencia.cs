using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC06EC02
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        /// <summary>
        /// Muestra todos los datos de todos los autos de la competencia
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            foreach (AutoF1 auto in this.competidores)
                retorno.AppendLine(auto.MostrarDatos());

            return retorno.ToString();
        }

        //public static bool operator -(Competencia c, AutoF1 a)
        //{

        //}

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c.competidores.Count < c.cantidadCompetidores && c!=a)
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadDeCombustible = (short)new Random().Next(15, 100);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que un auto ya se encuentre en la competencia
        /// </summary>
        /// <param name="c">Objeto Competencia</param>
        /// <param name="a">Objeto Auto</param>
        /// <returns>TRUE si se encuentra, FALSE si no</returns>
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
                if (auto == a)
                    return true;

            return false;
        }

        /// <summary>
        /// Verifica que un auto NO se encuentre en la competencia
        /// </summary>
        /// <param name="c">Objeto Competencia</param>
        /// <param name="a">Objeto Auto</param>
        /// <returns>FALSE si se encuentra, TRUE si no</returns>
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
