using System;
using System.Linq;

namespace _04.FoldАndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 2 3 6
            //5  6 +
            //2  3 =
            //7  9

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftFoldIndex = numbers.Length / 4 - 1;
            int rightFoldIndex = 3 * numbers.Length / 4;

            int[] topNumbers = new int[numbers.Length / 2];

            int howManyFarNumbersCount = 0;

            for (int i = leftFoldIndex; i >= 0; i--)
            {
                howManyFarNumbersCount++;

                topNumbers[leftFoldIndex - i] = numbers[i];
            }

            for (int i = numbers.Length - 1;  i >= rightFoldIndex; i--)
            {
                topNumbers[numbers.Length - 1 - i + howManyFarNumbersCount] = numbers[i];
            }

            int[] bottomNumbers = new int[numbers.Length / 2];

            for (int i = leftFoldIndex + 1; i < rightFoldIndex; i++)
            {
                bottomNumbers[i - howManyFarNumbersCount] = numbers[i];
            }

            for (int i = 0; i < topNumbers.Length; i++)
            {
                Console.Write(topNumbers[i] + bottomNumbers[i] + " ");
            }
        }
    }
}
