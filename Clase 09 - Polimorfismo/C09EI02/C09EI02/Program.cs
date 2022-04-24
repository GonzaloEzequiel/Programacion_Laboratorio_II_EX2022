/*
 *  Ejercicio I02 - Calculadora de formas
 * 
 *  Consigna
 *  
 *   1. Crear una biblioteca de clases que contenga la siguiente jerarquía de herencia:
 *     - La clase Figura será base de las demás y no deberá poder instanciarse.
 *     - Las clases Rectangulo y Circulo heredarán de Figura.
 *     - La clase Cuadrado heredará de Rectangulo.
 *     - Las clases Circulo y Cuadrado no se deben poder heredar (ser base).
 * 
 *  2. Agregar el método Dibujar que tendrá una implementación por defecto en la clase base y retornará el texto "Dibujando forma...". 
 *  Las clases derivadas directas invalidarán dicha implementación y la cambiarán por "Dibujando círculo", "Dibujando rectángulo", según corresponda.
 *  
 *  3. Agregar el método CalcularSuperficie que deberá ser implementado de manera obligatoria por las clases derivadas. 
 *  Debe retornar un double con el resultado del cálculo de superficie (área) para la figura correspondiente.
 *  
 *  4. Agregar el método CalcularPerimetro que deberá ser implementado de manera obligatoria por las clases derivadas. 
 *  Debe retornar un double con el resultado del cálculo del perímetro para la figura correspondiente.
 *  
 *  5. Crear un proyecto de consola y en el método Main:
 *      Crear una lista de figuras.
 *      Agregar a la lista una figura de cada tipo.
 *      Recorrer la lista mostrando:
 *          El resultado del método Dibujar.
 *          El área y el perímetro de cada figura con una precisión de 2 decimales.
 *          El tipo del objeto (método GetType).
 *          
 *  6. Responder:
 *      ¿Por qué la clase Cuadrado no está obligada a implementar el método Dibujar? ¿Las otras clases están obligadas a hacerlo?
 *      ¿Por qué la clase Cuadrado no está obligada a implementar el método CalcularSuperficie? ¿Las otras clases están obligadas a hacerlo?
 *      ¿A qué implementación del método CalcularPerimetro llaman los objetos de tipo Cuadrado
 * 
 */

using System;
using System.Collections.Generic;
using BibliotecaC09EI02;

namespace C09EI02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            lista.Add(new Circulo(4));
            lista.Add(new Cuadrado(3));
            lista.Add(new Rectangulo(4, 8));

            int i = 1;

            foreach(Figura figura in lista)
            {
                Console.WriteLine($"=============== FIGURA {i} ==================");
                Console.WriteLine($" Tipo: {figura.GetType().Name}");
                Console.WriteLine($" {figura.Dibujar()}");
                Console.WriteLine($" Área: {figura.CalcularSuperficie()}");
                Console.WriteLine($" Perímetro: {figura.CalcularPerimetro()}");
                Console.WriteLine($"=============================================");
                i++;
            }
        }
    }
}
 