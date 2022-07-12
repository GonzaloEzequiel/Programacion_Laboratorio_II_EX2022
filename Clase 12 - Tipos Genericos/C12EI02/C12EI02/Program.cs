/*
 *  Ejercicio I02 - Contabilidad
 * 
 *  Crear un proyecto de biblioteca de clases y agregar las clases del siguiente diagrama:
 *  
 *   -------------------------------                                 -----------------------------------------------------------------------
 *  |   Documento                   |                               |   Contabilidad<T,U>                                                   |
 *  |     Fields                    |                               |     Fields                                                            |
 *  |       (private) numero : int  |                               |       (private) egresos : List<T>                                     |
 *  |     Methods                   |                               |       (private) ingresos : List<U>                                    |
 *  |       Documento(int numero)   |                               |     Methods                                                           |
 *  |_______________________________|                               |       operator +(Contabilidad<T,U> c, T egreso) : Contabilidad<T,U>   |
 *                  |                                               |       operator +(Contabilidad<T,U> c, U ingreso) : Contabilidad<T,U>  |
 *                  |                                               |_______________________________________________________________________|
 *                  |
 *               ___|___________________________________
 *              |                                       |
 *   ---------------------------                 ---------------------------
 *  |   Recibo -> Documento     |               |   Factura -> Documento    |
 *  |     Methods               |               |     Methods               |
 *  |       Recibo()            |               |       Factura(int numero) |
 *  |       Recibo(int numero)  |               |___________________________|
 *  |___________________________|
 *  
 *  Crear en Contabilidad un constructor que no reciba parámetros e inicialice las listas.
 *  El constructor sin parámetros de Recibo asignará 0 como número de documento.
 *  Tanto el tipo genérico T como el U deberán ser del tipo Documento o uno de sus derivados.
 *  El tipo U deberá tener una restricción que indique que deberá tener un constructor público y sin parámetros.
 *  El operador + entre Contabilidad y T agrega un elemento a la lista egresos.
 *  El operador + entre Contabilidad y U agrega un elemento a la lista ingresos.
 *  
 *  Crear un proyecto de consola y generar el código necesario para probar dichas clases.
 * 
 */

using System;
using BibliotecaC12EI02;

namespace C12EI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Recibo recibo1 = new Recibo();
            Factura factura1 = new Factura(123);
            Factura factura2 = new Factura(456);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad += recibo1;
            contabilidad += factura1;
            contabilidad += factura2;

            foreach(Factura item in contabilidad.Egresos)
            {
                Console.WriteLine(item.Numero);
            }
            foreach (Recibo item in contabilidad.Ingresos)
            {
                Console.WriteLine(item.Numero);
            }

            Console.WriteLine("Bye World!");
        }
    }
}
