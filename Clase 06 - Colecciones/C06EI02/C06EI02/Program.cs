/*
 *  Ejercicio I02 - Números locos II
 *  
 *  Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.
 *  Mostrar la colección tal como fue cargada.
 *  Luego mostrar los positivos ordenados en forma decreciente.
 *  Por último, mostrar los negativos ordenados en forma creciente.
 * 
 */

using System;
using System.Collections.Generic;

namespace C06EI02
{
    class Program
    {
        static void Main(string[] args)
        {
            //se intancian la Lista, Pila y Cola de numeros enteros
            List<int> lista = new List<int>();
            Stack<int> pilaPos = new Stack<int>();
            Stack<int> pilaNeg = new Stack<int>();
            Queue<int> colaPos = new Queue<int>();
            Queue<int> colaNeg = new Queue<int>();
            Random randomLoco = new Random();

            //se agregan a las colecciones numeros enteros generados al azar
            for(int i=0; i<20; i++)
            {
                do
                {
                    lista.Add(randomLoco.Next(-100, 100));

                } while (lista[i] == 0);
            }

            //se muestran en pantalla
            Console.WriteLine("Lista Original");
            Console.Write("[");
            foreach (int numero in lista)
            {
                Console.Write($"{numero}");
                if(lista.IndexOf(numero) != lista.Count-1)
                    Console.Write(", ");
            }
            Console.Write("]\n\n");

            //------------------------------------------------------------------------------
            Console.WriteLine("Lista Ordenada decreciente");
            Console.Write("[");
            lista.Sort(Program.Drececiente);
            foreach (int numero in lista)
            {
                Console.Write($"{numero}");
                if (lista.IndexOf(numero) != lista.Count - 1)
                    Console.Write(", ");
            }
            Console.Write("]\n\n");

            //------------------------------------------------------------------------------
            Console.WriteLine("Lista Positivos");
            Console.Write("[");
            foreach (int numero in lista)
            {
                if (numero > 0)
                {
                    Console.Write($"{numero}");
                    if (lista.IndexOf(numero) != lista.Count - 1)
                        Console.Write(", ");
                    colaPos.Enqueue(numero);
                }
                else
                {
                    colaNeg.Enqueue(numero);                    
                }                
            }
            Console.Write("]\n\n");

            //------------------------------------------------------------------------------
            Console.WriteLine("Lista Negativos");
            Console.Write("[");
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] < 0)
                {
                    Console.Write($"{lista[i]}");
                    if (i != 0)
                        Console.Write(", ");
                    pilaNeg.Push(lista[i]);
                }
                else
                {                    
                    pilaPos.Push(lista[i]);
                }
                
            }
            Console.Write("]\n\n");

            //------------------------------------------------------------------------------
            Console.WriteLine("Cola Positivos");
            Console.Write("[");
            foreach (int numero in colaPos)
            {
                Console.Write($"{numero}");
                if (lista.IndexOf(numero) != colaPos.Count - 1)
                    Console.Write(", ");
            }
            Console.Write("]\n\n");

            //------------------------------------------------------------------------------
            Console.WriteLine("Cola Negativos");
            Console.Write("[");
            foreach (int numero in colaNeg)
            {
                Console.Write($"{numero}");
                if (lista.IndexOf(numero) != lista.Count - 1)
                    Console.Write(", ");
            }
            Console.Write("]\n\n");

            //------------------------------------------------------------------------------
            Console.WriteLine("Pila Positivos");
            Console.Write("[");
            foreach (int numero in pilaPos)
            {
                Console.Write($"{numero}");
                if (lista.IndexOf(numero) != pilaPos.Count - 1)
                    Console.Write(", ");
            }
            Console.Write("]\n\n");

            //------------------------------------------------------------------------------
            Console.WriteLine("Pila Negativos");
            Console.Write("[");
            foreach (int numero in pilaNeg)
            {
                Console.Write($"{numero}");
                if (lista.IndexOf(numero) != lista.Count - 1)
                    Console.Write(", ");
            }
            Console.Write("]\n\n");
        }

        public static int Drececiente(int a, int b)
        {
            return b - a;
        }
    }
}
