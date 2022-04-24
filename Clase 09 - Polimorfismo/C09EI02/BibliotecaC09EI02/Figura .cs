using System;

namespace BibliotecaC09EI02
{
    public abstract class Figura 
    {
        /// <summary>
        /// Muestra un mensaje predeterminado
        /// </summary>
        /// <returns>"Dibujando forma..."</returns>
        public virtual string Dibujar()
        {
            return "Dibujando forma...";
        }

        /// <summary>
        /// Calcula la superficie de la figura
        /// </summary>
        /// <returns>Retornará el valor de la superficie (área)</returns>
        public abstract double CalcularSuperficie();

        /// <summary>
        /// Calcula la perímetro de la figura
        /// </summary>
        /// <returns>Retornará el valor de la perímetro (controno)</returns>
        public abstract double CalcularPerimetro();
    }
}
