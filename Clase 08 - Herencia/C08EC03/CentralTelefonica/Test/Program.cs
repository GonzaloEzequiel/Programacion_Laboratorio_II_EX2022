/*
 *  Ejercicio C03 - La centralita: Episodio I
 * 
 *  Esta aplicación servirá de control de llamadas realizadas en una central telefónica.
 *  
 *  Crear en una solución llamada CentralTelefonica un proyecto de tipo biblioteca de clases nombrado como Centralita que contenga la siguiente jerarquía de clases
 *  
 *   -----------------------------------------------------------------------                             ---------------------------------------------------------------
 *  |   Llamada                                                             |                           |   Centralita                                                  |
 *  |     Fields                                                            |                           |     Fields                                                    |
 *  |       (protected) duracion : float                                    |                           |       (private) listaDeLlamadas : List<Llamada>               |
 *  |       (protected) nroDestino : string                                 |                           |       (protected) razonSocial : string                        |
 *  |       (protected) nroOrigen : string                                  |                           |     Properties                                                |
 *  |     Properties                                                        |                           |       GananciasPorLocal { get; } : float                      |
 *  |       Duracion { get; } : float                                       |                           |       GananciasPorProvincial { get; } : float                 |
 *  |       NroDestino { get; } : string                                    |                           |       GananaciasPorTotal { get; } : float                     |
 *  |       NroOrigen { get; } : string                                     |                           |       Llamadas { get; } : List<Llamada>                       |
 *  |     Methods                                                           |                           |     Methods                                                   |
 *  |       Llamada(float duracion, string nroDestino, string nroOrigen)    |                           |       (private) CalcularGanancia(TipoLlamada tipo) : float    |
 *  |       Mostrar() : string                                              |                           |       Centralita()                                            |
 *  |       OrdenarPorDuracion(Llamada llamada1, Llamada llamada2) : int    |                           |       Centralita(string nombreEmpresa)                        |
 *  |     Nested Types                                                      |                           |       Mostrar() : string                                      |
 *  |       Enum TipoLlamada { Local, Provincial, Todas }                   |                           |       OrdenarLlamadas() : void                                |
 *  |_______________________________________________________________________|                           |_______________________________________________________________|
 *                                  |
 *                                  |
 *                      ____________|_______________________________________________________________________________________________
 *                     |                                                                                                            |
 *   ---------------------------------------------------------------------------     -----------------------------------------------------------------------------------
 *  |   Local -> Llamada                                                        |   |   Provincial -> Llamada                                                           |
 *  |     Fields                                                                |   |     Fields                                                                        |  
 *  |       (portected) costo : float                                           |   |       (proteted) franjaHoraria : Franja                                           |
 *  |     Properties                                                            |   |     Properties                                                                    |
 *  |       CostoLlamada { get; } : float                                       |   |       CostoLlamada { get; } : float                                               |
 *  |     Methods                                                               |   |     Methods                                                                       |
 *  |       (private) CalcularCosto() : float                                   |   |       CalcularCosto() : float                                                     |
 *  |       Local(Llamada llamada, float costo)                                 |   |       Mostrar() : string                                                          |
 *  |       Local(string origen, float diracion, string destino, float costo)   |   |       Provincial(Franja miFranja, Llamada llamada)                                |
 *  |       Mostrar() : string                                                  |   |       Provincial(string origen, Franja miFranja, float duracion, string destino)  |
 *  |___________________________________________________________________________|   |     Nested Types                                                                  |
 *                                                                                  |       Enum Franja { Franja_1, Franja_2, Franja_3 }                                |
 *                                                                                  |___________________________________________________________________________________|
 *                                                                                  
 *  Llamada
 *      Tendrá todos sus atributos con el modificador protected. Crear las propiedades de sólo lectura para exponer estos atributos.
 *      OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. Se utilizará para ordenar una lista de llamadas de forma ascendente.
 *      Mostrar es un método de instancia que deberá retornar todos los datos de la llamada como texto. Utilizar StringBuilder.
 *  
 *  Local
 *      Hereda de Llamada.
 *      Método Mostrar retornará como texto todos los datos de la clase base y agregará el costo de la llamada. Utilizar StringBuilder.
 *      CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo de la misma.
 *      La propiedad CostoLlamada retornará el precio, que se calculará en el método CalcularCosto.
 *      
 *  Provincial
 *      Hereda de Llamada.
 *      Método Mostrar retornará como texto todos los datos de la clase base y agregará el costo de la llamada y la franja horaria. Utilizar StringBuilder.
 *      CalcularCosto será privado y retornará el valor de la llamada a partir de la duración y el costo de la misma. Los valores serán:
 *          Franja_1: 0.99
 *          Franja_2: 1.25
 *          Franja_3: 0.66
 *          
 *  Centralita
 *      CalcularGanancia será privado. Este método recibe un enumerado TipoLlamada y retornará el valor de lo recaudado, según el criterio elegido 
 *      (ganancias por las llamadas del tipo Local, Provincial o de Todas según corresponda).
 *      El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales y provinciales y el detalle de las llamadas realizadas.
 *      La lista sólo se inicializará en el constructor por defecto Centralita.
 *      Las propiedades GananciaPorTotal, GananciaPorLocal y GananciaPorProvincial retornarán el precio de lo facturado según el criterio 
 *      (llamada local, provincial o todas). Dichos valores se calcularán en el método CalcularGanancia.
 *      
 *  Generar un nuevo proyecto de consola llamado Test. El namespace también deberá llamarse Test.
 *  Agregar el siguiente código en el método Main para probar la centralita:
 * 
 */

using System;
using BibliotecaCentralita;

namespace Test
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
            c.Llamadas.Add(l1);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l2);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l3);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());

            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}
