using System.Collections;
using System.Globalization;

namespace ExLIstaEmpregados {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("How many employes wiil be registred? ");
            int qtd = int.Parse(Console.ReadLine());
            List<Employers> list = new List<Employers>();

            for (int i = 0; i < qtd; i++) {
                Console.WriteLine($"Emplyoee #{i + 1}");
                Console.Write($"Id: ");
                int id = int.Parse(Console.ReadLine());
                for (int j = 0; j < list.Count; j++) {
                    while (id == list[j].Id) {
                        Console.Write($"Enter another id: ");
                        id = int.Parse(Console.ReadLine());
                    }
                }
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employers(id, name, Salary));
            }
            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int findID = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Employers emp = list.Find(x => x.Id == findID);
            if (emp != null) { emp.SalaryIncrease(pct); } else {Console.WriteLine("This id does not exist!"); }
            Console.WriteLine("Update list of employers");
            foreach (Employers e in list) {
                Console.WriteLine(e);
            }
        }
    }
}