using System;
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Altura { get; set; }

    public string Apresentar()
    {
        return $"Meu nome é {Nome}, tenho {Idade} anos e minha altura é {Altura}";
    }
}
class Program
{
    static void Main()
    {
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Gaby";
        pessoa1.Idade = 20;
        pessoa1.Altura = 1.54;

        Console.WriteLine(pessoa1.Apresentar());
    }
}