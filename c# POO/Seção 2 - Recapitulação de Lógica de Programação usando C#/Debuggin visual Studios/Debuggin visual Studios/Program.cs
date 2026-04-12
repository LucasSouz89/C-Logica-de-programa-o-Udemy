using System; // Importa a biblioteca base do .NET (necessária para Console.WriteLine, int, etc.)

namespace MyApp { // Define o "Espaço de Nomes" (o nome do seu projeto ou pasta lógica)

    internal class Program { // Declaração da Classe principal do programa

        // Main: É a "Porta de Entrada". Todo programa C# começa executando o que está aqui dentro.
        static void Main(string[] args) {

            // ===============================================================
            // GUIA DE SOBREVIVÊNCIA: DEBUGGING (DEPURAÇÃO)
            // ===============================================================
            // Use esta lista para lembrar o que cada tecla F faz no Visual Studio.

            /* F9          -> MARCAR/DESMARCAR BREAKPOINT 
                              (Cria a bolinha vermelha na esquerda. O código vai parar aqui.)

               F5          -> INICIAR / CONTINUAR
                              (Começa o programa ou, se estiver parado, solta ele até o próximo breakpoint.)

               F10         -> STEP OVER (PULAR)
                              (Executa a linha atual e vai para a próxima. Se tiver uma função, ele executa ela inteira sem entrar.)

               F11         -> STEP INTO (ENTRAR)
                              (Executa a linha e, se for uma função, ele ENTRA nela para mostrar linha por linha.)

               SHIFT + F11 -> STEP OUT (SAIR)
                              (Se você entrou numa função com F11 e quer sair logo, use isso. Ele termina a função e volta.)

               SHIFT + F5  -> STOP (PARAR)
                              (Mata o programa e encerra o Debug imediatamente.)
            */

        } // Fim do método Main
    } // Fim da classe Program
} // Fim do namespace