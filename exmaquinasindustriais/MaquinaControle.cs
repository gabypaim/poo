namespace maquinasindustriais;

// Herda de Maquina.
public class MaquinaControle : Maquina
{
    // Temperatura da máquina.
    public double Temp { get; set; }

    // Método específico da máquina de controle.
    public void MonitorarTempetura()
    {
        Console.WriteLine($"A maquina {NumeroSerie} está monitorando a temperatura");
    }
}