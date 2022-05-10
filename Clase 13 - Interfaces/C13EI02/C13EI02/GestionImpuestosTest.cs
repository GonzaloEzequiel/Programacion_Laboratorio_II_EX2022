using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaC13EI02;

namespace C13EI02
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            //arrange
            GestionImpuestos buenaGestion = new GestionImpuestos();
            PaquetePesado paqPesado1 = new PaquetePesado("M404SL69G", 650M, "Los Angeles", "Seoul", 60.75);
            PaqueteFragil paqFragil1 = new PaqueteFragil("01526F32", 125.50M, "La Ferrere", "Mar Del Plata", 12.5);
            List<Paquete> listado = new List<Paquete>();

            listado.Add(paqFragil1);
            listado.Add(paqPesado1);

            decimal esperado = (650M * 35 / 100) + (125.50M * 35 / 100);
            decimal obtenido;

            //act
            buenaGestion.RegistrarImpuestos(listado);
            obtenido = buenaGestion.CalcularTotalImpuestosAduana();

            //assert
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            //arrange
            GestionImpuestos buenaGestion = new GestionImpuestos();
            PaquetePesado paqPesado1 = new PaquetePesado("M404SL69G", 650M, "Los Angeles", "Seoul", 60.75);
            PaqueteFragil paqFragil1 = new PaqueteFragil("01526F32", 125.50M, "La Ferrere", "Mar Del Plata", 12.5);
            List<Paquete> listado = new List<Paquete>();

            listado.Add(paqFragil1);
            listado.Add(paqPesado1);

            decimal esperado = (650M * 25 / 100);
            decimal obtenido;

            //act
            buenaGestion.RegistrarImpuestos(listado);
            obtenido = buenaGestion.CalcularTotalImpuestosAfip();

            //assert
            Assert.AreEqual(esperado, obtenido);
        }
    }
}
