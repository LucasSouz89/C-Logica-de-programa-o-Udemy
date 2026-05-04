using ComoColecaoHashTestamIgualdade.Entites;


namespace ComoColecaoHashTestamIgualdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashSet<string> set = new HashSet<string>();
            //set.Add("Maria");
            //set.Add("Alex");
            //Console.WriteLine(set.Contains("Maria"));
            HashSet<Product> products = new HashSet<Product>();
            products.Add(new Product("TV",900.00));
            products.Add(new Product("Mesa", 500.00));

            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(13, 21));
            points.Add(new Point(1, 43));

            Product p = new Product("TV", 900.00);
            foreach (var item in products)
            {
                Console.WriteLine(p.Equals(item));
            }
            Point p2 = new Point(13, 21);
            foreach (var item in points)
            {
                Console.WriteLine(p2.Equals(item));
            }
        }
    }
}
