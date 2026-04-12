//Ex1
/*
using ExComposicao.Ex1.Class;
using ExComposicao.Ex1.Enums;

namespace ExComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1

            Console.WriteLine("Bem vindo a taverna RPG!");
            Console.Write("Digite seu nome: ");
            string name = Console.ReadLine();
            Console.Write("Qual é o seu rank? 1-Novato,2-Aventureiro,3-Lenda)? ");
            string rankNome;
            Opcao(out rankNome);
            Rank rank = Enum.Parse<Rank>(rankNome);
            Console.Write("Digite o nome da sua guilda: ");
            string guildName = Console.ReadLine();

            Guild guild = new Guild(guildName);
            Player p = new Player(name,rank,guild);

            Console.Write("Quantas missões você precisa fazer?: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine($"Missão {i}");
                Console.Write("Digite o titulo da quest");
                string title = Console.ReadLine();
                Console.Write("Digite a data da quest (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de xp: ");
                int xp = int.Parse(Console.ReadLine());
                p.AddQuest(new Quest(title,date,xp));
            }
            Console.WriteLine();
            Console.WriteLine("Calcule a quantidade de xp ganho");
            Console.Write("Digite a data(MM/YYYY): ");
            string[] vet = Console.ReadLine().Split("/");
            int mouth = int.Parse(vet[0]),year = int.Parse(vet[1]);
            int TotalXP = p.TotalXpGained(year, mouth);
            Console.WriteLine(p);
            Console.WriteLine($"Total de Xp do ano: {TotalXP}");


        }
        public static void Opcao(out string nome) 
        {
            int opcao = int.Parse(Console.ReadLine());
            while (opcao < 1 || opcao > 3) { Console.Write("Digite uma opcao valida: "); opcao = int.Parse(Console.ReadLine()); }
            switch (opcao)
            {
                case 1:
                    nome = "Novato";
                    break;
                case 2:
                    nome = "Aventureiro";
                    break;
                case 3:
                    nome = "Lenda";
                    break;
                default:
                    nome = "Novato";
                    break;
            }

        }
    }
}
*/
//Ex2
/*
using ExComposicao.Ex2.Class;
using ExComposicao.Ex2.Enums;
using System;
using System.Globalization;

namespace ExComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            PlacaFinal(out placa);
            TruckType truck;
            Caminhao(out truck);
            string transportadora = Transportadora();

            Carrier carrier = new Carrier(transportadora);
            Truck NewTruck = new Truck(placa,truck,carrier);
            Entregas(NewTruck);
            double venda = Revenue(NewTruck);
            Console.WriteLine($"Valor da venda: {venda}");
            Console.WriteLine(NewTruck);
            
        }
        public static void PlacaFinal(out string placaFinal)
        {
            Console.Write("Digite o numero da placa(ABC-1234): ");
            string[] vet = Console.ReadLine().Split("-");
            string letras = vet[0];
            string numeros = vet[1];
            while (letras.Length != 3 || numeros.Length != 4)
            {
                Console.Write("Digite o numero da placa valido: ");
                vet = Console.ReadLine().Split("-");
                letras = vet[0];
                numeros = vet[1];
            }
            placaFinal = (letras + "-" + numeros).ToUpper().Trim();
        }
        public static void Caminhao(out TruckType truck)
        {
            truck = new TruckType();

            int opcao = 0;

            while (opcao < 1 || opcao > 3)
            {
                Console.Write("Qual é o tipo de caminhão (1-Vuc,2-Toco,3-Carreta): ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        truck = Enum.Parse<TruckType>("Vuc");
                        break;
                    case 2:
                        truck = Enum.Parse<TruckType>("Toco");
                        break;
                    case 3:
                        truck = Enum.Parse<TruckType>("Carreta");
                        break;
                    default:
                        break;
                }
            }
        }
        public static string Transportadora()
        {
            Console.Write("Digite o nome da transportadora: ");
            var transportadora = Console.ReadLine();
            while (transportadora == null) { Console.Write("Digite o nome da transportadora valido: "); transportadora = Console.ReadLine(); }
            return transportadora;
        }
        public static void Entregas(Truck t)
        {
            Console.WriteLine();
            
            Console.Write("Digite o numero de entregas: ");
            var qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine($"Entrega #{i}");
                Console.Write("Digite a data.Ex(2025-12-31): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Digite a distancia(KM): ");
                var distance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Digite o valor de revenda: ");
                var revenue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Delivery d = new Delivery(date,distance,revenue);
                t.AddDelivery(d);
                Console.WriteLine();
            }

        }
        public static double Revenue(Truck t) {
           
            Console.Write("Calcule o valor do faturamento(mes-ano): ");
            string[] periodo = Console.ReadLine().Split('-');
            var mes = int.Parse(periodo[0]);
            var ano = int.Parse(periodo[1]);
            while ((mes < 1 || mes > 12) || (ano <1999 || ano > 2025)) { 
                Console.Write("Digite um peridodo valido(mes-ano): ");
                periodo = Console.ReadLine().Split('-');
                mes = int.Parse(periodo[0]);
                ano = int.Parse(periodo[1]);
            }
           return t.CalculateMonthlyRevenue(ano, mes);
        }
    }
}
*/
//Ex3 
using ExComposicao.Ex3.Class;
using ExComposicao.Ex3.Enums;
using System;
using System.Globalization;

namespace ExComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Programa de reconhecimento de drone------------");
            Battery battery;
            Battery(out battery);
            DroneStatus status;
            StatusDrone(out status);
            string nome = GetNome();
            Drone drone = new Drone(nome,status,battery);
            CargoList(drone);
            Console.WriteLine($"Total de carga do drone: {drone.TotalCargoWeight().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine("Digite o peso da nova carga: ");
            var newWeigth = double.Parse(Console.ReadLine());
            string situation = (drone.CanTakeoff(newWeigth) == true) ? "O drone é capaz de voar" : "O drone não é capaz de voar";
            Console.WriteLine(situation);
        }
        public static void Battery(out Battery b){
            Console.Write("Digite o modelo da bateria: ");
            var brand = Console.ReadLine();
            while(brand == null) {
                Console.Write("Digite o modelo da bateria valido: ");
                brand = Console.ReadLine(); 
            }
            brand.Trim().ToUpper();
            Console.Write("Digite a capacidade maxima da bateria(3000-5000): ");
            var maxCapacity = double.Parse(Console.ReadLine());
            while(maxCapacity < 3000 || maxCapacity > 5000)
            {
                Console.Write("Digite a capacidade maxima da bateria(3000-5000): ");
                maxCapacity = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            b = new Battery(brand,maxCapacity);
        }
        public static void StatusDrone(out DroneStatus status)
        {
            
            var opcao = 0;
            string situacao = "";
            while (opcao < 1 || opcao > 3)
            {
                Console.Write("Qual é o status do Drone?(1-Parado,2-Voando,3-Em manutenção) ");
                opcao = int.Parse(Console.ReadLine());
                
                switch (opcao) {
                    case 1:
                        situacao = "Idle";
                        break;
                    case 2:
                        situacao = "InFlight";
                        break;
                    case 3:
                        situacao = "Maintenance";
                        break;
                    default:
                        Console.WriteLine("Opcão invalida");
                        break;
                }
            }
            status = Enum.Parse<DroneStatus>(situacao);
        }
        public static string GetNome()
        {
            Console.Write("Digite o nome do drone: ");
            var name = Console.ReadLine();
            while (name == null) {
                Console.Write("Digite o nome do drone: ");
                name = Console.ReadLine();
            }
            return name.ToUpper().Trim();
        }
        public static void CargoList(Drone d)
        {
            Console.Write("Qual a quantidade de cargas que o drone deve entregar? ");
            var qtd = int.Parse(Console.ReadLine());
            while (qtd < 0) { Console.Write("Digite um numero valido: "); qtd = int.Parse(Console.ReadLine()); }
            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Carga #{i}");
                Console.Write("Digite o codigo de rastreio(WES-290): ");
                string[] vet = Console.ReadLine().Split("-");
                string lettter = vet[0];
                string numbers = vet[1];
                while(lettter.Length != 3 || numbers.Length !=3) { 
                    Console.Write("Digite o codigo de rastreio valido: ");
                    vet = Console.ReadLine().Split("-");
                    lettter = vet[0];
                    numbers = vet[1];
                }
                string finalName = (lettter + "-" + numbers).Trim().ToUpper();
                Console.Write("Digite o peso da carga: ");
                var Weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
                while (Weight <= 0)
                {
                    Console.WriteLine("Digite um numero valido: ");
                    Weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                DeliveryItem deliveryItem = new DeliveryItem(finalName,Weight);
                d.AddItem(deliveryItem);
            }
        }
    }
}
