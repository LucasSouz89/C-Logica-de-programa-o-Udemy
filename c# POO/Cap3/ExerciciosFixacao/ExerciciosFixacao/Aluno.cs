using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFixacao {
    internal class Aluno {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double soma() {
            return nota1 + nota2 + nota3;
        }

        public override string ToString() {
            if (soma() >= 60) {
                return $"NOTA FINAl = {soma().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                    $"APROVADO";
            } else {
                return $"NOTA FINAl = {soma().ToString("F2",CultureInfo.InvariantCulture)}\n" +
                    $"REPROVADO \n" +
                    $"FALTARAM {(60 - soma()).ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }
        }
    }
}
