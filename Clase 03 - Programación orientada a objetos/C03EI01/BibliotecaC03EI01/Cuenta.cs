using System;

namespace BibliotecaC03EI01
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public string GetCantidad()
        {
            return this.titular;
        }

        /// <summary>
        /// Muestra todos los datos de la cuenta
        /// </summary>
        /// <returns>una cadena de texto con todos los datos de la cuenta</returns>
        public string Mostrar()
        {
            return $"Titular: {this.titular} | Monto: ${this.cantidad : #.##}";
        }

        /// <summary>
        /// Añade una cantidad indicada a la cuenta
        /// </summary>
        /// <param name="montoIngresado">cantidad de dinero a ingresar</param>
        public void Ingresar(decimal montoIngresado)
        {
            if(montoIngresado > 1)
            {
                this.cantidad += montoIngresado;
            }
        }

        /// <summary>
        /// Remueve una cantidad ingresada de la cuenta, la cuenta puede estar en negativo aunque al estarlo no permite seguir retirando
        /// </summary>
        /// <param name="montoRetirado">cantidad de dinero a remover</param>
        public void Retirar(decimal montoRetirado)
        {
            if(this.cantidad >= 0)
                this.cantidad -= montoRetirado;
        }
    }
}
