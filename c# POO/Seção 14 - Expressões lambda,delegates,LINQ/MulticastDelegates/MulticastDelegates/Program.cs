using MulticastDelegates.Entites;

namespace MulticastDelegates
{
    internal class Program
    {
        delegate void BynaryNumericOperation(double x,double y);
        static void Main(string[] args)
        {
            BynaryNumericOperation op = CalculationService.ShowMax;
            op += CalculationService.ShowSum;

            op(23, 45);
        }
    }
}
