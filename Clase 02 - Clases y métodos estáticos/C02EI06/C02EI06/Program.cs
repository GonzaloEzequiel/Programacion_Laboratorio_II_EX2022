/*
 *  Ejercicio I06 - Calculadora de áreas
 * 
 *  Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:
 *      public double CalcularAreaCuadrado(double longitudLado) {}
 *      public double CalcularAreaTriangulo(double base, double altura) {}
 *      public double CalcularAreaCirculo(double radio) {}
 *      
 *  El ingreso de los datos como la visualización se deberán realizar desde el método Main().
 * 
 */

using System;
using BibliotecaC02EI06;

namespace C02EI06
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            double numeroIngresado1, numeroIngresado2, resultado = 0;

            string auxString = string.Empty;

            do
            {
                Console.WriteLine("** CALCULADORA DE AREA **");

                Console.WriteLine("¿Qué Desea Calcular?");
                Console.WriteLine("a. Cuadrado");
                Console.WriteLine("b. Triángulo");
                Console.WriteLine("c. Círculo");

                char.TryParse(Console.ReadLine(), out opcion);

            } while (opcion != 'a' && opcion != 'b' && opcion != 'c');

            switch(opcion)
            {
                case 'a':
                    Console.Write("Ingresar Lado: ");
                    auxString = Console.ReadLine();
                    while(!double.TryParse(auxString, out numeroIngresado1))
                    {
                        Console.Write("Error ingrese un número: ");
                        auxString = Console.ReadLine();
                    }
                    auxString = "cuadrado";
                    resultado = CalculadoraDeAreas.CalcularAreaCuadrado(numeroIngresado1);
                    break;

                case 'b':
                    Console.Write("Ingresar Base: ");
                    auxString = Console.ReadLine();
                    while (!double.TryParse(auxString, out numeroIngresado1))
                    {
                        Console.Write("Error ingrese un número: ");
                        auxString = Console.ReadLine();
                    }
                    Console.Write("Ingresar Altura: ");
                    auxString = Console.ReadLine();
                    while (!double.TryParse(auxString, out numeroIngresado2))
                    {
                        Console.Write("Error ingrese un número: ");
                        auxString = Console.ReadLine();
                    }

                    auxString = "triángulo";
                    resultado = CalculadoraDeAreas.CalcularAreaTriangulo(numeroIngresado1, numeroIngresado2);
                    break;

                case 'c':
                    Console.Write("Ingresar Radio: ");
                    auxString = Console.ReadLine();
                    while (!double.TryParse(auxString, out numeroIngresado1))
                    {
                        Console.Write("Error ingrese un número: ");
                        auxString = Console.ReadLine();
                    }
                    auxString = "cuadrado";
                    resultado = CalculadoraDeAreas.CalcularAreaCirculo(numeroIngresado1);
                    break;

                default:
                    break;
            }

            Console.WriteLine($"El area del {auxString} es: {resultado} unidades");
        }
    }
}
