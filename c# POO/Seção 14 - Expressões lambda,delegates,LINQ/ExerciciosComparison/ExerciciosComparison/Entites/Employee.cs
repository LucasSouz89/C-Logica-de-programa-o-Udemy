using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComparison.Entites
{
    internal class Employee
    {
        public string Name { get; set; }

        public double Salary { get; set; }

        public int Age { get; set; }

        public Employee(string name,double salary,int age) { Name = name;Salary = salary;Age = age; }

        public override string ToString()
        {
            return $"{Name}, {Age} years old, $ {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
