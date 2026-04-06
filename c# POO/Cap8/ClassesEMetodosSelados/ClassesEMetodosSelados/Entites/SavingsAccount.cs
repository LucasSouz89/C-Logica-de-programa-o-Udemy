using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEMetodosSelados.Entites
{
    sealed class SavingsAccount : Account
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
        //Criando o metodo override que vai sobrecerver o metodo padrão Withdraw do account.
        /*
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
        */
        //Usando base
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2;
        }

    }
}
