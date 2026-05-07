namespace ExercicioPropostoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter file full path: ");
                string path = @"" + Console.ReadLine();
                Dictionary<string,int> candidatos = new Dictionary<string,int>();
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) 
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        candidatos[name] = candidatos.GetValueOrDefault(name, 0) + votes;
                        Console.WriteLine(candidatos[name]);
                        
                    }
                }
                foreach(var item in candidatos)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }catch(IOException e) { Console.WriteLine($"A error ocurred: {e.Message}"); }
        }
    }
}
