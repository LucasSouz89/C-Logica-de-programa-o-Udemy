using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex9.Class
{
    static class Relatorio
    {
        public static void ImprimirDicionario<TChave,TValor>(TChave chave,TValor valor)
        {

            if (valor is double valorCorvertido) { Console.WriteLine($"Chave: {chave} -> Valor: {valorCorvertido.ToString("F2", CultureInfo.InvariantCulture)}"); }
            else
            {
                Console.WriteLine($"Chave: {chave} -> Valor: {valor}");
            }
        }
    }
}
