using System;
using ex04verificadoridade;

class Program
{
    static void Main()
    {
        VerificadorIdade verificador = new VerificadorIdade();

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine(verificador.Maioridade(idade));
    }
}