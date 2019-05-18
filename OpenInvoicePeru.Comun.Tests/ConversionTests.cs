using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenInvoicePeru.Comun.Tests
{
    [TestClass]
    public class ConversionTests
    {
        [TestMethod]
        public void Deberia_CrearTextoCorrecto_Cuando_ElTotalEsCero()
        {
            // arreglos...
            decimal valor = 0.0M;

            // acto...
            var rextoCalculado = Conversion.Enletras(valor);

            // assercion...
            Assert.AreEqual(RespuestasAnticipadas.CERO_CON_CERO, rextoCalculado);
        }

        [TestMethod]
        public void Deberia_CrearTextoCorrecto_Cuando_ElTotalContieneSolamenteCentavos()
        {
            // arreglos...
            decimal valor = 0.25M;

            // acto...
            var rextoCalculado = Conversion.Enletras(valor);

            // assercion...
            Assert.AreEqual(RespuestasAnticipadas.CERO_CON_25_CENTAVOS, rextoCalculado);
        }

        [TestMethod]
        public void Deberia_CrearTextoCorrecto_Cuando_ElTotalContieneDecenas()
        {
            // arreglos...
            decimal valor = 10.0M;

            // acto...
            var rextoCalculado = Conversion.Enletras(valor);

            // assercion...
            Assert.AreEqual(RespuestasAnticipadas.DEIZ_CON_CERO, rextoCalculado);
        }

        [TestMethod]
        public void Deberia_CrearTextoCorrecto_Cuando_ElTotalContieneCentenas()
        {
            // arreglos...
            decimal valor = 200.0M;

            // acto...
            var rextoCalculado = Conversion.Enletras(valor);

            // assercion...
            Assert.AreEqual(RespuestasAnticipadas.DOSCIENTOS_CON_CERO, rextoCalculado);
        }
    }

    internal static class RespuestasAnticipadas
    {
        public const string CERO_CON_25_CENTAVOS = "CERO CON 25/100";
        public const string CERO_CON_CERO = "CERO CON 00/100";
        public const string DEIZ_CON_CERO = "DIEZ CON 00/100";
        public const string DOSCIENTOS_CON_CERO = "DOSCIENTOS CON 00/100";
    }
}
