using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates.Entites
{
    class CalculationService
    {
        public static void ShowMax(double x,double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }
        public static void ShowSum(double x, double y) => Console.WriteLine(x + y);
        
    }
}
