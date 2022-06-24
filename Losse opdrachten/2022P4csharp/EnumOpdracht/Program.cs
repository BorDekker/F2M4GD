using System;
using System.IO;

namespace EnumOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Colors colors = new Colors();

            if (colors == Colors.Red)
            {
                Console.WriteLine("Red");
            }

            Colors[] array = (Colors[])Enum.GetValues(typeof(Colors));

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }

    internal enum Colors
    {
        Red,
        Green,
        Blue,
        Yellow,
        Pink,
        Purple
    }
}
