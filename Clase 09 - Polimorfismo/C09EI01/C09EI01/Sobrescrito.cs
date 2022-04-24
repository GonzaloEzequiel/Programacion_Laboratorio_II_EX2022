using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09EI01
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        /// <summary>
        /// Muestra un mensaje preestablecido
        /// </summary>
        /// <returns>Retorna "¡Este es mi método ToString sobrescrito!"</returns>
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        /// <summary>
        /// Compara si dos objetos son del mismo tipo
        /// </summary>
        /// <param name="obj1"></param>
        /// <returns>Retorna true si son del mismo tipo (objetos de la misma clase), false caso contrario</returns>
        public override bool Equals(Object obj1)
        {
            return this.GetType() == obj1.GetType();
        }

        /// <summary>
        /// Muestra unn número preestablecido
        /// </summary>
        /// <returns>Retorna el número 1142510181</returns>
        public override int GetHashCode()
        {
            return 1142510181;
        }

        public abstract string MiMetodo();
    }
}
