using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class ConsoleMonArena
    {
        public static void DoBattle(ConsoleMon a, ConsoleMon b)
        {
            Random random = new Random();
            int skillChoose = random.Next(a.skills.Count);
            Console.WriteLine(skillChoose);
        }
    }

}
