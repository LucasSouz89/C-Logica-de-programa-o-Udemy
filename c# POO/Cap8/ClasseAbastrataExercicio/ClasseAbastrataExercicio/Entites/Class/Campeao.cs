using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbastrataExercicio.Entites.Class
{
    abstract class Campeao
    {
        public string Nome { get; private set; }
        public double Mana { get; protected set; }

        public Campeao() { }

        public Campeao(string nome, double mana) {
            Nome = nome;
            Mana = mana;
        }
        public void AtaqueBasico() 
        {
            Console.WriteLine($"{Nome} deu ataque básico");
        }
        //O metodo abastratado fica impossibilitado de usar o metodo instanciado num objeto do tipo pai
        public abstract void UsarUltimate();

        
    }
}
