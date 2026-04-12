using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // ---------------------------------------------------------
            // 1. Entrada de Dados
            // ---------------------------------------------------------

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.Clear(); // Limpa a tela para a próxima pergunta

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Entre com o preço do produto:");
            // Importante: InvariantCulture para aceitar o ponto (ex: 500.50)
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            // Lê a linha toda, quebra nos espaços e guarda no vetor
            string[] vet = Console.ReadLine().Split(' ');

            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.Clear();


            // ---------------------------------------------------------
            // 2. Saída de Dados (Output)
            // ---------------------------------------------------------
            // O objetivo aqui é reproduzir a caixa "Saída Esperada" do slide

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}