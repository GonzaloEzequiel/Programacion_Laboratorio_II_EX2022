using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC13EI01
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; }
        }

        public Lapiz(int unidades)
        {

        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            this.tamanioMina -= 0.1F * texto.Length;

            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Es un Lápiz color: {((IAcciones)this).Color} con una mina de tamaño: {((IAcciones)this).UnidadesDeEscritura}";
        }
    }
}
