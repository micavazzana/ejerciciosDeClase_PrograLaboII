using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestParadaEnBoxes
{
    [TestClass]
    public class TestCompetencia
    {
        [TestMethod]
        public void ListaCompetidores_CuandoSeInstanciaUnaCompetencia_DeberiaDevolverUnaListaInstanciada()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 5, Competencia.TipoCompetencia.F1);

            //Assert
            Assert.IsNotNull(competencia.ListaCompetidores);
        }
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Add_CuandoSeQuiereAgregarUnAutoEnUnaCompetenciaDeMoto_DeberiaDevolverCompetenciaNoDisponibleException()
        {
            Competencia motocross = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);
            AutoF1 a1 = new AutoF1(4, "Red Bull Racing", 2);

            bool a�adeAuto = motocross + a1;
        }
        [TestMethod]
        public void Add_CuandoSeQuiereAgregarUnaMotoEnUnaCompetenciaDeMoto_DeberiaDevolverTrue()
        {
            Competencia motocross = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(7, "Red Bull Racing", 34);

            bool a�adeMoto = motocross + m1;

            Assert.IsTrue(a�adeMoto);
        }
        [TestMethod]
        public void Add_CuandoSeQuiereAgregarUnVehiculoEnUnaCompetenciaYVerificarQueSeHayaAniadido_DeberiaDevolverTrue()
        {
            Competencia motocross = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(7, "Red Bull Racing", 34);

            bool a�adeMoto = motocross + m1;
            bool existe = motocross == m1;

            Assert.IsTrue(existe);
        }
        [TestMethod]
        public void Add_CuandoSeQuiereQuitarUnVehiculoEnUnaCompetenciaYVerificarQueSeHayaQuitado_DeberiaDevolverTrue()
        {
            Competencia motocross = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(7, "Red Bull Racing", 34);

            bool a�adeMoto = motocross + m1;
            bool quitaMoto = motocross - m1;
            bool existe = motocross != m1;

            Assert.IsTrue(existe);
        }
    }
}
