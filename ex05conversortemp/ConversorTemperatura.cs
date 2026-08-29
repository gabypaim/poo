using System;
using System.Collections.Generic;
using System.Text;

namespace ex05conversortemp
{
    internal class ConversorTemperatura
    {   
        
        public double CelsiusforFahrenheit(double temp)
        {
            return (temp * 1.8) + 32;
        }

        public double FahrenheitforCelsius(double temp)
        {
            return (temp - 32) * 5 / 9;

        }
    }
}
