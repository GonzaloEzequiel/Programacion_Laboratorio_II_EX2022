/*
 *  Ejercicio I02 - Error al cubo
 *  
 *  Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
 *  Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
 *  
 */
using System;

namespace C01EI02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroString;

            double cuadrado;
            double cubo;

            //ingreso del numero por parte del user
            Console.WriteLine("Ingrese un número positivo: ");
            numeroString = Console.ReadLine();

            //validacion del dato ingresado
            while (!int.TryParse(numeroString, out numero) || numero <= 0)
            {
                Console.WriteLine("Error, Reingrese un número positivo: ");
                numeroString = Console.ReadLine();
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");
            Console.WriteLine($"El cubo de {numero} es: {cubo}");
        }
    }
}