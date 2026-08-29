using System;
using ex07medianotas;

class Program
{
    static void Main()
    {
        //Objeto
        Aluno aluno = new Aluno();

        //array
        double[] notas = new double[2];

        //entrada
        Console.Write("Digite o nome do(a) aluno(a)? ");
        string nome = Console.ReadLine();

        Console.Write("Primeira nota: ");
        notas[0] = double.Parse(Console.ReadLine().Replace('.', ','));

        Console.Write("Segunda nota: ");
        notas[1] = double.Parse(Console.ReadLine().Replace('.', ','));

        //metodos
        double media = aluno.CalcularMedia(notas[0], notas[1]);
        string resultado = aluno.Aprovacao(media);

        //saida
        Console.WriteLine("\nBOLETIM");
        Console.WriteLine($"Aluno: {nome}");
        Console.WriteLine($"nota: {media}");
        Console.WriteLine($"resultado: {media}");
    }
}