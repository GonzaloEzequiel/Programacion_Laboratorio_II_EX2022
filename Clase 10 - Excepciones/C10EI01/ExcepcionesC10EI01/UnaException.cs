using System;

namespace ExcepcionesC10EI01
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
