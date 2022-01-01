using System;
using System.Linq;

namespace _08.CondenseArrayToNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            int originalLenght = numbers.Length - 1;

            for (int i = 0; i < originalLenght; i++)
            {
                int[] condensed = new int[numbers.Length - 1];
                for (int j = 0; j < condensed.Length; j++)
                {
                    condensed[j] = numbers[j] + numbers[j + 1];
                }
                numbers = condensed;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
