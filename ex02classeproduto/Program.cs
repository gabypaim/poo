using System;
using ex02classeproduto;
class Program
{
    static void Main()
    {
        Produto p = new Produto("Notebook", 3500.00, 10);
        Console.WriteLine(p.ExibirInformacoes());
    }
}