using System;

namespace BilbiotecaC07EI01
{
    public class PuestoAtencion
    {
        public enum EPuesto
        {
            Caja1,
            Caja2
        }

        private static int numeroActual;
        private EPuesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }

        public int NumeroActual
        {
            get
            {
                return PuestoAtencion.numeroActual++;
            }
        }

        /// <summary>
        /// Simula la atencion a un cliente en n milisegundos
        /// </summary>
        /// <param name="cli">Objeto cliente</param>
        /// <returns>TRUE cuando termine de ser atendido</returns>
        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(new Random().Next(5000, 10000));
            return true;
        }

    }
}
