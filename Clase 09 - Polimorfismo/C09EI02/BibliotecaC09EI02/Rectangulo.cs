using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC09EI02
{
    public class Rectangulo : Figura
    {
        protected double lado1;
        protected double lado2;

        public Rectangulo(double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        /// <summary>
        /// Muestra un mensaje predenterminado 
        /// </summary>
        /// <returns>"Dibujando Rectángulo..."</returns>
        public override string Dibujar()
        {
            return "Dibujando Rectángulo...";
        }

        /// <summary>
        /// Calcula la superficie del rectángulo
        /// </summary>
        /// <returns>Retornará el valor de la superficie (área)</returns>
        public override double CalcularSuperficie()
        {
            return this.lado1 * this.lado2;
        }

        /// <summary>
        /// Calcula la perímetro del rectángulo
        /// </summary>
        /// <returns>Retornará el valor de la perímetro (contorno)</returns>
        public override double CalcularPerimetro()
        {
            return 2*this.lado1 + 2*this.lado2;
        }
    }
}
