using System;

namespace BibliotecaC02EI08
{
    public static class CalculadoraDeDias
    {
        /// <summary>
        /// CORREGIR se supone calcula cuantos dias pasaron desde unaFecha hasta hoy
        /// </summary>
        /// <param name="unaFecha">DateTime fecha a evaluar</param>
        /// <returns>int la cantidad de días que pasaron</returns>
        public static int CalcularCantidadDeDias(DateTime unaFecha)
        {
			TimeSpan resultado;
            resultado = (DateTime.Now - unaFecha).TotalDays;
			
			return resultado;
        }
    }
}
