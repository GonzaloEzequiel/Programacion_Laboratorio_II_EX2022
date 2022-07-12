using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesC14EC01
{
    public class UnaException : Exception
    {
        public UnaException() : base()
        {

        }

        public UnaException(string mensaje) : base(mensaje)
        {

        }

        public UnaException(string mensaje, Exception ex) : base(mensaje, ex)
        {

        }
    }
}
