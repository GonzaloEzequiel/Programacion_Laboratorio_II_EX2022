using System;

namespace ExcepcionesC10EI02
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException() : base()
        {

        }

        public ParametrosVaciosException(string mensaje) : base(mensaje)
        {

        }

        public ParametrosVaciosException(string mensaje, Exception excepcion) : base(mensaje, excepcion)
        {

        }
    }
}
