using System.Globalization;

namespace ExerciciosDelegates
{
    internal class Program
    {
        delegate string StringProcessor(string s);
        delegate int MathOperation(int i,int e);
        delegate bool NumberAnalyzer(int e);
        public delegate double DiscountStrategy(double price);
        static void Main(string[] args)
        {
            //Ex 1
            StringProcessor a = Program.UpperCase;
            Console.WriteLine(a("lucas"));
            var b = new StringProcessor(LowCase);
            Console.WriteLine(b.Invoke("LUCAS"));
            //Ex 2
            int n1 = 45, n2 = 12;
            MathOperation operation = Program.Multiply;
            Console.WriteLine(operation(n1,n2));
            operation = Program.Divide;
            Console.WriteLine(operation(n1,n2));
            //Ex3
            int number1 = -5, number2 = 10;
            NumberAnalyzer analazyer = Program.IsEven;
            Console.WriteLine(analazyer(number2));
            analazyer = Program.IsPositive;
            Console.WriteLine(analazyer(number1));
            //Ex 4
            double p1 = 200.00, p2 = 400.50;
            DiscountStrategy discount = Program.StudentDiscount;
            PrintFinalPrice(p1,discount);
            PrintFinalPrice(p2, Program.VipDiscount);
            //Ex 5
            MathOperation lambdaOperation = (x, y) => x - y;
            Console.WriteLine(lambdaOperation(35,20));
            lambdaOperation = (x, y) => x - y;
            Console.WriteLine(lambdaOperation(40,20));
            
        }
        public static string UpperCase(string s) => s.ToUpper();
        public static string LowCase(string s) => s.ToLower();


        public static int Multiply(int i, int e) => i * e;

        public static int Divide(int i, int e) => i / e;

        public static bool IsEven(int e) => e % 2 == 0;

        public static bool IsPositive(int e) => e > 0;

        public static double StudentDiscount(double price) => price * 0.5;
        public static double VipDiscount(double price) => price * 0.9;
        public static void PrintFinalPrice(double price,DiscountStrategy calc) => Console.WriteLine(calc(price).ToString("F2", CultureInfo.InvariantCulture));
    }
}
