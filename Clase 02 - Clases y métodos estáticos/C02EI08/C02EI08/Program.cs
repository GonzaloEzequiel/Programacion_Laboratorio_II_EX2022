/*
 *  Ejercicio I08 - El tiempo pasa...
 * 
 *  Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.
 *  Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.
 *  Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
 * 
 */

using System;
using BibliotecaC02EI08;

namespace C02EI08
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime fechaIngresada;

            string auxString;
            int auxYear, auxMonth, auxDay, resultado;

            Console.WriteLine("** INGRESE SU FECHA DE CUMPLEAÑOS **");
            Console.Write("Número de día: ");
            auxString = Console.ReadLine();
            Program.ValidarEntero(auxString,out auxDay);

            Console.Write("Número de mes: ");
            auxString = Console.ReadLine();
            Program.ValidarEntero(auxString, out auxMonth);

            Console.Write("Número de año: ");
            auxString = Console.ReadLine();
            Program.ValidarEntero(auxString, out auxYear);

            fechaIngresada = new DateTime(auxYear, auxMonth, auxDay);

            resultado = CalculadoraDeDias.CalcularCantidadDeDias(fechaIngresada);

            Console.WriteLine($"Pasaron {resultado} días desde su nacimiento!");
        }
		
		/// <summary>
        /// Valida que el usuario ingrese un valor correcto, convirtiendo una cadena en entero
        /// </summary>
        /// <param name="entrada">string cadena a convertir</param>
        /// <param name="salida">int variable donde se almacena la conversion</param>
        static void ValidarEntero(string entrada, out int entero)
        {
            while(!int.TryParse(entrada, out entero))
            {
                Console.Write("Error! Ingrese un número entero: ");
            }
        }
    }
}
