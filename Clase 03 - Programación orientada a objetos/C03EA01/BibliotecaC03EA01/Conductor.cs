using System;

namespace BibliotecaC03EA01
{
    public class Conductor
    {
        private string nombre;
        private int[] Kms;
        private int totalKmsSemanales;

        public Conductor(string nombre)
        {
            this.nombre = nombre;
            this.Kms = new int[7];
            this.totalKmsSemanales = 0;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public void SetKms(int dia, int Kms)
        {
            this.Kms[dia - 1] = Kms;
        }

        public int GetKms(int dia)
        {
            return Kms[dia - 1];
        }

        public int TotalKmsSemanales
        {
            get
            {
                return this.totalKmsSemanales;
            }
            set
            {
                this.totalKmsSemanales = value;
            }
        }
    }
}
