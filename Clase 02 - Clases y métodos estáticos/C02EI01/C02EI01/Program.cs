/*
 *  Ejercicio I01 - Validador de rangos
 * 
 *  Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:   
 *  
 *  bool Validar(int valor, int min, int max)
 *  valor: dato a validar.
 *  min: mínimo valor incluido.
 *  max: máximo valor incluido.
 *  
 *  Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
 *  Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio. *  
 * 
 */

using System;
using BibliotecaC02EI01;

namespace C02EI01
{
    class Program
    {
        private static int numeroIngresado;
        private const int cotaInferior = -100;
        private const int cotaSuperior = 100;

        private static int minimoValorIngresado;
        private static int maximoValorIngresado;
        private static int acumulador = 0;
        private static float promedio;

        private static string auxString;

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //ingreso y validacion de datos
                Console.Write($"Ingrese un numero {i + 1}: ");
                auxString = Console.ReadLine();
                while (!int.TryParse(auxString, out numeroIngresado))
                {
                    Console.Write("Error! Ingrese un numero: ");
                    auxString = Console.ReadLine();
                }

                if (Validador.Validar(numeroIngresado, cotaInferior, cotaSuperior))
                {
                    Console.WriteLine($"Numero Ingresado, entre {cotaInferior} y {cotaSuperior} !");
                }

                if (i == 0)
                {
                    minimoValorIngresado = numeroIngresado;
                    maximoValorIngresado = numeroIngresado;
                }
                else if (numeroIngresado > maximoValorIngresado)
                {
                    maximoValorIngresado = numeroIngresado;
                }
                else if (numeroIngresado < minimoValorIngresado)
                {
                    minimoValorIngresado = numeroIngresado;
                }

                acumulador += numeroIngresado;
            }

            promedio = acumulador / 10;

            Console.WriteLine($"Valor mínimo ingresado: {minimoValorIngresado}");
            Console.WriteLine($"Valor máximo ingresado: {maximoValorIngresado}");
            Console.WriteLine($"Promedio de los números ingresados: {promedio}");
        }
    }
}