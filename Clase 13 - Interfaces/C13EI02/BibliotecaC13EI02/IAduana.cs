using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC13EI02
{
    public interface IAduana
    {
        public abstract decimal Impuestos { get; }

        public abstract decimal AplicarImpuestos();
    }
}
