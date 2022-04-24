/*
 *  Ejercicio I01 - El viajar es un placer
 * 
 *  Crear un proyecto de biblioteca de clases con las clases Automovil, Moto, Camion.
 *  
 *  1. Crear un enumerado Colores { Rojo, Blanco, Azul, Gris, Negro }
 *  2. Camion tendrá los atributos: cantidadRuedas: short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, pesoCarga : int.
 *  3. Automovil tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cantidadMarchas : short, cantidadPasajeros : int.
 *  4. Moto tendrá los atributos: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.
 *  5. Crearle a cada clase un constructor que reciba todos sus atributos.
 *  6. Crear la clase VehiculoTerrestre y abstraer la información necesaria de las clases anteriores. Luego generar una relación de herencia entre ellas, según corresponda.
 *  7. VehiculoTerrestre tendrá un constructor que recibirá todos sus atributos. Modificar las clases que heredan de ésta para que lo reutilicen.
 *  
 *  Crear un proyecto de consola y generar el código necesario para probar las clases.
 * 
 */

using System;
using System.Collections.Generic;
using BibliotecaC08EI01;

namespace C08EI01
{
    class Program
    {     
        static void Main(string[] args)
        {
            List<VehiculoTerrestre> lista = new List<VehiculoTerrestre>();

            Camion camion1 = new Camion(6, 2, EColores.Blanco, 6, 10000);
            Camion camion2 = new Camion(4, 2, EColores.Gris, 6, 6000);

            Automovil auto1 = new Automovil(4, 5, EColores.Azul, 5, 5);
            Automovil auto2 = new Automovil(4, 3, EColores.Negro, 5, 4);

            Moto moto1 = new Moto(2, 0, EColores.Rojo, 250);
            Moto moto2 = new Moto(2, 0, EColores.Negro, 125);

            lista.Add(camion1);
            lista.Add(camion2);
            lista.Add(auto1);
            lista.Add(auto2);
            lista.Add(moto1);
            lista.Add(moto2);

            foreach (VehiculoTerrestre vehiculo in lista)
                Console.WriteLine(vehiculo.Mostrar());

            Console.ReadKey();
        }
    }
}
