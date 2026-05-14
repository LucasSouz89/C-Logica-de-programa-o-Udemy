using System.Globalization;
using System.Linq;

namespace ExerciciosLINQ

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            List<int> numeros = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                numeros.Add(i);
            }
            var numerosFiltrados = numeros.Where(x => x % 2 != 0).Select(x => x * 3).ToList();
            Console.WriteLine(string.Join("\n", numerosFiltrados));
            Console.WriteLine();
            //Ex2
            List<string> names = new List<string>() { "Leon", "Ashley", "Ada", "Krauser", "Saddler", "Luis" };
            List<string> namesFiltrados = names.Where(x => x.Length > 4).Select(x => x.ToUpper()).ToList();
            Console.WriteLine(string.Join("\n", namesFiltrados));
            //Ex3
            List<Enemy> enemyList = new List<Enemy>();
            Random rd = new Random();
            string[] nomeInimigos = { "Ganado", "Zealot", "Garrador", "Novistador", "Regenerador", "Colmillo" };
            Console.WriteLine();


            for (int j = 0; j < nomeInimigos.Length; j++)
            {
                var posicaoNomeAleatoria = rd.Next(0, nomeInimigos.Length);
                var vida = rd.Next(0, 100);
                while (enemyList.Where(x => x.Name == nomeInimigos[posicaoNomeAleatoria]).Any()) { posicaoNomeAleatoria = rd.Next(0, nomeInimigos.Length); }
                enemyList.Add(new Enemy(nomeInimigos[posicaoNomeAleatoria], vida));
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Rodada {i + 1}");
                foreach (var enemy in enemyList)
                {
                    var atackk = rd.Next(0, 65 - i * 2);
                    enemy.Health -= atackk;

                }
                Console.WriteLine(string.Join("\n", enemyList.Where(x => x.Health > 0).Select(x => $"{x.Name} {x.Health} hp")));
                Console.WriteLine(string.Join("\n", enemyList.Where(x => x.Health <= 0).Select(x => $"{x.Name} foi eliminado")));
                Console.WriteLine();
            }
            //Ex 4
            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(new Weapon("Combat Knife", 1000));
            weapons.Add(new Weapon("Red9", 14000));
            weapons.Add(new Weapon("SR M1903", 12000));
            weapons.Add(new Weapon("Striker", 38000));
            weapons.Add(new Weapon("Rocket Launcher", 50000));
            weapons.Add(new Weapon("First Aid Spray", 5000));
            var weaponsFilter = weapons.Where(x=> x.Price> 10000).Select(x=>$"{x.Name} {(x.Price*0.8).ToString("F2",CultureInfo.InvariantCulture)} pesetas");
            Console.WriteLine(string.Join("\n",weaponsFilter));
            //Ex 5
            List<int> actions = new List<int>() { 15, -5, 20, -3, 50, -10 };
            var cura = actions.Where(x => x < 0).Select(x => $"personagem se curou em {-(x)}").ToList();
            var dano = actions.Where(x => x >= 0).Select(x => $"personagem tomou dano de {x}").ToList();
            List<List<string>> RandomAction = new List<List<string>>();
            
            RandomAction.Add(cura);
            RandomAction.Add(dano);
            var randomPosition = rd.Next(0, RandomAction.Count);
            
            Console.WriteLine(string.Join("\n", RandomAction[randomPosition]));
            
            
        }
    }
}
