using System;
using System.Text;

namespace BibliotecaC05EI02
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        /// <summary>
        /// Muestra todos los datos y los cursos de un Ingresante
        /// </summary>
        /// <returns>String los datos del Ingresante</returns>
        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();

            mostrar.AppendLine($"Nombre: {this.nombre} | Edad: {this.edad} | Género: {this.genero} | Dirección: {this.direccion} | País: {this.pais}");
            mostrar.AppendLine("Cursos:");
            foreach (string curso in cursos)
                mostrar.AppendLine($"~ {curso}");

            return mostrar.ToString();
        }
    }
}
