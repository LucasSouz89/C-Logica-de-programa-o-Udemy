using ExercicosSobreConjutos.Class;

namespace ExercicosSobreConjutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter file full path: ");
                
                string path = @$"{Console.ReadLine()}";
                HashSet<User> users = new HashSet<User>();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        users.Add(new User(line));
                    }
                }
                Console.WriteLine($"Total users: {users.Count}");
            }
            catch (IOException E) { Console.WriteLine($"Um erro ocorreu: {E.Message}"); }
        }
    }
}
