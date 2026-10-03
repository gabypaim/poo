namespace maquinasindustriais;

// Impressora herda de MaquinaProducao.
public class Impressora : MaquinaProducao
{
    // Informação específica da impressora.
    public string TipoImpressora { get; set; }

    // Substitui o método da classe pai.
    public override void ImprimirModelo()
    {
        // Chama o método original da classe pai.
        base.ImprimirModelo();
    }
}