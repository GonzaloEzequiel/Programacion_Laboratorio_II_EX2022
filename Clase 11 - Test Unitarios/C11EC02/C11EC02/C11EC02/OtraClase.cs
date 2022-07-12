using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcepcionesC10EI01;

namespace C11EC02
{
    public class OtraClase
    {
        public void MetodoDeInstancia()
        {          
            try
            {
                MiClase prueba = new MiClase("Gonzalo");
            }
            catch (UnaException ex)
            {
                Console.WriteLine("Se capturo UnaException");
                throw new MiException($"Excepción REcapaturada recapturada(2)", ex);
            }
        }
    }
}
