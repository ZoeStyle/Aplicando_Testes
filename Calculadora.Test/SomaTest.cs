using Microsoft.VisualStudio.TestTools.UnitTesting;
using calc = Calculadora.Core;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class SomaTest
    {
        public SomaTest()
        {
            _calc = new calc.Calculadora(-4);
        }

        private calc.Calculadora _calc;

        [TestMethod]
        public void TestSomarNumerosPositivos()
        {
            Assert.AreEqual(4, _calc.Somar(2, 2));
        }

        [TestMethod]
        public void TestSomaComNumerosNegativos()
        {
            Assert.AreEqual(-2, _calc.Somar(-1, -1));
        }

        [TestMethod]
        public void TestSomarComUmNumeroPositivoUmNegativo()
        {
            Assert.AreEqual(4, _calc.Somar(-1, 5));
        }

        [TestMethod]
        public void TestSomarNumeroAbaixoDoLimite()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                _calc.Somar(-5, -4);
            });
        }

        [TestCleanup]
        public void CleanUp()
        {
            _calc = null;
        }
    }
}