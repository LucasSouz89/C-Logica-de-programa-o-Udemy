namespace HasHSetESortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashSet
            Console.WriteLine("---HashSet---");
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            //False
            Console.WriteLine(set.Contains("Controle"));
            //True
            Console.WriteLine(set.Contains("Notebook"));
            Console.WriteLine();
            Impressao<string>(set);
            Console.WriteLine();
            Console.WriteLine("---SortedSet---");
            //Sortedset
            SortedSet<int> a = new SortedSet<int>() {1,4,3,2,10,30 };
            Impressao<int>(a);
            Console.WriteLine();
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 9, 11, 7,2,30 };
            Impressao<int>(b);
            //Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            Console.WriteLine();
            Impressao(c);
            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Impressao<int>(d);
            //Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Impressao<int>(e);
        }
        public static void Impressao<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
