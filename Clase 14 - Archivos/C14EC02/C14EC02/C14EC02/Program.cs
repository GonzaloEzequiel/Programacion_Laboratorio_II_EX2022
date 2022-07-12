/*
 *  Ejercicio C02 - La centralita: Episodio VI
 * 
 *  Partir del ejercicio La centralita: Episodio V y realizar los siguientes cambios:
 *  
 *  1. El método Guardar de la implementación de IGuardar en Centralita deberá guardar en un archivo de texto a modo de bitácora fecha y hora con el siguiente formato 
 *      “Jueves 19 de octubre de 2017 19:09hs – Se realizó una llamada”; para lo cual este método deberá ser llamado desde el operador + (suma). 
 *      En caso de no poder guardar, igualmente agregar la llamada a la Centralita y luego lanzar la excepción FallaLogException.
 *      
 *  2. El método Leer deberá obtener los datos de un archivo dado y retornarlos.
 *  
 *  3. En el método Main modificar el código para que, antes de salir, muestre el log.
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
