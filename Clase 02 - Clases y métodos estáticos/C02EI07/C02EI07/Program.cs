/*
 *  Ejercicio I07 - Pitágoras estaría orgulloso
 * 
 *  Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.
 *  El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
 *  Mostrar el resultado en la consola.
 * 
 */

using System;
using BibliotecaC02EI07;

namespace C02EI07
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, resultado;

            string auxString;

            Console.WriteLine("** CALCULADORA DE HIPOTENUSA **");
            
            Console.Write("Ingrese primer lado en cm: ");
            auxString = Console.ReadLine();
            Program.ValidarIngresoDouble(auxString, out lado1);

            Console.Write("Ingrese segundo lado en cm: ");
            auxString = Console.ReadLine();
            Program.ValidarIngresoDouble(auxString, out lado2);

            resultado = CalculadoraDeHipotenusa.CalcularHipotenusa(lado1, lado2);

            Console.WriteLine($"La hipotenusa mide {resultado}cm");
        }

        /// <summary>
        /// Valida que el usuario ingrese un valor correcto, convirtiendo una cadena en double
        /// </summary>
        /// <param name="entrada">string cadena a convertir</param>
        /// <param name="salida">double variable donde se almacena la conversion</param>
        static void ValidarIngresoDouble(string entrada, out double salida)
        {
            while(!double.TryParse(entrada, out salida))
            {
                Console.Write("Error! Ingrese un número: ");
                entrada = Console.ReadLine();
            }
        }
    }
}
