using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExComposicao.Ex1.Entities.Class
{
    internal class CastAction
    {

        public int ComboMultiplier { get; private set; }

        public Spell Spell { get; private set; }


        public CastAction() { }

        public CastAction(int combo, Spell spell) {
            ComboMultiplier = combo;
            Spell = spell;
        }

        public double SubTotalDamage()
        {
            double damage = ComboMultiplier*Spell.BaseDamage;
            return damage;
        }
        public override string ToString()
        {
            return $"{Spell}| ComboMultiplier: {ComboMultiplier} | SubTotal de dano: {SubTotalDamage().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
