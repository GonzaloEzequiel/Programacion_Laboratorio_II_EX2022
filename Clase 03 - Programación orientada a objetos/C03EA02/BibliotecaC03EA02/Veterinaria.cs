using System;
using System.Collections.Generic;

namespace BibliotecaC03EA02
{
    public class Veterinaria
    {
        //private static string nombreFantasia;
        //private static string razonSocial;
        //private static string direccion;
        private static List<Cliente> clientes = new List<Cliente>();

        public static List<Cliente> Clientes
        {
            get
            {
                return clientes;
            }
        }

        /// <summary>
        /// Agrega un cliente a la Veterinaria
        /// </summary>
        /// <param name="cliente">Nuevo Cliente</param>
        public static void AgregarClientes(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        /// <summary>
        /// Quita un cliente de la lista
        /// </summary>
        /// <param name="cliente">Cliente a quitar</param>
        public static void QuitarCliente(Cliente cliente)
        {
            clientes.Remove(cliente);
        }

        /// <summary>
        /// Quita un cliente de la lista encontrado por nombre
        /// </summary>
        /// <param name="cliente">Cliente a quitar</param>
        public static void QuitarCliente(string nombreliente)
        {
            foreach (Cliente item in clientes)
                if (item.Nombre == nombreliente)
                    clientes.Remove(item);
        }

    }        
}
