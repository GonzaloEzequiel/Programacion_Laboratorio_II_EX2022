/*
 *  Ejercicio I01 - Puesto de atención
 * 
 *  Crear un proyecto de biblioteca de clases para un sistema de atención al cliente.
 *  Se deberán implementar las clases Cliente, Negocio y PuestoAtencion:
 *      -Diagrama de clases-
 *  
 *  Clase PuestoAtencion:
 *  El atributo numeroActual es estático y privado. Se inicializará en el constructor de clase (estático) con valor 0.
 *  El método Atender simulará un tiempo de atención a un cliente: recibirá un cliente, simulará un tiempo de atención mediante el método Sleep de la clase Thread 
 *  (perteneciente al espacio de nombre System.Threading) y retornará true para indicar el final de la atención.
 *  La propiedad estática NumeroActual es la encargada de incrementar en 1 al atributo numeroActual y luego retornarlo.
 *  
 *  Clase Cliente:
 *  La sobrecarga del operador == retornará true si dos clientes tienen el mismo número.
 *  
 *  Clase Negocio:
 *  El constructor privado inicializará la colección y el puesto de atención como Caja1.
 *  El operador + será el único capaz de agregar un Cliente a la cola de atención. Sólo se agregará un Cliente si este no forma parte de la lista. Reutilizar el == de Cliente.
 *  La propiedad Cliente retornará el próximo cliente en la cola de atención en el get. El set deberá controlar que el Cliente no figure en la cola de atención, caso contrario lo agregará.
 *  El operador == retornará true si el cliente se encuentra en la colección.
 *  El operador ~ generará una atención del próximo cliente en la cola, utilizando la propiedad Cliente y el método Atender de PuestoAtencion. 
 *  Retornará true si pudo realizar la operación completa.
 *  La propiedad ClientesPendientes retornará la cantidad de clientes esperando a ser atendidos.
 *  Crear un proyecto de consola y pegar el siguiente código en el método Main para probar la solución:
 * 
 */

using System;
using BilbiotecaC07EI01;

namespace C07EI01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(1, "Lautaro");
            Cliente c2 = new Cliente(2, "Mauricio");
            Cliente c3 = new Cliente(3, "Esteban");
            Negocio n1 = new Negocio("Kiosco-24");

            if (n1 + c1)
            {
                Console.WriteLine("Se agrego c1 a la cola");
            }

            if (!(n1 + c1))
            {
                Console.WriteLine("Cliente c1 ya esta en la cola");
            }

            if (n1 + c2)
            {
                Console.WriteLine("Se agrego c2 a la cola");
            }

            if (n1 + c3)
            {
                Console.WriteLine("Se agrego c3 a la cola");
            }

            Console.WriteLine("Clientes pendientes: {0}", n1.ClientesPendientes);

            while (~n1)
            {
                Console.WriteLine("Clientes pendientes: {0}", n1.ClientesPendientes);
            }
        }
    }
}
