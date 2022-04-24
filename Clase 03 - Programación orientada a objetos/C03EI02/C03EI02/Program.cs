/*
 *  Ejercicio I02 - ¿Vos cuántas primaveras tenés?
 * 
 *  Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.
 *  Deberá tener los atributos:
 *      nombre
 *      fechaDeNacimiento
 *      dni
 *      
 *  Deberá tener un constructor que inicialice todos los atributos.
 *  
 *  Construir los siguientes métodos para la clase:
 *      Setter y getter para cada uno de los atributos.
 *      CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
 *      Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
 *      EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
 *      
 *  Instanciar 3 objetos de tipo Persona en el método Main.
 *  Mostrar quiénes son mayores de edad y quiénes no.
 * 
 */

using System;
using BibliotecaC03EI02;

namespace C03EI02
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Gonzalo", new DateTime(1987, 6, 24), 33111296);
            Persona persona2 = new Persona("Florencia", new DateTime(1993, 11, 16), 39218751);
            Persona persona3 = new Persona("Lomito", new DateTime(2018, 12, 01), 55069666);



            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
