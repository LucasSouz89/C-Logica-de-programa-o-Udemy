using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido.Entites.Class
{
    sealed class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour,double additinalCharge) :base(name,hours,valuePerHour) 
        {
            AdditionalCharge = additinalCharge;
        }
        public sealed override double Payment()
        {
            return base.Payment()+AdditionalCharge*1.10;
            
        }

    }
}
