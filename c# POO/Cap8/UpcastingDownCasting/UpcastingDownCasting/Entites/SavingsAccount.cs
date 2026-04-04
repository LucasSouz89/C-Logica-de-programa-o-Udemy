using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDownCasting.Entites
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; private set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance,double rate) : base(number,holder,balance) {
            InterestRate = rate;
        }
        public void uptadeBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
