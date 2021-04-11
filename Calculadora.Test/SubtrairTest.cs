using Microsoft.VisualStudio.TestTools.UnitTesting;
using calc = Calculadora.Core;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class SubtrairTest
    {
        public SubtrairTest()
        {
            _calc = new calc.Calculadora(-5);
        }
        private calc.Calculadora _calc;

        [TestMethod]
        public void SubtrairNumerosPositivos()
        {
            Assert.AreEqual(4, _calc.Subtrair(8, 4));
        }

        [TestMethod]
        public void SubtrairNumerosNegativos()
        {
            Assert.AreEqual(0, _calc.Subtrair(-1, -1));
        }

        [TestMethod]
        public void SubtrairNumeroPositivoComNegativo()
        {
            Assert.AreEqual(-2, _calc.Subtrair(-1, 1));
        }

        [TestMethod]
        public void SubtrairComException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                _calc.Subtrair(-5, -6);
            });
        }

        [TestCleanup]
        public void CleanUp()
        {
            _calc = null;
        }

    }
}