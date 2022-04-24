using System;

namespace BibliotecaC02EI07
{
    public static class CalculadoraDeHipotenusa
    {
        public static double CalcularHipotenusa(double base1, double altura)
        {
            return Math.Sqrt(Math.Pow(base1, 2) + Math.Pow(altura, 2));
        }

    }
}
