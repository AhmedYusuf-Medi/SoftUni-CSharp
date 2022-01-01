using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"D:\C#\Advanced C# SoftUni\StreamsFilesAndDirectoriesLab\02.LineNumbers\input.txt"))
            {

                string line = String.Empty;

                int row = 1;
            
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"{row}.{line}");
         
                    row++;
                }
            }
        }
    }
}
