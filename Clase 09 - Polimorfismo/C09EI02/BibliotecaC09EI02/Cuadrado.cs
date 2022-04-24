using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC09EI02
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado1) : base(lado1, lado1)
        {

        }

        /// <summary>
        /// Muestra un mensaje predenterminado 
        /// </summary>
        /// <returns>"Dibujando Cuadrado..."</returns>
        public override string Dibujar()
        {
            return "Dibujando Cuadrado...";
        }
    }
}
