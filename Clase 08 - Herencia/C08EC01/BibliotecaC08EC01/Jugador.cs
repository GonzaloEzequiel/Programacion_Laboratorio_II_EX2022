using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC08EC01
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {

        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }

        public float PromedioGoles
        {
            get
            {
                if (partidosJugados > 0)
                    return (float)this.TotalGoles / this.PartidosJugados;
                else
                    return 0;
            }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }

        /// <summary>
        /// Retorna una cadena de string con todos los datos y estadísticas del jugador.
        /// </summary>
        /// <returns>Los datos del jugador</returns>
        public override string MostrarDatos()
        {
            return $"{base.MostrarDatos()} | Partidos Jugados: {this.partidosJugados} | Cantidad Goles: {this.totalGoles} | Promedio Goles: {this.PromedioGoles}";
        }

        /// <summary>
        /// Compara si dos jugadores son iguales por DNI
        /// </summary>
        /// <param name="j1">Primer Jugador</param>
        /// <param name="j2">Segundo Jugador</param>
        /// <returns>TRUE si son iguales, FALSE si no</returns>
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        /// <summary>
        /// Compara si dos jugadores NO son iguales por DNI
        /// </summary>
        /// <param name="j1">Primer Jugador</param>
        /// <param name="j2">Segundo Jugador</param>
        /// <returns>FALSE si son iguales, TRUE si no</returns>
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
    }
}
