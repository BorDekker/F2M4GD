using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{

    class Skill
    {
        string name = "thunder bolt";
        int damage = 2;
        int EnergyCost = 30;
        public Elements element;

        internal void UseOn(ConsoleMon caster, ConsoleMon target)
        {
            caster.DepleteEnergy(EnergyCost);
            target.TakeDamage(damage);
        }

        internal Skill()
        {

        }

        internal Skill(Skill copyFrom)
        {
            this.name = copyFrom.name;
            this.damage = copyFrom.damage;
            this.EnergyCost = copyFrom.EnergyCost;
            this.element = copyFrom.element;
        }
    }

    internal enum Elements
    {
        Water,
        Earth,
        Fire,
        Air,
        Lightning,
        Lava,
        Metal
    }

    internal class Copy
    {
        public string copy;
        public string copyFrom;

        internal Copy()
        {
            copy = null;
        }

        internal Copy(string copyFrom)
        {
            this.copyFrom = copyFrom;
        }
    }
}
