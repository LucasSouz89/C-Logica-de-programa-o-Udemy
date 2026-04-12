using ExerciciosHerança.Ex1.Entites.Class;
using ExerciciosHerança.Ex2.Entites.Class;
using ExerciciosHerança.Ex3.Entites.Class;

namespace ExerciciosHerança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            Enemy enemy = new Enemy("Zumbi",100.00,20);
            enemy.TakeDamage(20);
            enemy.Roar();
            //Ex2
            Armor Katana = new Armor("Katana","Aço",20,50);
            Console.WriteLine(Katana);
            for (int i = 0; i < 3; i++)
            {
                Katana.UseItem();
            }
            Console.WriteLine(Katana);
            
            
            Katana.Repair(3);
            
            Console.WriteLine(Katana);
            //Ex 3
            Tank drMundo = new Tank("Dr.Mundo corporativo",5000,100);
            Console.WriteLine(drMundo);
            drMundo.Damage(2000);
            Console.WriteLine(drMundo);
            drMundo.Regenarate();
            Console.WriteLine(drMundo);
        }
    }
}
