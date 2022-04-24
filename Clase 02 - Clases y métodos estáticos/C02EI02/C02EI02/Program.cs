/*
 *  Ejercicio I02 - ¿Desea continuar?
 *  
 *  Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
 *  Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
 *  El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 * 
 */

using System;
using BibliotecaC02EI02;

namespace C02EI02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acumulador = 0;

            string auxString;
            char auxChar;
            int i=1;

            do
            {
                //solicitud y validacion de ingreso de dato por parte del user
                Console.Write($"Ingrese número {i}: ");
                auxString = Console.ReadLine();
                while (!int.TryParse(auxString, out numeroIngresado))
                {
                    Console.Write($"Error! Reingrese número {i}: ");
                    auxString = Console.ReadLine();
                }

                //se suma al total en cada iteración, el numero ingresado por el usuario
                acumulador += numeroIngresado;
                i++;

                Console.Write("¿Desea Continuar? S/N ");
                auxChar = Console.ReadLine().ToUpper()[0];

                Console.WriteLine();

            } while(Validador.ValidarRespuesta(auxChar));

            Console.Clear();
            Console.Write($"El total sumado es {acumulador}");
        }
    }
}
