/*
 *  Ejercicio C02 - Vulcano
 *  
 *  Partir del ejercicio Fahrenheit 451 y agregarle un proyecto de tipo Windows Forms App con el siguiente formato:
 *  Implementarlo con la misma lógica que el ejercicio Cotizador desktop.
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaC04EA01;

namespace C05EC02
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
            Application.Run(new FrmConversor());
        }
    }
}
