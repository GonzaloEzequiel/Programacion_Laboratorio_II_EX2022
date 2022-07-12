using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC13EI01
{
    public class CartucheraSimple
    {
        public List<Boligrafo> boligrafos;
        public List<Lapiz> lapices;
        
        public CartucheraSimple()
        {
            this.boligrafos = new List<Boligrafo>();
            this.lapices = new List<Lapiz>();
        }

        public bool RecorrerElementos()
        {
            foreach (Boligrafo boligrafo in this.boligrafos)
            {
                if (boligrafo.UnidadesDeEscritura > 0)
                {
                    boligrafo.UnidadesDeEscritura -= 1;
                }
                else
                {
                    boligrafo.Recargar(20);
                    return false;
                }
            }

            foreach (Lapiz lapiz in this.lapices)
            {
                if(((IAcciones)lapiz).UnidadesDeEscritura > 0)
                {
                    ((IAcciones)lapiz).UnidadesDeEscritura -= 1;
                }
                else
                {
                    try
                    {
                        ((IAcciones)lapiz).Recargar(20);
                    }
                    catch(NotImplementedException ex)
                    {
                        Console.WriteLine("Lapiz.Recargar() no está implementado bro\n" + ex.Message);
                        return false;
                    }
                }

            }

            return true;
        }
    }
}
