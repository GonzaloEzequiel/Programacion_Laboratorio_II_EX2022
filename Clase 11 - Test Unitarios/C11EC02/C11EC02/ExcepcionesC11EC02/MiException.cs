using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesC10EI01
{
    public class MiException : Exception
    {
        public MiException() : base ()
        {

        }

        public MiException(string mensaje) : base(mensaje)
        {

        }

        public MiException(string mensaje, Exception ex) : base(mensaje, ex)
        {

        }
    }
}
