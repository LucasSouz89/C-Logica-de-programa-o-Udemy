using ExercicioPropostoMetodoAbstrato.Entites;
using System.Globalization;

namespace ExercicioPropostoMetodoAbstrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            var qtd = int.Parse(Console.ReadLine());
            List<Account> list = new List<Account>();
            for (int i = 1; i <= qtd; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                var option = Console.ReadLine();
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Anual income: ");
                var income = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (option.ToLower() == "i")
                {
                    Console.Write("Health expenditures: ");
                    var health = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new NaturalPerson(name, income, health));
                }
                else if (option.ToLower() == "c")
                {
                    Console.Write("Number of employees: ");
                    var employeers = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employeers));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0; 
            foreach(var account in list)
            {
                sum += account.Tax();
                Console.WriteLine(account);

            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
