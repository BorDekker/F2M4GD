using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class ConsoleMonArena
    {
        public void DoBattle(ConsoleMon a, ConsoleMon b)
        {
            Random random = new Random();
            int skillChoose = random.Next(a.skills.Count);
            Skill skll = a.skills[skillChoose];
            skll.UseOn(a, b);
            int skillChoos = random.Next(b.skills.Count);
            Skill skil = b.skills[skillChoos];
            skil.UseOn(b, a);
            Console.WriteLine(a.health);
            Console.WriteLine(b.health);
            //Console.WriteLine(random.Next(skillChoose));
        }
    }

}
