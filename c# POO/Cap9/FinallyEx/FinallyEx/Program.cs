namespace FinallyEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*
            try
            {
                Console.Write("Digite um texto: ");
                var palavra = Console.ReadLine();

                if (palavra.ToLower() == "bug")
                {
                    throw new Exception("Erro: Disco cheio,falha ao salvar");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

            */
            //Ex 2
            /*
            try
            {
                Console.WriteLine("Digite a senha correta do servidor: ");
                var senha = Console.ReadLine();
                if (senha == "1234") { Console.WriteLine("Conexão estabelecida com sucesso!"); }
                else { throw new Exception("Senha Incorreta! Conexão recusada."); }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { Console.WriteLine("Limpando cache de rede e encerrando tentativa de conexão."); }
            */
            //Ex 3

            Console.WriteLine(TentarAbrirBau());

        }
        public static bool TentarAbrirBau()
        {
            try
            {
                Console.WriteLine("Digite a palvara correta: ");

                if (Console.ReadLine().ToLower() == "abrir") { return true; }
                else { throw new Exception(); }

            }
            catch (Exception) { return false; }
            finally { Console.WriteLine("Zelador: Eu rodo mesmo se você der return!"); }
        }
    }
}
