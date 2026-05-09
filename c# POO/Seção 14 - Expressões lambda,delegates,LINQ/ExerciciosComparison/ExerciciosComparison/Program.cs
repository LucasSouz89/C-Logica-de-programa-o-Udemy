using ExerciciosComparison.Entites;
using System.Globalization;

namespace ExerciciosComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            List<double> salarios = new List<double>() { 2500.00, 1200.50, 8000.00, 4500.00 };
            salarios.Sort((p1,p2)=>p2.CompareTo(p1));
            Console.WriteLine(string.Join(", ", salarios.Select(s => s.ToString("F2",CultureInfo.InvariantCulture))));
            //Ex 2
            List<string> palavras = new List<string>() { "Paralelepipedo", "Oi", "Cachorro", "Sol", "Computador" };
            palavras.Sort((p1,p2) =>p1.Length.CompareTo(p2.Length));
            Console.WriteLine(string.Join(", ",palavras));
            //Ex 3 e 4
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Carlos", 2300, 34));
            employees.Add(new Employee("Marcos", 2300, 25));
            employees.Add(new Employee("Gabriel", 1700, 19));
            employees.Add(new Employee("Robson", 5300, 44));
            employees.Add(new Employee("Roberto", 10500, 49));
            // employees.Sort((p1,p2) =>p2.Salary.CompareTo(p1.Salary));
            employees.Sort(CompareEmployeers);
            Console.WriteLine(string.Join("\n", employees));
            //Ex 5
            List<TaskItem> tasks = new List<TaskItem>();
            tasks.Add(new TaskItem("Ajudar fazendeiro", true));
            tasks.Add(new TaskItem("Derrotar goblins", true));
            tasks.Add(new TaskItem("Roubar a espada", false));
            tasks.Add(new TaskItem("Derrottar o chefe dos orcs", false));

            tasks.Sort((p1,p2) =>p2.IsCompleted.CompareTo(p1.IsCompleted));
            Console.WriteLine(string.Join("\n",tasks));
        }
        public static int CompareEmployeers(Employee p1,Employee p2 )
        {
            if (p1.Salary.CompareTo(p2.Salary) == 0) { return p1.Name.CompareTo(p2.Name); }
            return p2.Salary.CompareTo(p1.Salary);
        }
    }
}
