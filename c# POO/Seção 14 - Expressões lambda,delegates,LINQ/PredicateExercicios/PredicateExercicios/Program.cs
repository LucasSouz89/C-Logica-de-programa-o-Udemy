using PredicateExercicios.Entites;
using System.Globalization;

namespace PredicateExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            List<int> list = new List<int>() { 15, 8, 99, 45, 120, 3 };
           bool result = list.Exists(x => x > 100);
            Console.WriteLine(result);
            //Ex2 
            List<string> itens = new List<string>() { "Green Herb", "Shotgun", "Handgun", "Red Herb", "Key" };
            var filtrados = itens.FindAll(item => item.StartsWith("H"));
            Console.WriteLine(string.Join("\n",filtrados));
            //Ex 3
            List<double> pesos = new List<double>() { 1.5, 0.2, 5.0, 0.8, 3.2 };
            pesos.RemoveAll(x => x < 1);
            foreach (var peso in pesos) { Console.WriteLine(peso.ToString("F2",CultureInfo.InvariantCulture)); }
            //Ex4
            List<Enemy> enemies = new List<Enemy>();
            enemies.Add(new Enemy("Zumbi",200));
            enemies.Add(new Enemy("Zumbi de fogo", -50));
            enemies.Add(new Enemy("Zumbi Tank", 0));
            enemies.Add(new Enemy("Zumbi rastejante", 1));
            var aliveEnemys = enemies.FindAll(x => x.Health > 0);
            Console.WriteLine(string.Join("\n",aliveEnemys));

        }
    }
}
