using Exerc2;

public class Program
{
    public static void Main()
    {
        Produto p = new Produto("Notebook", 3500.00, 10);
        Console.WriteLine(p.ExibirInformacoes());
    }
}