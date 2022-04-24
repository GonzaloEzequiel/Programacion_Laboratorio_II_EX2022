using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC08EI01
{
    public enum EColores
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro
    }

    public class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private EColores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        public virtual string Mostrar()
        {
            return $"Tipo: {this.GetType().Name} | Color: {this.color} | Ruedas: {this.cantidadRuedas} | Puertas: {this.cantidadPuertas}";
        }
    }
}
