using ExercicioFixação.Entites;
using System.Globalization;
using System.Linq;

namespace ExercicioFixação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            ReadFile(employees);
            ShowInformations(employees);
            
        }public static void ReadFile(List<Employee> employees)
        {
            try
            {
                Console.Write("Enter full file path: ");
                string path = @"" + Console.ReadLine();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Trim('\'').Trim('\"').Split(",");
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, email, salary));
                    }

                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
        public static void ShowInformations(List<Employee> employees)
        {
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2",CultureInfo.InvariantCulture)}: ");
            Console.WriteLine(string.Join("\n",employees.Where(x=> x.Salary > salary).OrderBy(x=> x.Email).Select(x=> x.Email)));
            var sum = employees.Where(x => x.Name[0] == 'M').Sum(x => x.Salary);
            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2",CultureInfo.InvariantCulture)}");
        }

    }
}
