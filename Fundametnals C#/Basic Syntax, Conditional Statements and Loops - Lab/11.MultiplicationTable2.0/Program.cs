using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startPoint = int.Parse(Console.ReadLine());
            int result;

            if (number > 10)
            {
                result = number * startPoint;
                Console.WriteLine($"{number} X {startPoint} = {result}");
            }
            else
            {
                for (int i = startPoint; i <= 10; i++)
                {
                    result = i * number;
                    Console.WriteLine($"{number} X {i} = {result}");
                }
            }
        }
    }
}
