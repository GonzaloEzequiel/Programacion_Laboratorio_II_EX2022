/*
 *  Ejercicio I03 - Los primos
 * 
 *  Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
 *  Validar que el dato ingresado por el usuario sea un número.
 *  Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
 *  Si ingresa "salir", cerrar la consola.
 *  Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
 * 
 */
using System;

namespace C01EI03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool primo;

            string numeroString;

            //ingreso del numero por parte del user
            Console.WriteLine("Ingrese un número: ");
            numeroString = Console.ReadLine();

            //validacion del dato ingresado
            while (!int.TryParse(numeroString, out numero))
            {
                Console.WriteLine("Error! Reingrese un número: ");
                numeroString = Console.ReadLine();
            }

            Console.WriteLine($"Números primos del 1 al {numero}:");

            //itero desde el 1 al numero ingresado (numerador)
            for (int i = 1; i < numero; i++)
            {
                primo = true;

                //itero desde i hasta el 1 (denominador)
                for (int j = i; j >= 1; j--)
                {
                    //un numero es primo si no tiene divisores (unicamente x 1 y x el mismo)
                    //yo asumo (en linea 39) que SÍ es primo, y si existe un divisor distinto de 1 rompo iteración
                    if ((i % j) == 0 && (j != 1 && j != i))
                    {
                        primo = false;
                        break;
                    }

                }

                //si es primo lo muestro
                if (primo)
                {
                    Console.Write($"{i}  ");
                }
            }
        }
    }
}