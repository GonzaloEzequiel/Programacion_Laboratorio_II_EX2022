/*
 *  Ejercicio C03 - Parada en boxes
 * 
 *  Partir del ejercicio Seguí participando.
 *  
 *  1. Agregar una propiedad que haga pública la lista de vehículos de Competencia.
 *  2. Crear un test unitario que valide que la lista de vehículos de la competencia esté instanciada al crear un nuevo objeto.
 *  3. Realizar un test unitario que controle que la excepción CompetenciaNoDisponible se lance al querer cargar un AutoF1 en una competencia del tipo MotoCross.
 *  4. Realizar otro test que controle que la excepción CompetenciaNoDisponible NO se lance al querer cargar un objeto del tipo MotoCross 
 *      en una competencia del tipo MotoCross.
 *  5. Comprobar que al cargar un nuevo vehículo en la competencia este figure en la lista. Utilizar el operador + y el ==.
 *  6. Comprobar que al quitar un vehículo existente en la competencia este ya no figure en la lista. Utilizar el operador - y el !=.
 *
 */

using System;
using System.Text;
using BibliotecaC11EC03;

namespace C11EC03
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
