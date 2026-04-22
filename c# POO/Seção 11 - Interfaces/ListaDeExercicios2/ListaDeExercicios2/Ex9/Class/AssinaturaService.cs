using ListaDeExercicios2.Ex9.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex9.Class
{
    sealed class AssinaturaService
    {
        public List<Fatura> faturas { get; private set; } = new List<Fatura>();

        private readonly ITaxa _taxa;

        public AssinaturaService(ITaxa taxa)
        {
            _taxa = taxa;
        }
        public void AddFatura(Fatura fatura)
        {
            faturas.Add(fatura);
        }
        public void RemoveFatura(Fatura fatura)
        {
            faturas.Remove(fatura);
        }
        public void GerarFaturas(double valorTotal,int meses)
        {
            double cotaBase = valorTotal/ meses;
            
            for (int i = 1; i <= meses; i++) 
            {
                AddFatura(new Fatura(_taxa.ApplicarTaxa(cotaBase, i))); 
            }
            
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int contador = 1;
            foreach(Fatura fatura in faturas)
            {
                sb.AppendLine($"Fatura #{contador} R${fatura.Valor.ToString("F2",CultureInfo.InvariantCulture)}");
                contador++;
            }
            return sb.ToString();
        }
    }
}
