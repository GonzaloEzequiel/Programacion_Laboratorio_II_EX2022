/*
 *  Ejercicio I01 - Máximo, mínimo y promedio
 *  
 *  Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
 *  
 */

using System;

namespace C01EI01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string numeroString;

            int acumulador = 0;
            int max = 0;
            int min = 0;
            double promedio;

            for (int i = 0; i < 5; i++)
            {
                //ingreso del numero por parte del user
                Console.WriteLine($"Ingrese el {i + 1}° numero: ");
                numeroString = Console.ReadLine();

                //validacion del dato ingresado
                while (!int.TryParse(numeroString, out numeroIngresado))
                {
                    Console.WriteLine($"Error! Reingrse el {i + 1}° numero: ");
                    numeroString = Console.ReadLine();
                }

                //la primer iteracion el numero ingresado es min y max
                if (i == 0)
                {
                    max = numeroIngresado;
                    min = numeroIngresado;
                }
                else if (numeroIngresado > max)
                {
                    max = numeroIngresado;
                }
                else if (numeroIngresado < min)
                {
                    min = numeroIngresado;
                }

                acumulador += numeroIngresado;
            }

            promedio = acumulador / 5;

            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"Máximo: {max}");
            Console.WriteLine($"Mínimo: {min}");
            Console.WriteLine($"Promedio: {promedio}");
        }
    }
}
