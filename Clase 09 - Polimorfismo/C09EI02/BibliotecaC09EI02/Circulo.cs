using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC09EI02
{
    public sealed class Circulo : Figura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        /// <summary>
        /// Muestra un mensaje predenterminado 
        /// </summary>
        /// <returns>"Dibujando Círculo..."</returns>
        public override string Dibujar()
        {
            return "Dibujando Círculo...";
        }

        /// <summary>
        /// Calcula la superficie del círculo
        /// </summary>
        /// <returns>Retornará el valor de la superficie (área)</returns>
        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }

        /// <summary>
        /// Calcula la perímetro del círculo
        /// </summary>
        /// <returns>Retornará el valor de la perímetro (contorno)</returns>
        public override double CalcularPerimetro()
        {
            return Math.PI * this.radio;
        }
    }
}
