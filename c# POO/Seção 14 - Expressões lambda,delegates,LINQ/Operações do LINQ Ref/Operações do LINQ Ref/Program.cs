namespace Operações_do_LINQ_Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            List<Weapon> weapons = new List<Weapon>();
            weapons.Add(new Weapon("Combat Knife", 1000));
            weapons.Add(new Weapon("Red9", 14000));
            weapons.Add(new Weapon("SR M1903", 12000));
            weapons.Add(new Weapon("Striker", 38000));
            weapons.Add(new Weapon("Rocket Launcher", 50000));
            weapons.Add(new Weapon("First Aid Spray", 5000));

            var weaponsCrescent = weapons.OrderByDescending(x => x.Price).Select(x => $"{x.Name}, {x.Price} pecetas");
            Console.WriteLine(string.Join("\n",weaponsCrescent));
            //Ex 2
            var buscarArma = weapons.FirstOrDefault(x => x.Name == "Red9");
            var armaBuscada = (buscarArma != null) ? $"Arma encontrada: {buscarArma.Name}, {buscarArma.Price} pecetas" : "Arma não encontrada";
            Console.WriteLine(armaBuscada);
            //Ex3
            var precoTotal = weapons.Sum(x => x.Price);
            Console.WriteLine($"Preço total: {precoTotal} pecetas");
        }
    }
}
