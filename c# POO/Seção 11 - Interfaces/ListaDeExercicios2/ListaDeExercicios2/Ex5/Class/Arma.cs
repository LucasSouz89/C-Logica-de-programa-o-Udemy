using ListaDeExercicios2.Ex5.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex5.Class
{
    sealed class Arma
    {
        private readonly IMunicao _municao;


        public Arma(IMunicao municao)
        {
            _municao = municao;
        }

        public void Atirar(int disparos)
        {
            int danoTotal = 0;
            Random random = new Random();
            Console.WriteLine("Heavyn machingun!!!");
            for (int i = 1; i <= disparos; i++) 
            {
                int randomNumber = random.Next(1,10);
                Console.WriteLine(randomNumber.ToString());
                danoTotal += _municao.RetornarDano(randomNumber);
            }
            Console.WriteLine($"Dano total {danoTotal}");
        }
    }
}
