/*
 *  Ejercicio I06 - Años bisiestos
 *  
 *  Escribir un programa que determine si un año es bisiesto.
 *  Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
 *  Por ejemplo: el año 2000 es bisiesto pero 1900 no.
 *  Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
 * 
 */

using System;

namespace C01EI06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFin;

            string anioString;

            //ingreso y validacion de las cotas inferiores y superiores, por parte del user
            Console.WriteLine("Ingrese año inicio: ");
            anioString = Console.ReadLine();
            while (!int.TryParse(anioString, out anioInicio))
            {
                Console.WriteLine("Error, Ingrese un año: ");
                anioString = Console.ReadLine();
            }

            Console.WriteLine("Ingrese año fin: ");
            anioString = Console.ReadLine();
            while (!int.TryParse(anioString, out anioFin))
            {
                Console.WriteLine("Error, Ingrese un año: ");
                anioString = Console.ReadLine();
            }

            Console.WriteLine("\n----------------------\n");
            Console.WriteLine($"Años bisiestos entre {anioInicio} y {anioFin}: ");

            //la condicion de bisiesto se cumple si es multiplo de 4 (resto 0)
            for (int i = anioInicio; i <= anioFin; i++)
            {
                if (i % 4 == 0)
                    Console.Write($"{i} ");
            }
        }
    }
}