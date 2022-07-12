using System.Collections.Generic;
using System;
using System.Text;

namespace BibliotecaC12EC01
{
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        public enum ETipoCompetencia
        {
            F1,
            MotoCross,
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private ETipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<T>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, ETipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set
            {
                if (value > 1)
                    this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set
            {
                if (value > 1)
                    this.cantidadVueltas = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get { return this.competidores[i]; }
        }

        public ETipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public List<T> Competidores { get { return this.competidores; } }

        /// <summary>
        /// Muestra todos los datos de todos los autos de la competencia
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            foreach (VehiculoDeCarrera auto in this.competidores)
                retorno.AppendLine(auto.MostrarDatos());

            return retorno.ToString();
        }

        /// <summary>
        /// Quita un VehiculoDeCarrera a una Competencia, siempre y cuando se encuentre previamente
        /// </summary>
        /// <param name="c">objeto Competencia</param>
        /// <param name="a">objeto VehiculoDeCarrera</param>
        /// <returns>TRUE si se logró quitar, FALSE si no se quitó</returns>
        public static bool operator -(Competencia<T> c, T a)
        {
            foreach (T auto in c.competidores)
                if (auto == a)
                { 
                    c.competidores.Remove(auto);
                    return true;
                }

            return false;
        }

        /// <summary>
        /// Agrega un VehiculoDeCarrera a una Competencia, siempre y cuando no se encuentre previamente
        /// </summary>
        /// <param name="c">objeto Competencia</param>
        /// <param name="a">objeto VehiculoDeCarrera</param>
        /// <returns>TRUE si se logró agregar, FALSE si no se agregó</returns>
        public static bool operator +(Competencia<T> c, T a)
        {
            try
            {
                if (c.competidores.Count < c.cantidadCompetidores && c != a)
                {
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadVueltas;
                    a.CantidadDeCombustible = (short)new Random().Next(15, 100);
                    c.competidores.Add(a);
                    return true;
                }                
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                throw new Exception("Competencia incorrecta", ex);
            }

            return false;
        }

        /// <summary>
        /// Verifica que un auto ya se encuentre en la competencia
        /// </summary>
        /// <param name="c">Objeto Competencia</param>
        /// <param name="a">Objeto Auto</param>
        /// <returns>TRUE si se encuentra, FALSE si no</returns>
        public static bool operator ==(Competencia<T> c, T a)
        {
            if (c.tipo == ETipoCompetencia.F1 && a.GetType() == typeof(AutoF1) ||
                c.tipo == ETipoCompetencia.MotoCross && a.GetType() == typeof(MotoCross))
            {
                foreach (T vehiculo in c.competidores)
                {
                    if (vehiculo == a)
                        return true;                       
                }
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "operator ==");
            }

            return false;

        }

        /// <summary>
        /// Verifica que un auto NO se encuentre en la competencia
        /// </summary>
        /// <param name="c">Objeto Competencia</param>
        /// <param name="a">Objeto Auto</param>
        /// <returns>FALSE si se encuentra, TRUE si no</returns>
        public static bool operator !=(Competencia<T> c, T a)
        {
            return !(c == a);
        }
    }
}
