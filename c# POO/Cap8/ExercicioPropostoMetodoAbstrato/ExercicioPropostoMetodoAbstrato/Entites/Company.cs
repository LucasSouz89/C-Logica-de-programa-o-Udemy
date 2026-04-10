using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoMetodoAbstrato.Entites
{
    sealed class Company : Account
    {
        public int Employers { get;private set; }

        public Company() { }

        public Company(string name, double income,int employers) : base(name,income)
        {
            Employers = employers;
        }
        public sealed override double Tax()
        {
            double taxValue;
            taxValue = (Employers <= 10) ? Income * 0.16 :  Income * 0.14;
            return taxValue;
        }
    }
}
