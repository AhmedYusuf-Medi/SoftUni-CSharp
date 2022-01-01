using System;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result;

            for (int i = 1; i <= 10; i++)
            {
                result = i * number;
                Console.WriteLine($"{number} X {i} = {result}");
            }
        }
    }
}
