namespace IntroducaoAoDelegate
{
    internal class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 20;

            //Console.WriteLine(CalculationService.Sum(a,b));
            // Console.WriteLine(CalculationService.Square(a));
            //jeito 1
            //BinaryNumericOperation op = CalculationService.Max;

            //jeito2
            var op = new BinaryNumericOperation(CalculationService.Sum);
            Console.WriteLine(op.Invoke(a,b));

        }
    }
}
