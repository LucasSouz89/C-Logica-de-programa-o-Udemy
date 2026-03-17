using System;
using System.Globalization; // Necessário para o CultureInfo

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // ---------------------------------------------------------
            // 1. Declaração de Variáveis
            // ---------------------------------------------------------

            // Dados dos Produtos
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            // Dados de Registro
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            // Valores Monetários e Medidas
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            // ---------------------------------------------------------
            // 2. Saída de Dados (Output)
            // ---------------------------------------------------------

            Console.WriteLine("Produtos:");

            // Usando interpolação de strings ($)
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");

            Console.WriteLine(); // Pula linha vazia

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine(); // Pula linha vazia

            // Formatação de casas decimais
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondando (três casas decimais): {medida:F3}");

            // Usando concatenação (+) para mudar o separador decimal (vírgula -> ponto)
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}