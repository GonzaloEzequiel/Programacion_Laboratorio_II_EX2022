using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC03EA02
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaDeNacimiento;
        private List<Vacuna> historialDeVacunacion;

        public Mascota(string especie, string nombre, DateTime fechaDeNacimiento, List<Vacuna> historialDeVacunacion)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.historialDeVacunacion = historialDeVacunacion;
        }

        public Mascota(string especie, string nombre, DateTime fechaDeNacimiento, string nombreVacuna)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.historialDeVacunacion = new List<Vacuna>();
            historialDeVacunacion.Add(new Vacuna(nombreVacuna));
        }

        public Mascota(string especie, string nombre, DateTime fechaDeNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            //this.historialDeVacunacion = new List<Vacuna>();
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// Muestra los datos de una mascota
        /// </summary>
        /// <returns>todos los datos</returns>
        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Especie: {this.especie} | Nombre: {this.nombre} | Fecha de Nacimiento {this.fechaDeNacimiento}");
            retorno.AppendLine("Vacunas:");
            if(this.historialDeVacunacion != null)
                foreach (Vacuna item in this.historialDeVacunacion)
                    retorno.AppendLine(item.GetNombre());                

            return retorno.ToString();
        }
    }
}
