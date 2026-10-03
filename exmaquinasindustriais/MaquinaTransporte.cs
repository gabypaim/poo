namespace maquinasindustriais;

// Herda diretamente de Maquina.
public class MaquinaTransporte : Maquina
{
    // Informação específica da máquina de transporte.
    public string Carga { get; set; }

    // Método específico para transportar.
    public void TransportarCarga()
    {
        Console.WriteLine($"A maquina {NumeroSerie} está transportando a carga {Carga}");
    }
}