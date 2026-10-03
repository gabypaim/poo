namespace Biblioteca;

public class Cliente : Pessoa
{
    public void EmprestarLivro(string livro)
    {
        Console.WriteLine($"{Nome} emprestou o livro {livro}.");
    }
}