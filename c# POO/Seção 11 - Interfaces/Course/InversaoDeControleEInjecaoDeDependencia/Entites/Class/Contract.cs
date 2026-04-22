using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoDeControleEInjecaoDeDependencia.Entites.Class
{
    sealed class Contract
    {
        public int Number { get;private set; }

        public DateTime Date { get;private set; }

        public double TotalValue { get; set; }

        public List<Installment> Installments { get; private set; } = new List<Installment>();


        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
        public void AddInstallments(Installment installment) { Installments.Add(installment); }
        public void RemoveInstallments(Installment installment){ Installments.Remove(installment); }
    }
}
