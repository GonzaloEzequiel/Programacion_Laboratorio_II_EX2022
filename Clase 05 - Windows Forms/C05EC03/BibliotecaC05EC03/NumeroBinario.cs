using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilbiotecaC04EC01
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string Numero
        {
            get
            {
                return this.numero;
            }
        }

        /// <summary>
        /// Suma una cantidad NumeroDecimal a un NumeroBinario, dando el resultado como NumeroBinario
        /// </summary>
        /// <param name="b">NumeroBinario</param>
        /// <param name="d">NumeroDecimal</param>
        /// <returns>resultado como NumeroBinario</returns>
        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            double auxDouble = Conversor.ConvertirBinarioADecimal(int.Parse(b.numero));

            auxDouble += d.Numero;

            return Conversor.ConvertirDecimalABinario(auxDouble);
        }

        /// <summary>
        /// Resta una cantidad NumeroDecimal a un NumeroBinario, dando el resultado como NumeroBinario
        /// </summary>
        /// <param name="b">NumeroBinario</param>
        /// <param name="d"NumeroDecimal></param>
        /// <returns>resultado como NumeroBinario</returns>
        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            double auxDouble = Conversor.ConvertirBinarioADecimal(int.Parse(b.numero));

            auxDouble -= d.Numero;

            return Conversor.ConvertirDecimalABinario(auxDouble);
        }

        /// <summary>
        /// Comprara si un NumeroBinario tiene el mismo valor que un NumeroDecimal
        /// </summary>
        /// <param name="b"></param>
        /// <param name="d"></param>
        /// <returns>TRUE si tienen el mismo valor, FALSE si no</returns>
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return Conversor.ConvertirBinarioADecimal(int.Parse(b.numero)) == d.Numero;
        }

        /// <summary>
        /// Comprara si un NumeroBinario NO tiene el mismo valor que un NumeroDecimal
        /// </summary>
        /// <param name="b"></param>
        /// <param name="d"></param>
        /// <returns>TRUE si NO tienen el mismo valor, FALSE si tienen el mismo valor</returns>
        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return Conversor.ConvertirBinarioADecimal(int.Parse(b.numero)) != d.Numero;
        }

        /// <summary>
        /// Crea un objeto NumeroBinario desde una cadena
        /// </summary>
        /// <param name="cadena">la instancia NumeroBinario con el valor si es correcto, la intancia NumeroBinario con valor 0 si es incorrecto</param>
        public static implicit operator NumeroBinario(string cadena)
        {
            bool binario = true;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] != '0' && cadena[i] != '1')
                {
                    binario = false;
                    break;
                }
            }

            if (binario)
                return new NumeroBinario(cadena);
            else
                return new NumeroBinario("0");
        }

        /// <summary>
        /// Retorna una cadena con el valor del NumeroBinario
        /// </summary>
        /// <param name="b">cadena</param>
        public static explicit operator string(NumeroBinario b)
        {
            return b.numero;
        }
    }
}
