using System;
using System.Collections.Generic;

namespace BibliotecaC07EI02
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                if(i >= 0 && i < this.paginas.Count)
                {
                    return this.paginas[i];
                }
                return string.Empty;
            }
            set
            {
                if (i >= 0 && i < this.paginas.Count)
                {
                    this.paginas[i] = value;
                }
                else if (i >= 0 && i >= this.paginas.Count)
                    this.paginas.Add(value);
            }
        }
    }
}
