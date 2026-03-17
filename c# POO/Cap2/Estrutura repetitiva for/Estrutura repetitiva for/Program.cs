using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // ---------------------------------------------------------------
            // ESTRUTURA REPETITIVA FOR (PARA)
            // ---------------------------------------------------------------
            // Usamos quando SABEMOS a quantidade exata de repetições.

            Console.Write("Quantos números inteiros você vai digitar? ");
            // Variável de controle (N): Define o limite do loop.
            int n = int.Parse(Console.ReadLine());

            // Variável Acumuladora (Soma):
            // Tem que começar com 0 (elemento neutro da soma) e ficar FORA do loop.
            // Se colocar dentro, ela zera toda vez que o loop rodar!
            int soma = 0;

            // ANATOMIA DO FOR:
            // Parte 1 (int i = 1): INICIALIZAÇÃO -> Executa só uma vez no começo.
            // Parte 2 (i <= n): CONDIÇÃO -> Verifica antes de cada rodada. Se Verdadeiro, entra. Se Falso, sai.
            // Parte 3 (i++): INCREMENTO -> Executa ao FINAL de cada rodada (prepara a próxima).
            for (int i = 1; i <= n; i++) {

                // Dica: Usamos a variável 'i' apenas para contar em qual volta estamos.
                Console.Write($"Valor #{i}: ");

                // Lê o número digitado pelo usuário
                int valor = int.Parse(Console.ReadLine());

                // ACUMULADOR:
                // Pega o que já tinha no balde 'soma' e junta com o novo 'valor'.
                soma = soma + valor; // Poderia usar: soma += valor;
            }

            // Resultado final (só mostra depois que saiu do loop)
            Console.WriteLine($"SOMA: {soma}");
        }
    }
}