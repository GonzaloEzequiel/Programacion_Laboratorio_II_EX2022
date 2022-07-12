/*
 *  Ejercicio C01 - La centralita: Episodio III
 * 
 *  Partir del ejercicio La centralita: Episodio II.
 *  
 *  1. Agregar la clase CentralitaException, la cual deriva de Exception.
 *  
 *   ---------------------------------------------------------------------------------------------------
 *  |   CentralitaException -> Exception                                                                |
 *  |     Fields                                                                                        |
 *  |       (private) nombreClase : string                                                              |
 *  |       (private) nombreMetodo : string                                                             |
 *  |     Properties                                                                                    |
 *  |       NombreClase { get; } : string                                                               |
 *  |       NombreMetodo { get; } : string                                                              |
 *  |     Methods                                                                                       |
 *  |       CentralitaException(string mensaje, string clase, string metodo)                            |
 *  |       CentralitaException(string mensaje, string clase, string metodo, Exception innerExcepion)   |
 *  |___________________________________________________________________________________________________|
 *   
 *  2. En el operador + de Centralita, lanzar la excepción CentralitaException en el de que la llamada se encuentre registrada en el sistema.
 *  
 *  3. Capturar dicha excepción tanto en la versión para consola como en la de formularios y mostrar el mensaje de forma amigable para el usuario.
 *  
 */

using System;
using BibliotecaCentralita;

namespace C09EC01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.EFranja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.EFranja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            try
            {
                c += l1;
                Console.WriteLine(c.ToString());
                c += l2;
                Console.WriteLine(c.ToString());
                c += l3;
                Console.WriteLine(c.ToString());
                c += l4;
                Console.WriteLine(c.ToString());
            }
            catch(CentralitaException ex)
            {
                Console.WriteLine(ex.Message);
            }

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }        
    }
}
