using ExercicioFinalComposicao.Entites.Class;
using ExercicioFinalComposicao.Entites.Enuns;
using System.Globalization;

namespace ExercicioFinalComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client;
            Client(out client);
            OrderStatus orderStatus;
            OrderStatus(out orderStatus);
            Order newOrder = new Order(DateTime.Now,orderStatus,client);
            RecordingItems(newOrder);
            Console.WriteLine(newOrder);

            
        }
        public static void Client(out Client c)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            var Date = DateTime.Parse(Console.ReadLine());
            c = new Client(name,email,Date);

        }
        public static void OrderStatus(out OrderStatus o) 
        {
            Console.Write("Enter order data: ");
            o = Enum.Parse<OrderStatus>(Console.ReadLine());

        }
        public static void RecordingItems(Order order) {
            Console.Write("How many items to this order: ");
            var qtd = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine($"Enter #{i} item data");
                Console.Write("Product name: ");
                var name = Console.ReadLine();
                Console.Write("Product price: ");
                var price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Product product = new Product(name,price);
                Console.Write("Quantity: ");
                var quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity,product.Price,product);
                order.AddItem(orderItem);
            }
        }
    }
}
