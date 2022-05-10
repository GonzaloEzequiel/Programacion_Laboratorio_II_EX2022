/*
 *  Ejercicio I02 - Control de aduana
 *  
 *  1. Crear un proyecto de pruebas unitarias y agregar las clases y métodos de prueba del siguiente diagrama:
 *  
 *  
 *  2. Crear un proyecto de tipo biblioteca de clases y agregar los elementos del siguiente diagrama:
 *  
 *  Paquete
 *      Es una clase abstracta.
 *      Su atributo costoEnvio es protegido.
 *      La propiedad TienePrioridad es abstracta.
 *      El método ObtenerInformacionDePaquete retorna todos los datos del paquete (incluyendo si tiene prioridad) como una cadena de texto.
 *      
 *  PaqueteFragil
 *      Hereda de Paquete.
 *      Implementa la propiedad TienePrioridad retornando true ya que los paquetes frágiles tienen prioridad.
 *      Implementar la prueba unitaria TienePrioridad_DeberiaRetornarTrue de la clase PaqueteFragilTest. 
 *          Deberá verificar que la propiedad TienePrioridad retorne true para las instancias de PaqueteFragil.
 *          
 *  PaquetePesado
 *      Hereda de Paquete.
 *      Implementa la propiedad TienePrioridad retornando false ya que los paquetes pesados NO tienen prioridad.
 *      Implementar la prueba unitaria TienePrioridad_DeberiaRetornarFalse de la clase PaquetePesadoTest.
 *          Deberá verificar que la propiedad TienePrioridad retorne false para las instancias de PaquetePesado.
 * 
 *  3. Implementar la interfaz IAduana en Paquete de forma implícita.
 *  
 *      i. Implementar la prueba unitaria Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio de la clase PaqueteFragilTest.
 *          Deberá verificar que la propiedad Impuestos, cuando se invoca de forma implícita desde una instancia de PaqueteFragil, 
 *          retorne el 35% del costo de envío.
 *      
 *      ii. Implementar la prueba unitaria Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita 
 *          de la clase PaquetePesadoTest. Deberá verificar que la propiedad Impuestos, cuando se invoca de forma implícita desde una instancia 
 *          de PaquetePesado, retorne el 35% del costo de envío.
 *          
 *      iii. Realizar los cambios necesarios en Paquete para que las pruebas de los puntos anteriores pasen.
 *      
 *      iv. El método AplicarImpuestos deberá ser virtual. 
 *          
 *      v. Implementar la prueba unitaria AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana de la clase PaqueteFragilTest. 
 *          Deberá verificar que el método AplicarImpuestos, cuando se invoca de forma implícita desde una instancia de PaqueteFragil, 
 *          retorne el costo del envío con el impuesto de aduana aplicado.
 *      
 *      vi. Realizar los cambios necesarios en Paquete para que el test anterior pase. Reutilizar código.
 *      
 *  4. Implementar la interfaz IAfip en PaquetePesado.
 *      
 *      i. La propiedad Impuestos deberá ser implementada de forma explícita.
 *      
 *      ii. Implementar la prueba unitaria Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaIAfip 
 *          de la clase PaquetePesadoTest. Deberá verificar que la propiedad Impuestos, cuando se invoca de forma explícita desde una referencia de tipo IAfip, 
 *          retorne el 25% del costo de envío.
 *          
 *      iii. Realizar los cambios necesarios en PaquetePesado para que el test pase.
 *      
 *      iv. Implementar la prueba unitaria AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana de la clase PaquetePesadoTest. 
 *          Deberá verificar que el método AplicarImpuestos, cuando se invoca de forma implícita desde una instancia de PaquetePesado, 
 *          retorne el costo de envío con ambos impuestos de AFIP y aduana aplicados.
 *          
 *      v. Sobrescribir el método AplicarImpuestos en PaquetePesado y realizar lo necesario para que el test anterior pase. Reutilizar código.
 * 
 *  5. Agregar la clase GestionImpuestos a la biblioteca de clases. Seguir el siguiente diagrama:
 *  
 *      Las listas se instanciarán en el constructor.
 *      La sobrecarga del método RegistrarImpuestos que recibe un paquete deberá agregar dicho paquete a la lista impuestosAduana. 
 *          Además, si el paquete implementa IAfip deberá ser incorporado a la lista impuestosAfip.
 *      La sobrecarga del método RegistrarImpuestos que recibe una lista de paquetes deberá agregar todos los paquetes a la lista impuestosAduana. 
 *          Además, los paquetes que implementen IAfip deberán ser incorporados a la lista impuestosAfip. Reutilizar código.
 *          
 *  6. Implementar la prueba unitaria CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana de la clase GestionImpuestosTest.
 *      Deberá verificar que el método CalcularTotalImpuestosAduana retorne la suma de los impuestos de aduana. 
 *          Realizar la prueba con al menos un paquete de cada tipo.
 *          
 *  7. Implementar la prueba unitaria CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip de la clase GestionImpuestosTest. 
 *      Deberá verificar que el método CalcularTotalImpuestosAfip retorne la suma de los impuestos de AFIP. 
 *          Realizar la prueba con al menos un paquete de cada tipo.
 *  
 *  8. Crear un proyecto de consola e incoporar el siguiente código en el método Main:
 *  
 *  9. Verificar que la salida por consola coincida con la siguiente:
 *  
 *  
 */

using System;
using System.Collections.Generic;
using System.Text;
using BibliotecaC13EI02;

namespace ConsolaC13EI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaqueteFragil("F01", 190.00M, "Buenos aires", "La rioja", 1.75));
            paquetes.Add(new PaquetePesado("P01", 2598.63M, "Misiones", "San luis", 56.32));
            paquetes.Add(new PaqueteFragil("F02", 1599.99M, "Córdoba", "Mendoza", 44.12));
            paquetes.Add(new PaquetePesado("P02", 639.60M, "Jujuy", "Tierra del fuego", 5.05));
            paquetes.Add(new PaqueteFragil("F03", 458.95M, "Santa cruz", "San Juan", 10.00));
            paquetes.Add(new PaquetePesado("P03", 120.40M, "Río negro", "Neuquén", 35.00));

            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            gestionImpuestos.RegistrarImpuestos(paquetes);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Total impuestos aduana: ${gestionImpuestos.CalcularTotalImpuestosAduana():#.00}");
            stringBuilder.AppendLine($"Total impuestos AFIP: ${gestionImpuestos.CalcularTotalImpuestosAfip():#.00}");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Paquetes:");

            for (int i = 0; i < paquetes.Count; i++)
            {
                stringBuilder.AppendLine("---------------------------------------");
                stringBuilder.AppendLine($"PAQUETE {i + 1:00}");
                stringBuilder.AppendLine(paquetes[i].ObtenerInformacionDePaquete());

                if (paquetes[i] is IAfip paqueteAfip)
                {
                    stringBuilder.AppendLine($"Impuesto AFIP: ${paqueteAfip.Impuestos:#.00}");
                }

                if (paquetes[i] is IAduana paqueteAduana)
                {
                    stringBuilder.AppendLine($"Impuesto aduana: ${paqueteAduana.Impuestos:#.00}");
                }

                stringBuilder.AppendLine($"Costo de envío con impuestos: ${paquetes[i].AplicarImpuestos():#.00}");
            }

            stringBuilder.AppendLine("---------------------------------------");

            Console.WriteLine(stringBuilder);
        }
    }
}
