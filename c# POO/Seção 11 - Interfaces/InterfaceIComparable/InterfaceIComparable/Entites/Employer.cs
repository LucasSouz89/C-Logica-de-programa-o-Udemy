using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceIComparable.Entites;

namespace InterfaceIComparable.Entites
{
    sealed class Employer : IComparable
    {
        public string Name { get; set; }

        public double Salary { get; set; }

        public Employer(string csvName)
        {
            string[] vet = csvName.Split(',');
            Name = vet[0];
            Salary = double.Parse(vet[1],CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return $"{Name} , Salary $ {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
        public int CompareTo(Object obj) 
        {
            if (!(obj is Employer)) { 
                throw new ArgumentException("A object is a different class");
            }
            Employer other = obj as Employer;
            return Salary.CompareTo(other.Salary);
        }
    }
}
