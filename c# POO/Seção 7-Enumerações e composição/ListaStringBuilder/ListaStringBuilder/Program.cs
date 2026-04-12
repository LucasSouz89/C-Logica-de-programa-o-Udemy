using ListaStringBuilder.Entites.Class;
using System;

namespace ListaStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plate = TruckPlate();
            string local = Destinatation();
            DateTime date = DepuarateDate();
            ShippingManifest s = new ShippingManifest(plate,local,date);
            Pallets(s);
            Console.WriteLine(s);
            

        }
        public static string TruckPlate()
        {
            Console.Write("Digite o numero da placa(EKG-290): ");
            string[] vet = Console.ReadLine().Split('-');
            string letters = vet[0];
            string numbers = vet[1];
            while(letters.Length != 3 || numbers.Length != 3)
            {
                Console.Write("Digite o numero da placa valido(EKG-290): ");
                vet = Console.ReadLine().Split('-');
                letters = vet[0];
                numbers = vet[1];
            }
            string finalPlate = letters + "-" + numbers;
            return finalPlate;
            
        }
        public static string Destinatation()
        {
           Console.Write("Digite o destino: ");
           string local = Console.ReadLine();
           while(local == null || local.Length == 0)
            {
                Console.Write("Digite um destino valido: ");
                local = Console.ReadLine();
            }
           return local;
        }
        public static DateTime DepuarateDate()
        {
            Console.Write("Digite a data da entrega(dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            while(date.Year == null || date.Month == null|| date.Day == null)
            {
                Console.Write("Digite a data valida(dd/MM/yyyy): ");
                date = DateTime.Parse(Console.ReadLine());
            }
            return date;
        }
        public static void Pallets(ShippingManifest s) {
            Console.Write("Quantos pallets devem ser armazenados no caminhão?");
            var qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Pallet #{i}");
                Console.Write("Digite o id do pallet: ");
                var idPallet = Console.ReadLine();
                while (idPallet.Length == 0 || idPallet == null)
                {
                    Console.Write("Digite o id do pallet valido: ");
                    idPallet = Console.ReadLine();
                }
                Console.Write("Digite o conteudo do pallet: ");
                var content = Console.ReadLine();
                while (content.Length == 0 || content == null)
                {
                    Console.Write("Digite o conteudo do pallet valido: ");
                    content = Console.ReadLine();
                }
                Console.Write("Digite o peso do pallet(KG): ");
                var weight = double.Parse(Console.ReadLine());
                while(weight <= 0)
                {
                    Console.Write("Digite o peso do pallet valido(KG): ");
                    weight = double.Parse(Console.ReadLine());
                }
                Pallet pallet = new Pallet(idPallet,content,weight);
                s.AddPallet(pallet);
            }
            Console.WriteLine();
        }
    }
}
