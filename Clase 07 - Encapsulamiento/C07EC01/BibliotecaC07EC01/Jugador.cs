using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC07EC01
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        //private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            //this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
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
            {   if (partidosJugados > 0)
                    return (float)this.TotalGoles / this.PartidosJugados;
                else
                    return 0;
            }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    this.nombre = value;
            }
        }

        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }


        /// <summary>
        /// Retorna una cadena de string con todos los datos y estadísticas del jugador.
        /// </summary>
        /// <returns>Los datos del jugador</returns>
        public string MostrarDatos()
        {
            return $"Nombre: {this.nombre} | DNI: {this.dni} | Partidos Jugados: {this.partidosJugados} | Cantidad Goles: {this.totalGoles} | Promedio Goles: {this.PromedioGoles}";
        }

        /// <summary>
        /// Compara si dos jugadores son iguales por DNI
        /// </summary>
        /// <param name="j1">Primer Jugador</param>
        /// <param name="j2">Segundo Jugador</param>
        /// <returns>TRUE si son iguales, FALSE si no</returns>
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        /// <summary>
        /// Compara si dos jugadores NO son iguales por DNI
        /// </summary>
        /// <param name="j1">Primer Jugador</param>
        /// <param name="j2">Segundo Jugador</param>
        /// <returns>FALSE si son iguales, TRUE si no</returns>
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
    }
}
