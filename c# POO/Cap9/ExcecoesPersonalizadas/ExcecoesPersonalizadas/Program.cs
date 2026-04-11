using ExcecoesPersonalizadas.Entites;
using ExcecoesPersonalizadas.Entites.Exceptions;
using System.Numerics;

namespace ExcecoesPersonalizadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                var number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date(dd/MM/yyyy): ");
                var checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date(dd/MM/yyyy): ");
                var checkout = DateTime.Parse(Console.ReadLine());
                Reservation r = new Reservation(number, checkin, checkout);
                Console.WriteLine(r);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date(dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date(dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());
                r.UpdateDates(checkin, checkout);
                Console.WriteLine(r);


            }
            catch (FormatException) { Console.WriteLine("Error: Invalid format!"); }
            catch (DomainException r) { Console.WriteLine(r.Message); }
            catch (Exception e) { Console.WriteLine($"Unexpected error: {e.Message}"); }
            finally { Console.WriteLine("System logout"); }
            
        }
    }
}
