using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09EI01
{
    class SobreSobrescrito : Sobrescrito
    {
        /// <summary>
        /// Retornará el valor de miAtributo
        /// </summary>
        public override string MiPropiedad
        {
            get
            {
                return this.miAtributo;
            }
        }

        /// <summary>
        /// Retorna el valor de MiPropiedad
        /// </summary>
        /// <returns></returns>
        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }
    }
}
