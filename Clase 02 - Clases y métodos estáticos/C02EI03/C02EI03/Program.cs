/*
 *  Ejercicio I03 - Conversor binario
 *  
 *  Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):
 *  El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario:
 *      public string ConvertirDecimalABinario(int numeroEntero) {}
 *      
 *  El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.
 *      public int ConvertirBinarioADecimal(int numeroEntero) {}
 *      
 *      IMPORTANTE: NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
 *  
 */

using System;
using BibliotecaC02EI03;

namespace C02EI03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDecimal = 141;
            int numeroBinario = 100110;

            Console.WriteLine("ESTO ES UNA PRUEBA");

            Console.WriteLine($"Numero Decimal: {numeroDecimal} es {Conversor.ConvertirDecimalABinario(numeroDecimal)} en binario!");
            Console.WriteLine($"Numero Binario: {numeroBinario} es {Conversor.ConvertirBinarioADecimal(numeroBinario)} en decimal!");


        }
    }
}
