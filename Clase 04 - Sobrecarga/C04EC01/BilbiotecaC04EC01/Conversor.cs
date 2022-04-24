using System;
using System.Text;

namespace BilbiotecaC04EC01
{
    public class Conversor
    {
        /// <summary>
        /// Convierte un número decimal a un número binario
        /// </summary>
        /// <param name="numeroEntero">int numero decimal a convertir</param>
        /// <returns>string retorna el número decimal converitdo a binario como una cadena</returns>
        public static string ConvertirDecimalABinario(double numeroEntero)
        {
            double[] numeroBinario = new double[50];
            int i = 0;

            do
            {
                //almacena en el array de enteros, los restos de dividir constantemente el numeroEntero en 2. Esto resulta en tener invertido lo indices del numero binario.
                numeroBinario[i] = numeroEntero % 2;                                       
                numeroEntero /= 2;
                i++;

            } while (numeroEntero > 0);

            StringBuilder reordenamiento = new StringBuilder();

            //se itera la misma cantidad de veces que en el paso anterior, reordenando (de atras hacia adelante) el array de enteros para mostrarlo como cadena
            for (int j = i - 1; j >= 0; j--)
            {
                reordenamiento.Append(numeroBinario[j]);
            }

            return reordenamiento.ToString();
        }

        /// <summary>
        /// Valida que el número sea binario, y lo convierte a decimal
        /// </summary>
        /// <param name="numeroEntero">número a convertir a decimal</param>
        /// <returns>int el número convertido si OK; -1 si el número ingresado no era binario</returns>
        public static double ConvertirBinarioADecimal(int numeroEntero)
        {
            double auxdouble = -1;
            string auxString = numeroEntero.ToString();

            bool esBinario = true;

            for (int i = 0; i < auxString.Length; i++)
            {
                if (auxString[i] != '0' && auxString[i] != '1')
                {
                    esBinario = false;
                    break;
                }
            }

            if (esBinario)
            {
                // Investigando hallé que este método posee una sobrecarga(n°19/19) la cual permite pasar un string a entero especificando la base
                //
                // int Covert.ToInt32(string? vale, int fromBase)
                // "Converts the string representation of a number in a specified base to an equivalent 32-bit signed integer."
                //
                // La implementaría de la siguiente forma:
                // return (Convert.ToInt32(binario, 2)).ToString();
                //
                // Sin embargo opté por usar la siguiente forma que deduje, siguiendo los pasos lógicos de la operación, aunque admito no tiene el mejor aspecto!!
                for (int index = (auxString.Length - 1); index >= 0; index--)
                {
                    auxdouble += int.Parse((auxString[index].ToString())) * (int)Math.Pow(2, ((auxString.Length - 1) - index));
                }
            }

            return auxdouble;
        }
    }
}
