/*
 *  Ejercicio A02 - La veterinaria
 * 
 *  Requerimiento
 *  El dueño de una veterinaria nos contrató para que desarrollemos una aplicación donde pueda consultar la lista de clientes y sus mascotas.
 *  De los clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. A un cliente se le pueden asociar una o más mascotas.
 *  De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación. Los primeros tres datos son obligatorios para dar de alta una mascota, 
 *  mientras que el último arrancará vacío y se podrá ir agregando vacunas. De las vacunas sólo interesa conocer el nombre.
 *  
 *  Consigna
 *  Crear una aplicación de consola.
 *  Modelar y declarar las clases necesarias para resolver la necesidad del cliente. Hacerlo en un proyecto de biblioteca de clases.
 *  Las clases deberán tener los métodos necesarios, incluyendo uno que devuelva toda la información del objeto en formato string.
 *  
 *  Instanciar los siguientes objetos:
 *  Un cliente con un perro sin vacunar.
 *  Un cliente con un gato con la vacuna "Triple Felina".
 *  Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
 *  Mostrar por consola todos los datos de los clientes instanciados y sus mascotas.
 * 
 */

using System;
using BibliotecaC03EA02;

namespace C03EA02
{
    class Program
    {
        static void Main(string[] args)
        {            
            //se instancian los clientes
            Cliente cliente1 = new Cliente("Juan Carlos", "Rivadavia 2150 10°A", "48654715");
            Cliente cliente2 = new Cliente("Florencia", "Dawin 666 PB", "41825748");
            Cliente cliente3 = new Cliente("Gonzalo", "Ramos 26", "49538620");
            //se instancian las mascotas
            Mascota mascota1 = new Mascota("Perro", "Raulito", new DateTime(2015, 06, 12));
            Mascota mascota2 = new Mascota("Gato", "Lomito", new DateTime(2018, 12, 1), "Triple Felina");
            Mascota mascota3 = new Mascota("Gato", "Menta", new DateTime(2018, 12, 12));
            Mascota mascota4 = new Mascota("Perro", "Ravioles", new DateTime(2020, 02, 24), "AntiRábica");
            //se agregan los clientes creados a una lista de clientes de la veterinaria
            Veterinaria.AgregarClientes(cliente1);
            Veterinaria.AgregarClientes(cliente2);
            Veterinaria.AgregarClientes(cliente3);
            //se vinculan las mascotas a los clientes
            cliente1.AgregarMascota(mascota1);
            cliente2.AgregarMascota(mascota2);
            cliente3.AgregarMascota(mascota3);
            cliente3.AgregarMascota(mascota4);
            
            //y se muestran en pantalla
            foreach (Cliente item in Veterinaria.Clientes)
                Console.WriteLine(item.Mostrar());

            Console.ReadKey();
        }
    }
}
