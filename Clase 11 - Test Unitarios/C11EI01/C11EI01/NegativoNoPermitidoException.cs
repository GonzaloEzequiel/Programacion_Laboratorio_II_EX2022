using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11EI01
{
    class NegativoNoPermitidoException : Exception
    {
        public NegativoNoPermitidoException() : base()
        {

        }

        public NegativoNoPermitidoException(string message) : base(message)
        {

        }
    }
}
