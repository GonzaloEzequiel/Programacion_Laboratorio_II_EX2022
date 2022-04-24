/*
 *  Ejercicio I01 - Sumador
 * 
 *  Crear un proyecto de tipo biblioteca de clases y agregar la clase Sumador.
 *  
 *  Diagrama de clase Sumador
 *      Fields
 *      (private) cantidadSumas : int
 *      Methods
 *      explicit operator int(Sumador s) : int
 *      operator |(Sumador s1, Sumador s2) : bool
 *      operator +(Sumador s1, Sumador s2) : long
 *      Sumador()
 *      Sumador(int cantidadSumas)
 *      Sumar(long a, long b) : long
 *      Sumar(string a, string b) : string
 *  
 *  Crear dos constructores:
 *      Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
 *      Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
 *      
 *  El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:
 *      En el caso de Sumar(long, long) sumará los valores numéricos
 *      En el de Sumar(string, string) concatenará las cadenas de texto.
 *      
 *  Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.
 *  
 *  Seguido:
 *  Generar una conversión explícita que retorne cantidadSumas.
 *  Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.
 *  Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.
 *  Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.
 *  
 */

using System;
using BibliotecaC04EI01;

namespace C04EI01
{
    class Program
    {
        static void Main(string[] args)
        {
            //primera instancia contructor vacio
            Sumador sumadorLoco = new Sumador();
            //prueba de metodo Sumar con sus dos sobrecargas
            Console.WriteLine(sumadorLoco.Sumar(4, 5));
            Console.WriteLine(sumadorLoco.Sumar("Hola", "Mundo"));
            //prueba de la sobrecarga explícita y muestra en consola
            int auxContador = (int)sumadorLoco;
            Console.WriteLine($"Total sumas de sumadorLoco: {auxContador}");
            //segunda instancia contructor con int
            Sumador sumadorCuerdo = new Sumador(20);
            auxContador = (int)sumadorCuerdo;
            //prueba de la sobrecarga comparativa (|)
            if (sumadorLoco | sumadorCuerdo)
                Console.WriteLine("Ambos tienen la misma cantidad de sumas");
            else
                Console.WriteLine("Los Sumadores tienen distintas cantidades de sumas");
            //prueba de la sobrecarga sumadora (+)
            long auxContador2 = sumadorLoco + sumadorCuerdo;
            Console.WriteLine($"Cantidad de sumas totales: {auxContador2}");

        }
    }
}
