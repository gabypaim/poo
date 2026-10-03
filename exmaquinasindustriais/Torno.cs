namespace maquinasindustriais;

// Torno herda de MaquinaProducao.
// Portanto também recebe as coisas de Maquina.
public class Torno : MaquinaProducao
{
    // Tipo específico do torno.
    public string TipoTorno { get; set; }

    // override = substitui a versão que veio da classe pai.
    public override void ProduzirPeca()
    {
        // base = chama a versão da classe pai.
        base.ProduzirPeca();
    }
}