using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesC10EI02
{
    public class Calculador
    {
        public static float Calcular(int num1, int num2)
        {
            try
            {
                return (float)num1 / num2;
            }
            catch(DivideByZeroException)
            {
                throw;
            }
        }
    }
}
