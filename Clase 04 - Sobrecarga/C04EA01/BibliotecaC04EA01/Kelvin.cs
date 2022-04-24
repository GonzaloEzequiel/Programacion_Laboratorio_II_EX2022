using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC04EA01
{
    public class Kelvin
    {
        private double cantidad;

        public Kelvin(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region CREACION DE OBJETO KELVIN IMPLICITO DESDE DOUBLE, EXPLICITO DESDE OTROS TIPOS
        /// <summary>
        /// Crea una nueva instancia de objeto tipo Kelvin con el valor 'd' por cantidad
        /// </summary>
        /// <param name="d">Double cantidad de grados</param>
        public static implicit operator Kelvin(double d)
        {
            return new Kelvin(d);
        }

        /// <summary>
        /// Convierte una temperatura °K a °F
        /// </summary>
        /// <param name="c">objeto °K</param>
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(k.cantidad * 9 / 5 - 459.67);
        }

        /// <summary>
        /// Convierte una temperatura °K a °C
        /// </summary>
        /// <param name="c">objeto °K</param>
        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius((((Fahrenheit)k).GetCantidad() - 32) * 5 / 9);
        }
        #endregion

        #region OPERACIONES SUMA Y RESTA DE OBJETO KELVIN CON VALOR DOUBLE
        /// <summary>
        /// Suma una cantidad double de grados a los grados K
        /// </summary>
        /// <param name="k">Objetio tipo Kelvin</param>
        /// <param name="d">Double cantidad de gragos</param>
        /// <returns>El objeto C con la cantidad de grados sumada</returns>
        public static double operator +(Kelvin k, double d)
        {
            return k.cantidad + d;
        }

        /// <summary>
        /// Resta una cantidad double de grados a los grados K
        /// </summary>
        /// <param name="k">Objetio tipo Kelvin</param>
        /// <param name="d">Double cantidad de gragos</param>
        /// <returns>El objeto C con la cantidad de grados Restada</returns>
        public static double operator -(Kelvin k, double d)
        {
            return k.cantidad - d;
        }
        #endregion

        #region OPERACIONES OBJETO KELVIN CON OTROS OBJETOS

        #region OPERACIONES CON OBJETOS KELVIN
        /// <summary>
        /// Suma las temperaturas de dos objetos Kelvin
        /// </summary>
        /// <param name="k1">Primer objeto Kelvin</param>
        /// <param name="k2">Segundo objeto Kelvin</param>
        /// <returns>Un nuevo objeto Kelvin con el valor de temperatura igual al resultado de la suma</returns>
        public static Kelvin operator +(Kelvin k1, Kelvin k2)
        {
            return new Kelvin(k1.cantidad + k2.cantidad);
        }

        /// <summary>
        /// Resta las temperaturas de dos objetos Kelvin
        /// </summary>
        /// <param name="k1">Primer objeto Kelvin</param>
        /// <param name="k2">Segundo objeto Kelvin</param>
        /// <returns>Un nuevo objeto Kelvin con el valor de temperatura igual al resultado de la resta</returns>
        public static Kelvin operator -(Kelvin k1, Kelvin k2)
        {
            return new Kelvin(k1.cantidad - k2.cantidad);
        }

        /// <summary>
        /// Comprara si dos objetos Kelvin son equivalentes en temperatura
        /// </summary>
        /// <param name="k1">Primer objeto Kelvin</param>
        /// <param name="k2">Segundo objeto Kelvin</param>
        /// <returns>TRUE si ambas temperaturas son iguales, FALSE si no</returns>
        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return k1.cantidad == k2.cantidad;
        }

        /// <summary>
        /// Comprara si dos objetos Kelvin son equivalentes en temperatura
        /// </summary>
        /// <param name="k1">Primer objeto Kelvin</param>
        /// <param name="k2">Segundo objeto Kelvin</param>
        /// <returns>FALSE si ambas temperaturas son iguales, TRUE si no</returns>
        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1==k2);
        }
        #endregion

        #region OPERACIONES CON OBJETOS CELSIUS
        /// <summary>
        /// Suma la temperatura de un objeto C al objeto K
        /// </summary>
        /// <param name="k">Objeto Kelvin</param>
        /// <param name="c">Objeto Celsius</param>
        /// <returns>Un nuevo objeto Kelvin con el valor de temperatura igual al resultado de la suma</returns>
        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.cantidad + ((Kelvin)c).cantidad);
        }

        /// <summary>
        /// Resta la temperatura de un objeto C al objeto K
        /// </summary>
        /// <param name="k">Objeto Kelvin</param>
        /// <param name="c">Objeto Celsius</param>
        /// <returns>n nuevo objeto Kelvin con el valor de temperatura igual al resultado de la resta</returns>
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.cantidad - ((Kelvin)c).cantidad);
        }

        /// <summary>
        /// Comprara si un objeto Kelvin y un objeto Celsius son equivalentes en temperatura
        /// </summary>
        /// <param name="k">Objeto Kelvin</param>
        /// <param name="c">Objeto Celsius</param>
        /// <returns>TRUE si ambas temperaturas son iguales, FALSE si no</returns>
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return k.cantidad == ((Kelvin)c).cantidad;
        }

        /// <summary>
        /// Comprara si un objeto Kelvin y un objeto Celsius son equivalentes en temperatura
        /// </summary>
        /// <param name="k">Objeto Kelvin</param>
        /// <param name="c">Objeto Celsius</param>
        /// <returns>FALSE si ambas temperaturas son iguales, TRUE si no</returns>
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k==c);
        }
        #endregion

        #region OPERACIONES CON OBJETOS FAHRENHEIT
        /// <summary>
        /// Suma la temperatura de un objeto F al objeto K
        /// </summary>
        /// <param name="k">Objeto Kelvin</param>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <returns>Un nuevo Kelvin Celsius con el valor de temperatura igual al resultado de la suma</returns>
        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.cantidad + ((Kelvin)f).cantidad);
        }

        /// <summary>
        /// Resta la temperatura de un objeto F al objeto K
        /// </summary>
        /// <param name="k">Objeto Kelvin</param>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <returns>Un nuevo Kelvin Celsius con el valor de temperatura igual al resultado de la Resta</returns>
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.cantidad - ((Kelvin)f).cantidad);
        }

        /// <summary>
        /// Comprara si un objeto Kelvin y un objeto Fahrenheit son equivalentes en temperatura
        /// </summary>
        /// <param name="k">Objeto Kelvin</param>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <returns>TRUE si ambas temperaturas son iguales, FALSE si no</returns>
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.cantidad == ((Kelvin)f).cantidad;
        }

        /// <summary>
        /// Comprara si un objeto Kelvin y un objeto Fahrenheit son equivalentes en temperatura
        /// </summary>
        /// <param name="k">Objeto Kelvin</param>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <returns>FALSE si ambas temperaturas son iguales, TRUE si no</returns>
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k==f);
        }
        #endregion

        #endregion
    }
}
