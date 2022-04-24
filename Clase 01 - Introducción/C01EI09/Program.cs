/*
 *  Ejercicio I09 - Dibujando un triángulo equilátero
 *  
 *  Escribir un programa que imprima por consola un triángulo como el siguiente:
 *  
 *          *
 *         ***
 *        *****
 *       *******
 *      *********
 *      
 *  El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
 *  
 */

using System;

namespace C01EI09
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;

            int auxInt;
            string auxString;

            //ingreso y validación del número (altura) por parte del usuario
            Console.WriteLine("** Triángulo Equilátero **");
            Console.Write("Ingrese altura: ");
            auxString = Console.ReadLine();
            while (!int.TryParse(auxString, out altura) || altura <= 0)
            {
                Console.WriteLine("Error! Ingrese un numero entero postivo: ");
            }

            auxInt = altura;

            //iteracion de "altura"
            for (int i = 1; i <= altura; i++)
            {
                //iteracion de margen izquierdo
                for (int j = (auxInt - 1); j > 0; j--)
                {
                    Console.Write(" ");
                }

                //iteracion de "ancho" del piso
                for (int k = i + (i - 1); k > 0; k--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                auxInt--;
            }
        }
    }
}
