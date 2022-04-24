using System;

namespace BibliotecaC04EA01
{
    public class Fahrenheit
    {
        private double cantidad;

        public Fahrenheit(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region CREACION DE OBJETO FAHRENHEIT IMPLICITO DESDE DOUBLE, EXPLICITO DESDE OTROS TIPOS
        /// <summary>
        /// Crea una nueva instancia de objeto tipo Fahrenheit con el valor 'd' por cantidad
        /// </summary>
        /// <param name="d">Double cantidad de grados</param>
        public static implicit operator Fahrenheit(double d)
        {
            return new Fahrenheit(d);
        }

        /// <summary>
        /// Convierte una temperatura °F a °C
        /// </summary>
        /// <param name="f">objeto °F</param>
        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius(f.cantidad - 32 * 5 / 9);
        }

        /// <summary>
        /// Convierte una temperatura °F a °K
        /// </summary>
        /// <param name="f">objeto °F</param>
        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.cantidad + 459.67) * 5 / 9);
        }
        #endregion

        #region OPERACIONES SUMA Y RESTA DE OBJETO FAHRENHEIT CON VALOR DOUBLE
        /// <summary>
        /// Suma una cantidad double de grados a los grados F
        /// </summary>
        /// <param name="f">Objetio tipo Fahrenheit</param>
        /// <param name="d">Double cantidad de gragos</param>
        /// <returns>El objeto F con la cantidad de grados sumada</returns>
        public static double operator +(Fahrenheit f, double d)
        {
            return f.cantidad + d;
        }

        /// <summary>
        /// Resta una cantidad double de grados a los grados F
        /// </summary>
        /// <param name="k">Objetio tipo Fahrenheit</param>
        /// <param name="d">Double cantidad de gragos</param>
        /// <returns>El objeto F con la cantidad de grados Restada</returns>
        public static double operator -(Fahrenheit f, double d)
        {
            return f.cantidad - d;
        }
        #endregion

        #region OPERACIONES OBJETO FAHRENHEIT CON OTROS OBJETOS

        #region OPERACIONES CON OBJETOS FAHRENHEIT
        /// <summary>
        /// Suma las temperaturas de dos objetos Fahrenheit
        /// </summary>
        /// <param name="f1">Primer objeto Fahrenheit</param>
        /// <param name="f2">Segundo objeto Fahrenheit</param>
        /// <returns>Un nuevo objeto Fahrenheit con el valor de temperatura igual al resultado de la suma</returns>
        public static Fahrenheit operator +(Fahrenheit f1, Fahrenheit f2)
        {
            return new Fahrenheit(f1.cantidad + f2.cantidad);
        }

        /// <summary>
        /// Resta las temperaturas de dos objetos Fahrenheit
        /// </summary>
        /// <param name="f1">Primer objeto Fahrenheit</param>
        /// <param name="f2">Segundo objeto Fahrenheit</param>
        /// <returns>Un nuevo objeto Fahrenheit con el valor de temperatura igual al resultado de la resta</returns>
        public static Fahrenheit operator -(Fahrenheit f1, Fahrenheit f2)
        {
            return new Fahrenheit(f1.cantidad - f2.cantidad);
        }

        /// <summary>
        /// Comprara si dos objetos Fahrenheit son equivalentes en temperatura
        /// </summary>
        /// <param name="f1">Primer objeto Fahrenheit</param>
        /// <param name="f2">Segundo objeto Fahrenheit</param>
        /// <returns>TRUE si ambas temperaturas son iguales, FALSE si no</returns>
        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.cantidad == f2.cantidad;
        }

        /// <summary>
        /// Comprara si dos objetos Fahrenheit son equivalentes en temperatura
        /// </summary>
        /// <param name="f1">Primer objeto Fahrenheit</param>
        /// <param name="f2">Segundo objeto Fahrenheit</param>
        /// <returns>FALSE si ambas temperaturas son iguales, TRUE si no</returns>
        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1==f2);
        }
        #endregion

        #region OPERACIONES CON OBJETOS CELSIUS
        /// <summary>
        /// Suma la temperatura de un objeto C al objeto F
        /// </summary>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <param name="c">Objeto Celsius</param>
        /// <returns>Un nuevo objeto Fahrenheit con el valor de temperatura igual al resultado de la suma</returns>
        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.cantidad + ((Fahrenheit)c).cantidad);
        }

        /// <summary>
        /// Resta la temperatura de un objeto C al objeto F
        /// </summary>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <param name="c">Objeto Celsius</param>
        /// <returns>n nuevo objeto Fahrenheit con el valor de temperatura igual al resultado de la resta</returns>
        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.cantidad - ((Fahrenheit)c).cantidad);
        }

        /// <summary>
        /// Comprara si un objeto Fahrenheit y un objeto Celsius son equivalentes en temperatura
        /// </summary>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <param name="c">Objeto Celsius</param>
        /// <returns>TRUE si ambas temperaturas son iguales, FALSE si no</returns>
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return f.cantidad == ((Fahrenheit)c).cantidad;
        }

        /// <summary>
        /// Comprara si un objeto Fahrenheit y un objeto Celsius son equivalentes en temperatura
        /// </summary>
        /// <param name="f">Objeto Kelvin</param>
        /// <param name="c">Objeto Celsius</param>
        /// <returns>FALSE si ambas temperaturas son iguales, TRUE si no</returns>
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f==c);
        }
        #endregion

        #region OPERACIONES CON OBJETOS KELVIN
        /// <summary>
        /// Suma la temperatura de un objeto K al objeto F
        /// </summary>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <param name="k">Objeto Kelvin</param>
        /// <returns>Un nuevo objeto Fahrenheit con el valor de temperatura igual al resultado de la suma</returns>
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.cantidad + ((Fahrenheit)k).cantidad);
        }

        /// <summary>
        /// Resta temperatura de un objeto K al objeto F
        /// </summary>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <param name="k">Objeto Kelvin</param>
        /// <returns>Un nuevo objeto Fahrenheit con el valor de temperatura igual al resultado de la resta</returns>
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.cantidad - ((Fahrenheit)k).cantidad);
        }

        /// <summary>
        /// Comprara si un objeto Fahrenheit y un objeto Kelvin son equivalentes en temperatura
        /// </summary>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <param name="k">Objeto Kelvin</param>
        /// <returns>TRUE si ambas temperaturas son iguales, FALSE si no</returns>
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return f.cantidad == ((Fahrenheit)k).cantidad;
        }

        /// <summary>
        /// Comprara si un objeto Fahrenheit y un objeto Kelvin son equivalentes en temperatura
        /// </summary>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <param name="k">Objeto Kelvin</param>
        /// <returns>FALSE si ambas temperaturas son iguales, TRUE si no</returns>
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f==k);
        }
        #endregion

        #endregion
    }
}
