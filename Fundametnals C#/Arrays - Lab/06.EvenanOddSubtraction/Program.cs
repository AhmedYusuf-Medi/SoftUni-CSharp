using System;
using System.Linq;

namespace _06.EvenanOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int even = 0;
            int odd = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (currentNum % 2 == 0)
                {
                    even += currentNum;
                }
                else
                {
                    odd += currentNum;
                }
            }
            int diff = even - odd;
            Console.WriteLine(diff);
        }
    }
}
