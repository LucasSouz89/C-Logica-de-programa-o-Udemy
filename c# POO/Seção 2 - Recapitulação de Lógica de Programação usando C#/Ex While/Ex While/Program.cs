using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // ===============================================================
            // LISTA DE EXERCÍCIOS: ESTRUTURA REPETITIVA (WHILE)
            // ===============================================================

            // ---------------------------------------------------------------
            // EXERCÍCIO 01: Validação de Senha
            // ---------------------------------------------------------------
            /*
            Console.WriteLine("Digite a senha:");
            // 1. Leitura Inicial: Precisamos do primeiro valor para testar.
            int senha = int.Parse(Console.ReadLine());

            // 2. Condição: Enquanto a senha for DIFERENTE de 2002, o loop prende o usuário.
            while (senha != 2002) {
                
                // Se entrou aqui, a senha está errada.
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Digite outra senha:");

                // 3. Atualização: Lê a senha de novo.
                // Sem isso, a variável 'senha' nunca muda e cria um Loop Infinito.
                senha = int.Parse(Console.ReadLine());
            }

            // O programa só chega aqui quando o While der FALSO (ou seja, senha == 2002).
            Console.WriteLine("Acesso Permitido");
            */


            // ---------------------------------------------------------------
            // EXERCÍCIO 02: Quadrantes Cartesianos
            // ---------------------------------------------------------------
            /*
            Console.WriteLine("Escreva duas coordenadas na mesma linha (X e Y):");
            string[] vet = Console.ReadLine().Split();
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            // Regra: O programa para se PELO MENOS UM dos valores for Zero.
            // Por isso usamos && (E). O loop só roda se X não for zero E Y não for zero.
            while (x != 0 && y != 0) {
                
                // Lógica de verificação dos sinais (+/-)
                if (x > 0 && y > 0) Console.WriteLine("Primeiro");
                else if (x < 0 && y > 0) Console.WriteLine("Segundo");
                else if (x < 0 && y < 0) Console.WriteLine("Terceiro");
                else Console.WriteLine("Quarto"); // Sobra apenas x > 0 e y < 0

                // Leitura dentro do Loop (Para processar a próxima coordenada)
                Console.WriteLine("Escreva duas coordenadas na mesma linha:");
                vet = Console.ReadLine().Split();
                x = int.Parse(vet[0]); 
                y = int.Parse(vet[1]);
            }
            // Se digitar 0 em qualquer um, o loop quebra e o programa encerra sem mensagem.
            */


            // ---------------------------------------------------------------
            // EXERCÍCIO 03: Posto de Combustível (Urna Eletrônica)
            // ---------------------------------------------------------------
            Console.WriteLine("Digite o combustível que você abasteceu:");
            Console.WriteLine("1.Álcool 2.Gasolina 3.Diesel 4.Fim");

            // Inventário: Iniciamos as contagens com zero.
            int alcool = 0, gasolina = 0, disel = 0;
            int codigo = int.Parse(Console.ReadLine());

            // Lógica da Condição: 
            // Roda se for válido (1 a 3) OU se for código de erro (>4).
            // Basicamente: "Roda enquanto NÃO for 4".
            while (codigo < 4 && codigo > 0 || codigo > 4) {

                Console.Clear(); // Limpa a tela para organizar (opcional, mas legal!)

                // Verifica qual caixa deve receber +1 ponto
                if (codigo == 1) {
                    alcool = alcool + 1;
                } else if (codigo == 2) {
                    gasolina = gasolina + 1;
                } else if (codigo == 3) {
                    disel = disel + 1;
                }

                // Tratamento de erro dentro do loop
                if (codigo > 4 || codigo < 0) {
                    Console.WriteLine("Digite um codigo valido");
                }

                // Pede o próximo voto
                Console.WriteLine("Digite outro para adicionar ou 4 para sair");
                codigo = int.Parse(Console.ReadLine());

                // Validação visual extra antes de voltar pro loop
                if (codigo > 4 || codigo < 1) {
                    Console.WriteLine("Codigo invalido detectado...");
                }
            }

            // Relatório Final (Pós-Loop)
            // Só imprime isso quando o usuário digitar 4.
            if (codigo == 4) {
                Console.Clear();
                Console.WriteLine("Muito Obrigado");
                Console.WriteLine($"Alcool: {alcool}");
                Console.WriteLine($"Gasolina: {gasolina}");
                Console.WriteLine($"Diesel: {disel}"); // Correção feita!
            }
        }
    }
}