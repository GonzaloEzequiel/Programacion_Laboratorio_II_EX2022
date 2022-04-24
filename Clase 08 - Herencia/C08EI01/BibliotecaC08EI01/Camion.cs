using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC08EI01
{
    public class Camion : VehiculoTerrestre
    {
        
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public override string Mostrar()
        {
            return $"{base.Mostrar()} | Marchas: {this.cantidadMarchas} | Carga: {this.pesoCarga}";
        }
    }
}
