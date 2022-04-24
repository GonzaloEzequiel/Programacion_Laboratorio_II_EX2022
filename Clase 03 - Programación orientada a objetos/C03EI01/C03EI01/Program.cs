/*
 *  Ejercicio I01 - Creo que necesito un préstamo 
 * 
 *  Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.
 *  Deberá tener los atributos:
 *      titular - que contendrá la razón social del titular de la cuenta.
 *      cantidad - que será un número decimal que representa al monto actual de dinero en la cuenta.
 *  Construir los siguientes métodos para la clase:
 *      Un constructor que permita inicializar todos los atributos.
 *      Un método getter para cada atributo.
 *      Mostrar() retornará una cadena de texto con todos los datos de la cuenta.
 *      Ingresar() recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
 *      Retirar() recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
 *      
 *  En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
 *  
 */
using System;
using BibliotecaC03EI01;

namespace C03EI01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Gonzalo", 70000.00M);
            Cuenta cuenta2 = new Cuenta("Florencia", 64000.00M);

            Cuenta cuentaSeleccionada;

            int opcion;

            decimal auxDecimal;
            string auxString;

            char salir = 'N';

            //menu entrada
            do
            {
                Console.WriteLine("POR MOTIVOS ESTRICTAMENTE DIDACTICOS:");
                Console.WriteLine($"1- {cuenta1.Mostrar()}");
                Console.WriteLine($"2- {cuenta2.Mostrar()}");
                Console.Write("Seleccione una cuenta: ");
                auxString = Console.ReadLine();
                int.TryParse(auxString, out opcion);

            } while (opcion != 1 && opcion != 2);            

            if (opcion == 1)
                cuentaSeleccionada = cuenta1;
            else
                cuentaSeleccionada = cuenta2;

            do
            {
                Console.Clear();

                Console.WriteLine(cuentaSeleccionada.Mostrar());

                //menu de opcion
                do
                {
                    Console.WriteLine("ELEGIR OPCION:");
                    Console.WriteLine($"1- Ingresar");
                    Console.WriteLine($"2- Retirar");
                    Console.Write("Seleccione una opcion: ");
                    auxString = Console.ReadLine();
                    int.TryParse(auxString, out opcion);

                } while (opcion != 1 && opcion != 2);

                switch (opcion)
                {
                    case 1:
                        do
                        {
                            Console.Write($"Monto a Ingresar: $");
                            auxString = Console.ReadLine();

                        } while (!decimal.TryParse(auxString, out auxDecimal));

                        cuentaSeleccionada.Ingresar(auxDecimal);

                        break;

                    case 2:

                        do
                        {
                            Console.Write($"Monto a Retirar: $");
                            auxString = Console.ReadLine();

                        } while (!decimal.TryParse(auxString, out auxDecimal));

                        cuentaSeleccionada.Retirar(auxDecimal);

                        break;
                }

                Console.Write("Desea Salir?");
                salir = char.Parse(Console.ReadLine());

            } while (salir != 'S');            

            Console.ReadKey();
        }
    }
}
