using System.Collections;

namespace polimorfismo;

public class Program
{
    static void Main()
    {
        ArrayList funcionario = new ArrayList();

        funcionario.Add(new Gerente("Nicole", 7600,32));
        funcionario.Add(new Vendedor("Gaby", 2300,2502));
        funcionario.Add(new Desenvolvedor("Red", 2300,"c"));
        funcionario.Add(new Vendedor("Green", 2300,2502));

        foreach(Funcionario func in funcionario)
        {
            func.ExibirDados();


            Console.WriteLine($"Bonus Padrão: {func.CalcularBonus():F2}");
            Console.WriteLine($"Bonus Padrão: {func.CalcularBonus(15):F2}\n");
            Console.WriteLine($"--------------------------------");

        }
    }


}
