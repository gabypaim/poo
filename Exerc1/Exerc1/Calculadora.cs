using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc1
{
    internal class Calculadora
    {
        public int Somar(int a, int b) => a + b;
        public int Subtrair(int a, int b) => a - b;
        public int Multiplicar(int a, int b) => a * b;
        public double Dividir(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Divisão por zero não é permitido");
            return (double)a / b;
        }
    }
}
