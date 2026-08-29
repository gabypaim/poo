using System;
using System.Collections.Generic;
using System.Text;

namespace ex07medianotas
{
    internal class Aluno
    {
        public double CalcularMedia(double n1, double n2) => (n1 + n2)/2;

        public string Aprovacao(double media)
        {
            if (media >= 6)
            {
                return "Aprovado!!!";
            } else
            {
                return "Reprovado.";
            }
        }
    }
}
