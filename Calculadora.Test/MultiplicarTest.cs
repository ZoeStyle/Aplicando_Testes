using Microsoft.VisualStudio.TestTools.UnitTesting;
using calc = Calculadora.Core;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class MultiplicarTest
    {
        public MultiplicarTest()
        {
            _calc = new calc.Calculadora(-2);
        }

        private calc.Calculadora _calc;

        [TestMethod]
        public void MultiplicarNumeroPositivos()
        {
            Assert.AreEqual(4, _calc.Multiplicar(2, 2));
        }

        [TestMethod]
        public void MultiplicarComException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                _calc.Multiplicar(-3, 1);
            });
        }

        [TestCleanup]
        public void CleanUp()
        {
            _calc = null;
        }
    }
}