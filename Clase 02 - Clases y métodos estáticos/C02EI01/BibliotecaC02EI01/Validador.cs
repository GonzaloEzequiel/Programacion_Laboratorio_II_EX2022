using System;

namespace BibliotecaC02EI01
{
    public static class Validador
    {
        /// <summary>
        /// Valida si un número, se encuentra acotado entre dos valores, mínimo y máximo respectivamente
        /// </summary>
        /// <param name="valor">Número a evaluar</param>
        /// <param name="min">Valor mínimo / cota inferior</param>
        /// <param name="max">Valor máximo / cota superior</param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {
            return (valor >= min && valor <= max);
        }
    }
}
