using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC13EI02
{
    public interface IAduana
    {
        public decimal Impuestos { get; }

        public decimal AplicarImpuestos();
    }
}
