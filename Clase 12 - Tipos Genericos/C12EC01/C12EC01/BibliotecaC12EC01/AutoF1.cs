using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC12EC01
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }

        /// <summary>
        /// Muestra todos los datos de un AutoF1
        /// </summary>
        /// <returns>todos los datos</returns>
        public override string MostrarDatos()
        {
            return $"{base.MostrarDatos()} | Caballos de Fuera: {this.CaballosDeFuerza}";
        }

        /// <summary>
        /// Compara dos autos de F1 y verifica si son iguales (sólo si los atributos número y escuderia son iguales)
        /// </summary>
        /// <param name="a1">Primer Auto</param>
        /// <param name="a2">Segundo Auto</param>
        /// <returns>TRUE si son iguales, FALSE si no</returns>
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return ((VehiculoDeCarrera)a1 == a2) && a1.CaballosDeFuerza == a2.CaballosDeFuerza;
        }

        /// <summary>
        /// Compara dos autos de F1 y verifica si NO son iguales (sólo si los atributos número y escuderia son iguales)
        /// </summary>
        /// <param name="a1">Primer Auto</param>
        /// <param name="a2">Segundo Auto</param>
        /// <returns>FALSE si son iguales, TRUE si no</returns>
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
