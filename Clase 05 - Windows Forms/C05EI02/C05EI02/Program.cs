/*
 *  Ejercicio I02 - Registrate
 * 
 *  Crear un proyecto de tipo Windows Forms App y un proyecto de biblioteca de clases.
 *  Agregar al proyecto de biblioteca de clases la clase Ingresante tal como describe el siguiente diagrama:
 *  
 *  INRGESANTE
 *      Fields
 *      (private) cursos : string[]
 *      (private) direccion : string
 *      (private) edad : int
 *      (private) genero : string
 *      (private) nombre : string
 *      (private) pais : string
 *      Methods
 *      Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
 *      Mostrar() : string;
 *      
 *  El constructor inicializará todos los atributos de la clase.
 *  El método Mostrar expondrá todos los atributos de la clase al exterior, utilizar StringBuilder e interpolación de strings.
 *  
 *  El proyecto de Windows Forms contará con los siguientes controles:
 *  Un control de tipo GroupBox que contendrá dos controles de tipo TextBox para cargar el nombre y la dirección, y un NumericUpDown para cargar la edad del usuario con sus respectivos Label.
 *  Un segundo control de tipo GroupBox que contendrá tres RadioButton que determinarán el género del usuario (masculino, femenino o no binario).
 *  Un último control de tipo GroupBox contendrá tres controles de tipo CheckBox con los distintos cursos a elegir (C#, C++ o JavaScript). 
 *  Se deben poder elegir todos los cursos, ninguno o algunos.
 *  Un control de tipo ListBox que tendrá los paises para que el usuario escoja (Argentina, Chile o Uruguay).
 *  Por último, un botón que al accionarse deberá mostrar toda la información del usuario registrado.
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05EI02
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
            Application.Run(new FrmRegistro());
        }
    }
}
