using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaC11EC03;
using System;

namespace TestProjectC11EC03
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarListaDeCorredoresInctanciadaAlConstruirCompetencia_DebeRetornarTrue()
        {
            Competencia prueba;
            bool expected = true;
            bool actual;

            prueba = new Competencia(16, 60, Competencia.ETipoCompetencia.F1);
            actual = prueba.Competidores is not null;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AgregarUnVehiculoAUnaCompetencia_SePruebaAgregarUnaMotoAUnaCompetenciaDeAutos_DebeLanzarCompetenciaNoDisponibleException()
        {
            Competencia carreraMotos = new Competencia(16, 60, Competencia.ETipoCompetencia.MotoCross);
            AutoF1 auto = new AutoF1(1, "Ferrari", 400);
            string expected = new CompetenciaNoDisponibleException("","","").GetType().Name;
            string actual;

            try
            {
                bool sePodraONoSePodra = carreraMotos + auto;
                actual = null;
            }
            catch(Exception ex)
            {
                actual = ex.InnerException.GetType().Name;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AgregarUnVehiculoAUnaCompetencia_SePruebaAgregarUnaMotoAUnaCompetenciaDeMotos_NoDebeLanzarException()
        {
            Competencia carreraMotos = new Competencia(16, 60, Competencia.ETipoCompetencia.MotoCross);
            MotoCross moto1 = new MotoCross(10, "Lamborghini", 250);
            bool expected = true;
            bool actual;

            try
            {
                bool sePodraONoSePodra = carreraMotos + moto1;
                actual = true;
            }
            catch (Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ComprobarQueUnVehiculoEnCompetenciaFigureEnLaLista_DebeRetornarTrue()
        {
            Competencia carreraMotos = new Competencia(16, 60, Competencia.ETipoCompetencia.MotoCross);
            MotoCross moto1 = new MotoCross(10, "Lamborghini", 250);
            bool expected = true;
            bool actual;

            bool sePodraONoSePodra = carreraMotos + moto1;
            actual = carreraMotos == moto1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ComprobarQueUnVehiculoRemovidoNoFigureEnLaLista_DebeRetornarTrue()
        {
            Competencia carreraMotos = new Competencia(16, 60, Competencia.ETipoCompetencia.MotoCross);
            MotoCross moto1 = new MotoCross(10, "Lamborghini", 250);
            bool expected = true;
            bool actual;

            //se agrega
            bool sePodraONoSePodra = carreraMotos + moto1;
            //se quita
            sePodraONoSePodra = carreraMotos - moto1;
            //se busca
            actual = carreraMotos != moto1;

            Assert.AreEqual(expected, actual);
        }
    }
}
