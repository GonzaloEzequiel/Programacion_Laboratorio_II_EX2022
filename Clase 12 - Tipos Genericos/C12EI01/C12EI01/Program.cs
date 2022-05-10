/*
 *  Ejercicio I01 - Torneo
 * 
 *  1. Crear un proyecto del tipo biblioteca de clases.
 *  2. Generar la clase Torneo con un tipo genérico.
 *      i. Restringir el tipo genérico para que deba ser del tipo Equipo o sus derivados.
 *      ii. Tendrá un atributo equipos de tipo List<T> y otro nombre de tipo string.
 *      iii. Sobrecargar el operador == para que controle si un equipo ya está inscripto al torneo.
 *      iv. Sobrecargar el operador + para agregar un equipo a la lista, siempre y cuando este no se encuentre ya en el torneo.
 *      v. El método Mostrar retornará los datos del torneo y de los equipos participantes.
 *      vi. El método privado CalcularPartido recibirá dos elementos del tipo T, que deberán ser del tipo Equipo o sus herencias, 
 *          y calculará utilizando la clase Random un resultado del partido. 
 *          Retornará el resultado como un string con el siguiente formato donde EQUIPOX es el nombre del equipo y RESULTADOX la cantidad de goles/puntos:
 *      
 *              [EQUIPO1][RESULTADO1] – [RESULTADO2][EQUIPO2]
 *              
 *      vii. La propiedad pública JugarPartido tomará dos equipos de la lista al azar y calculará el resultado del partido a través del método CalcularPartido.
 *      
 *  3. Generar la clase Equipo abstracta.
 *      i. Agregar un atributo nombre de tipo string y otro fechaCreacion de tipo DateTime.
 *      ii. Dos equipos serán iguales si comparten el mismo nombre y fecha de creación.
 *      iii. El método Ficha retornará el nombre del equipo y su fecha de creación con el siguiente formato:
 *          [EQUIPO] fundado el [FECHA]
 *  
 *  4. Generar la clase EquipoFutbol que herede de Equipo.
 *  5. Generar la clase EquipoBasquet que herede de Equipo.
 *  6. Crear un proyecto de consola.
 *      i. Generar dos torneos, uno de Futbol y otro de Basquet.
 *      ii. Crear 3 equipos de cada tipo.
 *      iii. Agregar los equipos en tantos torneos como se pueda.
 *      iv. Llamar al método Mostrar de Torneo e imprimir su retorno por pantalla.
 *      v. Llamar al menos 3 veces a la propiedad JugarPartido de cada torneo e imprimir su respuesta por pantalla.
 *      
 */

using System;
using BibliotecaC12EI01;

namespace C12EI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Liga de Futbol");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Copa Ginobili");

            EquipoFutbol ef1 = new EquipoFutbol("Racing", DateTime.Now);
            EquipoFutbol ef2 = new EquipoFutbol("Boca", DateTime.Now);
            EquipoFutbol ef3 = new EquipoFutbol("Velez", DateTime.Now);

            EquipoBasquet eb1 = new EquipoBasquet("Racing", DateTime.Now);
            EquipoBasquet eb2 = new EquipoBasquet("Bahia Blanca", DateTime.Now);
            EquipoBasquet eb3 = new EquipoBasquet("Campana", DateTime.Now);

            torneoFutbol += ef1;
            torneoFutbol += ef1; //prueba de error
            torneoFutbol += ef2;
            torneoFutbol += ef3;

            torneoBasquet += eb1;
            torneoBasquet += eb2;
            torneoBasquet += eb2; //prueba de error
            torneoBasquet += eb3;

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoFutbol.JugarPartido);            

            Console.ReadKey();
        }
    }
}
