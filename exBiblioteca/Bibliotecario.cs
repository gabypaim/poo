namespace Biblioteca;

public class Bibliotecario : Funcionario
{
    public override void ExecutarTarefa()
    {
        Console.WriteLine($"{Nome} está organizando livros e atendendo clientes.");
    }
}