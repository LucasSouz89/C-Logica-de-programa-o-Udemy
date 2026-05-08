using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethotsExercicios.Extension
{
    static class ListExtension
    {
        public static T GetRandom<T>(this List<T> list) 
        {
            Random rnd = new Random();
            int position = rnd.Next(0,list.Count);
            return list[position];
        }
        public static void PrintAll<T>(this List<T> list) => Console.WriteLine(string.Join(",", list));





    }
}
