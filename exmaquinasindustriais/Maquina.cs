namespace maquinasindustriais;

// abstract = classe que serve como base.
// Não criamos uma Maquina diretamente.
// Ela existe para ser herdada por outras classes.
public abstract class Maquina
{
    // Propriedade pública.
    // get = pegar/ler o valor.
    // set = colocar/alterar o valor.
    public int NumeroSerie { get; set; }

    public int AnoFabricacao { get; set; }

    // Método que qualquer classe filha pode usar.
    public void Ligar()
    {
        Console.WriteLine($"A maquina {NumeroSerie} está ligada");
    }

    // Outro método que as classes filhas podem usar.
    public void Desligar()
    {
        Console.WriteLine($"A maquina {NumeroSerie} está desligada");
    }
}
