using System;
using System.Globalization; // Necessário para usar o CultureInfo (ponto no lugar de vírgula)

namespace Course {
    class Program {
        static void Main(string[] args) {

            // ---------------------------------------------------------
            // 1. Declaração de Variáveis e Tipos Básicos
            // ---------------------------------------------------------

            bool sit = true;
            char genero = 'F';
            char letra = '\u0041'; // Código Unicode para a letra 'A'

            int n1 = 14;
            int n2 = 1000;
            int n3 = 2147483647; // Limite máximo do int positivo

            // Long: armazena números inteiros maiores que o int. Exige o sufixo 'L'.
            long l1 = 222222222222222220L;

            // Float: Exige o sufixo 'f'. Menor precisão que o double.
            float a = 43.5f;

            // Double: Padrão para números decimais.
            double a2 = 43.5;

            string nome = "Lucas";
            nome = "Roberto"; // Alterando o valor da variável

            // Object: Tipo genérico que aceita qualquer coisa (string, int, float...)
            object objt1 = "Alex Brown";
            object objt2 = 14f;


            // ---------------------------------------------------------
            // 2. Saída de Dados Simples
            // ---------------------------------------------------------
            // Dica: Digitar "cw" + TAB + TAB cria o Console.WriteLine automaticamente.

            Console.WriteLine("--- Imprimindo Variáveis ---");
            Console.WriteLine(n1 + n2 + n3); // Soma
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(l1);
            Console.WriteLine(sit);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(a);
            Console.WriteLine(a2);
            Console.WriteLine(nome);
            Console.WriteLine(objt1);
            Console.WriteLine(objt2);


            // ---------------------------------------------------------
            // 3. Valores Mínimos e Máximos (Limites dos Tipos)
            // ---------------------------------------------------------

            Console.WriteLine("\n--- Valores Mínimos e Máximos ---");
            int n7 = int.MinValue;
            sbyte n8 = sbyte.MaxValue;
            long l9 = long.MaxValue;
            decimal l10 = decimal.MinValue;

            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(l9);
            Console.WriteLine(l10);


            // ---------------------------------------------------------
            // 4. Quebra de Linha (WriteLine vs Write)
            // ---------------------------------------------------------

            Console.WriteLine("\n--- Teste de Quebra de Linha ---");
            Console.WriteLine("Bom dia"); // Com quebra (pula linha ao final)

            Console.Write("Bom dia");     // Sem quebra (o cursor fica na frente)
            Console.Write("Bom dia");
            Console.WriteLine("Boa noite"); // Resultado: Bom diaBom diaBoa noite


            // ---------------------------------------------------------
            // 5. Formatação de Números e Strings
            // ---------------------------------------------------------

            int idade = 32;
            double saldo = 10.35784;
            string nome2 = "Pedro";

            Console.WriteLine("\n--- Formatação e Concatenação ---");

            // F2 = 2 casas decimais, F4 = 4 casas decimais
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));

            // CultureInfo.InvariantCulture força o uso do PONTO em vez de vírgula
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


            // A) Placeholders (Método antigo)
            // {0}, {1} são substituídos pelas variáveis na ordem
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R${2:F2}", nome2, idade, saldo);

            // B) Interpolação (Método mais moderno e fácil com $)
            Console.WriteLine($"{nome2} tem {idade} anos e um saldo de R${saldo:F2}");

            // C) Concatenação (Método manual com +)
            // Aqui conseguimos usar o CultureInfo individualmente na variável
            Console.WriteLine(nome2 + " tem " + idade + " anos e um saldo de R$" + saldo.ToString("F2", CultureInfo.InvariantCulture));

            // OBS: Não é possível mudar vírgula para ponto direto na interpolação ($) sem mudar a cultura do programa todo.
        }
    }
}