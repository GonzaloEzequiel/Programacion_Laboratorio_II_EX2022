using Microsoft.VisualStudio.TestTools.UnitTesting;
using C14EC01;
using ExcepcionesC14EC01;
using System;

namespace TestProjectC14EC01
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void MiClaseMetodoEstáticoLanzandoException_DebeSerDividedByZeroException()
        {
            string expected = new DivideByZeroException().GetType().Name;
            string actual;

            try
            {
                MiClase.MetodoEstatico();
                actual = null;
            }
            catch (Exception ex)
            {
                actual = ex.GetType().Name;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MiClaseConstructorSinParametroLanzandoException_DebeSerDividedByZeroException()
        {
            MiClase prueba;
            string expected = new DivideByZeroException().GetType().Name;
            string actual;

            try
            {
                prueba = new MiClase();
                actual = null;
            }
            catch (Exception ex)
            {
                actual = ex.GetType().Name;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MiClaseConstructorConParametroLanzandoException_DebeSerUnaException()
        {
            MiClase prueba;
            string expected = new UnaException().GetType().Name;
            string actual;

            try
            {
                prueba = new MiClase("atributoPrueba");
                actual = null;
            }
            catch (Exception ex)
            {
                actual = ex.GetType().Name;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OtraClaseMetodoDeInstanciaLanzandoException_DebeSerMiException()
        {
            OtraClase prueba = new OtraClase();
            string expected = new MiException().GetType().Name;
            string actual;

            try
            {
                prueba.MetodoDeInstancia();
                actual = null;
            }
            catch (Exception ex)
            {
                actual = ex.GetType().Name;
            }

            Assert.AreEqual(expected, actual);
        }
    }
}
