using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc2
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string ExibirInformacoes() => $"Produto: {Nome}\nPreço: {Preco}\nQuantidade: {Quantidade}";
        public double CalcularValorTotal() => Preco * Quantidade;
        public void AdicionarEstoque(int quantidade) => Quantidade += quantidade;
        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > Quantidade)
            {
                throw new InvalidOperationException("Quantidade insuficiente em estoque");
            }
            
            Quantidade -= quantidade;
        }

    }
}
