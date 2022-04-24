using System;

namespace BibliotecaC04EC02
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }
        
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        /// <summary>
        /// Muestra la marca el precio y el codigo de un producto
        /// </summary>
        /// <param name="p">objeto Prducto</param>
        /// <returns>un String con los datos del producto</returns>
        public static string MostrarProducto(Producto p)
        {
            return $"Marca {p.marca} | Precio {p.precio} | Código: {p.codigoDeBarra}";
        }

        /// <summary>
        /// Muestra el atributo: codigo de barra de un producto
        /// </summary>
        /// <param name="p">objeto Prducto</param>
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        /// <summary>
        /// Compara dos objetos de tipo Producto
        /// </summary>
        /// <param name="p1">Primer objeto tipo Producto</param>
        /// <param name="p2">Segundo objeto tipo Producto</param>
        /// <returns>Retornará true si las marcas y códigos de barra son iguales, false caso contrario</returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;
        }

        /// <summary>
        /// Compara un objeto Producto con un string
        /// </summary>
        /// <param name="p">Objeto tipo Producto</param>
        /// <param name="marca">String marca a comparar</param>
        /// <returns>Retornará true si la marca del producto coincide con la cadena pasada como argumento, false caso contrario.</returns>
        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }

        /// <summary>
        /// Compara dos objetos de tipo Producto
        /// </summary>
        /// <param name="p1">Primer objeto tipo Producto</param>
        /// <param name="p2">Segundo objeto tipo Producto</param>
        /// <returns>Retornará true si las marcas y códigos de barra NO son iguales, false caso contrario</returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Compara un objeto Producto con un string
        /// </summary>
        /// <param name="p">Objeto tipo Producto</param>
        /// <param name="marca">String marca a comparar</param>
        /// <returns>Retornará true si la marca del producto NO coincide con la cadena pasada como argumento, false caso contrario.</returns>
        public static bool operator !=(Producto p, string marca)
        {
            return !(p==marca);
        }

    }
}
