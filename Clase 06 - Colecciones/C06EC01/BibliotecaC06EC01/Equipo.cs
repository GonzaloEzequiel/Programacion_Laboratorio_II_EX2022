using System;
using System.Collections.Generic;

namespace BibliotecaC06EC01
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public List<Jugador> Jugadores
        {
            get { return this.jugadores; }
        }

        /// <summary>
        /// Agrega un jugador a la lista siempre y cuando no exista aún en el equipo y la cantidad de jugadores no supere el límite establecido por el atributo cantidadDeJugadores
        /// </summary>
        /// <param name="e">Objeto Equipo</param>
        /// <param name="j">Objeto Jugador</param>
        /// <returns></returns>
        public static bool operator +(Equipo e, Jugador j)
        {
            if(!e.jugadores.Contains(j) && e.jugadores.Count <= e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }
    }
}
