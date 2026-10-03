namespace Biblioteca;

public abstract class Pessoa
{
    public string Nome { get; set; }
    public string CPF { get; set; }

    public virtual void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
    }
}