using ListaExComposicao.Ex1.Entities.Class;
using ListaExComposicao.Ex1.Entities.Enuns;
using System.Globalization;

namespace ListaExComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Crianção de persongagem RPG");
            Character character1;
            CharacterCreation(out character1);
            CombatEncounter combat;
            CombatNow(out combat, character1);
            MagicInCombat(combat);
            Console.WriteLine();
            Console.WriteLine("Detalhes: ");
            Console.WriteLine(combat);
            

        }
        public static void CharacterCreation(out Character c) {
            Console.Write("Digite o nome do seu personagem: ");
            var name = Console.ReadLine();
            var level = 1;
            c = new Character(name, level);
        }
        public static void CombatNow(out CombatEncounter combat,Character character){
            Console.WriteLine("Um combate acabou de acontecer!!!");
            DateTime date = DateTime.Now;
            CombatStatus combatStatus = CombatStatus.IN_PROGRESS;
            combat = new CombatEncounter(date,combatStatus,character);
        }
        public static void MagicInCombat(CombatEncounter combat) {
            Console.Write("Quantos feitiços você tem no arsenal? ");
            var qtd = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 1; i <= qtd; i++) {
                
                Console.WriteLine($"Feitiço #{i}");
                Console.Write("Nome: ");
                var name = Console.ReadLine();
                double baseDamage = random.NextDouble()*(20-1)+1;
                Console.WriteLine($"Dano:{baseDamage.ToString("F2",CultureInfo.InvariantCulture)}");
                Spell spell = new Spell(name,baseDamage);
                int ComboMultiplayer = random.Next(2,5);
                CastAction action = new CastAction(ComboMultiplayer,spell);
                combat.AddAction(action);
                Console.WriteLine();

            }
        }
    }
}
