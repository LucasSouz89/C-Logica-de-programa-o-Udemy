using InversaoDeControleEInjecaoDeDependencia.Entites.Class;
using InversaoDeControleEInjecaoDeDependencia.Entites.Interface;
using System.Globalization;

namespace InversaoDeControleEInjecaoDeDependencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            var number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            var date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            var value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            var installments = int.Parse(Console.ReadLine());
            Contract contract = new Contract(number, date, value);
            ContractService service = new ContractService(new PaypalService());
            service.ProcessContract(contract, installments);
            Console.WriteLine(contract);

        }
    }
}
