using ActionExercicos.Entites;
using System.Collections.Generic;

namespace ActionExercicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            List<string> jogadores = new List<string>() { "FalleN", "KSCERATO", "Taco" };
            jogadores.ForEach(x => { Console.WriteLine($"O jogador {x} está online!"); });
            //Ex2
            List<Enemy> enemies = new List<Enemy>();
            
            enemies.Add(new Enemy("Zumbi", 200));
            enemies.Add(new Enemy("Zumbi de fogo", -50));
            enemies.Add(new Enemy("Zumbi Tank", 0));
            enemies.Add(new Enemy("Zumbi rastejante", 1));
            enemies.ForEach(x => { x.Health += 50; });
            enemies.ForEach(x => { Console.WriteLine(x); });
            //Ex 3
            Action<Enemy> buffAction = e => e.Health += 100;
            buffAction += e => Console.WriteLine($"{e.Name} recebeu um Super Buff e agora tem {e.Health} de HP!");
            enemies.ForEach(buffAction);
            //Ex4
            List<Product> products = new List<Product>();
            products.Add(new Product("TV", 900));
            products.Add(new Product("Mouse", 50));
            products.Add(new Product("Tablet", 350));
            products.Add(new Product("HD Case", 50));
            products.ForEach(x => { if (x.Price > 100) { x.Price -= x.Price * 0.10; } else { x.Price -= x.Price * 0.20; } Console.WriteLine(x); });
            //Ex 5
            Enemy boss = new Enemy("Nemesis", 1000);
            Program.ApplySkill(boss, x => x.Health /= 2);
            Console.WriteLine(boss);
        }
        public static void ApplySkill(Enemy target, Action<Enemy> skill) { skill(target); }
    }
}
