/*
 *  Ejercicio C01 - Cotizador desktop
 *  
 *  Partir del ejercicio Cotizador y agregarle un proyecto de tipo Windows Forms App con el siguiente formato:
 *  
 *  Agregar el método estático SetCotizacion en las clases Euro y Peso.
 *  La casilla de cotización del dólar deberá permanecer siempre en 1. Utilizar el evento de pérdida de foco del TextBox para chequear que así sea.
 *  El formulario debe iniciar centrado en la pantalla, no tener las cajas de maximizar y minimizar y no poder modificarse su tamaño.
 *  Utilizar un ImageList para los dos estados del botón (candado cerrado y abierto).
 *  Cerrado: los TextBox txtCotizacion (Euro | Dólar | Pesos) no podrán ser editados (propiedad Enabled en false).
 *      Descargar icono de candado cerrado
 *  Abierto: los TextBox serán editables.
 *      Descargar icono de candado abierto
 *  Al producirse el evento Leave de cada TextBox, editar la cotización de la moneda correspondiente. Si el dato ingresado no es válido, devolver el foco a dicho control.
 *  
 *  Implementarlo de tal forma que al ingresar un valor válido en la primer casilla (txtEuro, txtDolar y txtPeso respectivamente) y 
 *  presionar el botón del medio (btnConvertEuro, btnConvertDolar y btnConvertPeso) el resultado de la conversión se vea reflejado en las casillas de la derecha 
 *  (txtEuroAEuro, txtEuroADolar, txtEuroAPeso, txtDolarAEuro, txtDolarADolar, txtDolarAPeso, txtPesosAEuro, txtPesosADolar y txtPesosAPeso), 
 *  las cuales no podrán ser editadas/escritas por el usuario.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace C05EC01
{
    static class Program
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
            Application.Run(new frmConversor());
        }
    }
}
