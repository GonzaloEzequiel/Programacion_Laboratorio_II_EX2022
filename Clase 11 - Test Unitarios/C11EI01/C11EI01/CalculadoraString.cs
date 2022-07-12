using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11EI01
{
    public class CalculadoraString
    {
        public static int Add(string numeros)
        {
            int acumulador = 0;
            int auxInt;
            char[] separadores = { ',', '\n' };

            if (numeros.StartsWith("//"))
            {
                Array.Resize<char>(ref separadores, separadores.Length + 1);
                separadores[separadores.Length - 1] = numeros[2];
            }

            string[] nuevoArreglo = numeros.Split(separadores);

            foreach (string cadena in nuevoArreglo)
            {
                if (int.TryParse(cadena, out auxInt))
                {
                    if(auxInt >= 0)
                        acumulador += auxInt;
                    else
                        throw new NegativoNoPermitidoException();
                }
            }

            return acumulador;
        }
    }
}
