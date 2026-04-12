using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFixacao {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double pct) {
            SalarioBruto += SalarioBruto * pct / 100;
        }
        public override string ToString() {
            return $"{Nome}, $ {SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
