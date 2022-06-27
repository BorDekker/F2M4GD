using ConsoleMonsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMonFactory monFactory = new ConsoleMonFactory();
            monFactory.Load();
            ConsoleMon cm = monFactory.Make("EnterMon");
            ConsoleMon com = monFactory.Make("NewLineMon");
            Console.WriteLine(cm.monsterType);
            Console.WriteLine(com.monsterType);

            ConsoleMonArena MonArena = new ConsoleMonArena();
            MonArena.DoBattle(cm, com);
        }
    }
}
