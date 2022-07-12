/*
 *  Ejercicio I01 - Test Driven Development
 * 
 *  Crear una calculadora de string con un método int Add (string numeros) y automatizar las pruebas unitarias para cada uno de los siguientes puntos.
 *  
 *  SUGERENCIAS
 *      Comience con el caso de prueba más simple de un string vacío y pase a uno y dos números
 *      Recuerde resolver las cosas de la forma más sencilla posible
 *      Recuerde refactorizar después de cada prueba aprobada.
 * 
 *  Parte I
 *  El método Add debe poder tomar hasta dos números separados por comas, y devolverá su suma.
 *  Por ejemplo "" o "1" o "1,2" como entradas (para un string vacío devolverá 0).
 *  
 *  Parte II
 *  Permitir que el método Add maneje una cantidad desconocida de números.
 *  
 *  Parte III
 *  Permita que el método Add admita salto de línea entre números (en lugar de comas).
 *  La siguiente entrada está bien: "1 \ n2,3" (será igual a 6).
 *  La siguiente entrada NO está bien: "1, \ n" (no es necesario probarlo, solo se aclara)
 *  
 *  Parte IV
 *  Permitir que el método Add soporte diferentes delimitadores.
 *  Para cambiar un delimitador, el comienzo del string contendrá dos barras, debe verse así:
 *      // [delimitador] \ n [números ...]
 *  
 *  Por ejemplo: "//; \ n1; 2" debe devolver tres donde el valor predeterminado delimitador es ';'.
 *  Las barras son opcionales. Todos los escenarios existentes aún deben ser compatibles.
 *  
 *  Parte V
 *  Si Add recibe un número negativo arrojará una excepción NegativoNoPermitidoException que en su mensaje contendrá el negativo que se recibió.
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C11EI01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculadoraStringAdd_DebeDevolverCeroPorqueStringEsNulo()
        {
            //Arrange
            string stringPrueba = string.Empty;
            int expected = 0;
            int actual;

            //Act
            actual = CalculadoraString.Add(stringPrueba);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculadoraStringAdd_DebeDevolverUno()
        {
            string stringPrueba = "1,NaN";
            int expected = 1;
            int actual;

            actual = CalculadoraString.Add(stringPrueba);

            Assert.AreEqual(expected, actual);
        }

        //PARTE II
        [TestMethod]
        public void CalculadoraStringAdd_DebeDevolverDiez()
        {
            string stringPrueba = "1,3,6";
            int expected = 10;
            int actual;

            actual = CalculadoraString.Add(stringPrueba);

            Assert.AreEqual(expected, actual);
        }

        //PARTE III
        [TestMethod]
        public void CalculadoraStringAdd_DebeDevolverCincuenta()
        {
            string stringPrueba = "10,NaN,14\n6,  ,15,5";
            int expected = 50;
            int actual;

            actual = CalculadoraString.Add(stringPrueba);

            Assert.AreEqual(expected, actual);
        }

        //PARTE IV
        [TestMethod]
        public void CalculadoraStringAdd_DebeDevolverCien()
        {
            string stringPrueba = "//; 10,NaN;14\n6,  ,15,5;50";
            int expected = 100;
            int actual;

            actual = CalculadoraString.Add(stringPrueba);

            Assert.AreEqual(expected, actual);
        }

        //PARTE V
        [TestMethod]
        public void CalculadoraStringAdd_DebeDevolverException()
        {
            string stringPrueba = "//; 10,NaN;-14\n6,  ,15,5;50";
            string expected = new NegativoNoPermitidoException().GetType().Name;
            string actual;

            try
            {
                CalculadoraString.Add(stringPrueba);
                actual = null;
            }
            catch(Exception ex)
            {
                actual = ex.GetType().Name;
            }            

            Assert.AreEqual(expected, actual);
        }
    }
}
