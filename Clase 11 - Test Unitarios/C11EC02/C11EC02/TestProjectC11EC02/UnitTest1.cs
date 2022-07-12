/*
 *  Ejercicio C02 - Lanzar, atrapar y probar
 *  
 *  Partir del ejercicio Lanzar y atrapar.
 *  
 *  Realizar un test unitario para cada método y/o constructor. Cada test deberá validar que el método lance la excepción que le corresponde.
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using C11EC02;
using System;
using ExcepcionesC10EI01;

namespace TestProjectC11EC02
{
    [TestClass]
    public class UnitTest1
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
            catch(Exception ex)
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
