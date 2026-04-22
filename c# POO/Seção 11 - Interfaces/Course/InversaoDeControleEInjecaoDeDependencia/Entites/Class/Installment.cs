using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoDeControleEInjecaoDeDependencia.Entites.Class
{
    sealed class Installment
    {
        public DateTime DueDate { get;private set; }
        public double Amount { get; set; }

        

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        
    }
}
