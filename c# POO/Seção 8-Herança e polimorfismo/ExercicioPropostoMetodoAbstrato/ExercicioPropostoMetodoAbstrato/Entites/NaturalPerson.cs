using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoMetodoAbstrato.Entites
{
    sealed class NaturalPerson : Account

    {
        public double HealthcareExpenses { get;private set; }

        public NaturalPerson() { }

        public NaturalPerson(string name, double income,double healthExpenses): base(name,income) 
        {
            HealthcareExpenses = healthExpenses;
        }

        public sealed override double Tax()
        {
           double taxValue;
           taxValue = (Income < 20000) ? (Income * 0.15) - (HealthcareExpenses * 0.5) : (Income * 0.25) - (HealthcareExpenses * 0.5);
           return taxValue;
            
        }
    }
}
