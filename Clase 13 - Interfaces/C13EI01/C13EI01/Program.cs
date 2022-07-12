/*
 *  Ejercicio I01 - Cartuchera
 * 
 *  PARTE I
 * 
 *  Crear un proyecto de tipo biblioteca de clases y crear las clases del siguiente diagrama:
 *  
 *   -------------------------------------------------------             -------------------------------------------------------
 *  |   Boligrafo                                           |           |   Lapiz                                               |
 *  |     Fields                                            |           |     Fields                                            |
 *  |       (private) colorTinta : ConsoleColor             |           |       (private) tamanioMina : float                   |
 *  |       (private) float : tinta                         |           |     Properties                                        |
 *  |     Properties                                        |           |       Color { get; set; } : ConsoleColor              |
 *  |       Color { get; set; } : ConsoleColor              |           |       UnidadesDeEscritura { get; set; } : float       |
 *  |       UnidadesDeEscritura { get; set; } : float       |           |     Methods                                           |
 *  |     Methods                                           |           |       Lapiz(int unidades)                             |
 *  |       Boligrafo(int unidades, ConsoleColor color)     |           |       Escribir(strin texto : EscrituraWrapper         |
 *  |       Escribir(strin texto : EscrituraWrapper         |           |       Recargar(int unidades) : bool                   |
 *  |       Recargar(int unidades) : bool                   |           |       ToString() : string                             |
 *  |       ToString() : string                             |           |_______________________________________________________|  
 *  |_______________________________________________________|                           
 *  
 *                                                                                           ---------------------------------------------------------------
 *   ---------------------------------------------------------------                        |   IAcciones                                                   | 
 *  |   EscrituraWrapper                                            |                       |     Properties                                                | 
 *  |     Fields                                                    |                       |       (abstract) Color { get; set; } : ConsoleColor           |
 *  |       color : ConsoleColor                                    |                       |       (abstract) UnidadesDeEscritura { get; set; } : float    |
 *  |       texto : string                                          |                       |     Methods                                                   |
 *  |     Methods                                                   |                       |       (abstract) Escribir(string texto) : EscrituraWrapper    |
 *  |       EscrituraWrapper(string texto, ConsoleColor color)      |                       |       (abstract) Recargar(int unidades) : bool                |
 *  |_______________________________________________________________|                       |_______________________________________________________________|
 *    
 *  
 *  1. La clase Boligrafo implementará la interfaz de forma implícita y en Lapiz de forma explícita.
 * 
 *  2. En Lapiz:
 *      i. El método Escribir reducirá la mina en 0.1 por cada carácter escrito.
 *      ii. El método Recargar lanzará NotImplementedException.
 *      iii. El color será gris (grey), sin posibilidad de modificarlo. El set lanzará NotImplementedException.
 *      iv. La propiedad UnidadesDeEscritura retornará el valor del atributo tamanioMina.
 *      
 *  3. En Boligrafo:
 *      i. El método Escribir reducirá la tinta en 0.3 por cada carácter escrito.
 *      ii. El método Recargar incrementará la tinta en tantas unidades como se agreguen.
 *      iii. La propiedad UnidadesDeEscritura retornará el valor del atributo tinta.
 *      
 *  4. En ambas clases el método ToString retornará un texto informando si es un lápiz o un bolígrafo, el color de escritura y el nivel de tinta.
 *  
 *  5. Crear un proyecto de consola y agregar el siguiente código en el método Main, modificar si hace falta:
 *  
 *  PARTE II
 *  
 *  1. Declarar la clase CartucheraMultiuso que tendrá un atributo del tipo List<IAcciones>.
 *  
 *  2. Crear el método RecorrerElementos.
 *      i. Se deberá recorrer la lista y gastará 1 unidades de cada elemento.
 *      ii. Cuando sea necesario, recargará antes de salir del método (cargar 20 unidades).
 *      iii. Retornará true si se pudo gastar exactamente 1 unidad de todos los elementos.
 *      
 *  3. Declarar la clase CartucheraSimple que tendrá dos atributos del tipo List<Boligrafo> y List<Lapiz> respectivamente.
 *  
 *  4. Crear el método RecorrerElementos para que haga exactamente lo mismo que el de CartucheraMultiuso. Recorrer cada lista por su tipo.
 *  
 *  5. Crear dentro del método Main un objeto del tipo CartucheraMultiuso y otro de CartucheraSimple.
 *      i. Cargar sus listas de elementos.
 *      ii. Llamar a los métodos RecorrerElementos hasta que alguno de ellos retorne false.
 *      iii. Imprimir por pantalla su retorno.
 * 
 */

using System;
using BibliotecaC13EI01;

namespace C13EI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            CartucheraMultiuso cartucheraMultiuso = new CartucheraMultiuso();
            CartucheraSimple cartucheraSimple = new CartucheraSimple();

            cartucheraMultiuso.listado.Add(miLapiz);
            cartucheraMultiuso.listado.Add(miBoligrafo);

            cartucheraSimple.lapices.Add(miLapiz);
            cartucheraSimple.boligrafos.Add(miBoligrafo);

            Console.WriteLine();

            Console.WriteLine(cartucheraMultiuso.RecorrerElementos());
            Console.WriteLine(cartucheraSimple.RecorrerElementos());

            Console.ReadKey();
        }
    }
}
