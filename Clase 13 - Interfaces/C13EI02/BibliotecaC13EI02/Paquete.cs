using System;
using System.Text;

namespace BibliotecaC13EI02
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        public abstract bool TienePrioridad { get; }

        public decimal Impuestos { get { return this.costoEnvio * 35/100; } }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Codigo de Seguimiento: {this.codigoSeguimiento}");
            retorno.AppendLine($"Costo de envio: ${this.costoEnvio}");
            retorno.AppendLine($"Origen: {this.origen} | Destino: {this.destino} | Peso: {this.pesoKg}Kg");
            if(this.TienePrioridad)
                retorno.AppendLine($"Tiene Prioridad.");
            else
                retorno.AppendLine($"No tiene Prioridad.");

            return retorno.ToString();
        }

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + this.Impuestos;
        }
    }
}
