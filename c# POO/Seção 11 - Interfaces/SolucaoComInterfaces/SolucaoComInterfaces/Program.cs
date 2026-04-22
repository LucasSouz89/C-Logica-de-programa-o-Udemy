using SolucaoComInterfaces.Entites.Class;
using SolucaoComInterfaces.Entites.Services;
using System.Globalization;

namespace SolucaoComInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Vehicle vehicle;
            DateTime start, finish;
            Invoice invoice;
            RentalService rentalService;
            CarName(out vehicle);
            Date(out start, out finish);

            CarRental carRental = new CarRental(start, finish, vehicle);
            CarRentalCalculate(out rentalService);
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("Invoice:");
            Console.WriteLine(carRental.Invoice);



        }
        public static void CarName(out Vehicle v)
        {
            Console.Write("Car model: ");
            var carModel = Console.ReadLine();
            v = new Vehicle(carModel);
        }
        public static void Date(out DateTime start, out DateTime finish)
        {
            Console.Write("Pickup (dd/MM/yyyy hh:MM): ");
            start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:MM): ");
            finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyy HH:mm", CultureInfo.InvariantCulture);
        }
        public static void CarRentalCalculate(out RentalService r)
        {
            Console.WriteLine("Enter price per hour: ");
            var hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per day: ");
            var day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r = new RentalService(hour, day,new BrazilTaxService());
        }
    }
}
