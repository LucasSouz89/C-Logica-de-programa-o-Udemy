using ExercicioResolvido.Entites.Class;
using System.Globalization;

namespace ExercicioResolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            var qtd = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Outsourced (y/n)? ");
                var yn = Console.ReadLine();
                while ((yn != "y" && yn != "n")&& (yn != "Y" && yn != "N"))
                {
                    Console.Write("Outsourced (y/n)? ");
                    yn = Console.ReadLine();
                }
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Hours: ");
                var hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                var vph = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (yn == "n" || yn == "N")
                {
                    employees.Add(new Employee(name, hours, vph));
                }
                else {
                    Console.Write("Additional charge: ");
                    var ac = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name,hours,vph,ac));
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (var e in employees) {
                Console.WriteLine(e);
            }
        }
    }
}