using GetHashCoideEEquals.Class;

namespace GetHashCoideEEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Equals
            string[] nome = { "Maria", "João", "Maria" };
            Console.WriteLine(nome[0].Equals(nome[1]));
            //GetHshCode
            Console.WriteLine(nome[0].GetHashCode());
            Console.WriteLine(nome[1].GetHashCode());
            Console.WriteLine(nome[2].GetHashCode());

            Client client1 = new Client();
            client1.Email = "lucaskotlin@gmail.com";
            client1.Name = "Lucas";
            Client client2 = new Client();
            client2.Email = "maria@outlook.com";
            client2.Name = "Maria";

            Console.WriteLine(client1.Equals(client2));
            Console.WriteLine(client2 == client1);
            Console.WriteLine(client1.GetHashCode());
            Console.WriteLine(client2.GetHashCode());
        }
    }
}
