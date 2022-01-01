using System;
using System.Linq;

namespace _04.FoldАndSumVariantB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int k = numbers.Length / 4;
            int[] output = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                output[i] = numbers[k - (i + 1)] + numbers[k + i];
                output[output.Length - 1 - i] = numbers[output.Length - 1 - i + k] + numbers[(output.Length - 1 - i) + (k + 2 * i + 1)];
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
