/*
 *  Ejercicio C01 - La centralita: Episodio II
 * 
 *  Partir del ejercicio La centralita: Episodio I y modificar la jerarquía de clases para obtener:
 *  
 *   -----------------------------------------------------------------------                             ---------------------------------------------------------------
 *  |   Llamada                                                             |                           |   Centralita                                                  |
 *  |     Fields                                                            |                           |     Fields                                                    |
 *  |       (protected) duracion : float                                    |                           |       (private) listaDeLlamadas : List<Llamada>               |
 *  |       (protected) nroDestino : string                                 |                           |       (protected) razonSocial : string                        |
 *  |       (protected) nroOrigen : string                                  |                           |     Properties                                                |
 *  |     Properties                                                        |                           |       GananciasPorLocal { get; } : float                      |
 *  |       (abstract) Duracion { get; } : float                            |                           |       GananciasPorProvincial { get; } : float                 |
 *  |       NroDestino { get; } : string                                    |                           |       GananaciasPorTotal { get; } : float                     |
 *  |       NroOrigen { get; } : string                                     |                           |       Llamadas { get; } : List<Llamada>                       |
 *  |     Methods                                                           |                           |     Methods                                                   |
 *  |       Llamada(float duracion, string nroDestino, string nroOrigen)    |                           |       (private) AgregarLlamada(Llamada nuevaLlamada) : void   |
 *  |       (protected) Mostrar() : string                                  |                           |       (private) CalcularGanancia(ETipoLlamada tipo) : float   |
 *  |       operator !=(Llamada l1, Llamada l2) : bool                      |                           |       Centralita()                                            |
 *  |       operator ==(Llamada l1, Llamada l2) : bool                      |                           |       Centralita(string nombreEmpresa)                        |
 *  |       OrdenarPorDuracion(Llamada llamada1, Llamada llamada2) : int    |                           |       (private) Mostrar() : string                            |
 *  |     Nested Types                                                      |                           |       operator !=(Centralita c, Llamada llamada) : bool       |
 *  |       Enum TipoLlamada { Local, Provincial, Todas }                   |                           |       operator +(Centralita c, Llamada llamada) : Centralita  |
 *  |_______________________________________________________________________|                           |       operator ==(Centralita c, Llamada llamada) : bool       |
 *                                  |                                                                   |       OrdenarLlamadas() : void                                |
 *                                  |                                                                   |       ToString() : string                                     |
 *                                  |                                                                   |_______________________________________________________________|
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
 *  |       (private) CalcularCosto() : float                                   |   |       (private) CalcularCosto() : float                                           |
 *  |       Equals(object obj) : bool                                           |   |       Equals(object obj) : bool                                                   |
 *  |       Local(Llamada llamada, float costo)                                 |   |       (protected) Mostrar() : string                                              |
 *  |       Local(string origen, float diracion, string destino, float costo)   |   |       Provincial(Franja miFranja, Llamada llamada)                                |
 *  |       (protected) Mostrar() : string                                      |   |       Provincial(string origen, Franja miFranja, float duracion, string destino)  |
 *  |       ToString() : string                                                 |   |       ToString() : string                                                         |
 *  |___________________________________________________________________________|   |     Nested Types                                                                  |
 *                                                                                  |       Enum Franja { Franja_1, Franja_2, Franja_3 }                                |
 *                                                                                  |___________________________________________________________________________________|
 * 
 *  Llamada
 *      La clase Llamada ahora será abstracta. Tendrá definida la propiedad de sólo lectura CostoLlamada que también será abstracta.
 *      El método Mostrar deberá ser declarado como virtual, protegido y retornará un string que contendrá los atributos propios de la clase Llamada.
 *      El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo (utilizar el método Equals, 
 *      sobrescrito en las clases derivadas) y los números de destino y origen son iguales en ambas llamadas.
 *      
 *  Local
 *      Sobrescribir el método Mostrar. Será protegido. Reutilizará el código escrito en la clase base y además agregará la propiedad CostoLlamada,
 *      utilizando un StringBuilder.
 *      El método Equals retornará true sólo si el objeto que recibe es de tipo Local.
 *      El método ToString reutilizará el código del método Mostrar.
 *      
 *  Provincial
 *      El método Mostrar será protegido. Reutilizará el código escrito en la clase base y agregará los datos de franjaHoraria y 
 *      CostoLlamada al texto de retorno. Utilizar StringBuilder.
 *      El método Equals retornará true sólo si el objeto que recibe es de tipo Provincial.
 *      El método ToString reutilizará el código del método Mostrar.
 *      
 *  Centralita
 *      El método Mostrar pasará a ser privado y será llamado por la sobrescritura del método ToString.
 *      El método AgregarLlamada es privado. Recibe una instancia de Llamada y la agrega a la lista de llamadas.
 *      El operador == retornará true si la centralita contiene la llamada en su lista genérica. Utilizar la sobrecarga del operador == de la clase Llamada.
 *      El operador + invocará al método AgregarLlamada sólo si la llamada no está registrada en la Centralita. 
 *      Utilizar la sobrecarga del operador == de Centralita.
 *      
 *  Reescribir el método Main para que:
 *      Sólo agregue mediante el operador +.
 *      Sólo muestre los datos de Centralita una vez ordenados.
 *      
 *  Agregar un proyecto de tipo Windows Forms App y generar el siguiente formulario principal FrmMenu, que tendrá como único atributo una Centralita:
 *  
 *  Agregar los formularios FrmLlamador y FrmMostrar:
 *      Recibirán en su constructor a la instancia de Centralita creada en FrmMenu.
 *      FrmLlamador tendrá una propiedad de sólo lectura que expondrá dicha Centralita, 
 *      a fin de volver a ser leída por el formulario de menú una vez terminada la acción.
 *      
 *      
 *  Si se presiona el botón btnGenerarLlamada abrir un nuevo formulario de forma modal:
 *      Si la llamada comienza con #, es provincial. Si la llamada no comienza con #, se deberá poner el combo cmbFranja en estado deshabilitado.
 *      La fuente de txtNroDestino será 16. Este TextBox sólo se podrá cargar mediante el panel numérico.
 *      El panel numérico se encontrará dentro de un Groupbox con el título "Panel".
 *      El TextBox situado por debajo del botón btnLimpiar será el txtNroOrigen.
 *      La duración será un número aleatorio entre 1 y 50.
 *      El costo, en caso de necesitarlo, será un número aleatorio entre 0,5 y 5,6.
 *      El combo cmbFranja, situado al final del formulario, será el encargado de colocar una franja horaria a las llamadas provinciales. 
 *      Cargar desde el Enumerado utilizando el siguiente código: 
 *      
 *      // Carga
 *      cmbFranja.DataSource = Enum.GetValues(typeof(Franjas));
 *      // Lectura
 *      Franjas franjas;
 *      Enum.TryParse<Franjas>(cmbFranja.SelectedValue.ToString(), out franjas);    
 *      
 *  Si se presiona alguno de los botones btnFacturacionTotal, btnFacturacionLocal o btnFacturacionProvincial,
 *  abrir un formulario sólo con un RichTextBox y la información correspondiente impresa en él.
 *  
 *      El formulario tendrá un atributo del tipo TipoLlamada, y una propiedad de sólo escritura para cargarle datos y así saber qué llamadas mostrar.
 *      
 *  Todos los formularios deberán aparecer centrados, el principal en la pantalla y el resto con respecto al principal.
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
