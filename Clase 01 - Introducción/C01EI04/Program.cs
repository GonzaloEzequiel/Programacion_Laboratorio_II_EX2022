/*
 *  Ejercicio I04 - Un número perfecto
 *  
 *  Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
 *  El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
 *  Escribir una aplicación que encuentre los 4 primeros números perfectos.  
 *  
 */

using System;

namespace C01EI04
{
    class Program
    {
        static void Main(string[] args)
        {
            long sumaDeTodosLosEnterosPositivosDivisores;

            //iteración desde el 6 (dato) hasta el 10000 para cubrir los 4 primeros números perfectos
            for (int i=6; i<10000; i++)
            {
                sumaDeTodosLosEnterosPositivosDivisores = 0;

                //iteración desde un numero menos del inicio, pues se descarta que el numero es divisible por si mismo
                for(int j=i-1; j>=1; j--)
                {
                    if(i%j==0)
                    {
                        sumaDeTodosLosEnterosPositivosDivisores += j;
                    }
                }

                //si cumple la condicion se muestra
                if (i == sumaDeTodosLosEnterosPositivosDivisores)
                    Console.WriteLine($"{i} ");
            }
        }
    }
}
