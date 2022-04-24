/*
 *  Ejercicio I07 - Recibo de sueldo
 * 
 *  Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes 
 *  de N cantidad de empleados de una fábrica.
 *  Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
 *  hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
 *  Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos 
 *  los empleados ingresados.
 *  
 */

using System;

namespace C01EI07
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorHora;
            string nombre;
            int antiguedad;
            int cantidadHorasTrabajadas;
            bool seguir;

            double sueldoBruto;
            double sueldoNeto;

            double auxDouble;
            char auxChar;
            string auxString;

            int i = 1;

            do
            {
                Console.Clear();

                Console.WriteLine($"Empleado {i}:");
                Console.WriteLine("-------------");

                //ingreso de valor hora y verificacion
                Console.Write("Ingrese valor hora: ");
                auxString = Console.ReadLine();
                while (!double.TryParse(auxString, out valorHora))
                {
                    Console.Write("Error! Ingrese un valor: ");
                    auxString = Console.ReadLine();
                }

                //ingreso de nombre y verificacion
                Console.Write("Ingrese nombre: ");
                nombre = Console.ReadLine();
                while (double.TryParse(nombre, out auxDouble))
                {
                    Console.Write("Error! Ingrese un nombre: ");
                    nombre = Console.ReadLine();
                }

                //ingreso de antigüedad y verificacion
                Console.Write("Ingrese antigüedad: ");
                auxString = Console.ReadLine();
                while (!int.TryParse(auxString, out antiguedad))
                {
                    Console.Write("Error! Ingrese un valor: ");
                    auxString = Console.ReadLine();
                }

                //ingreso de cant. horas trabajadas y verificacion
                Console.Write("Ingrese cantidad de horas trabajadas: ");
                auxString = Console.ReadLine();
                while (!int.TryParse(auxString, out cantidadHorasTrabajadas))
                {
                    Console.Write("Error! Ingrese un valor: ");
                    auxString = Console.ReadLine();
                }

                //operaciones
                sueldoBruto = (valorHora * cantidadHorasTrabajadas) + (antiguedad * 150);
                sueldoNeto = sueldoBruto - (sueldoBruto * 13 / 100);

                i++;

                Console.Clear();
                Console.WriteLine("-------------------- RECIBO DE SUELDO --------------------");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Antigüedad: {antiguedad}");
                Console.WriteLine($"Horas trabajadas en el mes: {cantidadHorasTrabajadas}");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine($"Total a cobrar en bruto: ${sueldoBruto}");
                Console.WriteLine($"Total a cobrar en neto: ${sueldoNeto}");
                Console.WriteLine("----------------------------------------------------------");

                do
                {
                    Console.WriteLine("\n\n¿Desea Continuar? S/N");
                    auxChar = Console.ReadLine().ToUpper()[0];

                } while (auxChar != 'N' && auxChar != 'S');

                //innecesario, pero quería que la condicion de salida sea booleana
                if (auxChar == 'S')
                    seguir = true;
                else
                    seguir = false;

            } while (seguir);

            Console.WriteLine("Adios Mundo!");
        }
    }
}
