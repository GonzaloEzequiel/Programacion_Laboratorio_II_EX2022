/*
 *  Ejercicio C02 - Go Speed Racer Go!
 * 
 *  Partir del ejercicio Enciendan sus motores y agregar la clase VehiculoDeCarrera y la clase MotoCross.
 *  
 *   -----------------------------------------------------------                            ---------------------------------------------------------------------------------------
 *  |   VehiculoDeCarrera                                       |                           |   Competencia                                                                         |
 *  |     Fields                                                |                           |     Fields                                                                            |
 *  |       (private) cantidadCombustible : short               |                           |       (private) cantidadCompetidores : short                                          |
 *  |       (private) enCompetencia : bool                      |                           |       (private) cantidadVueltas : short                                               |
 *  |       (private) escuderia : string                        |                           |       (private) compteridores : List<VehiculoDeCarrera>                               |
 *  |       (private) numero : short                            |                           |       (private) tipo : TipoCompetencia                                                |
 *  |       (private) vueltasRestantes : short                  |                           |     Properties                                                                        |
 *  |     Properties                                            |                           |       CantidadCompetidores { get; set; } : short                                      |
 *  |       CantidadCombustible { get; set; } : short           |                           |       CantidadVueltas { get; set; } : short                                           |
 *  |       EnCompetencia { get; set } : bool                   |                           |       this[int i] { get; } : VehiculoDeCarrera                                        |
 *  |       Escuderia { get; set; } : string                    |                           |       Tipo { get; set; } : TipoCompetencia                                            |
 *  |       Numero { get; set; } : short                        |                           |     Methods                                                                           |
 *  |       VueltasRestantes { get; set; } : short              |                           |       (private) Competencia()                                                         |
 *  |     Methods                                               |                           |       Competencia(short cantVueltas, short cantCompetidores, TipoCompetencia tipo)    |
 *  |       MostrarDatos() : string                             |                           |       MostrarDatos() :  string                                                        |
 *  |       VehiculoDeCarrera(short numero, string escuderia)   |                           |       operator !=(Competencia c, VehiculoDeCarrera a) : bool                          |
 *  |___________________________________________________________|                           |       operator -(Competencia c, VehiculoDeCarrera a) : bool                           |
 *                                |                                                         |       operator +(Competencia c, VehiculoDeCarrera a) : bool                           |
 *                                |                                                         |       operator ==(Competencia c, VehiculoDeCarrera a) : bool                          |
 *                                |                                                         |     Nested Types                                                                      |
 *                                |                                                         |       Enum { F1, MotoCross }                                                          |
 *                                |                                                         |_______________________________________________________________________________________|
 *                                |
 *                                |
 *                   _____________|_____________________________________________________________________________________________________________
 *                  |                                                                                                                           |
 *   ---------------------------------------------------------------------------                             -----------------------------------------------------------------------
 *  |   AutoF1 -> VehiculoDeCarrera                                             |                           |   MotoCross  -> VehiculoDeCarrera                                     |
 *  |     Fields                                                                |                           |     Fields                                                            |
 *  |       (private) caballosDeFuerza : short                                  |                           |       (private) cilindrada : short                                    |
 *  |     Properties                                                            |                           |     Properties                                                        |
 *  |       CaballosDeFuereza { get; set; } : short                             |                           |       Cilindrada { get; set; } : short                                |
 *  |     Methods                                                               |                           |     Methods                                                           |
 *  |       AutoF1(short numero, string escuderia)                              |                           |       MostrarDatos() : string                                         |
 *  |       AutoF1(short numero, string escuderia, short caballosDeFuerza)      |                           |       MotoCross(short numero, string escuderia)                       |
 *  |       MostrarDatos() : string                                             |                           |       MotoCross(short numero, string escuderia, short cilindrada)     |
 *  |       operator !=(AutoF1 a1, AutoF1 a2) : bool                            |                           |       operator !=(MotoCross a1, MotoCross a2) : bool                  |
 *  |       operator ==(AutoF1 a1, AutoF1 a2) : bool                            |                           |       operator ==(MotoCross a1, MotoCross a2) : bool                  |
 *  |___________________________________________________________________________|                           |_______________________________________________________________________|
 *  
 *  
 *  Mover toda la información pedida a la clase VehiculoDeCarrera, modificando AutoF1 y generando sus correspondientes propiedades.
 *  
 *      * Dos VehiculoDeCarrera son iguales si coincide su número y escudería.
 *      * Dos AutoF1 serán iguales cuando, además de coincidir los datos contenidos en VehiculoDeCarrera, coincida el atributo caballosDeFuerza.
 *      * Dos MotoCross son iguales si coincide cuando, además de coincidir los datos contenidos en VehiculoDeCarrera, coincida el atributo cilindrada.
 *      * El método Mostrar de VehiculoDeCarrera será el único capaz de exponer información de este tipo de objetos.
 *  
 *  En la clase Competencia cambiar el tipo de la lista por VehiculoDeCarrera.
 *  
 *      * Si la competencia es declarada del tipo CarreraMotoCross, sólo se podrán agregar vehículos del tipo MotoCross. Si la competencia es del tipo F1, 
 *      sólo se podrán agregar objetos AutoF1. Colocar dicha comparación dentro de la sobrecarga del operador == de la clase Competencia.
 *      
 *  Modificar todo lo que sea necesario para que el sistema siga comportándose de la misma forma, aceptando también vehículos del tipo MotoCross en la competencia.
 * 
 */

using System;
using System.Text;
using BibliotecaC08EC02;

namespace C08EC02
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia copaLomito = new Competencia(30, 60, Competencia.ETipoCompetencia.F1);
            Competencia granPremioMenta = new Competencia(20, 10, Competencia.ETipoCompetencia.MotoCross);

            AutoF1 auto1 = new AutoF1(1, "Ferrari", 400);
            AutoF1 auto2 = new AutoF1(2, "Ferrari", 400);
            AutoF1 auto3 = new AutoF1(30, "Mercedes Benz", 390);
            AutoF1 auto4 = new AutoF1(30, "MacLaren", 395);
            MotoCross moto1 = new MotoCross(10, "Lamborghini", 250);
            MotoCross moto2 = new MotoCross(10, "Lamborghini", 250);
            MotoCross moto3 = new MotoCross(21, "Ferrari", 350);
            MotoCross moto4 = new MotoCross(22, "Ferrari", 300);

            StringBuilder muestroEnPantalla = new StringBuilder();

            muestroEnPantalla.AppendLine($"Agrego auto1 a la Copa Lomito: {copaLomito + auto1}");
            muestroEnPantalla.AppendLine($"Agrego auto2 a la Copa Lomito: {copaLomito + auto2}");
            muestroEnPantalla.AppendLine($"Agrego auto3 a la Copa Lomito: {copaLomito + auto3}");
            muestroEnPantalla.AppendLine($"Agrego auto4 a la Copa Lomito: {copaLomito + auto4}");
            muestroEnPantalla.AppendLine("--------------------------------------------------------");
            muestroEnPantalla.AppendLine($"Agrego auto5 al Gran Premio Menta: {granPremioMenta + moto1}");
            muestroEnPantalla.AppendLine($"Agrego auto6(NO) al Gran Premio Menta: {granPremioMenta + moto2}");
            muestroEnPantalla.AppendLine($"Agrego auto7 al Gran Premio Menta: {granPremioMenta + moto3}");
            muestroEnPantalla.AppendLine($"Agrego auto8 al Gran Premio Menta: {granPremioMenta + moto4}");

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
            Console.WriteLine($"Mmoto en indice 1 {granPremioMenta[1].MostrarDatos()}");            

        }
    }
}
