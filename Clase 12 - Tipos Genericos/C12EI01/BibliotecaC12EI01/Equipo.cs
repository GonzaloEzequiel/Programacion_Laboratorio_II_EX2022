using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC12EI01
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public string Nombre { get { return this.nombre; } }
        //public DateTime FechaCreacion { get; }

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1==e2);
        }

        public string Ficha()
        {
            return $"{this.nombre} fundado el {this.fechaCreacion}";
        }
    }
}
