/*
 *  Ejercicio I03 - El ejemplo universal
 *  
 *  Crear una aplicación de consola y una biblioteca de clases que contenga la clase del siguiente diagrama:
 *  
 *      Class Estudiante
 *      Fields
 *          (private) apellido : string
 *          (private) legajo : string
 *          (private) nombre : string
 *          (private) notaPrimerParcial : int
 *          (private) notaSegundoParcial : int
 *          (private) random : Random
 *      Methods
 *          CalcularNotaFinal() : double
 *          (private) CalcularPromedio() : float
 *          (static) Estudiante()
 *          Estudiante(string nombre, string apellido, string legajo)
 *          Mostrar() : string
 *          SetNotaPrimerParicial(int nota) : void
 *          SetNotaSegundoParicial(int nota) : void
 *          
 *      La clase Estudiante:
 *      Tendrá un constructor estático que inicializará el atributo estático random.
 *      Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
 *      El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
 *      El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
 *      El método privado CalcularPromedio retornará el promedio de las dos notas.
 *      El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, 
 *      caso contrario la inicializará con el valor -1.
 *      El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
 *      Nombre, apellido y legajo.
 *      Nota del primer y segundo parcial.
 *      Promedio.
 *      Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
 *  
 *      Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
 *      Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
 *      Mostrar los datos de todos los alumnos.
 * 
 */

using System;
using BibliotecaC03EI03;

namespace C03EI03
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Gonzalo", "Ezequiel", "20220301");
            Estudiante estudiante2 = new Estudiante("Florencia", "Agustina", "20220302");
            Estudiante estudiante3 = new Estudiante("Alumno", "Ficticio", "20220305");

            estudiante1.SetNotaPrimerParicial(10);
            estudiante1.SetNotaSegundoParicial(8);

            estudiante2.SetNotaPrimerParicial(4);
            estudiante2.SetNotaSegundoParicial(9);

            estudiante3.SetNotaPrimerParicial(3);
            estudiante3.SetNotaSegundoParicial(2);

            Console.WriteLine("  Nombre     Apellido       Legajo       1°Parcial       2°Parcial       Promedio        Final  ");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}
