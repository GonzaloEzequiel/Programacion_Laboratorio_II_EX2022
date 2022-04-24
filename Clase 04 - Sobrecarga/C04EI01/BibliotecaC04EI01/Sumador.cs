using System;

namespace BibliotecaC04EI01
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador() : this(0) { }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }        

        /// <summary>
        /// Suma los valores numéricos
        /// </summary>
        /// <param name="a">primer valor</param>
        /// <param name="b">segundo valor</param>
        /// <returns>El resultado de la suma</returns>
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;            
            return a + b;
        }

        /// <summary>
        /// Concatena las cadenas de texto
        /// </summary>
        /// <param name="a">primera cadena</param>
        /// <param name="b">segunda cadena</param>
        /// <returns>La concatenacion de ambas cadenas</returns>
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + " " + b;
        }

        /// <summary>
        /// Muestra la catidad de sumas de un sumador
        /// </summary>
        /// <param name="s">Sumador a evaluar</param>
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        /// <summary>
        /// Suma la cantidadSumas entra dos Sumadores
        /// </summary>
        /// <param name="s1">Primer Sumador</param>
        /// <param name="s2">Segundo Sumador</param>
        /// <returns>La suma del atributo cantidadSumas de cada argumento</returns>
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        /// <summary>
        /// Comprar la cantidadSumas entre dos Sumadores
        /// </summary>
        /// <param name="s1">Primer Sumador</param>
        /// <param name="s2">Segundo Sumador</param>
        /// <returns>Retornar TRUE si ambos sumadores tienen igual valor en el atributo cantidadSumas</returns>
        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }
    }
}
