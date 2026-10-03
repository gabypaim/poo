namespace Biblioteca;

public abstract class Funcionario : Pessoa
{
    public virtual void ExecutarTarefa()
    {
        Console.WriteLine($"{Nome} está executando uma tarefa.");
    }
}