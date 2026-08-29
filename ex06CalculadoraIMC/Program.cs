using System;
using ex06calculadoraIMC;

class Program
{
    static void Main()
    {   
        //objeto
        IMC imc = new IMC();

        //entrada
        Console.Write("Digite sua altura e peso: ");
        string[] valores = Console.ReadLine().Split(' ');

        // vars
        double altura = double.Parse(valores[0].Replace(".", ","));
        double peso = double.Parse(valores[1].Replace(".", ","));

        //metodos
        double resultado = imc.Calcular(altura, peso);
        string classificacao = imc.Classificar(resultado);

        //saida f2=duas casas decimais ou arredonda
        Console.WriteLine($"{resultado:F2}");
        Console.WriteLine(classificacao);
    }
}