using System;
using ex01calculadorasimples;

class Program
{
    static void Main()
    {
        //objeto
         Calculadora calc = new Calculadora();

        //saida
        Console.WriteLine("Numeros: 10,5");
        Console.WriteLine($"Somar: {calc.Somar(10, 5)}");
        Console.WriteLine($"Subtrair: {calc.Subtrair(10, 5)}");
        Console.WriteLine($"Multiplicação: {calc.Multiplicar(10, 5)}");
        Console.WriteLine($"Divisão: {calc.Dividir(10, 5)}");
    }
}