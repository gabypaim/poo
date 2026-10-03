namespace Biblioteca;

public class Autor : Pessoa
{
    public void RegistrarObra(string obra)
    {
        Console.WriteLine($"{Nome} registrou a obra {obra}.");
    }
}