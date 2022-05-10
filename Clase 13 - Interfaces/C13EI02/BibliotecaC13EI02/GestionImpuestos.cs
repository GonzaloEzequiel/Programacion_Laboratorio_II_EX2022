using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC13EI02
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal sumador = 0;

            foreach (Paquete paquete in this.impuestosAduana)
                sumador += paquete.Impuestos;

            return sumador;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal sumador = 0;

            foreach (Paquete paquete in this.impuestosAfip)
                sumador += ((IAfip)paquete).Impuestos;

            return sumador;
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach(Paquete paquete in paquetes)
            {
                this.RegistrarImpuestos(paquete);
            }
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            this.impuestosAduana.Add(paquete);

            if (paquete is IAfip)
                this.impuestosAfip.Add((IAfip)paquete);
        }

    }
}
