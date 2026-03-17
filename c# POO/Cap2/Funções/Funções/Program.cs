using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // ===============================================================
            // GUIA RÁPIDO DE DEBUG (Salva isso na sua vida!)
            // ===============================================================
            /* F9        -> Marcar/Desmarcar BREAKPOINT (O ponto vermelho de parada)
               F5        -> Iniciar o Debug (vai direto até o próximo Breakpoint)
               F10       -> STEP OVER: Executa a linha e passa para a próxima (NÃO entra na função)
               F11       -> STEP INTO: Executa a linha e ENTRA na função (se houver uma)
               SHIFT+F11 -> STEP OUT: Sai da função atual e volta para quem chamou
               SHIFT+F5  -> PARAR Debug (Encerra o programa forçado)
            */

            // -----------------------------------------------------------
            // EXEMPLO 2: Usando FUNÇÃO com DEBUG
            // -----------------------------------------------------------

            Console.WriteLine("Digite três numeros (um por linha):");

            // DICA DE DEBUG: Coloque o cursor na linha abaixo e aperte F9. 
            // Vai aparecer uma bolinha vermelha na esquerda. Agora aperte F5 para rodar até aqui.
            int numb1 = int.Parse(Console.ReadLine());

            // DICA DE DEBUG: A partir daqui, vá apertando F10.
            // Observe que a linha amarela desce uma por uma sem entrar em detalhes do 'int.Parse'.
            int numb2 = int.Parse(Console.ReadLine());
            int numb3 = int.Parse(Console.ReadLine());

            // ================== O GRANDE MOMENTO ==================
            // Aqui você tem duas escolhas cruciais:
            // OPÇÃO A (F10): O Debug calcula o resultado e pular para a linha do Console.WriteLine.
            // OPÇÃO B (F11): O Debug ENTRA na função 'Maior' para você ver a lógica linha a linha.
            // Tente usar o F11 aqui!
            double resultado = Maior(numb1, numb2, numb3);

            Console.WriteLine($"MAIOR = {resultado}");
        }

        // ---------------------------------------------------------------
        // DECLARAÇÃO DA FUNÇÃO (MÉTODO)
        // ---------------------------------------------------------------
        static int Maior(int a, int b, int c) {

            // SE VOCÊ APERTOU F11 LÁ EM CIMA, VOCÊ CAIU AQUI!

            // Dica: Passe o mouse em cima das variáveis 'a', 'b' e 'c' agora.
            // O Visual Studio vai mostrar o valor que elas receberam lá da Main.
            int m = a;

            // Continue apertando F10 para andar aqui dentro.
            if (b > m) {
                m = b; // Se o código entrar aqui, você verá a setinha amarela passar aqui.
            }

            if (c > m) {
                m = c;
            }

            // DICA DE DEBUG: Se você já entendeu a lógica e quer voltar logo pra Main,
            // aperte SHIFT + F11. Ele executa o resto da função instantaneamente e volta.
            return m;
        }
    }
}