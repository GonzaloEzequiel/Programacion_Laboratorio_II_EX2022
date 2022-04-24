using System;

namespace BibliotecaC08EI01
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public override string Mostrar()
        {
            return $"{base.Mostrar()} | Marchas: {this.cantidadMarchas} | Pasajeros: {this.cantidadPasajeros}";
        }
    }
}
