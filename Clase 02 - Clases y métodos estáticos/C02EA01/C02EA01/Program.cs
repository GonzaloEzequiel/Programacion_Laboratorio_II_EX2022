/*
 *  Ejercicio A01 - Calcular un factorial
 *  
 *  El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros positivos que estén debajo de él
 *  por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.
 *  En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
 * 
 */

using System;
using BibliotecaC02EA01;

namespace C02EA01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero;
            double resultado;

            string auxSting;

            Console.WriteLine("** CALCULADOR DE FACTORIAL **");

            Console.Write("Ingrese un numero entero: ");
            auxSting = Console.ReadLine();
            Program.ValidarEntero(auxSting, out numeroEntero);

            resultado = CalculadorFactorial.CalcularFactorial(numeroEntero);

            Console.WriteLine($"El factorial de {numeroEntero} ({numeroEntero}!) es: {resultado}");
        }

        /// <summary>
        /// Valida que el usuario ingrese un valor correcto, convirtiendo una cadena en entero
        /// </summary>
        /// <param name="entrada">string cadena a convertir</param>
        /// <param name="salida">int variable donde se almacena la conversion</param>
        static void ValidarEntero(string entrada, out int entero)
        {
            while (!int.TryParse(entrada, out entero))
            {
                Console.Write("Error! Ingrese un número entero: ");
            }
        }
    }
}
