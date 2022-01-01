using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = array[0];
            int cols = array[1];

            int[,] numbers = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    numbers[row, col] = input[col];
                }
            }

            int maxSum = 0;

            int upperOne = 0;
            int upperTwo = 0;
            int lowerOne = 0;
            int lowerTwo = 0;

            for (int row = 0; row < rows - 1; row++)
            {

                for (int col = 0; col < cols - 1; col++)
                {

                    var newSquareSum = numbers[row, col] + numbers[row, col + 1] +

                    numbers[row + 1, col] + numbers[row + 1, col + 1];

                    if (maxSum < newSquareSum)
                    {
                        maxSum = newSquareSum;
                        upperOne = numbers[row, col];
                        upperTwo = numbers[row, col + 1];
                        lowerOne = numbers[row + 1, col];
                        lowerTwo = numbers[row + 1, col + 1];
                    }
                }
            }
            Console.WriteLine($"{upperOne} {upperTwo}");
            Console.WriteLine($"{lowerOne} {lowerTwo}");
            Console.WriteLine(maxSum);
        }
    }
}
