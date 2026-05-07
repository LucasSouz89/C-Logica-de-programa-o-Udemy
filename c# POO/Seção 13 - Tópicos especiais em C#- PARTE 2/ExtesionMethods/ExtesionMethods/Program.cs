
using System;

namespace ExtesionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primeiro exemplo
            DateTime date = new DateTime(2018,11,16,8,10,45);
            Console.WriteLine(date.ElapsedTime());
            //Segundo Exemplo
            string s1 = "Good morning dear studentes";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
