/*
 *  Ejercicio C01 - Lanzar, atrapar, probar y guardar
 * 
 *  1. Partir del ejercicio Lanzar, atrapar y probar y agregarle un nuevo proyecto llamado IO.
 *  
 *  2. Dentro de este proyecto crear la clase estática ArchivoTexto que deberá contener:
 *      i. Un método Guardar que agregará información al archivo de texto ubicado en la ruta pasada como parámetro. También recibirá un string con la información a guardar.
 *      ii. Un método Leer que retornará el contenido del archivo ubicado en la ruta pasada como parámetro. 
 *          En caso de no existir, lanzará la excepción de sistema FileNotFoundException.
 *          
 *  3. Modificar en el método Main donde se captura la excepción. Quitar los Console.WriteLine y guardar todos los datos del error en un archivo de texto, 
 *      cuyo nombre será la fecha y hora actual con el formato: [año][mes][día]–[hora][minutos].txt.
 *      Por ejemplo: 20171012-1316.txt
 *  
 *  4. Luego, fuera del bloque catch, utilizar el método Leer para mostrar por pantalla los mensajes de error.
 *       
 */

using System;
using System.IO;
using System.Text;
using ExcepcionesC14EC01;
using IOC14EC01;

namespace C14EC01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtraClase prueba = new OtraClase();
            string archivoGuardado = string.Empty;

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

                //Console.WriteLine(sb.ToString());

                try
                {
                    archivoGuardado = ArchivoTexto.Guardar(".txt", sb.ToString());
                }
                catch (Exception)
                {
                    archivoGuardado = "";
                }
            }

            try
            {
                Console.WriteLine(ArchivoTexto.Leer(archivoGuardado));
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Error4");
            }
            
        }
    }
}
