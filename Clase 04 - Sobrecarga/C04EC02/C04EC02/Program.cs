/*
 *  Ejercicio C02 - La estantería
 *  
 *  Crear un proyecto de tipo biblioteca de clases que contenga la clase Producto.
 *  
 *  PRODUCTO
 *      Fields
 *      (private) codigoDeBarra : string
 *      (private) marca : string
 *      (private) precio : float
 *      
 *      Methods
 *      explicit operator string(Producto P) : string
 *      GetMarca() : string
 *      GetPrecio() : float
 *      MostrarProducto(Producto p) : string
 *      operator !=(Producto p, string marca) : bool
 *      operator !=(Producto p1, producto p2) : bool
 *      operator ==(Producto p, string marca) : bool
 *      operator ==(Producto p1, Producto p2) : bool
 *      Producto(string marca, string codigo, float precio)
 *      
 *  Todos sus atributos son privados.
 *  Posee sólo un constructor de instancia.
 *  El método GetMarca, retornará el valor correspondiente al atributo marca.
 *  También poseerá el atributo codigoDeBarras, el cual se publicará sólo a través de la conversión explícita nombrada más adelante.
 *  El método de clase (estático) MostrarProducto es público y retornará una cadena detallando los atributos de la clase.
 *  
 *  Posee las siguientes sobrecargas de operadores:
 *  explicit: Realizará la conversión de un objeto Producto a string. Sólo retornará el atributo codigoDeBarras del producto.
 *  == (Producto, Producto): Retornará true si las marcas y códigos de barra son iguales, false caso contrario.
 *  == (Producto, string): Retornará true si la marca del producto coincide con la cadena pasada como argumento, false caso contrario.
 *  
 *  Generar la clase Estante.
 *  
 *  ESTANTE
 *      Fields
 *      (private) productos : Producto[]
 *      (private) ubicacionEstante : int
 *      Methods
 *      (static) Estante(int capacidad)
 *      Estante(int capacidad, int ubicacion)
 *      GetProductos() : Producto[]
 *      MostrarEstante(Estante e) : string
 *      operator !=(Estante e, Producto p) : bool
 *      operator -(Estante e, Prodicto p) : Estante
 *      operator +(Estante e, Producto p) : bool
 *      operator ==(Estante e, Producto p) : bool
 *      
 *  Posee dos atributos privados. Uno será un entero que indicará la ubicación del estante y el otro es un array de tipo Producto.
 *  El constructor de instancia privado será el único que incializará el array. La sobrecarga pública del constructor inicializará la ubicación del estante,
 *  recibiendo como parámetros la capacidad y la ubicación. Reutilizar código.
 *  El método público GetProductos, retornará el array de productos.
 *  El método público de clase (estático) MostrarEstante, retornará una cadena con toda la información del estante incluyendo el detalle de cada uno de sus productos. Reutilizar código.
 *  
 *  Posee las siguientes sobrecargas de operadores:
 *  ==: Retornará true si es que el producto ya se encuentra en el estante, false caso contrario.
 *  +: Retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y dicho producto no se encuentra en el estante, false caso contrario. Reutilizar código.
 *  -: Retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado. Reutilizar código.    
 *      
 *  Crear un proyecto de consola y agregar en el método Main el siguiente código:
 *  
 */

using System;
using BibliotecaC04EC02;

namespace C04EC02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo un estante
            Estante estante = new Estante(3, 1);

            // Creo 4 productos
            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);

            // Agrego los productos al estante
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }

            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }

            if (estante + p2)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }

            if (estante + p3)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }

            if (estante + p4)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }

            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));
        }
    }
}
