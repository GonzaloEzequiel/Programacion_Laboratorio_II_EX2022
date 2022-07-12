using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaCentralita
{
    public class Centralita : IGuardar<string>
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal { get { return this.CalcularGanancia(ETipoLlamada.Local); } }

        public float GananciasPorProvincial { get { return this.CalcularGanancia(ETipoLlamada.Provincial); } }

        public float GananciasPorTotal { get { return this.CalcularGanancia(ETipoLlamada.Todas); } }

        public List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }



        public string RutaDeArchivo
        {
            get { return ""; }
            set { razonSocial = value; }
        }

        public bool Guardar()
        {
            // consulta todos sus datos
            return true;
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(ETipoLlamada tipo)
        {
            float acumuladorLocal = 0;
            float acumuladorProvincial = 0;
            float acumuladorTodas = 0;

            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                {
                    acumuladorLocal += ((Local)llamada).CostoLlamada;
                    //acumuladorTodas += ((Local)llamada).CostoLlamada;
                }
                else
                {
                    acumuladorProvincial += ((Provincial)llamada).CostoLlamada;
                    //acumuladorTodas += ((Provincial)llamada).CostoLlamada;
                }

                acumuladorTodas += llamada.CostoLlamada;
            }

            switch (tipo)
            {
                case ETipoLlamada.Local:
                    return acumuladorLocal;
                case ETipoLlamada.Provincial:
                    return acumuladorProvincial;
                case ETipoLlamada.Todas:
                    return acumuladorTodas;
                default:
                    return -1;
            }
        }

        /// <summary>
        /// Recibe una instancia de Llamada y la agrega a la lista de llamadas
        /// </summary>
        /// <param name="nuevaLlamada">Llamada a agregar</param>
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        /// <summary>
        /// Expone la razón social, la ganancia total, ganancia por llamados locales y provinciales y el detalle de las llamadas realizadas.
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Razon Social: {this.razonSocial}");
            retorno.AppendLine($"Ganancias por llamadas locales: ${this.GananciasPorLocal}");
            retorno.AppendLine($"Ganancias por llamadas provinciales: ${this.GananciasPorProvincial}");
            retorno.AppendLine($"Ganancias totales: ${this.GananciasPorTotal}");

            return retorno.ToString();
        }

        /// <summary>
        /// Busca y compara si una llamada forma parte o no en la lista de llamadas de una Centralita
        /// </summary>
        /// <param name="c">Centralita</param>
        /// <param name="llamada">Llamada a buscar</param>
        /// <returns>TRUE si la centralita contiene la llamada, FALSE si no</returns>
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c== llamada);
        }

        /// <summary>
        /// Invoca al método AgregarLlamada sólo si la llamada no está registrada en la Centralita
        /// </summary>
        /// <param name="c">Centralita</param>
        /// <param name="llamada">Llamada a agregar</param>
        /// <returns>devuelve la Centralita con la llamada agregada (o no)</returns>
        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if (c != llamada)
                c.AgregarLlamada(llamada);
            else
                throw new CentralitaException("La llamada ya se encuentra registrada", "Centralita", "operator +");

            return c;
        }

        /// <summary>
        /// Busca y compara si una llamada forma parte o no en la lista de llamadas de una Centralita
        /// </summary>
        /// <param name="c">Centralita</param>
        /// <param name="llamada">Llamada a buscar</param>
        /// <returns>TRUE si la centralita contiene la llamada, FALSE si no</returns>
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            //return c.Llamadas.Contains(llamada);

            foreach(Llamada item in c.Llamadas)
                if(item==llamada)
                    return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// 
        /// </summary>
        public void OrdenarLlamadas()
        {
            //foreach(Llamada llamada in this.Llamadas)
            //{
            //    foreach(Ll)
            //}
        }

        /// <summary>
        /// Reutiliza el código del método Mostrar
        /// </summary>
        /// <returns>Todos los datos de una llamada local</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
