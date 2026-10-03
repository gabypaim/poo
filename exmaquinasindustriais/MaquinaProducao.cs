namespace maquinasindustriais;

// Também é abstract.
// Herda tudo que existe em Maquina.
public abstract class MaquinaProducao : Maquina
{
    // Peça que a máquina vai produzir.
    public string Peca { get; set; }

    // virtual = as classes filhas podem substituir esse método.
    public virtual void ProduzirPeca()
    {
        Console.WriteLine($"A {NumeroSerie} está produzindo a peça {Peca}");
    }

    // Também pode ser substituído pelas classes filhas.
    public virtual void ImprimirModelo()
    {
        Console.WriteLine($"A {NumeroSerie} está imprimindo a peça {Peca}");
    }
}