using System;
using ex05conversortemp;

class Program
{
    static void Main()
    {
        ConversorTemperatura temperatura = new ConversorTemperatura();

        Console.Write("Digite uma temperatura para converter: ");
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Converter para Celsius? (S/N): ");
        string resposta = Console.ReadLine().ToUpper();
        bool paraCelsius = resposta == "S";

        if (paraCelsius)
        {
            double resultado = temperatura.FahrenheitforCelsius(temp);
            Console.WriteLine($"Temperatura em Celsius: {resultado}");
        }
        else
        {
            double resultado = temperatura.CelsiusforFahrenheit(temp);
            Console.WriteLine($"Temperatura em Fahrenheit: {resultado}");
        }
    }
}
 