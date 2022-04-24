/*
 *  Ejercicio A01 - Vienen con sistema de auto-navegación
 * 
 *  Requerimiento
 *  De una empresa de transporte de cargas se quiere guardar el nombre de los conductores y los kilómetros que conducen cada día de la semana. *  
 *  Para guardar esta información, la empresa de transporte tendrá un array de conductores. *  
 *  De cada conductor se tendrá la siguiente información:
 *  
 *      Nombre del conductor.
 *      Kilometros recorridos por cada día de la semana. Por ejemplo:
 *      Día 1: 200
 *      Día 2: 599
 *      Día 3: 899
 *      Día 4: 0 (tiene franco)
 *      Día 5: 256
 *      Día 6: 0
 *      Día 7: 0
 *  
 *  Consigna
 *  Desarrollar las clases y métodos necesarios. Toda la lógica de negocio deberá estar encapsulada en clases y dentro de un proyecto de tipo biblioteca de clases.
 *  Crear un proyecto de consola y en el método Main cargar 3 conductores a la empresa de transportes.
 *  
 *  Luego mostrar:
 *  El conductor que hizo más km en esa semana.
 *  El conductor que hizo más km el día 3.
 *  El conductor que hizo más km el día 5.
 * 
 */

using System;
using BibliotecaC03EA01;

namespace C03EA01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variablesCorrespondientesACargaManual comentado
            //string auxNombre;
            //int auxDia;
            //string auxString;
            //double auxKms;
            #endregion

            int maxKmsSemana = 0;
            string maxKmsSemanaConductor = string.Empty;


            int maxKmsDia3 = 0;
            string maxKmsDia3Conductor = string.Empty;


            int maxKmsDia5 = 0;
            string maxKmsDia5Conductor = string.Empty;

            Conductor[] planilla = new Conductor[3];

            #region CARGA MANUAL comentado
            /*            
            for(int i=0; i<planilla.Length; i++)
            {
                //----------------------------------------- conductor
                Console.Write("Ingrese Nombre: ");
                auxNombre = Console.ReadLine().Trim();

                planilla[i] = new Conductor(auxNombre);

                //----------------------------------------- dia 1
                Console.Write("Kms día1: ");
                auxString = Console.ReadLine();
                while (!int.TryParse(auxString, out auxKms))
                {
                    Console.Write("Kms día1: ");
                    auxString = Console.ReadLine();
                }

                planilla[i].setKms(0, auxKms);

                //----------------------------------------- dia 2
                Console.Write("Kms día2: ");
                auxString = Console.ReadLine();
                while (!int.TryParse(auxString, out auxKms))
                {
                    Console.Write("Kms día2: ");
                    auxString = Console.ReadLine();
                }

                planilla[i].setKms(1, auxKms);

                //----------------------------------------- dia 3
                Console.Write("Kms día3: ");
                auxString = Console.ReadLine();
                while (!int.TryParse(auxString, out auxKms))
                {
                    Console.Write("Kms día3: ");
                    auxString = Console.ReadLine();
                }

                planilla[i].setKms(2, auxKms);

                //----------------------------------------- dia 4
                Console.Write("Kms día4: ");
                auxString = Console.ReadLine();
                while (!int.TryParse(auxString, out auxKms))
                {
                    Console.Write("Kms día4: ");
                    auxString = Console.ReadLine();
                }

                planilla[i].setKms(3, auxKms);

                //----------------------------------------- dia 5
                Console.Write("Kms día5: ");
                auxString = Console.ReadLine();
                while (!int.TryParse(auxString, out auxKms))
                {
                    Console.Write("Kms día5: ");
                    auxString = Console.ReadLine();
                }

                planilla[i].setKms(4, auxKms);

                //----------------------------------------- dia 6
                Console.Write("Kms día6: ");
                auxString = Console.ReadLine();
                while (!int.TryParse(auxString, out auxKms))
                {
                    Console.Write("Kms día6: ");
                    auxString = Console.ReadLine();
                }

                planilla[i].setKms(5, auxKms);

                //----------------------------------------- dia 7
                Console.Write("Kms día7: ");
                auxString = Console.ReadLine();
                while (!int.TryParse(auxString, out auxKms))
                {
                    Console.Write("Kms día7: ");
                    auxString = Console.ReadLine();
                }

                planilla[i].setKms(6, auxKms);

                for(int j=0; j<7; j++)
                {
                    planilla[i].totalKmsSemanales += planilla[i].getKms(j);
                }
            }
            */
            #endregion

            #region CARGA HARDCODEADA
            planilla[0] = new Conductor("Omar");
            planilla[0].SetKms(1, 1000);
            planilla[0].SetKms(2, 1000);
            planilla[0].SetKms(3, 1);
            planilla[0].SetKms(4, 1000);
            planilla[0].SetKms(5, 1);
            planilla[0].SetKms(6, 1000);
            planilla[0].SetKms(7, 1);

            planilla[1] = new Conductor("Ricardo");
            planilla[1].SetKms(1, 100);
            planilla[1].SetKms(2, 0);
            planilla[1].SetKms(3, 400);
            planilla[1].SetKms(4, 150);
            planilla[1].SetKms(5, 666);
            planilla[1].SetKms(6, 170);
            planilla[1].SetKms(7, 200);

            planilla[2] = new Conductor("El Pollo");
            planilla[2].SetKms(1, 420);
            planilla[2].SetKms(2, 666);
            planilla[2].SetKms(3, 450);
            planilla[2].SetKms(4, 375);
            planilla[2].SetKms(5, 200);
            planilla[2].SetKms(6, 0);
            planilla[2].SetKms(7, 0);

            for (int i = 0; i < planilla.Length; i++)
            {
                for (int j = 1; j < 8; j++)
                {
                    planilla[i].TotalKmsSemanales += planilla[i].GetKms(j);
                }
            }
            #endregion

            for (int i = 0; i < planilla.Length; i++)
            {
                if (planilla[i].TotalKmsSemanales > maxKmsSemana)
                {
                    maxKmsSemana = planilla[i].TotalKmsSemanales;
                    maxKmsSemanaConductor = planilla[i].Nombre;
                }

                if (planilla[i].GetKms(3) > maxKmsDia3)
                {
                    maxKmsDia3 = planilla[i].GetKms(3);
                    maxKmsDia3Conductor = planilla[i].Nombre;
                }

                if (planilla[i].GetKms(5) > maxKmsDia5)
                {
                    maxKmsDia5 = planilla[i].GetKms(5);
                    maxKmsDia5Conductor = planilla[i].Nombre;
                }
            }

            Console.WriteLine($"El conductor que hizo mas kms en la semana: {maxKmsSemanaConductor} ({maxKmsSemana})");
            Console.WriteLine($"El conductor que hizo mas kms el dia 3: {maxKmsDia3Conductor} ({maxKmsDia3})");
            Console.WriteLine($"El conductor que hizo mas kms el dia 5: {maxKmsDia5Conductor} ({maxKmsDia5})");

        }
    }
}
