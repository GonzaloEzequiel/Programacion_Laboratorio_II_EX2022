using System;

namespace BibliotecaC06EC02
{
    public class AutoF1
    {
        private short cantidadDeCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        private AutoF1()
        {
            this.enCompetencia = false;
            this.cantidadDeCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public AutoF1(short numero, string escuderia) : this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public short CantidadDeCombustible
        {
            get { return this.cantidadDeCombustible; }
            set { this.cantidadDeCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        /// <summary>
        /// Muestra todos los datos de un AutoF1
        /// </summary>
        /// <returns>todos los datos</returns>
        public string MostrarDatos()
        {
            return $"Escuderia: {this.escuderia} | Número: {this.numero} | Vueltas Restantes: {this.VueltasRestantes} | Combustible: {this.CantidadDeCombustible} | En compentecia: {this.EnCompetencia}";
        }

        /// <summary>
        /// Compara dos autos de F1 y verifica si son iguales (sólo si los atributos número y escuderia son iguales)
        /// </summary>
        /// <param name="a1">Primer Auto</param>
        /// <param name="a2">Segundo Auto</param>
        /// <returns>TRUE si son iguales, FALSE si no</returns>
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }

        /// <summary>
        /// Compara dos autos de F1 y verifica si NO son iguales (sólo si los atributos número y escuderia son iguales)
        /// </summary>
        /// <param name="a1">Primer Auto</param>
        /// <param name="a2">Segundo Auto</param>
        /// <returns>FALSE si son iguales, TRUE si no</returns>
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
