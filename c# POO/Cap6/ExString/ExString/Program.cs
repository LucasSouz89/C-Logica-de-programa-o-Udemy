namespace ExString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            var comandoSujo = "    /dAnce   ";
            var comandoLimpo = comandoSujo.ToLower().Trim();
           
            Console.WriteLine(comandoLimpo);
            //Ex2
            var linhaDoSave = "Diamante:150";
            var index = linhaDoSave.IndexOf(":");
            linhaDoSave = linhaDoSave.Substring(index+1);
            Console.WriteLine(linhaDoSave);
            //Ex 3
            var nome = Console.ReadLine();
            bool nomeVazio = (String.IsNullOrWhiteSpace(nome));
            while (nomeVazio) { 
                Console.Write("Nome invalido!Digite outro: "); 
                nome = Console.ReadLine();
                nomeVazio = String.IsNullOrWhiteSpace(nome);
            }

        }
    }
}
