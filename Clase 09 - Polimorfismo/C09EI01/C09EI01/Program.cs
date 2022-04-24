/*
 *  Parte I
 *  Crear un proyecto de consola que contenga la clase Sobrescrito.
 * 
 *      1. Sobrescribir el método ToString para que retorne "¡Este es mi método ToString sobrescrito!".
 *      2. Sobrescribir el método Equals para que retorne true si son del mismo tipo (objetos de la misma clase), false caso contrario.
 *      3. Sobrescribir el método GetHashCode para que retorne el número 1142510181.
 *      4. Agregar en el método Main el siguiente código:
 * 
 *  Parte II
 *  
 *      1. Agregar a la clase Sobrescrito un atributo miAtributo del tipo string, con visibilidad protected.
 *      2. Generar un constructor de instancia que inicialice miAtributo con el valor "Probar abstractos".
 *      3. Agregará propiedad abstracta MiPropiedad de sólo lectura. Una vez implementada, retornará el valor de miAtributo.
 *      4. Crear un método abstracto MiMetodo que retorne un string. Una vez implementada, retornará el valor de MiPropiedad.
 *      5. Agregar una clase llamada SobreSobrescrito que herede de Sobrescrito. Implementar el código necesario para que todo funcione correctamente.
 *      6. Modificar el método Main para probar las modificaciones.
 *  
 */

using System;
using System.Text;

namespace C09EI01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobrescrito objetoSobrescrito = new SobreSobrescrito();

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.MiMetodo());

            Console.ReadKey();
        }
    }
}
