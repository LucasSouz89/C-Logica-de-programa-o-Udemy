using ExContratos.Entities.Class;
using ExContratos.Entities.Enuns;
using System.Globalization;

namespace ExContratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            var department = Console.ReadLine();
            Department de = new Department(department);
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Level (Junior/Midlevel/Senior): ");
            WorkerLevel l = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            var baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Worker person = new Worker(name,l,baseSalary,de);
            Console.Write("How many Contracts to this worker? ");
            var qtd = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < qtd; i++) {
                Console.WriteLine($"Enter {i+1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                string[] vet = Console.ReadLine().Split('/');
                var day = int.Parse(vet[0]);
                var mouth = int.Parse(vet[1]);
                var year = int.Parse(vet[2]);
                DateTime date = new DateTime(year,mouth,day);
                Console.Write("Value per hour: ");
                var value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration(hours): ");
                var hours = int.Parse(Console.ReadLine());
                HourContract Contract = new HourContract(date,value,hours);
                person.AddContract(Contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYY): ");
            string[] vet2 = Console.ReadLine().Split('/');
            int m = int.Parse(vet2[0]);
            int y = int.Parse(vet2[1]);
            double income = person.Income(y, m);
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Department: {person.Department.Name}");
            Console.WriteLine($"Income for {m}/{y}: {income.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
