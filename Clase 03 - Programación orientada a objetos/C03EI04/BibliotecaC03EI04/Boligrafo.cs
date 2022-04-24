using System;
using System.Linq;
using System.Text;

namespace BibliotecaC03EI04
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        /// <summary>
        /// getter del atributo color de la instancia
        /// </summary>
        /// <returns>el color del bolígrafo</returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// getter del atributo tinta de la instancia
        /// </summary>
        /// <returns>la cantidad de tinta del bolígrafo<</returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// Recarga al bolígrafo a su máximo de tinta
        /// </summary>
        public void Recargar()
        {
            short cantidad = Boligrafo.cantidadTintaMaxima;
            cantidad -= this.tinta;

            this.SetTinta(cantidad);
        }

        /// <summary>
        /// Dibuja un '*' por cantidad de tinta en el bolígrafo que se alcanzó a gastar
        /// </summary>
        /// <param name="gasto">cantidad de tinta gastada</param>
        /// <param name="dibujo">*</param>
        /// <returns></returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno;

            StringBuilder auxString = new StringBuilder();
            short negativo = 0;
            negativo -= gasto;

            this.SetTinta(negativo);
            if (gasto <= this.tinta)
            {                
                Console.WriteLine("*SE PINTÓ EL DIBUJO*");
                
                Console.BackgroundColor = this.color;                                
                for (int i = 0; i < gasto; i++)
                    auxString.Append('*');

                dibujo = auxString.ToString();
                retorno = true;
            }
            else
            {
                Console.WriteLine("*NO SE PUDO PINTAR TODO EL DIBUJO");

                Console.BackgroundColor = this.color;
                for (int i=0; i<this.tinta; i++)
                    auxString.Append('*');

                dibujo = auxString.ToString();
                retorno = false;
            }            

            return retorno;
        }

        /// <summary>
        /// Establece la cantidad de tinta del bolígrafo, tanto para cuando se carga como cuando se usa
        /// </summary>
        /// <param name="tinta">cantindad de tinta en cuestión</param>
        private void SetTinta(short tinta)
        {
            //carga tinta
            if (tinta > 0)
            {
                //el nivel de tinta resultante sea mayor o igual a cero y menor o igual a cantidadTintaMaxima
                if ((this.tinta + tinta) <= Boligrafo.cantidadTintaMaxima)
                {
                    if (this.tinta != Boligrafo.cantidadTintaMaxima)
                    {
                        this.tinta += tinta;
                        Console.WriteLine("*TINTA CARGADA*");
                    }

                    if (this.tinta == Boligrafo.cantidadTintaMaxima)
                        Console.WriteLine("*TINTA MAXIMA*");
                }
                else
                {
                    Console.WriteLine("*SUPERA EL NIVEL MAXIMO, NO SE CARGA*");
                }
            }
            //usa tinta
            else
            {
                //el nivel de tinta resultante sea mayor o igual a cero
                if ((this.tinta + tinta) >= 0)
                {
                    this.tinta += tinta;
                    if (this.tinta == 0)
                       Console.WriteLine("*NIVEL DE TINTA CERO*");
                }
                else
                {
                    Console.WriteLine("*TINTA INSUFICIENTE*");
                }
            }            
        }
    }
}
