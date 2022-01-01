using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = Console.ReadLine().Split(@"\");

            var lastfile = file[file.Length - 1].Split('.');

            var name = lastfile[0];
            var extension = lastfile[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
