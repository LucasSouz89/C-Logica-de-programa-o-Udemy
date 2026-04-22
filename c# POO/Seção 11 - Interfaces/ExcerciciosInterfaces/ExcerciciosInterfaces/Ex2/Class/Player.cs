using ExcerciciosInterfaces.Ex2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex2.Class
{
    sealed class Player
    {
        public string Name { get;private set; }
        public int Strenght { get;private set; }

        IWeapon _weapon;

        public Player() { }

        public Player(string name, int strenght,IWeapon weapon) 
        {
            Name = name;
            Strenght = strenght;
            _weapon = weapon;
        }
        public void Atacar()
        {
            
            
            Console.WriteLine($"O jogador {Name} atacou causando {_weapon.CalculateDamage(Strenght)}");
        }
    }
}
