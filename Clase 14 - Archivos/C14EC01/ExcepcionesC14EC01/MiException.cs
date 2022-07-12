using System;

namespace ExcepcionesC14EC01
{
    public class MiException : Exception
    {
        public MiException() : base()
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
