namespace Biblioteca;

class Program
{
    static void Main()
    {
        Bibliotecario bibliotecario = new Bibliotecario()
        {
            Nome = "Jinshi",
            CPF = "111.111.111-11"
        };

        Auxiliar auxiliar = new Auxiliar()
        {
            Nome = "Maomao",
            CPF = "222.222.222-22"
        };

        Cliente cliente = new Cliente()
        {
            Nome = "Gaby",
            CPF = "333.333.333-33"
        };

        Autor autor = new Autor()
        {
            Nome = "Nicole",
            CPF = "444.444.444-44"
        };

        cliente.EmprestarLivro("Memórias do Subsolo");
        autor.RegistrarObra("Turma da Mônica");

        bibliotecario.ExecutarTarefa();
        auxiliar.ExecutarTarefa();

        List<Pessoa> pessoas = new List<Pessoa>();

        pessoas.Add(bibliotecario);
        pessoas.Add(auxiliar);
        pessoas.Add(cliente);
        pessoas.Add(autor);

        foreach (Pessoa pessoa in pessoas)
        {
            pessoa.Apresentar();
            Console.WriteLine();
        }
    }
}