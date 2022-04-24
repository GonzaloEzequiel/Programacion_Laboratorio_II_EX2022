using System;

namespace BibliotecaC02EI04
{
    public static class Calculadora
    {
        public static double? Calcular(double numero1, double numero2, char operacion)
        {
            double? resultado = null;

            switch(operacion)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if(Calculadora.Validar(numero2))
                        resultado = numero1 / numero2;
                    break;
                default:
                    break;
            }

            return resultado;
        }

        public static bool Validar(double denominador)
        {
            return denominador != 0;
        }
    }
}
