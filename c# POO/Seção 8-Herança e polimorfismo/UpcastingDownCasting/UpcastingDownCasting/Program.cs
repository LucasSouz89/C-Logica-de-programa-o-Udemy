using UpcastingDownCasting.Entites;
using System;

namespace UpcastingDownCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // 📦 UPCASTING (O Disfarce Genérico)
            // ==========================================
            // Definição Sênior: Upcasting não altera o objeto na memória. Ele apenas coloca
            // uma "etiqueta" genérica da classe Pai em um objeto da classe Filha.

            // Exemplo: Na memória nasce uma Conta Empresarial, mas o sistema vai tratar genericamente como Conta.
            Account contaGenericaEmpresa = new BusinessAccount(190, "DHL", 10000000, 25000000);

            // Exemplo: Na memória nasce uma Conta Poupança, mas tratada genericamente como Conta.
            Account contaGenericaPoupanca = new SavingsAccount(298, "Familia silva", 10000, 2);


            // ==========================================
            // 🔍 DOWNCASTING (A Revelação do Objeto)
            // ==========================================
            // Definição Sênior: É o ato de tirar a etiqueta genérica, provando para o compilador 
            // qual é o tipo real do objeto na memória, para podermos usar seus métodos específicos.

            // 1. O jeito clássico e seguro (Testando a conta da DHL)
            if (contaGenericaEmpresa is BusinessAccount)
            {
                // Como o "is" deu verdadeiro, fazemos o casting com segurança
                BusinessAccount contaDhlReal = (BusinessAccount)contaGenericaEmpresa;
                contaDhlReal.Loan(100);
                Console.WriteLine("Empréstimo da DHL aprovado!");
            }

            // 2. Usando o "as" (Testando a conta da Família Silva)
            if (contaGenericaPoupanca is SavingsAccount)
            {
                // O "as" tenta fazer o casting. Se falhar, ele devolve nulo em vez de crashar a tela.
                SavingsAccount contaSilvaReal = contaGenericaPoupanca as SavingsAccount;
                contaSilvaReal.uptadeBalance();
                Console.WriteLine("Rendimento da Família Silva atualizado!");
            }

            // ==========================================
            // 🛡️ O ESCUDO EM AÇÃO (Evitando a Tela Azul)
            // ==========================================
            // Vamos tentar dar um empréstimo empresarial para a conta Poupança da Família Silva:
            if (contaGenericaPoupanca is BusinessAccount)
            {
                // O C# NUNCA vai entrar aqui, bloqueando o bug mortal!
                BusinessAccount erroCasting = (BusinessAccount)contaGenericaPoupanca;
                erroCasting.Loan(500);
            }
            else
            {
                Console.WriteLine("Ação bloqueada: A Família Silva não possui uma Conta Empresarial!");
            }
        }
    }
}