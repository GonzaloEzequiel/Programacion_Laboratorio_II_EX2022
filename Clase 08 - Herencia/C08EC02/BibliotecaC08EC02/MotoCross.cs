using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC08EC02
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada 
        { 
            get { return this.cilindrada; }
        }

        /// <summary>
        /// Muestra todos los datos de una MotoCross
        /// </summary>
        /// <returns>todos los datos</returns>
        public override string MostrarDatos()
        {
            return $"{base.MostrarDatos()} | Cilindrada: {this.Cilindrada}";
        }

        /// <summary>
        /// Comprueba que dos objetos Motocross sean iguales, según su escuderia y numero (VehiculoDeCarrera) y su cilindrada
        /// </summary>
        /// <param name="a1">Primer Objeto MotoCross</param>
        /// <param name="a2">Segundo Objeto MotoCross</param>
        /// <returns>TRUE si ambos MotoCross son el mismo, FALSE si no lo son</returns>
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return ((VehiculoDeCarrera)a1 == a2) && a1.Cilindrada==a2.Cilindrada;
        }

        /// <summary>
        /// Comprueba que dos objetos Motocross NO sean iguales, según su escuderia y numero (VehiculoDeCarrera) y su cilindrada
        /// </summary>
        /// <param name="a1">Primer Objeto MotoCross</param>
        /// <param name="a2">Segundo Objeto MotoCross</param>
        /// <returns>FALSE si ambos MotoCross son el mismo, TRUE si no lo son</returns>
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
