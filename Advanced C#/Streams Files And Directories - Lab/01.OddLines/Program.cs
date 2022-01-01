using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"D:\C#\Advanced C# SoftUni\StreamsFilesAndDirectoriesLab\01.OddLines\input.txt"))
            {

                string line = reader.ReadLine();

                int row = 0;
                while (line != null)
                {
                    if (row % 2 ==1)
                    {
                        Console.WriteLine(line);
                        Console.WriteLine();
                    }
                    line = reader.ReadLine();
                    row++;
                }  
            }    
        }
    }
}
