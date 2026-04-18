using Problema1.Entites;
using System.Globalization;
using Problema1.Entites.Exception;

namespace Problema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter rental data");
                Console.Write("Car model: ");
                var carModel = Console.ReadLine();
                Console.Write("Pickup (dd/MM/yyyy hh:MM): ");
                var pickup = DateTime.Parse(Console.ReadLine());
                Console.Write("Return (dd/MM/yyyy hh:MM): ");
                var returnn = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter price per hour: ");
                var priceHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter price per day: ");
                var priceDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                CarRental car = new CarRental(carModel, pickup, returnn, priceDay, priceHour);
                Console.WriteLine("INVOICE: ");
                Console.WriteLine(car);
            }
            catch (ExceptionDomain e) { Console.WriteLine($"Um erro ocorreu: {e.Message}"); }
            catch (Exception e) { Console.WriteLine($"Um erro ocorreu: {e.Message}"); }

        }
    }
}
