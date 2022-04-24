using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            this.vertice2 = new Punto(Math.Abs(vertice1.GetX()), Math.Abs(vertice3.GetY()));
            this.vertice4 = new Punto(Math.Abs(vertice3.GetX()), Math.Abs(vertice1.GetY()));
        }

        public Punto Vertice1
        {
            get
            {
                return this.vertice1;
            }
        }

        public Punto Vertice2
        {
            get
            {
                return this.vertice2;
            }
        }

        public Punto Vertice3
        {
            get
            {
                return this.vertice3;
            }
        }

        public Punto Vertice4
        {
            get
            {
                return this.vertice4;
            }
        }

        /// <summary>
        /// calcula (si es la primera vez) y devuelve el area del rectángulo
        /// </summary>
        /// <returns>el valor del area en unidades cuadradas</returns>
        public float GetArea()
        {
            if(this.area == 0)
                this.area = ((vertice2.GetY() - vertice1.GetY()) * (vertice3.GetX() - vertice2.GetX()));

            return this.area;
        }

        /// <summary>
        /// calcula (si es la primera vez) y devuelve el perímetro del rectángulo
        /// </summary>
        /// <returns>el valor del perímetro</returns>
        public float GetPerimetro()
        {
            if (this.perimetro == 0)
                this.perimetro = ((vertice2.GetY() - vertice1.GetY()) * 2 + (vertice3.GetX() - vertice2.GetX()) * 2);

            return this.perimetro;
        }
    }
}
