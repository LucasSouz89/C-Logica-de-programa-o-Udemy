using ListaDeExercicios2.Ex1;
using ListaDeExercicios2.Ex1.Interface;
using ListaDeExercicios2.Ex10.Class;
using ListaDeExercicios2.Ex10.Interface;
using ListaDeExercicios2.Ex2.Class;
using ListaDeExercicios2.Ex2.Interface;
using ListaDeExercicios2.Ex3.Class;
using ListaDeExercicios2.Ex4.Class;
using ListaDeExercicios2.Ex5.Class;
using ListaDeExercicios2.Ex5.Interface;
using ListaDeExercicios2.Ex6.NewFolder;
using ListaDeExercicios2.Ex7.NewFolder;
using ListaDeExercicios2.Ex9.Class;
using ListaDeExercicios2.Ex9.Interface;
using System.Globalization;

namespace ListaDeExercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            //SistemaDeAlerta system = new SistemaDeAlerta(new SmsMensageiro());
            //system.Enviar("Olá como vai amigo?");
            //system.Enviar("Notei que estava fazendo exercicios sobre injeção de dependencia..");
            //Ex2
            //Loja loja = new Loja(new DescontoVip());
            //loja.Vender(200.00);
            //Ex 3
            //Invasao invasao = new Invasao();
            //invasao.GerarZumbis(200);
            //Ex 4
            //Inventario inventario = new Inventario();
            //Console.Write("Quantidade de poções: ");
            //int qtd = int.Parse(Console.ReadLine());
            //inventario.ComprarPocoes(qtd);
            //Console.WriteLine();
            //Console.WriteLine(inventario);
            //Ex 5
            //Arma submachineGun = new Arma(new BalaComum());
            //submachineGun.Atirar(25);
            //Ex 6
            //Nave nave = new Nave();
            //DateTime date = new DateTime(2000, 12, 20);
            //nave.GerarRelatorios(date, 5);
            //Ex 7
            //Ferreiro ferreiro = new Ferreiro();
            //ferreiro.CalcularEmprestimo(200, 4);
            //Ex 8
            //double valorBase = 100.00, subtotal = valorBase + (valorBase * 0.10);
            //double totalFinal = subtotal + (subtotal * 0.05);
            //Console.WriteLine(totalFinal.ToString("F2",CultureInfo.InvariantCulture));
            //Ex 9
            AssinaturaService assinatura = new AssinaturaService(new TaxaBasica());
            assinatura.GerarFaturas(1000, 12);
            Console.WriteLine(assinatura);
            //Ex 10
            
            ContratoEspacial contrato = new ContratoEspacial(1000, new DateTime(2018,07,25));
            Financiamento financiamento = new Financiamento(new BancoEstelar());
            financiamento.Processar(contrato, 10);
;        }
    }
}
