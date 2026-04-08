using ClassesAbstratas.Entites;
using System.Globalization;

namespace ClassesAbstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Classe abtastata não pode ser instanciada
            // Account account = new Account();   
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Familia pereira", 500, 0.01));
            list.Add(new BusinessAccount(2002, "Meli", 500, 200000));
            list.Add(new SavingsAccount(1003, "Bob", 500, 0.01));
            list.Add(new BusinessAccount(1004,"DHL",500,1000000));

            double sum = 0;
            foreach (var account in list) {
                sum += account.Balance;
            }
            Console.WriteLine($"Valor total : {sum.ToString("F2",CultureInfo.InvariantCulture)}");

            foreach (Account acc in list) {
                acc.Withdraw(1000);
                Console.WriteLine($"{acc.Holder} |Conta:{acc.Number} - $ {acc.Balance.ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}