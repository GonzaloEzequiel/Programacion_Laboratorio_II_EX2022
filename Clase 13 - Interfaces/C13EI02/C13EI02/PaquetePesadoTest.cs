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
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            //arrange
            PaquetePesado paqPesado1 = new PaquetePesado("M404SL69G", 650M, "Los Angeles", "Seoul", 60.75);
            decimal esperado = 650M + (650M * 25 / 100) + (650M * 35 / 100);
            decimal obtenido;

            //act
            obtenido = ((IAfip)paqPesado1).AplicarImpuestos();

            //assert
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            //arrange
            PaquetePesado paqPesado1 = new PaquetePesado("M404SL69G", 650M, "Los Angeles", "Seoul", 60.75);
            decimal esperado = 650M * 25/100;
            decimal obtenido;

            //act
            obtenido = ((IAfip)paqPesado1).Impuestos;

            //assert
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //arrange
            PaquetePesado paqPesado1 = new PaquetePesado("M404SL69G", 650M, "Los Angeles", "Seoul", 60.75);
            decimal esperado = 650M * 35/100;
            decimal obtenido;

            //act
            obtenido = paqPesado1.Impuestos;

            //assert
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            //arrange
            PaquetePesado paqPesado1 = new PaquetePesado("M404SL69G", 650M, "Los Angeles", "Seoul", 60.75);
            bool esperado = false;
            bool obtenido;
            //act
            obtenido = paqPesado1.TienePrioridad;

            //assert
            Assert.AreEqual(esperado, obtenido);
        }
    }
}
