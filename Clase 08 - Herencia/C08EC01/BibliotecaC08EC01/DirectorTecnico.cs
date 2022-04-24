using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC08EC01
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre) : base(nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this (nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
    
        /// <summary>
        /// Muestra todos los datos de un DirectorTecncio
        /// </summary>
        /// <returns>todos los datos</returns>
        public override string MostrarDatos()
        {
            return $"{base.MostrarDatos()} | Fecha de Nacimiento: {this.fechaNacimiento}";
        }

        /// <summary>
        /// Compara si dos DirectorTecncio son iguales
        /// </summary>
        /// <param name="dt1">Primer DirectorTecncio</param>
        /// <param name="dt2">Segundo DirectorTecncio</param>
        /// <returns>TRUE si ambos son iguales, FALSE si no lo son</returns>
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Nombre == dt2.Nombre && dt1.fechaNacimiento == dt2.fechaNacimiento;
        }

        /// <summary>
        /// Compara si dos DirectorTecncio NO son iguales
        /// </summary>
        /// <param name="dt1">Primer DirectorTecncio</param>
        /// <param name="dt2">Segundo DirectorTecncio</param>
        /// <returns>TRUE si NO son iguales, FALSE si lo son</returns>
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
