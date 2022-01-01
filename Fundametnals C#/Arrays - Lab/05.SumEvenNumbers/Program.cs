using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentNum = number[i];
                if (currentNum % 2 ==0)
                {
                    sum += currentNum;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
