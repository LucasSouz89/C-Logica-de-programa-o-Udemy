using SobreposicaoPalavrasVirtualOverrideBase.Entites;

namespace SobreposicaoPalavrasVirtualOverrideBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Account acc1 = new Account(1001,"Alex",500);
           Account acc2 = new SavingsAccount(2022, "Familia pereira", 500, 2);

            acc1.Withdraw(200);
            acc2.Withdraw(200);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
