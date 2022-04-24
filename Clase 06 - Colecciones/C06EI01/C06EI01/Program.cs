/*
 *  Ejercicio I01 - Números locos
 *  
 *  Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.
 *  Mostrar el vector tal como fue ingresado.
 *  Luego mostrar los positivos ordenados en forma decreciente.
 *  Por último, mostrar los negativos ordenados en forma creciente. 
 * 
 */

using System;

namespace C06EI01
{
    class Program
    {
        static void Main(string[] args)
        {
            //se instancia un array de 20 numeros enteros
            int[] numerosEnteros = new int[20];
            int[] auxArrayPositivos = new int[20];
            int[] auxArrayNegativos = new int[20];
            Random randomLoco = new Random();

            //se carga el array de numeros enteros generados
            for(int i=0; i<numerosEnteros.Length; i++)
            {
                do
                {
                    numerosEnteros[i] = randomLoco.Next(-100, 100);

                } while (numerosEnteros[i] == 0);
            }

            //se muestra el vector original en pantalla
            Console.WriteLine("Array Original:");
            Console.Write("[");
            foreach(int numero in numerosEnteros)
            {
                Console.Write($"{numero}");
                if (Array.IndexOf(numerosEnteros, numero) != numerosEnteros.Length - 1)
                    Console.Write(", ");
            }
            Console.Write("]\n\n");

            //separo los numeros positivos de los negativos
            int k = 0;
            int j = 0;
            foreach (int numero in numerosEnteros)
            {
                if (numero > 0)
                {
                    auxArrayPositivos[k] = numero;
                    k++;
                }
                else
                {
                    auxArrayNegativos[j] = numero;
                    j++;
                }                
            }

            //redimensiono ambos arrays
            Array.Resize<int>(ref auxArrayPositivos, k);
            Array.Resize<int>(ref auxArrayNegativos, j);

            //ordeno ambos arrays de forma creciente
            Array.Sort(auxArrayPositivos);
            Array.Sort(auxArrayNegativos);
            //intercambio las posiciones de los elementos del array de positivos (decreciente)
            Intercambiar(auxArrayPositivos);

            //se muestran los nuevos vectores en pantalla
            Console.WriteLine("Array de positivos ordenados decreciente:");
            Console.Write("[");
            foreach (int numero in auxArrayPositivos)
            {
                Console.Write($"{numero}");
                if (Array.IndexOf(auxArrayPositivos, numero) != auxArrayPositivos.Length - 1)
                    Console.Write(", ");
            }
            Console.Write("]\n\n");
            Console.WriteLine("Array de negativos ordenados creciente:");
            Console.Write("[");
            foreach (int numero in auxArrayNegativos)
            {
                Console.Write($"{numero}");
                if (Array.IndexOf(auxArrayNegativos, numero) != auxArrayNegativos.Length - 1)
                    Console.Write(", ");
            }
            Console.Write("]\n\n");
        }

        /// <summary>
        /// Intercambia los valores de las posiciones de un array de enteros
        /// </summary>
        /// <param name="a">El array</param>
        private static void Intercambiar(int[] a)
        {
            int aux;
            for(int i=0; i<a.Length-1; i++)
            {
                for(int j=1; j<a.Length; j++)
                {
                    aux = a[i];
                    a[i] = a[j];
                    a[j] = aux;
                }
            }
        }
    }
}
