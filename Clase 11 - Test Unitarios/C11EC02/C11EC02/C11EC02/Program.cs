/*
 *  Ejercicio I01 - Lanzar y atrapar
 * 
 *  Crear una aplicación de consola y agregar el código necesario para:
 *      1. Crear dos excepciones propias (nuevas clases que hereden de Exception) con los nombres UnaExcepcion y MiExcepcion.
 *      2. Crear una clase llamada MiClase y dentro colocar un método estático y dos constructores de instancia.
 *      3. Dentro del método estático lanzar una excepción DivideByZeroException (sólo lanzarla).
 *      4. Capturar la excepción del punto anterior en uno de los constructores de instancia y relanzarla hacia el otro constructor de instancia.
 *      5. En este segundo constructor se deberá instanciar otro objeto del tipo MiClase, capturando su excepción. 
 *      Crear una excepción propia llamada UnaException (utilizar la propiedad InnerException para almacenar la excepción original) y volver a lanzarla.
 *      6. Generar la clase OtraClase con un método de instancia, donde se instancie un objeto MiClase y se capture la excepción anterior. 
 *      Este método generará una excepción propia llamada MiException y la lanzará.
 *      7. MiException será capturada en el método Main, mostrando el mensaje de error que esta almacena por pantalla y los mensajes de todas las excepciones 
 *      almacenadas en sus propiedades InnerException. 
 *       
 */

using System;
using System.Text;
using C11EC02;
using ExcepcionesC10EI01;

namespace C11EC02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtraClase prueba = new OtraClase();

            try
            {
                prueba.MetodoDeInstancia();

            }
            catch (MiException ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Se capturó MiExcepcion!!");
                sb.AppendLine("-------------------------------------");
                sb.AppendLine("Mensaje de MiExcepción: " + ex.Message);
                sb.AppendLine("Mensaje de MiExcepción.InnerException (UnaExepcion): " + ex.InnerException.Message);
                sb.AppendLine("Mensaje de MiExcepción.InnerException.InnerException (DivideByZeroException): " + ex.InnerException.InnerException.Message);

                Console.WriteLine(sb.ToString());
            }

        }
    }
}
