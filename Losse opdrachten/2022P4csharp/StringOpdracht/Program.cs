using System;
using System.IO;

namespace StringOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\borde\Documents\Ma\Periode 1.4\F2M4GD\stringsplit.txt"); ;

            text = text.Replace(" ", "");
            string[] value = text.Split(':');
            Console.WriteLine(value);

            string[] value2 = value[1].Split(',');

            foreach (var item in value2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
