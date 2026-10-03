namespace maquinasindustriais;
class program
{
    static void Main()
    {
        Console.WriteLine("Maquinas industriais");

        Impressora impressora = new Impressora()
        {
            NumeroSerie = 1050,
            AnoFabricacao = 1960,
            Peca = "Mancal",
            TipoImpressora = "HP"
        };

        impressora.Desligar();
        impressora.Ligar();
        impressora.ImprimirModelo();


        Torno torno = new Torno()
        {
            NumeroSerie = 5969,
            AnoFabricacao = 1982,
            Peca = "Mancal",
            TipoTorno = "Schneider"
        };

        torno.Desligar();
        torno.Ligar();
        torno.ProduzirPeca();

        MaquinaControle controle = new MaquinaControle()
        {
            NumeroSerie = 5431,
            AnoFabricacao = 1962,
            Temp = 200
        };

        controle.Desligar();
        controle.Ligar();
        controle.MonitorarTempetura();

        MaquinaTransporte transporte = new MaquinaTransporte()
        {
            NumeroSerie = 1540,
            AnoFabricacao = 1965,
            Carga = "Elefante"
        };

        transporte.Desligar();
        transporte.Ligar();
        transporte.TransportarCarga();
    }
}