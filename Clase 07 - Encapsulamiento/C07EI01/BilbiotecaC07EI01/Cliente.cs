using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilbiotecaC07EI01
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this (numero)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this.nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        /// <summary>
        /// Compara si dos intancias de Cliente corresponden al mismo
        /// </summary>
        /// <param name="c1">Primer Objeto Cliente</param>
        /// <param name="c2">Segundo Objeto Cliente</param>
        /// <returns>TRUE si ambos corresponden al mismo, FALSE si no</returns>
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }

        /// <summary>
        /// Compara si dos intancias de Cliente NO corresponden al mismo
        /// </summary>
        /// <param name="c1">Primer Objeto Cliente</param>
        /// <param name="c2">Segundo Objeto Cliente</param>
        /// <returns>TRUE si NO corresponden al mismo, FALSE si corresponden al mismo</returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1==c2);
        }        
    }
}
