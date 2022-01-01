using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                 num = i;

                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

                sum = 0;
            }
        }
    }
}
