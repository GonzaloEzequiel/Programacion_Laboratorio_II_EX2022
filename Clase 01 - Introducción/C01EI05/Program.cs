/*
 *  Ejercicio I05 - Tirame un centro
 * 
 *  Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
 *  El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
 *  El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
 *  Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
 *  
 */

using System;

namespace C01EI05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroString;
            double sumaIzq;
            double sumaDer;

            bool centro = false;

            //ingreso del numero por parte del user
            Console.WriteLine("Ingrese un número: ");
            numeroString = Console.ReadLine();

            //validacion del dato ingresado
            while (!int.TryParse(numeroString, out numero))
            {
                Console.WriteLine("Error! Rengrese un número: ");
                numeroString = Console.ReadLine();
            }

            for (int i = 1; i < numero; i++)
            {
                sumaIzq = 0;
                sumaDer = 0;

                //se suman los numeros a la izq del ingresado
                for (int j = 1; j < i; j++)
                {
                    sumaIzq += j;
                }

                //se suman los numeros a la der del ingresado
                for (int k = numero; k > i; k--)
                {
                    sumaDer += k;
                }

                //si ambas sumas son iguales, se cumple la condicion, y el centro numérico es la actual iteración, por lo que rompo la misma
                if (sumaIzq == sumaDer)
                {
                    Console.WriteLine($"El centro numérico es: {i} ");
                    centro = true;
                    break;
                }
            }

            if (!centro)
            {
                Console.WriteLine($"No existe centro numérico entre 1 y {numero}");
            }
        }
    }
}