using ExcerciciosInterfaces.Ex1.Class;
using ExcerciciosInterfaces.Ex1.Services;
using ExcerciciosInterfaces.Ex2.Class;
using ExcerciciosInterfaces.Ex3.Class;
using ExcerciciosInterfaces.Ex3.Class.Entites1;
using ExcerciciosInterfaces.Ex3.Class.Interface;
using ExcerciciosInterfaces.Ex4.Class;
using ExcerciciosInterfaces.Ex4.Class.Interface;
using ExcerciciosInterfaces.Ex5.Class;
using ExcerciciosInterfaces.Ex5.Interface;
using ExcerciciosInterfaces.Ex6.Class;
using ExcerciciosInterfaces.Ex6.Interface;
using ExcerciciosInterfaces.Ex6.Services;

namespace ExcerciciosInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            //SecuritySystem alarm1 = new SecuritySystem(new SmsService());
            //alarm1.TriggerAlarm();
            //SecuritySystem alarm2 = new SecuritySystem(new EmailService());
            //alarm2.TriggerAlarm();
            //Ex2
            //Player player = new Player("Arthur",30,new Sword());
            //player.Atacar();
            //Player player2 = new Player("Merlin",20,new MagicStaff());
            //player2.Atacar();
            //Ex3
            //Subscription subscription = new Subscription("Souza_Jogos",20.00,6);
            //BillingService billingService = new BillingService(new StudentDiscountService());
            //Console.WriteLine(billingService.ProcessBilling(subscription));
            //Ex4
            //BlacksmithService weapon = new BlacksmithService(new ScrapModifier());
            //Console.WriteLine(weapon.ForgeWeapon("Taco de beisebol", 20)); 
            //Ex5
            //PlayerVitals player1 = new PlayerVitals("SouzaJogos",200);

            //MedicalService m = new MedicalService(new HealthyState());
            //Console.WriteLine(m.ApplyMedkit(player1, 200));
            //Console.WriteLine();
            //MedicalService m2 = new MedicalService(new CriticalInfectionState());
            //Console.WriteLine(m2.ApplyMedkit(player1, 200)); 
            //Ex 6
            EnemyTarget enemy = new EnemyTarget("Zumbi", 200);
            List<CombatService> list = new List<CombatService>();
            list.Add(new CombatService(new HollowPointAmmo()));
            list.Add(new CombatService(new ArmorPiercingAmmo()));

            foreach(var i in list)
            {
                Console.WriteLine(i.ProcessShot(100,enemy));
                Console.WriteLine();
            }
             

        }
    }
}
