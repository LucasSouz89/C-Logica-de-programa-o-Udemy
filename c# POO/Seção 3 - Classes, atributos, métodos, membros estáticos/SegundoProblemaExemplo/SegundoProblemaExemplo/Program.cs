using SegundoProblemaExemplo;
using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Produto produto = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto.nome = Console.ReadLine();
            Console.Write("Preco: ");
            produto.preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.quantidade = int.Parse(Console.ReadLine());
            double ValorTotal = produto.ValorTotalEmEstoque();
            Console.WriteLine($"Dados do produto: {produto}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);
            Console.WriteLine($"Dados do produto: {produto}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);
            Console.WriteLine($"Dados do produto: {produto}");
        }
    }
}