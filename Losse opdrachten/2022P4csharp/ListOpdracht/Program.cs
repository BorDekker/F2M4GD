using System;
using System.Collections.Generic;

namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> birds = new List<string>() {"Uil", "Kraai", "Hond", "Papegaai" };

            birds.Remove("Hond");

            foreach (string bird in birds)
            {
                Console.WriteLine(bird);
            }

            List<string> birds2 = new List<string>() { "Meeuw", "duif" };

            birds2.AddRange(birds);

            foreach (string bird2 in birds2)
            {
                Console.WriteLine(bird2);
            }

            Console.ReadLine();
        }
    }
}
