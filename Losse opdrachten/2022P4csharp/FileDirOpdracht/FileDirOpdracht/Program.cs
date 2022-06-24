using System;
using System.IO;

namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            if (Directory.Exists(@"c:\Users\borde\OneDrive\Documenten\Ma\Periode 1.1"))
            {
                Console.WriteLine("Directory exists");
            }

            DirectoryInfo myCode = new DirectoryInfo(@"c:\Users\borde\OneDrive\Documenten\Ma\Periode 1.1");
            foreach (var fi in myCode.GetDirectories("*", SearchOption.AllDirectories))
            {
                Console.WriteLine(fi.Name);
            }
        }
    }
}
