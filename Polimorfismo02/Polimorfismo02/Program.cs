using System.Collections;
using static Polimorfismo02.Forma;

namespace Polimorfismo02;

public abstract class Forma
{
    public string Nome { get; set; }
    public Forma(string nome)
    {
        Nome = nome;
    }

    public virtual double CalcularArea()
    {
        return 0;
    }

    public virtual double CalcularArea(double fator)
    {
        return CalcularArea() * fator;
    }

    public class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double raio) : base("Circulo")
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * ( Raio * Raio );
        }

    }

    public class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double altura, double largura) :base("Retangulo")
        {
            Altura = altura;
            Largura = largura;
        }

        public override double CalcularArea()
        {
            return (Altura + Largura) / 2;
        }

    }
    public class Triangulo : Forma
    {
        public double Basee { get; set; }
        public double Altura { get; set; }

        public Triangulo(double altura, double basee) : base("Triangulo")
        {
            Altura = altura;
            Basee = basee;
        }

        public override double CalcularArea()
        {
            return (Basee*Altura) / 2 ;
        }

    }

    
}

public class Program
{
    static void Main()
    {
        ArrayList formas=new ArrayList();

        formas.Add(new Circulo(5));
        formas.Add(new Triangulo(5,2));
        formas.Add(new Retangulo(5, 5));
       
        foreach( Forma form in formas)
        {
            Console.WriteLine($"Forma: {form.Nome}");
            Console.WriteLine($"Area: {form.CalcularArea()}");
            Console.WriteLine($"Area fator 2: {form.CalcularArea(2)}\n");
            
        }
    }
}