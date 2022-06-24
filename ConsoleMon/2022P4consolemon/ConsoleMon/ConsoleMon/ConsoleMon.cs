using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class ConsoleMon
    {
        public string name = "Pickachu"; 
        public int health = 10;
        public int energy = 200;
        public Elements strenght = Elements.Lightning;

        public Elements weakness = Elements.Air;

        public List<Skill> skills = new List<Skill>();

        public string monsterType;

        internal void  TakeDamage(int damage)
        {
            
            int Health = health - damage;
        }

        internal void DepleteEnergy(int Energy)
        {
            
            int bEnergy = energy - Energy;
        }

        internal ConsoleMon()
        {

        }

        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.name = copyFrom.name;
            this.health = copyFrom.health;
            this.energy = copyFrom.energy;
            this.strenght = copyFrom.strenght;
            this.weakness = copyFrom.weakness;

            for (int i = 0; i < copyFrom.skills.Count; i++)
            {
                Skill copyFromThisSkill = copyFrom.skills[i];
                Skill copy = new Skill(copyFromThisSkill);

                this.skills.Add(copy);
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> skills = new List<string>() { "Thunderbolt", "Greater Thunderbolt", "Ultimate Thunderbolt" };

            skills.Add("lightning spear");
            skills.Add("Greater Lightning spear");
            skills.Add("Dash");

            skills.Remove("Dash");

            foreach (string skill in skills)
            {
                Console.WriteLine(skill);
            }

            Console.ReadLine();
        }
    }
}
