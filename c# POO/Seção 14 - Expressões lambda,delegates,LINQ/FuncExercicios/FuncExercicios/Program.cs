using System.Globalization;
using System.Linq;

namespace FuncExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var dobros = numbers.Select(x => x * 2).ToList();
            Console.WriteLine(string.Join("\n",dobros));
            //Ex2
            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(new Weapon("Pistol",10));
            weapons.Add(new Weapon("Shotgun", 22.5));
            weapons.Add(new Weapon("Sniper", 55.2));
            Console.WriteLine(string.Join("\n",weapons.Select(x=> x.Damage.ToString("F2",CultureInfo.InvariantCulture))));
            Console.WriteLine();
            //Ex3
            Console.WriteLine(string.Join("\n", weapons.Select(x=> $"{x.Name}, {x.Damage} dmg")));
            Console.WriteLine();
            //Ex4
            Func<Weapon, double> aplicarImposto = x => x.Damage * 1.15;
            Console.WriteLine(string.Join("\n", weapons.Select(aplicarImposto)));
            //Ex 5
            TransformAndPrint(numbers,x=> x*x);
        }public static void TransformAndPrint(List<int> numbers,Func<int,int> transform)
        {
            foreach (var number in numbers) 
            {
                Console.WriteLine(transform(number)); 
            }
        }
    }
}
