using ExExceptionsPersonalizadas.Entites.Class;
using ExExceptionsPersonalizadas.Entites.Exceptions;

namespace ExExceptionsPersonalizadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*
            try
            {
                List<Package> packages = new List<Package>();
                packages.Add(new Package("AHJL-2026", 20, 40)); // Sem erros
                packages.Add(new Package("SASA-2025",20,21)); // Erro ao adicionar uma carga maior que a capacidade maxima
                packages.Add(new Package("Q2DSA-2024", 20, 19)); //Erro de peso maior que capacidade maxima

                foreach(var i in packages)
                {
                    i.AddWeight(5);
                    Console.WriteLine(i);
                }
            }
            catch (ExceptionDomain domain) { Console.WriteLine(domain.Message); }
            */
            //Ex2
            /*
            try
            {

                //Não vai jogar para o erro de dominio
                TankBuild tank = new TankBuild("Dr.Mundo", 3000);
                tank.BuyItem(1200);
                tank.AtivateWarmogsHEart();
                //Vai jogar para erro de dominio
                TankBuild tank2 = new TankBuild("Ornn", 3000);
                tank2.BuyItem(800);
                tank2.AtivateWarmogsHEart();
            }
            catch (ExceptionDomain e) { Console.WriteLine(e.Message); }
            finally { Console.WriteLine("Fechando programa"); }
            */
            //Ex3
            try
            {
                List<Hypercar> cars = new List<Hypercar>();
                //Objeto funnciona normalmente
                cars.Add(new Hypercar("Lamborghini", 150, 300));
                //Erro ao colocar que a velocidade atual é negativa
                //cars.Add(new Hypercar("Buggati", -5,300));
                //Erro ao colocar que a velocidade maxima é zero ou menor
                //cars.Add(new Hypercar("Mclaren", 0, 0));
                //Erro ao colocar que a velocidade atual é maior que a velocidade maxima
                //cars.Add(new Hypercar("Konnekseg", 450, 300));
                //Erro ao chamar o metodo e passar da velocidade maxima
                //cars.Add(new Hypercar("Porche", 150, 290));
                //Erro ao chamar o metodo e ser menor que a velocidade atual
                //cars.Add(new Hypercar("Mclaren", 400, 500));
                

                foreach (var car in cars)
                {
                    car.Accelerate(300);
                    Console.WriteLine(car);
                }
            }
            catch (ExceptionDomain domain) { Console.WriteLine(domain.Message); }
            finally { Console.WriteLine("Fechando o programa"); }
        }
    }
}
