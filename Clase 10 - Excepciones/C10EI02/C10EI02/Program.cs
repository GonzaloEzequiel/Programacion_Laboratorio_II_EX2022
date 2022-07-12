/*
 *  Ejercicio I02 - Atrapame si puedes...
 * 
 *  Consigna
 *  Crear una aplicación de Windows Forms que pueda realizar un cálculo de consumo entre kilometros y litros.
 *  
 *  El formulario deberá contener:
 *      2x Labels
 *      2x TextBox
 *      1x Button
 *      1x RichTextbox
 *      
 *  El formulario debe levantar en el centro de la pantalla, no debe tener los botones de maximizar, minimizar y no se le tiene que poder modificar el tamaño.
 *  El RichTextbox no tiene que poder editarse.
 *  El formulario debe validar que los dos parámetros ingresados no estén vacíos y en caso de estar se deberá lanzar una nueva excepción 
 *      de tipo ParametrosVaciosException e informar al usuario.
 *  Una vez que los parámetros fueron cargados validar si la conversión es posible (utilizar int.Parse), de lo contrario capturar la excepción correspondiente.
 *  Crear una clase estática llamada Calculador con un metodo estático Calcular que recibe dos enteros y retorna su división tener en cuenta 
 *      que las división por cero lanza una excepción, controlarla.
 *  Todas las excepciones que fueron capturadas deben ser mostradas al usuario de una forma mas entendible ("amigable") por medio del metodo Show 
 *      de la clase MessageBox.
 *      
 *  El programa no debe tener ninguna excepción no controlada.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C10EI02
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCalculador());
        }
    }
}
