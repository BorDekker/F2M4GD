using System;
using System.IO;

namespace FileIOOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetTempFileName();
            var fi1 = new FileInfo(path);

            using (StreamWriter sw = fi1.CreateText())
            {
                sw.WriteLine("My");
                sw.WriteLine("Name");
                sw.WriteLine("Is");
                sw.WriteLine("Bor");
                sw.WriteLine("Dekker");
            }

            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}
