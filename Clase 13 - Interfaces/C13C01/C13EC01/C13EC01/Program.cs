/*
 *  Ejercicio C01 - La centralita: Episodio V
 * 
 *  Partir del ejercicio La centralita: Episodio IV y agregar la siguiente interfaz:
 *  
 *   -----------------------------------------------
 *  |   IGuardar<T>                                 |
 *  |     Properties                                |
 *  |       RutaDeArchivo { get; set; } : string    |
 *  |     Methods                                   |
 *  |       Guardar() : bool                        |
 *  |       Leer() : T                              |
 *  |_______________________________________________|  
 *  
 * 
 *  1. Implementar la interfaz en la clase Centralita para datos del tipo string.
 *      i. Guardar tomará el objeto y consultará todos sus datos, luego retornará true.
 *      ii. Leer lanzará la excepción NotImplementedException.
 *      
 *  2. Implementar la interfaz en las llamadas del tipo Local y Provincial para los tipos de datos Local y Provincial respectivamente.
 *      i. Tanto Leer como Guardar lanzarán la excepción NotImplementedException.
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
