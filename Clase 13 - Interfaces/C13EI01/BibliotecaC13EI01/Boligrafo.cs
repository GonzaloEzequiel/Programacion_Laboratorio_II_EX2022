using System;

namespace BibliotecaC13EI01
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }

        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura -= 0.3F * texto.Length;

            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            if (unidades > 0)
            {
                this.UnidadesDeEscritura += unidades;
                return true;
            }
            else
            {
                return false;
            }            
        }

        public override string ToString()
        {
            return $"Es un Boligrafo color: {this.Color} con nivel de tinta: {this.UnidadesDeEscritura}";
        }
    }
}
