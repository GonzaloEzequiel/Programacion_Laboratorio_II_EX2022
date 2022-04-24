using System;

namespace BibliotecaC02EI02
{
    public static class Validador
    {
        /// <summary>
        /// Valida la respuesta que permite la continuidad de ejecución
        /// </summary>
        /// <param name="continuar"></param>
        /// <returns>bool true si el valor a evaluar es una S (maypus), false si es cualquier otro caracter</returns>
        public static bool ValidarRespuesta(char continuar)
        {
            return continuar == 'S';
        }
    }
}
