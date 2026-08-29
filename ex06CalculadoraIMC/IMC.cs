using System;
using System.Collections.Generic;
using System.Text;

namespace ex06calculadoraIMC
{
    internal class IMC
    {
        public double Calcular(double altura, double peso)
        {
            return peso / (altura * altura);
        }

        public string Classificar(double resultado)
        {
            if (resultado <= 18.5)
            {
                return "Baixo peso";
            } 
            else if (resultado <= 24.9)
            {
                return "Peso normal";
            }
            else if (resultado <= 29.9)
            {
                return "sobrepeso";
            }
            else if (resultado <= 34.9)
            {
                return "Obesidade grau I";
            }
            else if (resultado <= 39.9)
            {
                return "Obesidade grau II";
            }
            else
            {
                return "Obesidade grau III(mórbida)";
            }
        }
    }
}
