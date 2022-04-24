/*
 *  Ejercicio I02 - ¿Consultaste el índice?
 * 
 *  Crear la clase Libro en una biblioteca de clases y el código necesario para acceder a las páginas mediante un valor numérico.
 *      -Diagrama de clases-
 *      
 *  El descriptor de acceso get del indexador leerá la página pedida, siempre y cuando el subíndice se encuentre dentro de un rango correcto, sino retornará un string vacío.
 *  En el set, si la página existe (existe ese índice) le asignará el texto. Si no existe (si el índice es superior al máximo existente), agregará una nueva página.
 *  Crear un proyecto de consola y probar la clase en el método Main.
 * 
 */

using System;
using BibliotecaC07EI02;

namespace C07EI02
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro();

            libro1[0] = "Contenido Carátula";
            libro1[1] = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            libro1[2] = "Cómo Aprender C# en 1 hora";
            libro1[3] = "Botánica for dummies, capítulo 1";
            libro1[4] = "Botánica for dummies, capítulo 2";

            for(int i=0; i<6; i++)
            {
                Console.WriteLine($"Página n°{i}: {libro1[i]}");
            }
        }
    }
}
