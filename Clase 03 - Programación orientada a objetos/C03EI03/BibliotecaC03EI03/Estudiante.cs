using System;
using System.Text;

namespace BibliotecaC03EI03
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        /// <summary>
        /// permite cambiar el valor del atributo notaPrimerParcial
        /// </summary>
        /// <param name="nota">nota numerica a ingresar</param>
        public void SetNotaPrimerParicial(int nota)
        {
            if (nota > 0 && nota <= 10)
                this.notaPrimerParcial = nota;
        }

        /// <summary>
        /// permite cambiar el valor del atributo notaSegundoParcial
        /// </summary>
        /// <param name="nota">nota numerica a ingresar</param>
        public void SetNotaSegundoParicial(int nota)
        {
            if (nota > 0 && nota <= 10)
                this.notaSegundoParcial = nota;
        }

        /// <summary>
        /// calcula la nota final del alumno
        /// </summary>
        /// <returns>la nota final numérica si el alumno aprobó, -1 si desaprobó</returns>
        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
                return random.Next(6, 10);
            else
                return -1;
        }

        /// <summary>
        /// calcula el promedio de las dos notas del alumno
        /// </summary>
        /// <returns>el promedio de las dos nota</returns>
        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) /2;
        }

        /// <summary>
        /// arma una cadena de texto con todos los datos del alumno
        /// </summary>
        /// <returns>los datos del alumno</returns>
        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            double auxDouble = this.CalcularNotaFinal();

            retorno.AppendFormat(" {0, -50} {1, -50}     {2, -30}       {3, -10}    {4, -10}   {this.CalcularPromedio()}", this.nombre, this.apellido, this.legajo, this.notaPrimerParcial, this.notaSegundoParcial);

            if (auxDouble != -1)
                retorno.AppendFormat("                {0, 30}", auxDouble);
            else
                retorno.Append("Alumno desaprobado");

            return retorno.ToString();
        }
    }
}
