using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC04EA01
{
    public class Celsius
    {
        private double cantidad;

        public Celsius(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region CREACION DE OBJETO CELSIUS IMPLICITO DESDE DOUBLE, EXPLICITO DESDE OTROS TIPOS
        /// <summary>
        /// Crea una nueva instancia de objeto tipo Celsius con el valor 'd' por cantidad
        /// </summary>
        /// <param name="d">Double cantidad de grados</param>
        public static implicit operator Celsius(double d)
        {
            return new Celsius(d);
        }

        /// <summary>
        /// Convierte una temperatura °C a °F
        /// </summary>
        /// <param name="c">objeto °C</param>
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.cantidad * 9 / 5 + 32);
        }

        /// <summary>
        /// Convierte una temperatura °C a °K
        /// </summary>
        /// <param name="c">objeto °C</param>
        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin((((Fahrenheit)c).GetCantidad() + 459.67) * 5/9);
        }
        #endregion

        #region OPERACIONES SUMA Y RESTA DE OBJETO CELSIUS CON VALOR DOUBLE
        /// <summary>
        /// Suma una cantidad double de grados a los grados C
        /// </summary>
        /// <param name="c">Objetio tipo Celsius</param>
        /// <param name="d">Double cantidad de gragos</param>
        /// <returns>El objeto C con la cantidad de grados sumada</returns>
        public static Celsius operator +(Celsius c, double d)
        {
            return new Celsius(c.cantidad + d);
            //return c.cantidad + d;
        }

        /// <summary>
        /// Resta una cantidad double de grados a los grados C
        /// </summary>
        /// <param name="c">Objetio tipo Celsius</param>
        /// <param name="d">Double cantidad de gragos</param>
        /// <returns>El objeto C con la cantidad de grados restada</returns>
        public static Celsius operator -(Celsius c, double d)
        {
            return new Celsius(c.cantidad - d);
            //return c.cantidad - d;
        }
        #endregion

        #region OPERACIONES OBJETO CELSIUS CON OTROS OBJETOS

        #region OPERACIONES CON OBJETOS CELSIUS
        /// <summary>
        /// Suma las temperaturas de dos objetos Celsius
        /// </summary>
        /// <param name="c1">Primer objeto Celsius</param>
        /// <param name="c2">Segundo objeto Celsius</param>
        /// <returns>Un nuevo objeto Celsius con el valor de temperatura igual al resultado de la suma</returns>
        public static Celsius operator +(Celsius c1, Celsius c2)
        {
            return new Celsius(c1.cantidad + c2.cantidad);
        }

        /// <summary>
        /// Resta las temperaturas de dos objetos Celsius
        /// </summary>
        /// <param name="c1">Primer objeto Celsius</param>
        /// <param name="c2">egundo objeto Celsius</param>
        /// <returns>Un nuevo objeto Celsius con el valor de temperatura igual al resultado de la resta</returns>
        public static Celsius operator -(Celsius c1, Celsius c2)
        {
            return new Celsius(c1.cantidad - c2.cantidad);
        }

        /// <summary>
        /// Comprara si dos objetos Celsius son equivalentes en temperatura
        /// </summary>
        /// <param name="c1">Primer objeto Celsius</param>
        /// <param name="c2">egundo objeto Celsius</param>
        /// <returns>TRUE si ambas temperaturas son iguales, FALSE si no</returns>
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.cantidad == c2.cantidad;
        }

        /// <summary>
        /// Comprara si dos objetos Celsius son equivalentes en temperatura
        /// </summary>
        /// <param name="c1">Primer objeto Celsius</param>
        /// <param name="c2">egundo objeto Celsius</param>
        /// <returns>FALSE si ambas temperaturas son iguales, TRUE si no</returns>
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }
        #endregion

        #region OPERACIONES CON OBJETOS FAHRENHEIT
        /// <summary>
        /// Suma la temperatura de un objeto F al objeto C
        /// </summary>
        /// <param name="c">Objeto Celsius</param>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <returns>Un nuevo objeto Celsius con el valor de temperatura igual al resultado de la suma</returns>
        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.cantidad + ((Celsius)f).cantidad);
        }

        /// <summary>
        /// Resta la temperatura de un objeto F al objeto C
        /// </summary>
        /// <param name="c">Objeto Celsius</param>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <returns>Un nuevo objeto Celsius con el valor de temperatura igual al resultado de la resta</returns>
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.cantidad - ((Celsius)f).cantidad);
        }

        /// <summary>
        /// Comprara si un objeto Celsisus y un objeto Fahrenheit son equivalentes en temperatura
        /// </summary>
        /// <param name="c">Objeto Celsius</param>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <returns>TRUE si ambas temperaturas son iguales, FALSE si no</returns>
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return c.cantidad == ((Celsius)f).cantidad;
        }

        /// <summary>
        /// Comprara si un objeto Celsisus y un objeto Fahrenheit son equivalentes en temperatura
        /// </summary>
        /// <param name="c">Objeto Celsius</param>
        /// <param name="f">Objeto Fahrenheit</param>
        /// <returns>FALSE si ambas temperaturas son iguales, TRUE si no</returns>
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c==f);
        }
        #endregion

        #region OPERACIONES CON OBJETOS KELVIN
        /// <summary>
        /// Suma la temperatura de un objeto K al objeto C
        /// </summary>
        /// <param name="c">Objeto Celsius</param>
        /// <param name="k">Objeto Kelvin</param>
        /// <returns>Un nuevo objeto Celsius con el valor de temperatura igual al resultado de la suma</returns>
        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.cantidad + ((Celsius)k).cantidad);
        }

        /// <summary>
        /// Resta la temperatura de un objeto K al objeto C
        /// </summary>
        /// <param name="c">Objeto Celsius</param>
        /// <param name="k">Objeto Kelvin</param>
        /// <returns>Un nuevo objeto Celsius con el valor de temperatura igual al resultado de la resta</returns>
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(c.cantidad - ((Celsius)k).cantidad);
        }

        /// <summary>
        /// Comprara si un objeto Celsisus y un objeto Kelvin son equivalentes en temperatura
        /// </summary>
        /// <param name="c">Objeto Celsius</param>
        /// <param name="k">Objeto Kelvin</param>
        /// <returns>TRUE si ambas temperaturas son iguales, FALSE si no</returns>
        public static bool operator ==(Celsius c, Kelvin  k)
        {
            return c.cantidad == ((Celsius)k).cantidad;
        }

        /// <summary>
        /// Comprara si un objeto Celsisus y un objeto Kelvin son equivalentes en temperatura
        /// </summary>
        /// <param name="c">Objeto Celsius</param>
        /// <param name="k">Objeto Kelvin</param>
        /// <returns>FALSE si ambas temperaturas son iguales, TRUE si no</returns>
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c==k);
        }
        #endregion

        #endregion

    }
}
