using System;

namespace BibliotecaC02EA01
{
    public static class CalculadorFactorial
    {
        /// <summary>
        /// Calcula el factorial de un numero n dado
        /// </summary>
        /// <param name="numero">int numero entero a calcular factorial</param>
        /// <returns>double resultado del factorial del numero ingresado</returns>
        public static double CalcularFactorial(int numero)
        {
            double resultado = 1;

            for(int i=numero; i>1; i--)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
