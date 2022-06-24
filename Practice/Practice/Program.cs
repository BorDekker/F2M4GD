using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            RpgCharacter hero = new RpgCharacter("Cloud Strife", 999, 9999);
            Console.WriteLine(hero.name);
            Console.WriteLine(hero.str);
            Console.WriteLine(hero.hp);
            Console.ReadLine();
        }
    }

    internal RpgCharacter(string name, int str, int hp)
    {
        this.name = name;
        this.str = str;
        this.hp = hp;
    }
}
