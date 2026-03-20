namespace Ref_e_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ref
            int x = 10;
            Calculator.Triplicar(ref x);
            Console.WriteLine(x);
            //Out
            x = 10;
            int resultado;
            Calculator.Triplicar2(ref x, out resultado);
            Console.WriteLine(resultado);
            
        }
    }
}
