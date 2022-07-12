/*
 *  Ejercicio C01 - Competencia genérica
 * 
 *  Partir del ejercicio Seguí participando.
 *  
 *  1. La clase Competencia deberá tener un tipo genérico, el cual sólo podrá ser del tipo VehiculoDeCarrera o uno de sus derivados.
 *  
 *  2. La lista de competidores cambiará del tipo VehiculoDeCarrera al tipo genérico.
 *  
 *  3. Realizar todos los cambios necesarios para que esto funcione correctamente.
 *      Tener en cuenta que el test unitario planteado en Parada en boxes que controla el lanzamiento de la excepción CompetenciaNoDisponible ya no es necesario.
 *
 */

using System;
using System.Text;
using BibliotecaC12EC01;

namespace C12EC01
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia<AutoF1> copaLomito = new Competencia<AutoF1>(30, 60, Competencia<AutoF1>.ETipoCompetencia.F1);
            Competencia<MotoCross> granPremioMenta = new Competencia<MotoCross>(20, 10, Competencia<MotoCross>.ETipoCompetencia.MotoCross);

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
