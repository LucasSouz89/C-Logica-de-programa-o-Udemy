using InterfaceIComparable.Entites;
using System.Globalization;

namespace InterfaceIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string path = @"C:\Temp\in.txt";
            string path = @"C:\Temp\in2.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employer> list = new List<Employer>();
                    while (!sr.EndOfStream)
                    {
                        
                        list.Add(new Employer(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (var e in list) { Console.WriteLine(e); }

                }
            }catch(IOException e) { Console.WriteLine($"An error ocurred: {e.Message}"); }
        }
    }
}
