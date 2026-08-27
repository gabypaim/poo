using Exerc1;

public class Program
{
    public static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine($"Soma: {calc.Somar(10, 5)}");
        Console.WriteLine($"Subtração: {calc.Subtrair(10, 5)}");
        Console.WriteLine($"Multiplicação: {calc.Multiplicar(10, 5)}");
        Console.WriteLine($"Divisão: {calc.Dividir(10, 5)}");
        Console.WriteLine($"Divisão: {calc.Dividir(10, 0)}");
    }
}