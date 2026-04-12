namespace SwicthCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero = int.Parse(Console.ReadLine());
            switch (numero) {
                case 0: Console.WriteLine("Esse é o numero 0"); break;
                case 1: Console.WriteLine("Esse é o numero 1"); break;
                case 2: Console.WriteLine("Esse é o numero 2"); break;
                default : Console.WriteLine("Esse não é um numero valido");break;
            }
        }
    }
}
