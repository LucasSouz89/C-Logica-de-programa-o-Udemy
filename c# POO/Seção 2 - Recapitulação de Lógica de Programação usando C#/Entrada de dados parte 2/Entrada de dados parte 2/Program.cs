using System;
using System.Globalization; // Necessário para usar o ponto (.) nos números decimais

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // ---------------------------------------------------------
            // 1. Leitura e Conversão Individual (Parse)
            // ---------------------------------------------------------

            Console.WriteLine("Digite um número inteiro:");
            // Lê uma string e converte IMEDIATAMENTE para int
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um caractere (apenas uma letra):");
            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número decimal (com ponto):");
            // O InvariantCulture obriga o usuário a usar PONTO (ex: 4.5) e não vírgula.
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            // ---------------------------------------------------------
            // 2. Leitura de Múltiplos Dados na Mesma Linha (Split + Parse)
            // ---------------------------------------------------------

            Console.WriteLine("Digite: Nome (espaço) Sexo (espaço) Idade (espaço) Altura");
            // Exemplo de entrada: Maria F 23 1.68

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];                     // Já é string, não precisa converter
            char sexo = char.Parse(vet[1]);           // Converte string "F" para char 'F'
            int idade = int.Parse(vet[2]);            // Converte string "23" para int 23
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture); // Converte "1.68" para double


            // ---------------------------------------------------------
            // 3. Saída de Dados
            // ---------------------------------------------------------

            Console.Clear(); // Limpa o console para mostrar apenas os resultados

            Console.WriteLine("--- DADOS LIDOS ---");
            Console.WriteLine($"Inteiro: {n1}");
            Console.WriteLine($"Char: {ch}");
            Console.WriteLine($"Double: {n2.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("--- DADOS DO VETOR ---");
            // Montando a frase final com os dados processados
            Console.WriteLine($"{nome} {sexo} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}