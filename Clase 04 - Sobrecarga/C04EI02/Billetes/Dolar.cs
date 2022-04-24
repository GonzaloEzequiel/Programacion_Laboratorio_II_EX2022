using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Muestra la cantidad de Dolar
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

        /// <summary>
        /// Convierte a Euro una cantidad de Dolar, según la cotización
        /// </summary>
        /// <param name="d">La cantidad de Euro equivalente</param>
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        /// <summary>
        /// Convierte a Pesos una cantidad de Dolar, según la cotización
        /// </summary>
        /// <param name="d">La cantidad de Pesos equivalente</param>
        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * Peso.GetCotizacion());
        }

        /// <summary>
        /// Crea una nueva instancia de Dolar según la cantidad ingresada
        /// </summary>
        /// <param name="d">La nueva instancia</param>
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        /// <summary>
        /// Indica si la cantidad de Dolar es equivalente, o no, a su valor en Euro
        /// </summary>
        /// <param name="d">instancia de Dolar</param>
        /// <param name="e">instancia de Euro</param>
        /// <returns>TRUE si NO es equivalente, FALSE si lo es</returns>
        public static bool operator !=(Dolar d, Euro e)
        {
            return d.GetCantidad() != e.GetCantidad() * Euro.GetCotizacion();
        }

        /// <summary>
        /// Indica si la cantidad de Dolar es equivalente, o no, a su valor en Peso
        /// </summary>
        /// <param name="d">instancia de Dolar</param>
        /// <param name="p">instancia de Peso</param>
        /// <returns>TRUE si NO es equivalente, FALSE si lo es</returns>
        public static bool operator !=(Dolar d, Peso p)
        {
            return d.GetCantidad() != p.GetCantidad() * Peso.GetCotizacion();
        }

        /// <summary>
        /// Indica si las cantidades de dos instancias Dolar son o no equivalentes
        /// </summary>
        /// <param name="d1">1er instancia de Dolar</param>
        /// <param name="d2">2da instancia de Dolar</param>
        /// <returns>TRUE si NO son equivalente, FALSE si lo son</returns>
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() != d2.GetCantidad();
        }

        /// <summary>
        /// Resta el equivalente en Euro a una cantidad en Dolar
        /// </summary>
        /// <param name="d">Instancia de Dolar</param>
        /// <param name="e">Instancia de Euro</param>
        /// <returns>una nueva instancia con el valor final en Dolar</returns>
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - (e.GetCantidad() * Euro.GetCotizacion()));
        }

        /// <summary>
        /// Resta el equivalente en Peso a una cantidad en Dolar
        /// </summary>
        /// <param name="d">Instancia de Dolar</param>
        /// <param name="p">Instancia de Peso</param>
        /// <returns>una nueva instancia con el valor final en Dolar</returns>
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad - (p.GetCantidad() * Peso.GetCotizacion()));
        }

        /// <summary>
        /// Suma el equivalente en Euro a una cantidad en Dolar
        /// </summary>
        /// <param name="d">Instancia de Dolar</param>
        /// <param name="e">Instancia de Euro</param>
        /// <returns>una nueva instancia con el valor final en Dolar</returns>
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + (e.GetCantidad() * Euro.GetCotizacion()));
        }

        /// <summary>
        /// Suma el equivalente en Peso a una cantidad en Dolar
        /// </summary>
        /// <param name="d">Instancia de Dolar</param>
        /// <param name="p">Instancia de Peso</param>
        /// <returns>una nueva instancia con el valor final en Dolar</returns>
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad + (p.GetCantidad() * Peso.GetCotizacion()));
        }

        /// <summary>
        /// Indica si la cantidad de Dolar es equivalente, o no, a su valor en Euro
        /// </summary>
        /// <param name="d">instancia de Dolar</param>
        /// <param name="e">instancia de Euro</param>
        /// <returns>TRUE si es equivalente, FALSE si no lo es</returns>
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.GetCantidad() == e.GetCantidad() * Euro.GetCotizacion();
        }

        /// <summary>
        /// Indica si la cantidad de Dolar es equivalente, o no, a su valor en Peso
        /// </summary>
        /// <param name="d">instancia de Dolar</param>
        /// <param name="p">instancia de Peso</param>
        /// <returns>TRUE si es equivalente, FALSE si no lo es</returns>
        public static bool operator ==(Dolar d, Peso p)
        {
            return d.GetCantidad() == p.GetCantidad() * Peso.GetCotizacion();
        }

        /// <summary>
        /// Indica si las cantidades de dos instancias Dolar son o no equivalentes
        /// </summary>
        /// <param name="d1">1er instancia de Dolar</param>
        /// <param name="d2">2da instancia de Dolar</param>
        /// <returns>TRUE si son equivalente, FALSE si no lo es</returns>
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }
    }
}
