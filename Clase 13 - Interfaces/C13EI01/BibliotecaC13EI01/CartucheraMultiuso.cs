using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaC13EI01
{
    public class CartucheraMultiuso
    {
        public List<IAcciones> listado;

        public CartucheraMultiuso()
        {
            this.listado = new List<IAcciones>();
        }

        public bool RecorrerElementos()
        {
            foreach(IAcciones acciones in this.listado)
            {
                if(acciones.UnidadesDeEscritura > 0)
                {
                    acciones.UnidadesDeEscritura -= 1;
                }
                else
                {
                    try
                    {
                        acciones.Recargar(20);
                    }
                    catch (NotImplementedException ex)
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
