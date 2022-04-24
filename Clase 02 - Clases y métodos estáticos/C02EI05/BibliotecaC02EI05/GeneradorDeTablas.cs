using System;
using System.Text;

namespace BibliotecaC02EI05
{
    public static class GeneradorDeTablas
    {
        public static string GenerarTabla(int numeroEntero)
        {
            StringBuilder tabla = new StringBuilder();

            tabla.AppendLine($"Tabla de multiplicar del número {numeroEntero}:");
            for(int i=1; i<=10; i++)
            {
                tabla.AppendLine($"{numeroEntero} x {i} = {numeroEntero * i}");
            }    

            return tabla.ToString();
        }
    }
}
