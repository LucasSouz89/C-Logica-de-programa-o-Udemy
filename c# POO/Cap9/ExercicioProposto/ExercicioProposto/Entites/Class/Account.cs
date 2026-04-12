using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioProposto.Entites.Exceptions;

namespace ExercicioProposto.Entites.Class
{
    sealed class Account
    {
        public int Number { get;private set; }
        public string Holder { get;private set; }

        public double Balance { get;private set; }

        public double WithdrawLimit { get;private set; }

        public Account() { }

        public Account(int number, string holder, double balance, double widrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = widrawLimit;
        }
        public void Deposit(double amount)
        {
            if (amount < 0) { throw new ExceptionDomain("Deposit error: The amount cannot be negative."); }
            Balance += amount;
        }
        public void Withdraw(double amont)
        {
            if(amont > Balance) { throw new ExceptionDomain("Withdraw error: The amount is greater than the money in the account."); }
            if (amont > WithdrawLimit) { throw new ExceptionDomain("Withdraw error: The amount exceeds withdraw limit."); }
            Balance -= amont;
            
        }
        public override string ToString() 
        {
            return $"New balance: {Balance.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
