using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioResolvido.Entites.Class
{
    internal class Employee
    {
        public string Name { get; private set; }

        public int Hours { get; private set; }

        public double ValuePerHour { get;protected set; }


        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return ValuePerHour*Hours;
        }
        public override string ToString()
        {
            return $"{Name} - $ {Payment().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
