namespace ProgramacaoFuncionalECalculoLambda
{
    internal class Program
    {
        public static int globalValue = 3;
        static void Main(string[] args)
        {
            int[] vect = new int[] { 1, 2, 3,4,5 };
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(",",vect));
         
        }
        public static void ChangeOddValues(int[] vect)
        {
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] % 2 != 0)
                {
                    vect[i] += globalValue;
                }
            }
        }
    }
}
