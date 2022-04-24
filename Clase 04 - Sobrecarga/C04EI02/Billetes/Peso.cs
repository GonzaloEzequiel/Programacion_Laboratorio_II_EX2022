using System;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Peso()
        {
            cotzRespectoDolar = 102.65;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        /// <summary>
        /// Muestra la cantidad de Peso
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
        /// Convierte a Dolar una cantidad de Peso, según la cotización
        /// </summary>
        /// <param name="d">La cantidad de Dolar equivalente</param>
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.GetCantidad() / Peso.GetCotizacion());
        }

        /// <summary>
        /// Convierte a Euro una cantidad de Peso, según la cotización
        /// </summary>
        /// <param name="d">La cantidad de Euro equivalente</param>
        public static explicit operator Euro(Peso p)
        {
            return new Euro(p.cantidad / Peso.GetCotizacion() * Euro.GetCotizacion());
        }

        /// <summary>
        /// Crea una nueva instancia de Peso según la cantidad ingresada
        /// </summary>
        /// <param name="d">La nueva instancia</param>
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        /// <summary>
        /// Indica si la cantidad de Peso es equivalente, o no, a su valor en Dolar
        /// </summary>
        /// <param name="p">instancia de Peso</param>
        /// <param name="d">instancia de Dolar</param>
        /// <returns>TRUE si NO es equivalente, FALSE si lo es</returns>
        public static bool operator !=(Peso p, Dolar d)
        {
            return p.GetCantidad() * Peso.GetCotizacion() != d.GetCantidad();
        }

        /// <summary>
        /// Indica si la cantidad de Peso es equivalente, o no, a su valor en Euro
        /// </summary>
        /// <param name="p">instancia de Peso</param>
        /// <param name="e">instancia de Euro</param>
        /// <returns>TRUE si NO es equivalente, FALSE si lo es</returns>
        public static bool operator !=(Peso p, Euro e)
        {
            return p.GetCantidad() != e.GetCantidad() / Euro.GetCotizacion() * Peso.GetCotizacion();
        }

        /// <summary>
        /// Indica si las cantidades de dos instancias Peso son o no equivalentes
        /// </summary>
        /// <param name="p1">1er instancia de Peso</param>
        /// <param name="p2">2da instancia de Peso</param>
        /// <returns>TRUE si NO son equivalente, FALSE si lo son</returns>
        public static bool operator !=(Peso p1, Peso p2)
        {
            return p1.GetCantidad() != p2.GetCantidad();
        }

        /// <summary>
        /// Resta el equivalente en Dolar a una cantidad en Peso
        /// </summary>
        /// <param name="p">Instancia de Peso</param>
        /// <param name="d">Instancia de Dolar</param>
        /// <returns>una nueva instancia con el valor final en Euro</returns>
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad * Peso.GetCotizacion() - d.GetCantidad());
        }

        /// <summary>
        /// Resta el equivalente en Euro a una cantidad en Peso
        /// </summary>
        /// <param name="p">Instancia de Peso</param>
        /// <param name="e">Instancia de Euro</param>
        /// <returns>una nueva instancia con el valor final en Euro</returns>
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad - e.GetCantidad() / Euro.GetCotizacion() * Peso.GetCotizacion());
        }

        /// <summary>
        /// Suma el equivalente en Dolar a una cantidad en Peso
        /// </summary>
        /// <param name="p">Instancia de Peso</param>
        /// <param name="d">Instancia de Dolar</param>
        /// <returns>una nueva instancia con el valor final en Euro</returns>
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad * Peso.GetCotizacion() + d.GetCantidad());
        }

        /// <summary>
        /// Suma el equivalente en Euro a una cantidad en Peso
        /// </summary>
        /// <param name="p">Instancia de Peso</param>
        /// <param name="e">Instancia de Euro</param>
        /// <returns>una nueva instancia con el valor final en Euro</returns>
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.cantidad + e.GetCantidad() / Euro.GetCotizacion() * Peso.GetCotizacion());
        }

        /// <summary>
        /// Indica si la cantidad de Peso es equivalente, o no, a su valor en Dolar
        /// </summary>
        /// <param name="e">instancia de Euro</param>
        /// <param name="d">instancia de Dolar</param>
        /// <returns>TRUE si es equivalente, FALSE si no lo es</returns>
        public static bool operator ==(Peso p, Dolar d)
        {
            return p.GetCantidad() * Peso.GetCotizacion() == d.GetCantidad();
        }

        /// <summary>
        /// Indica si la cantidad de Peso es equivalente, o no, a su valor en Euro
        /// </summary>
        /// <param name="e">instancia de Euro</param>
        /// <param name="p">instancia de Peso</param>
        /// <returns>TRUE si es equivalente, FALSE si no lo es</returns>
        public static bool operator ==(Peso p, Euro e)
        {
            return p.GetCantidad() == e.GetCantidad()/ Euro.GetCotizacion() * Peso.GetCotizacion()  ;
        }

        /// <summary>
        /// Indica si las cantidades de dos instancias Peso son o no equivalentes
        /// </summary>
        /// <param name="p1">1er instancia de Peso</param>
        /// <param name="p2">2da instancia de Peso</param>
        /// <returns>TRUE si son equivalente, FALSE si no lo es</returns>
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }
    }
}
