using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex6.NewFolder
{
    sealed class Nave
    {

        public void GerarRelatorios(DateTime dataInicial,int meses)
        {
            DateTime NovaData = new DateTime();
            for (int i = 1; i <= meses; i++) 
            {
                NovaData = dataInicial.AddMonths(i);
                Console.WriteLine($"Salto temporal {i} relizado...Nova data: {NovaData.ToString("dd/MM/yyyy")}");
            }
            
        }
    }
}
