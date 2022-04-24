using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC04EC02
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        /// <summary>
        /// Muestra todos los productos de un estante
        /// </summary>
        /// <param name="e">Estante a mostrar</param>
        /// <returns>Ubicacion del estante y detalle de sus productos</returns>
        public static string MostrarEstante(Estante e)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Estante N° {e.ubicacionEstante}:");
            foreach (Producto item in e.productos)
                retorno.AppendLine(Producto.MostrarProducto(item));

            return retorno.ToString();
        }

        /// <summary>
        /// Indica si un producto puntual, se encuentra o no en el estante
        /// </summary>
        /// <param name="e">Estante</param>
        /// <param name="p">Producto</param>
        /// <returns>Retornará true si es que el producto ya se encuentra en el estante, false caso contrario</returns>
        public static bool operator ==(Estante e, Producto p)
        {
            return Array.IndexOf(e.productos, p) is not -1;
        }

        /// <summary>
        /// Indica si un producto puntual, se encuentra o NO en el estante
        /// </summary>
        /// <param name="e">Estante</param>
        /// <param name="p">Producto</param>
        /// <returns>Retornará true si es que el producto NO se encuentra en el estante, false caso contrario</returns>
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e==p);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e">Estante</param>
        /// <param name="p">Producto</param>
        /// <returns> Retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y dicho producto no se encuentra en el estante, false caso contrario</returns>
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;

            if(e!=p)
            {
                for(int i=0; i<e.productos.Length; i++)
                {
                    if(e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e">Estante</param>
        /// <param name="p">Producto</param>
        /// <returns>Retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado</returns>
        public static Estante operator -(Estante e, Producto p)
        {
            for (int i=0; i<e.productos.Length; i++)
            {
                if (e==p)
                {
                    e.productos[i] = null;
                    break;
                }
            }

            return e;
        }
    }
}
