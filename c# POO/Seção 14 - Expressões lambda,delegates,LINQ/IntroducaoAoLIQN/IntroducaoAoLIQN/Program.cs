using System.Linq;
namespace IntroducaoAoLIQN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Specify the data source
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            //Define the query expression

            var result = numbers
                .Where(x => x%2 == 0)
                .Select(x => x*10).ToArray();
            //Execute the query
            Console.WriteLine(string.Join("\n",result));
        }
    }
}
