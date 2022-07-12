/*
 *  Ejercicio I03 - Siempre quise tener un notepad °_°
 * 
 *  Crear un proyecto de Windows Forms App capaz de abrir, editar y guardar archivos de texto, tal como se puede hacer en un simple 
 *  editor de texto como puede ser el notepad de Windows.
 *  
 *  1. Agregar una barra de menú superior (MenuStrip) con las siguiente opciones del menú "Archivo":
 *      ° Archivo -> Abrir
 *      ° Archivo -> Guardar
 *      ° Archivo -> Guardar como...
 *      
 *  2. Usando la propiedad ShortcutKeys, asociar los siguientes shortcuts (atajos) a las opciones del menú:
 *      ° Abrir: Ctrl + A
 *      ° AGuardar: Ctrl + S
 *      ° Guardar como...: Ctrl + Shift + S
 *      
 *  3. Agregar una barra de estado en la parte inferior (StatusStrip) que contenga un ToolStripStatusLabel.
 *  
 *  4. Agregar un RichTextBox que deberá estar acoplado al centro del formulario (propiedad Dock).
 *  
 *  5. En el StatusStrip, informar la cantidad total de caracteres del texto en el RichTextBox.
 *  
 *  6. Utilizar la propiedad Dock para enlazar el MenuStrip al borde superior de la ventana y el StatusStrip al borde inferior.
 *  
 *  7. 
 *      
 *      
 *      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazVisualC14EI03
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
            Application.Run(new FrmNotepad());
        }
    }
}
