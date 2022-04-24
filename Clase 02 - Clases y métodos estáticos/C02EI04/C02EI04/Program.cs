/*
 *  Ejercicio I04 - La calculadora
 *  
 *  Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
 *  
 *  Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
 *      Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.
 *      Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
        Este método devolverá true si el operando es distinto de cero.

 *  Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).
 *  El usuario decidirá cuándo finalizar el programa.
 * 
 */

using System;
using BibliotecaC02EI04;

namespace C02EI04
{
    class Program
    {
        static void Main(string[] args)
        {
            char salir = 'N';
            
            double operando1, operando2;
            double? resultado;
            char operacion;

            string auxString;

            do
            {
                Console.Clear();

                Console.Write("Ingrese primer operando: ");
                auxString = Console.ReadLine();
                while(!double.TryParse(auxString, out operando1))
                {
                    Console.Write("Error! Ingrese primer operando: ");
                    auxString = Console.ReadLine();
                }

                Console.Write("Ingrese segundo operando: ");
                auxString = Console.ReadLine();
                while (!double.TryParse(auxString, out operando2))
                {
                    Console.Write("Error! Ingrese segundo operando: ");
                    auxString = Console.ReadLine();
                }

                do
                {
                    Console.Write("Ingrese operacion [+ - * /] : ");
                    char.TryParse(Console.ReadLine(), out operacion);

                } while (operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/');

                resultado = Calculadora.Calcular(operando1, operando2, operacion);

                if (resultado != null)
                    Console.WriteLine($"{operando1} {operacion} {operando2} = {resultado}");
                else
                    Console.WriteLine("No es posible dividir por CERO");

                Console.WriteLine("¿Desea Salir? S/N");
                char.TryParse(Console.ReadLine().ToUpper(), out salir);

            } while (salir != 'S');

            Console.WriteLine("ADIOS MUNDO!");
        }
    }
}
