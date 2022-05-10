using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10EI01
{
    internal class MiClase
    {
        private string atributo;

        public MiClase() : this("vacio")
        {

        }

        public MiClase(string atributo)
        {
            this.atributo = atributo;
        }

        public static string Mostrar(MiClase instancia)
        {
            throw new DivideByZeroException();
        }
    }
}
