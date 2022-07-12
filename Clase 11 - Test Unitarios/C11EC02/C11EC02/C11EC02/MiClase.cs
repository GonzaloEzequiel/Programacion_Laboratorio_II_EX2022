using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcepcionesC10EI01;

namespace C11EC02
{
    public class MiClase
    {
        private string atributo;

        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Se capturo la excepcion DivideByZeroException");
                throw;                
            }
        }

        public MiClase(string atributo)
        {
            this.atributo = atributo;

            try
            {
                new MiClase();
            }
            catch (DivideByZeroException exDBZCapturada)
            {
                Console.WriteLine("Se REcapturo (RElanzada) la excepcion DivideByZeroException");
                throw new UnaException($"Excepción DivideByZeroException REcapturada", exDBZCapturada);
            }
        }

        public static void MetodoEstatico()
        {
            Console.WriteLine("Se lanza la excpecion DivideByZeroException");
            throw new DivideByZeroException("Exception original lanzada");
        }
    }
}
