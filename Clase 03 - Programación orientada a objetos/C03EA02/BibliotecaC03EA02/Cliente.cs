using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC03EA02
{
    public class Cliente
    {
        private string nombre;
        private string domicilio;
        private string telefono;
        private List<Mascota> mascotas;

        public Cliente(string nombre, string domicilio, string telefono)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.telefono = telefono;

            mascotas = new List<Mascota>();
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
        /*
        public string Domicilio
        {
            get
            {
                return this.domicilio;
            }
            set
            {
                this.domicilio = value;
            }
        }

        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }
        */

        /// <summary>
        /// Muestra los datos de un cliente y sus mascotas
        /// </summary>
        /// <returns>Todos los datos del cliente</returns>
        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Nombre: {this.nombre} | Domicilio: {this.domicilio} | Teléfono: {this.telefono}");
            retorno.AppendLine("Mascotas:");
            if(this.mascotas != null)
                foreach (Mascota item in this.mascotas)
                    retorno.AppendLine(item.Mostrar());

            return retorno.ToString();
        }

        /// <summary>
        /// Agrega una mascota al cliente
        /// </summary>
        /// <param name="mascota">Mascota a agregar</param>
        public void AgregarMascota(Mascota mascota)
        {
            this.mascotas.Add(mascota);
        }

        /// <summary>
        /// Quita una mascota al cliente
        /// </summary>
        /// <param name="mascota">Mascota a quitar</param>
        public void RemoverMascota(Mascota mascota)
        {
            this.mascotas.Remove(mascota);
        }

        /// <summary>
        /// Quita una mascota (encontrada por nomrbre) al cliente
        /// </summary>
        /// <param name="mascota">Mascota a quitar</param>
        public void RemoverMascota(string nombreDeLaMascota)
        {
            foreach (Mascota item in this.mascotas)
                if (item.Nombre == nombreDeLaMascota)
                    this.mascotas.Remove(item);
        }
    }
}
