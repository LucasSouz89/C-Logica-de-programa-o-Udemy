using ExercicioProposto.Entites.Class;
using System.Globalization;
using ExercicioProposto.Entites.Exceptions;

namespace ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                var number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                var holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                var balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                var limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, balance, limit);
                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine(account);
            }
            catch (ExceptionDomain error) { Console.WriteLine(error.Message); }
            catch (FormatException) { Console.WriteLine("Format exception: Enter a valid argument"); }
            catch (Exception error) { Console.WriteLine(error.Message); }
            finally { Console.WriteLine("Leaving the program"); }
        }
    }
}
