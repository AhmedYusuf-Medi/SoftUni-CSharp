using System;

namespace _08.DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
