/*
 *  Ejercicio C02 - Seguí participando
 * 
 *  Partir del ejercicio Go Speed Racer Go! y agregar la excepción CompetenciaNoDisponibleException.
 *  
 *   ---------------------------------------------------------------------------------------------------------------
 *  |   CompetenciaNoDisponibleException -> Exception                                                               |
 *  |     Fields                                                                                                    |
 *  |       (private) nombreClase : string                                                                          |
 *  |       (private) nombreMetodo : string                                                                         |
 *  |     Properties                                                                                                |
 *  |       NombreClase { get; } : string                                                                           |
 *  |       NombreMetodo { get; } : string                                                                          |
 *  |     Methods                                                                                                   |
 *  |       CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)                           |
 *  |       CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerExcepion)  |
 *  |_______________________________________________________________________________________________________________|
 *  
 *  1. La sobrescritura del método ToString retornará un mensaje con el siguiente formato por líneas:
 *      i. "Excepción en el método {0} de la clase {1}:"
 *      ii. Mensaje propio de la excepción.
 *      iii. Todos los InnerException con una tabulación (\t).
 *      
 *  2. La excepción CompetenciaNoDisponibleException será lanzada dentro del operador == de Competencia y Vehiculo 
 *      con el mensaje "El vehículo no corresponde a la competencia", capturada dentro del operador + y lanzada nuevamente como una nueva excepción 
 *      con el mensaje "Competencia incorrecta". Utilizar la propiedad InnerException para almacenar la excepción original.
 *  
 *  3. Modificar el método Main para agregar un Vehiculo que no corresponda con la competencia, capturar la excepción y mostrar el error por pantalla.
 *  
 */

using System;
using System.Text;
using BibliotecaC10EC02;

namespace C08EC02
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia copaLomito = new Competencia(30, 60, Competencia.ETipoCompetencia.F1);
            Competencia granPremioMenta = new Competencia(20, 10, Competencia.ETipoCompetencia.MotoCross);

            AutoF1 auto1 = new AutoF1(1, "Ferrari", 400);
            AutoF1 auto2 = new AutoF1(2, "Aston Martin", 400);
            AutoF1 auto3 = new AutoF1(30, "Mercedes Benz", 390);
            AutoF1 auto4 = new AutoF1(30, "MacLaren", 395);
            MotoCross moto1 = new MotoCross(10, "Lamborghini", 250);
            MotoCross moto2 = new MotoCross(10, "Lamborghini", 250);
            MotoCross moto3 = new MotoCross(21, "Ferrari", 350);
            MotoCross moto4 = new MotoCross(22, "Honda", 300);

            StringBuilder muestroEnPantalla = new StringBuilder();

            try
            {
                muestroEnPantalla.AppendLine($"Agrego auto1 a la Copa Lomito: {copaLomito + auto1}");
                muestroEnPantalla.AppendLine($"Agrego auto2 a la Copa Lomito: {copaLomito + auto2}");
                muestroEnPantalla.AppendLine($"Agrego auto3 a la Copa Lomito: {copaLomito + auto3}");
                muestroEnPantalla.AppendLine($"Agrego auto4 a la Copa Lomito: {copaLomito + auto4}");
                //muestroEnPantalla.AppendLine($"Agrego moto1 a la Copa Lomito: {copaLomito + moto1}"); //este debe lanzar la ComptenciaNoDisponibleEx
                muestroEnPantalla.AppendLine("--------------------------------------------------------");
                muestroEnPantalla.AppendLine($"Agrego moto1 al Gran Premio Menta: {granPremioMenta + moto1}");
                muestroEnPantalla.AppendLine($"Agrego moto2(NO) al Gran Premio Menta: {granPremioMenta + moto2}");
                muestroEnPantalla.AppendLine($"Agrego moto3 al Gran Premio Menta: {granPremioMenta + moto3}");
                muestroEnPantalla.AppendLine($"Agrego moto4 al Gran Premio Menta: {granPremioMenta + moto4}");
                               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(muestroEnPantalla.ToString());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("COPA LOMITO:");
            Console.WriteLine(copaLomito.MostrarDatos());
            muestroEnPantalla.AppendLine("--------------------------------------------------------");
            Console.WriteLine("GP MENTA:");
            Console.WriteLine(granPremioMenta.MostrarDatos());

            //----- muestro datos de un auto y una moto por indice (indexador)
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Auto en indice 2 {copaLomito[2].MostrarDatos()}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Moto en indice 1 {granPremioMenta[1].MostrarDatos()}");   

        }
    }
}
