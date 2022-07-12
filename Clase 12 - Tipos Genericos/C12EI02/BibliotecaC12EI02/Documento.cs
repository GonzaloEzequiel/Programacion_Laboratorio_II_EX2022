using System;

namespace BibliotecaC12EI02
{
    public class Documento
    {
        protected int numero;

        public Documento(int numero)
        {
            this.numero = numero;
        }

        public int Numero { get { return this.numero; } }
    }
}
