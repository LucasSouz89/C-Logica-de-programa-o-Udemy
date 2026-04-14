namespace ExerciciosUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\Treinamentos\estoque.txt";
            int sum = 0;
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream) 
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                        string[] campos = line.Split(',');
                        string nome = campos[0];
                        int numeros = int.Parse(campos[1]);
                        
                        sum += numeros;

                    }
                }
            }
            catch (IOException e) { Console.WriteLine(e.Message); }
            Console.WriteLine($"Total de itens no estoque: {sum}");
        }
    }
}
