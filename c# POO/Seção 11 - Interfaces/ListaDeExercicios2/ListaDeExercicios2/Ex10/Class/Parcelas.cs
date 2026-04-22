using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex10.Class
{
    sealed class Parcelas
    {
        public DateTime Date { get; private set; }
        public double Valor { get; set; }

        public Parcelas(DateTime date, double valor)
        {
            Date = date;
            Valor = valor;
        }
    }
}
