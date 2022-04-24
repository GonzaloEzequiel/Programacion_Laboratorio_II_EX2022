using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilbiotecaC07EI01
{
    public class Negocio
    {
        private PuestoAtencion caja; 
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                bool resultado = this + value;
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }

        /// <summary>
        /// Agrega un Cliente a la cola de atención
        /// </summary>
        /// <param name="n">Objeto Negocio</param>
        /// <param name="c">Objeto Cliente</param>
        /// <returns></returns>
        public static bool operator +(Negocio n, Cliente c)
        {
            if(n!=c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator -(Negocio n)
        {
            return false;
        }

        /// <summary>
        /// Retornará true si el cliente se encuentra en la colección
        /// </summary>
        /// <param name="n">Objeto Negocio</param>
        /// <param name="c">Objeto Cliente</param>
        /// <returns></returns>
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Retornará false si el cliente NO se encuentra en la colección
        /// </summary>
        /// <param name="n">Objeto Negocio</param>
        /// <param name="c">Objeto Cliente</param>
        /// <returns></returns>
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        /// <summary>
        /// Genera una atención del próximo cliente en la cola, utilizando la propiedad Cliente y el método
        /// </summary>
        /// <param name="n"></param>
        /// <returns>TRUE cuando el cliente sea atendido</returns>
        public static bool operator ~(Negocio n)
        {
            if(n.ClientesPendientes > 0)
                return n.caja.Atender(n.Cliente);

            return false;
        }
    }
}
