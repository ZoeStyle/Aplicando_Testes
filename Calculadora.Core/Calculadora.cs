using System;

namespace Calculadora.Core
{
    public class Calculadora
    {
        public Calculadora(int limiteMinimo = 0)
        {
            _limiteMinimo = limiteMinimo;
        }
        private int _limiteMinimo;

        public int Somar(int a, int b)
        {
            ValidarLimite(a, b);
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            ValidarLimite(a, b);
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            ValidarLimite(a, b);
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            ValidarLimite(a, b);
            return a / b;
        }

        private void ValidarLimite(int a, int b)
        {
            if (a < _limiteMinimo || b < _limiteMinimo)
                throw new ArgumentOutOfRangeException("O argumento é menor que o limite minimo");
        }

    }
}