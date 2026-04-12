using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEMetodosSelados.Entites
{
    //Colocar como sealed class SavingsAccount : Account, evita que outra classe herdam SavingsAccount
    class SavingsAccount : Account
    {
        public double InterestRate { get; private set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance,double rate) : base(number,holder,balance) {
            InterestRate = rate;
        }
        public void UptadeBalance()
        {
            Balance += Balance * InterestRate;
        }
        //Um metodo selado evita que a subclasse sobrescreva o mesmo metodo
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2;
        }

    }
}
