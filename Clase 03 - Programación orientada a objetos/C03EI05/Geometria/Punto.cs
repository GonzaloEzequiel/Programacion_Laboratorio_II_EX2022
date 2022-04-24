using System;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// devuelve el valor de la coordenada X del punto, en el plano
        /// </summary>
        /// <returns>el valor de la coordenada</returns>
        public int GetX()
        {
            return this.x;
        }

        /// <summary>
        /// devuelve el valor de la coordenada Y del punto, en el plano
        /// </summary>
        /// <returns>el valor de la coordenada</returns>
        public int GetY()
        {
            return this.y;
        }
    }
}
