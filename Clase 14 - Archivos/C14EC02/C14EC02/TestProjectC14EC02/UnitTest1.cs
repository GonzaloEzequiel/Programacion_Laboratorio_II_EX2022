/*
 *  Ejercicio C01 - La centralita: Episodio IV
 * 
 *  Partir del ejercicio La centralita: Episodio III.
 *  
 *  1. Crear un test unitario que valide que la lista de llamadas de la centralita esté instanciada al crear un nuevo objeto del tipo Centralita.
 *  2. Controlar mediante un nuevo método de test unitario que la excepción CentralitaException se lance al intentar cargar una segunda 
 *      llamada con solamente los mismos datos de origen y destino de una llamada Local ya existente.
 *  3. Controlar mediante un nuevo método de test unitario que la excepción CentralitaException se lance al intentar cargar una segunda llamada 
 *      con solamente los mismos datos de origen y destino de una llamada Provincial ya existente.
 *  4. Dentro de un método de test unitario crear dos llamadas Local y dos Provincial, todos con los mismos datos de origen y destino. 
 *      Luego comparar cada uno de estos cuatro objetos contra los demás, debiendo ser iguales solamente las instancias 
 *      de Local y de Provincial entre sí.
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaCentralita;
using System;

namespace TestProjectC11EC01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarListaDeLlamadasInstanciadaAlConstruirCentralita_DebeDarVerdadero()
        {
            Centralita prueba = new Centralita("empresaPrueba");
            bool expected = true;
            bool actual;

            actual = (prueba.Llamadas is not null);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ControlarLanzamientoDeCentralitaExceptionCargandoUnaLlamadaLocalRepetida_DebeDarCentralitaException()
        {
            Centralita prueba = new Centralita("empresaPrueba");
            Local l1 = new Local("1130643436", 30, "1120691337", 2.65f);
            Local l2 = new Local("1130643436", 45, "1120691337", 1.99f);
            string expected = new CentralitaException("","","").GetType().Name;
            string actual;

            prueba += l1;

            try
            {
                prueba += l2;
                actual = null;
            }
            catch (Exception ex)
            {
                actual = ex.GetType().Name;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ControlarLanzamientoDeCentralitaExceptionCargandoUnaLlamadaProvincialRepetida_DebeDarCentralitaException()
        {
            Centralita prueba = new Centralita("empresaPrueba");
            Provincial l1 = new Provincial("1120691337", Provincial.EFranja.Franja_1, 21, "#054110987591523");
            Provincial l2 = new Provincial("1120691337", Provincial.EFranja.Franja_1, 304, "#054110987591523");
            string expected = new CentralitaException("", "", "").GetType().Name;
            string actual;

            prueba += l1;

            try
            {
                prueba += l2;
                actual = null;
            }
            catch (Exception ex)
            {
                actual = ex.GetType().Name;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidarLlamadasSoloDelMismoTipo_DebeDarVerdadero()
        {
            Centralita prueba = new Centralita("empresaPrueba");
            Local l1 = new Local("1130643436", 30, "1120691337", 2.65f);
            Local l2 = new Local("1130643436", 45, "1120691337", 1.99f);
            Provincial l3 = new Provincial("1130643436", Provincial.EFranja.Franja_1, 21, "1120691337");
            Provincial l4 = new Provincial("1130643436", Provincial.EFranja.Franja_1, 304, "1120691337");
            bool expected = true;
            bool actual;

            actual = (
                    (l1 == l2 && l1 != l3 && l1 != l4) &&
                    (l2 == l1 && l2 != l3 && l2 != l4) &&
                    (l3 == l4 && l3 != l1 && l3 != l2) &&
                    (l4 == l3 && l4 != l1 && l4 != l2) 
                );

            Assert.AreEqual(expected, actual);
        }

    }
}
