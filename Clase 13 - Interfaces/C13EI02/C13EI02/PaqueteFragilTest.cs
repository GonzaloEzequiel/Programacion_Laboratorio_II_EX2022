using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaC13EI02;

namespace C13EI02
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            //arrange
            PaqueteFragil paqFragil1 = new PaqueteFragil("01526F32", 125.50M, "La Ferrere", "Mar Del Plata", 12.5);
            decimal esperado = 125.50M + (125.50M * 35 / 100);
            decimal obtenido;

            //act
            obtenido = paqFragil1.AplicarImpuestos();

            //assert
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //arrange
            PaqueteFragil paqFragil1 = new PaqueteFragil("01526F32", 125.50M, "La Ferrere", "Mar Del Plata", 12.5);
            decimal esperado = 125.50M * 35 /100;
            decimal obtenido;

            //act
            obtenido = paqFragil1.Impuestos;

            //assert
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //arrange
            PaqueteFragil paqFragil1 = new PaqueteFragil("01526F32", 125.50M, "La Ferrere", "Mar Del Plata", 12.5);
            bool esperado = true;
            bool obtenido;
            //act
            obtenido = paqFragil1.TienePrioridad;

            //assert
            Assert.AreEqual(esperado, obtenido);
        }
    }
}
