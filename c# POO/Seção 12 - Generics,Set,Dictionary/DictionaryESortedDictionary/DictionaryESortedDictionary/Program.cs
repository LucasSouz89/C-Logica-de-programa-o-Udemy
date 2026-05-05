namespace DictionaryESortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> cookies = new Dictionary<string,string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388"; //sobrescreve

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            //Remove
            cookies.Remove("email");

            //try
            //{
            //    
            //    Console.WriteLine(cookies["email"]);
            //}catch(KeyNotFoundException e) { Console.WriteLine($"Error : {e.Message}"); }
            //Count
            string result = (cookies.ContainsKey("email")) ? cookies["email"] : "Key not found";
            Console.WriteLine(result);
            Console.WriteLine($"Size of dictionary: {cookies.Count}");
            //Loop
            Console.WriteLine("All cookies");
            //Jeito verboso
            foreach (KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            //Usando o var
            foreach (var item in cookies)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
