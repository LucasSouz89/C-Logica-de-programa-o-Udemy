using ExericiosInterfaceEHerança.Ex3.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericiosInterfaceEHerança.Ex3.Entites.Class
{
    internal class EscopetaCanoDuplo : Arma
    {
        public EscopetaCanoDuplo(string nome,IEFeitoTiro eFeitoTiro) : base(nome,eFeitoTiro) { }
        public override void PuxarGatilho()
        {
            Console.WriteLine($"Atirando com a {Nome}! Dano causado: {_efeitoTiro.CalcularDano()}");
        }
    }
}
