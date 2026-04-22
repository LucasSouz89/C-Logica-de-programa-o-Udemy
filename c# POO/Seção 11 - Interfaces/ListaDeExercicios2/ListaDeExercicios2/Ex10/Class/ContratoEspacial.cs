using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex10.Class
{
    sealed class ContratoEspacial
    {
        public double ValorTotal { get; set; }

        public DateTime DataDoContrato { get;private set; }

        public List<Parcelas> Parcelas { get; set; } = new List<Parcelas>();

        public ContratoEspacial(double valorTotal, DateTime dataDoContrato)
        {
            ValorTotal = valorTotal;
            DataDoContrato = dataDoContrato;
            
        }
        public void AddParcelas(Parcelas parcela) { Parcelas.Add(parcela); }
        public void RemoveParcelas(Parcelas parcela) { Parcelas.Remove(parcela); }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i =0; i < Parcelas.Count; i++) 
            {
                sb.AppendLine($"{Parcelas[i].Date.ToString("dd/MM/yyyy")} - {Parcelas[i].Valor.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            return sb.ToString();
        }
    }
}
