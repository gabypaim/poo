namespace Biblioteca;

public class Auxiliar : Funcionario
{
    public override void ExecutarTarefa()
    {
        Console.WriteLine($"{Nome} está repondo livros nas prateleiras.");
    }
}