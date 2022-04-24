using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        /// <summary>
        /// Muestra la cantidad de Euro
        /// </summary>
        /// <returns>La cantidad</returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }

        /// <summary>
        /// Muestra la cotización respecto al Dolar
        /// </summary>
        /// <returns>la cotización</returns>
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static void SetCotizacion(double value)
        {
            cotzRespectoDolar = value;
        }

        /// <summary>
        /// Convierte a Dolar una cantidad de Euro, según la cotización
        /// </summary>
        /// <param name="d">La cantidad de Dolar equivalente</param>
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.GetCotizacion());
        }

        /// <summary>
        /// Convierte a Pesos una cantidad de Euro, según la cotización
        /// </summary>
        /// <param name="d">La cantidad de Pesos equivalente</param>
        public static explicit operator Peso(Euro e)
        {
            return new Peso(e.cantidad / Euro.GetCotizacion() * Peso.GetCotizacion());
        }

        /// <summary>
        /// Crea una nueva instancia de Euro según la cantidad ingresada
        /// </summary>
        /// <param name="d">La nueva instancia</param>
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        /// <summary>
        /// Indica si la cantidad de Euro es equivalente, o no, a su valor en Dolar
        /// </summary>
        /// <param name="d">instancia de Dolar</param>
        /// <param name="e">instancia de Euro</param>
        /// <returns>TRUE si NO es equivalente, FALSE si lo es</returns>
        public static bool operator !=(Euro e, Dolar d)
        {
            return e.GetCantidad() * Euro.GetCotizacion() != d.GetCantidad() ;
        }

        /// <summary>
        /// Indica si la cantidad de Euro es equivalente, o no, a su valor en Peso
        /// </summary>
        /// <param name="d">instancia de Dolar</param>
        /// <param name="e">instancia de Peso</param>
        /// <returns>TRUE si NO es equivalente, FALSE si lo es</returns>
        public static bool operator !=(Euro e, Peso p)
        {
            return e.GetCantidad() / Euro.GetCotizacion() != p.GetCantidad() * Peso.GetCotizacion();
        }

        /// <summary>
        /// Indica si las cantidades de dos instancias Euro son o no equivalentes
        /// </summary>
        /// <param name="e1">1er instancia de Euro</param>
        /// <param name="e2">2da instancia de Euro</param>
        /// <returns>TRUE si NO son equivalente, FALSE si lo son</returns>
        public static bool operator !=(Euro e1, Euro e2)
        {
            return e1.GetCantidad() != e2.GetCantidad();
        }

        /// <summary>
        /// Resta el equivalente en Dolar a una cantidad en Euro
        /// </summary>
        /// <param name="e">Instancia de Euro</param>
        /// <param name="d">Instancia de Dolar</param>
        /// <returns>una nueva instancia con el valor final en Euro</returns>
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad * Euro.GetCotizacion() - d.GetCantidad());
        }

        /// <summary>
        /// Resta el equivalente en Peso a una cantidad en Euro
        /// </summary>
        /// <param name="e">Instancia de Euro</param>
        /// <param name="p">Instancia de Peso</param>
        /// <returns>una nueva instancia con el valor final en Euro</returns>
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.cantidad / Euro.GetCotizacion() * Peso.GetCotizacion() - p.GetCantidad());
        }

        /// <summary>
        /// Suma el equivalente en Dolar a una cantidad en Euro
        /// </summary>
        /// <param name="e">Instancia de Euro</param>
        /// <param name="d">Instancia de Dolar</param>
        /// <returns>una nueva instancia con el valor final en Euro</returns>
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad * Euro.GetCotizacion() + e.GetCantidad());
        }

        /// <summary>
        /// Suma el equivalente en Peso a una cantidad en Euro
        /// </summary>
        /// <param name="e">Instancia de Euro</param>
        /// <param name="p">Instancia de Peso</param>
        /// <returns>una nueva instancia con el valor final en Euro</returns>
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.cantidad / Euro.GetCotizacion() * Peso.GetCotizacion() + p.GetCantidad());
        }

        /// <summary>
        /// Indica si la cantidad de Euro es equivalente, o no, a su valor en Dolar
        /// </summary>
        /// <param name="e">instancia de Euro</param>
        /// <param name="d">instancia de Dolar</param>
        /// <returns>TRUE si es equivalente, FALSE si no lo es</returns>
        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetCantidad() * Euro.GetCotizacion() == d.GetCantidad();
        }

        /// <summary>
        /// Indica si la cantidad de Euro es equivalente, o no, a su valor en Peso
        /// </summary>
        /// <param name="e">instancia de Euro</param>
        /// <param name="p">instancia de Peso</param>
        /// <returns>TRUE si es equivalente, FALSE si no lo es</returns>
        public static bool operator ==(Euro e, Peso p)
        {
            return e.GetCantidad() / Euro.GetCotizacion() * Peso.GetCotizacion() == p.GetCantidad() ;
        }

        /// <summary>
        /// Indica si las cantidades de dos instancias Euro son o no equivalentes
        /// </summary>
        /// <param name="e1">1er instancia de Euro</param>
        /// <param name="e2">2da instancia de Euro</param>
        /// <returns>TRUE si son equivalente, FALSE si no lo es</returns>
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
    }
}
