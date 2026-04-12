using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entites
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get;private set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double limit) : base(number,holder,balance)
        {
            
            LoanLimit = limit;

        }
        public void Loan(double amont) {
            if (amont <= LoanLimit)
            {
                Deposit(amont);
            }
        }
    }
}
