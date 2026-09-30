namespace polimorfismo;

public abstract class Funcionario
{
    //atributos
    public string Nome { get; set;  }
    public double Salario { get; set;  }

    //metodo construtor
    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }

    //sobreescrito de metodo (sobreescrito = classe filha)
    public virtual void ExibirDados()
    {
        Console.WriteLine($"Funcionario: {Nome}\n");
        Console.WriteLine($"Salário: {Salario}\n");
    }

    public virtual double CalcularBonus()
    {
        return Salario * 0.1;
    }

    //sobrecarga (tipo de virtualização), 2 metodos um ou outro, (sobrecarga = mesma classe)
    public virtual double CalcularBonus(double percentual) //assinatura diferente (double percentual)
    {
        return (Salario * percentual) / 100;
    }
}

public class Gerente : Funcionario
{
    public int QuantidadeFuncionario { get; set; }

    //contrutor
    public Gerente(string nome, double salario, int quantidadeFuncionario):base(nome,salario)
    {
        QuantidadeFuncionario = quantidadeFuncionario;
    }

    //sobreescrita
    public override void ExibirDados()
    {
        Console.WriteLine("GERENTE <3");
        Console.WriteLine($"Nome: {Nome}, \n Salário: {Salario:F2} \n Funcionarios: {QuantidadeFuncionario}\n");
    }
}

public class Vendedor : Funcionario
{
    public double TotalVendas { get; set;  }

    public Vendedor(string nome, double salario, double totalVendas) : base(nome, salario)
    {
        TotalVendas = totalVendas;
    }

    public override void ExibirDados()
    {
        Console.WriteLine("VENDEDOR <3");
        Console.WriteLine($"Nome: {Nome}, \n Salário: {Salario:F2} \n Total Vendas: {TotalVendas}\n");
    }

}

public class Desenvolvedor : Funcionario
{
    public string Linguagem { get; set; }

    public Desenvolvedor(string nome, double salario, string linguagem) : base(nome, salario)
    {
        Linguagem = linguagem;
    }

    public override void ExibirDados()
    {
        Console.WriteLine("DESENVOLVEDOR <3");
        Console.WriteLine($"Nome: {Nome}, \n Salário: {Salario:F2} \n Linguagem: {Linguagem}\n");
    }

}
