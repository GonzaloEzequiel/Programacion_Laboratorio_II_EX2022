/*
 *  Ejercicio C02 - Enciendan sus motores
 * 
 *  Crear un proyecto de biblioteca de clases que contenga las clases Competencia y AutoF1:
 *  
 *      AutoF1                                              Competencia
 *          Fields                                              Fields
 *          (private) cantidadCombustible : short               (private) cantidadComperidores : short
 *          (private) enCompetencia : bool                      (private) cantidadVueltas : short
 *          (private) escuderia : string                        (private) competidores : List<AutoF1>
 *          (private) numero : short                            Methods
 *          (private) vueltasRestantes : short                  (private) Competencia()
 *          Methods                                             Competencia(short cantidadVueltas, short cantidadCompetidores)
 *          AutoF1(short numero, string escuderia)              MostrarDatos() : string
 *          MostrarDatos() : string                             operator -(Competencia c, AutoF1 a) : bool
 *          operator !=(AutoF1 a1, AutoF1 a2)                   operator +(Competencia c, AutoF1 a) : bool
 *          operator ==(AutoF1 a1, AutoF1 a2)                   operator ==(Competencia c, AutoF1 a) : bool
 *          
 *  Clase AutoF1
 *  Al generar un auto se cargará el atributo enCompetencia como falso. Inicializar cantidadCombustible y vueltasRestantes en 0.
 *  Dos autos serán iguales si los atributos número y escuderia son iguales.
 *  Realizar los métodos getters y setters para cantidadCombustible , enCompetencia y vueltasRestantes.
 *  
 *  Clase Competencia
 *  El constructor privado será el único capaz de inicializar la lista de competidores.
 *  La sobrecarga del operador + agregará un competidor si es que aún hay espacio (validar con cantidadCompetidores)
 *  y el competidor no forma parte de la lista (== entre Competencia y AutoF1).
 *  Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero, la cantidad de vueltasRestantes será igual a la cantidadVueltas de Competencia 
 *  y se le asignará un número aleatorio entre 15 y 100 a cantidadCombustible.
 *  
 *  Crear un proyecto de consola y generar las invocaciones necesarias en el método Main para probar el código.
 * 
 */

using System;
using System.Text;
using BibliotecaC06EC02;

namespace C06EC02
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia copaLomito = new Competencia(30, 60);
            Competencia granPremioMenta = new Competencia(20, 10);

            AutoF1 auto1 = new AutoF1(1, "Ferrari");
            AutoF1 auto2 = new AutoF1(2, "Ferrari");
            AutoF1 auto3 = new AutoF1(30, "Mercedes Benz");
            AutoF1 auto4 = new AutoF1(30, "MacLaren");
            AutoF1 auto5 = new AutoF1(10, "Lamborghini");
            AutoF1 auto6 = new AutoF1(10, "Lamborghini");
            AutoF1 auto7 = new AutoF1(21, "Ferrari");
            AutoF1 auto8 = new AutoF1(22, "Ferrari");

            StringBuilder muestroEnPantalla = new StringBuilder();

            muestroEnPantalla.AppendLine($"Agrego auto1 a la Copa Lomito: {copaLomito + auto1}");
            muestroEnPantalla.AppendLine($"Agrego auto2 a la Copa Lomito: {copaLomito + auto2}");
            muestroEnPantalla.AppendLine($"Agrego auto3 a la Copa Lomito: {copaLomito + auto3}");
            muestroEnPantalla.AppendLine($"Agrego auto4 a la Copa Lomito: {copaLomito + auto4}");
            muestroEnPantalla.AppendLine("--------------------------------------------------------");
            muestroEnPantalla.AppendLine($"Agrego auto5 al Gran Premio Menta: {granPremioMenta + auto5}");
            muestroEnPantalla.AppendLine($"Agrego auto6(NO) al Gran Premio Menta: {granPremioMenta + auto6}");
            muestroEnPantalla.AppendLine($"Agrego auto7 al Gran Premio Menta: {granPremioMenta + auto7}");
            muestroEnPantalla.AppendLine($"Agrego auto8 al Gran Premio Menta: {granPremioMenta + auto8}");            

            Console.WriteLine(muestroEnPantalla.ToString());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("COPA LOMITO:");
            Console.WriteLine(copaLomito.MostrarDatos());
            muestroEnPantalla.AppendLine("--------------------------------------------------------");
            Console.WriteLine("GP MENTA:");
            Console.WriteLine(granPremioMenta.MostrarDatos());
        }
    }
}
