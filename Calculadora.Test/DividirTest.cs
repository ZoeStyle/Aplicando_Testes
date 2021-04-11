using Microsoft.VisualStudio.TestTools.UnitTesting;
using calc = Calculadora.Core;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class DividirTest
    {
        public DividirTest()
        {
            _calc = new calc.Calculadora();
        }
        private calc.Calculadora _calc;

        [TestMethod]
        public void DividirNumerosInteiro()
        {
            Assert.AreEqual(2, _calc.Dividir(4, 2));
        }

        [TestMethod]
        public void DividirComException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                _calc.Dividir(4, -1);
            });
        }
    }
}