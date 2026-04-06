using ClassesEMetodosSelados.Entites;

namespace ClassesEMetodosSelados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Account a = new BusinessAccount();
            BusinessAccount b = a as BusinessAccount;
        }
    }
}
