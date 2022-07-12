using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public interface IGuardar<T>
    {
        string RutaDeArchivo { get; set; }

        public bool Guardar();
        public T Leer(string ruta);
    }
}
