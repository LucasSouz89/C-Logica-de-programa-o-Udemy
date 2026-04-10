using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoMetodoAbstrato.Entites
{
    abstract class Account
    {
        public string Name { get; set; }

        public double Income { get;protected set; }

        public Account() { }

        public Account(string name,double income) { Name = name;Income = income; }

        public abstract double Tax();

        public override string ToString()
        {
            return $"{Name}: $ {Tax().ToString("F2",CultureInfo.InvariantCulture)} ";
        }
    }
}
