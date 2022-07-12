using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC13EI01
{
    public interface IAcciones
    {
        public ConsoleColor Color { get; set; }
        public float UnidadesDeEscritura { get; set;}

        public EscrituraWrapper Escribir(string texto);
        public bool Recargar(int unidades);
    }
}
