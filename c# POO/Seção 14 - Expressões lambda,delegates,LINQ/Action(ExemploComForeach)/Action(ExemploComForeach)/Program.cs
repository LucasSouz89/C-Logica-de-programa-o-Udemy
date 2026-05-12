namespace Action_ExemploComForeach_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900));
            list.Add(new Product("Mouse", 50));
            list.Add(new Product("Tablet", 350));
            list.Add(new Product("HD Case", 50));
            //Jeito 1
             Action<Product> act = PriceChange;
            //Jeito 2
            act = p => { p.Price += p.Price * 0.1; };
            list.ForEach(act);
            //Jeito 3
            list.ForEach(p => { p.Price += p.Price * 0.1; });
            Console.WriteLine(string.Join("\n",list));
            
            


        } 
        public static void PriceChange(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
