using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilbiotecaC04EC01
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double Numero
        {
            get
            {
                return this.numero;
            }
        }

        /// <summary>
        /// Suma una cantidad NumeroBinario a un NumeroDecimal, dando el resultado como NumeroDecimal
        /// </summary>
        /// <param name="d">NumeroDecimal</param>
        /// <param name="b">NumeroBinario</param>
        /// <returns>resultado como NumeroBinario</returns>
        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            return d.numero + Conversor.ConvertirBinarioADecimal(int.Parse(b.Numero));
        }

        /// <summary>
        /// Resta una cantidad NumeroBinario a un NumeroDecimal, dando el resultado como NumeroDecimal
        /// </summary>
        /// <param name="d"NumeroDecimal></param>
        /// <param name="b">NumeroBinario</param>
        /// <returns>resultado como NumeroDecimal</returns>
        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            return d.numero - Conversor.ConvertirBinarioADecimal(int.Parse(b.Numero));
        }

        /// <summary>
        /// Comprara si un NumeroDecimal tiene el mismo valor que un NumeroBinario
        /// </summary>
        /// <param name="d"></param>
        /// <param name="b"></param>
        /// <returns>TRUE si tienen el mismo valor, FALSE si no</returns>
        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            return d.numero == Conversor.ConvertirBinarioADecimal(int.Parse(b.Numero));
        }

        /// <summary>
        /// Comprara si un NumeroDecimal NO tiene el mismo valor que un NumeroBinario
        /// </summary>
        /// <param name="d"></param>
        /// <param name="b"></param>
        /// <returns>TRUE si NO tienen el mismo valor, FALSE si tienen el mismo valor</returns>
        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return d.numero != Conversor.ConvertirBinarioADecimal(int.Parse(b.Numero));
        }

        /// <summary>
        /// Crea un objeto NumeroDecimal desde una double
        /// </summary>
        /// <param name="numero">el nuevo objeto NumeroDecimal</param>
        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        /// <summary>
        /// Retorna un double con el valor del NumeroDecimal
        /// </summary>
        /// <param name="b">valor numerico</param>
        public static explicit operator double(NumeroDecimal d)
        {
            return d.numero;
        }
    
    }
}
