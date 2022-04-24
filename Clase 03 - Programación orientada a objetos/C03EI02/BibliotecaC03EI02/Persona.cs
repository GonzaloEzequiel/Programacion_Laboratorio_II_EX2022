using System;

namespace BibliotecaC03EI02
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (value != null)
                    this.nombre = value;
            }
        }

        public DateTime FechaDeNacimiento
        {
            get
            {
                return this.fechaDeNacimiento;
            }
            set
            {
                //if (value != null)
                    this.fechaDeNacimiento = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value > 0)
                    this.dni = value;
            }
        }

        /// <summary>
        /// Recibe una fecha de nacimiento y calcula la edad de una persona
        /// </summary>
        /// <param name="fechaDeNacimiento"></param>
        /// <returns>la edad de la persona</returns>
        private int CalcularEdad(DateTime fechaDeNacimiento)
        {
            int edad = 0;

            return edad;
        }

        /// <summary>
        /// Muestra los datos de una persona incluyendo la edad actual.
        /// </summary>
        /// <returns>una cadena de texto con todos los datos de la persona</returns>
        public string Mostrar()
        {
            return $"Nombre: {this.nombre} | DNI: {this.dni} | Fecha Nacimiento: {this.fechaDeNacimiento} | Edad: {this.CalcularEdad(this.fechaDeNacimiento)}años";
        }

        /// <summary>
        /// Indica si una persona es o no mayor de edad
        /// </summary>
        /// <returns>“Es mayor de edad" si lo es, “es menor” si no lo es</returns>
        private string EsMayorDeEdad()
        {
            string retorno = string.Empty;
          
            if(DateTime.Now.Year - this.fechaDeNacimiento.Year > 18)
            {
                retorno = "Es mayor de edad";
            }
            else
            {
                retorno = "Es menor";
            }

            return retorno;
        }
    }
}
