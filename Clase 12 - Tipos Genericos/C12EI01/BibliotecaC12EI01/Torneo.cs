using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaC12EI01
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            equipos = new List<T>();
        }

        public string JugarPartido
        {
            get 
            {
                Random r = new Random();                
                int indice1 = r.Next(0, this.equipos.Count);
                int indice2;
                do
                {
                    indice2 = r.Next(0, this.equipos.Count);
                } while (indice1 == indice2);

                return this.CalcularPartido(this.equipos[indice1], this.equipos[indice2]);
            }
        }

        public static bool operator ==(Torneo<T> t, T equipo)
        {
            foreach (T item in t.equipos)
            {
                if (item == equipo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> t, T equipo)
        {
            return !(t == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> t, T equipo)
        {
            if (t != equipo)
            {
                t.equipos.Add(equipo);
            }

            return t;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Nombre: {this.nombre}");
            foreach (T item in this.equipos)
            {
                retorno.AppendLine($"{item.Ficha()}");
            }

            return retorno.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random r = new Random();

            return $"{equipo1.Nombre} {r.Next(0, 5)} - {equipo2.Nombre} {r.Next(0, 5)}";
        }
    }
}
