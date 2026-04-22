using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex7.NewFolder
{
    sealed class Ferreiro
    {

        public void CalcularEmprestimo(double valorBase,int meses) 
        {
            for (int i = 1; i <= meses; i++) { 
                double juros = valorBase * i*0.05;
                Console.WriteLine($"Mês {i}: Juros da espada = R$ {juros.ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}
