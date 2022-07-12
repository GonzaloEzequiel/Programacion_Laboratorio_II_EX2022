using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC11EC03
{
    public class VehiculoDeCarrera
    {
        private short cantidadDeCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.escuderia = escuderia;
            this.numero = numero;
            this.enCompetencia = true;
        }

        public short CantidadDeCombustible
        {
            get { return this.cantidadDeCombustible; }
            set 
            { 
                if(value >= 0)
                    this.cantidadDeCombustible = value; 
            }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return this.escuderia; }
            set 
            { 
                if(!string.IsNullOrWhiteSpace(value))
                    this.escuderia = value; 
            }
        }

        public short Numero
        {
            get { return this.numero; }
            set
            {
                if (value >= 0)
                    this.numero = value;
            }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set
            {
                if (value >= 0)
                    this.vueltasRestantes = value;
            }
        }

        /// <summary>
        /// Muestra todos los datos de un VehiculoDeCarrera
        /// </summary>
        /// <returns>todos los datos</returns>
        public virtual string MostrarDatos()
        {
            return $"Tipo: {this.GetType().Name} | Numero: {this.Numero} | Escuderia: {this.Escuderia} | Vueltas Restantes: {this.VueltasRestantes} | Combustible: {this.CantidadDeCombustible} | En compentecia: {this.EnCompetencia}";
        }

        /// <summary>
        /// Compara dos VehiculoDeCarrera y verifica si son iguales (sólo si los atributos número y escuderia son iguales)
        /// </summary>
        /// <param name="a1">Primer VehiculoDeCarrera</param>
        /// <param name="a2">Segundo VehiculoDeCarrera</param>
        /// <returns>TRUE si son iguales, FALSE si no</returns>
        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }

        /// <summary>
        /// Compara dos VehiculoDeCarrera y verifica si NO son iguales (sólo si los atributos número y escuderia son iguales)
        /// </summary>
        /// <param name="a1">Primer VehiculoDeCarrera</param>
        /// <param name="a2">Segundo VehiculoDeCarrera</param>
        /// <returns>FALSE si son iguales, TRUE si no</returns>
        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 == a2);
        }
    }
}
