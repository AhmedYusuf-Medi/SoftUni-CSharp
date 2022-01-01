using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = numbers[0];
            int cols = numbers[1];

            int[,] square = new int[rows, cols];

            FillMatrix(rows, cols, square);

            var rowIndex = 0;
            var colIndex = 0;
            var maxSum = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                for (var col = 0; col < cols - 2; col++)
                {
                    int currentRowSum = 0;

                    for (int startRow  = row; startRow <= row + 2; startRow++)
                    {
                        for (int startcolum = col; startcolum <= col +2; startcolum++)
                        {
                            currentRowSum += square[startRow, startcolum];

                            if (currentRowSum > maxSum)
                            {
                                rowIndex = startRow - 1;
                                colIndex = startcolum = 1;
                                maxSum = currentRowSum;
                            }
                        }

                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            if (maxSum == 0)
            {
                Console.WriteLine($"0 " + $"0 " + $"0");
                Console.WriteLine($"0 " + $"0 " + $"0");
                Console.WriteLine($"0 " + $"0 " + $"0");
                return;
            }
            else
            {
                Console.WriteLine($"{square[rowIndex - 1, colIndex - 1]} " +
                              $"{square[rowIndex - 1, colIndex]} " +
                              $"{square[rowIndex - 1, colIndex + 1]}");

                Console.WriteLine($"{square[rowIndex, colIndex - 1]} " +
                                  $"{square[rowIndex, colIndex]} " +
                                  $"{square[rowIndex, colIndex + 1]}");

                Console.WriteLine($"{square[rowIndex + 1, colIndex - 1]} " +
                                  $"{square[rowIndex + 1, colIndex]} " +
                                  $"{square[rowIndex + 1, colIndex + 1]}");
            }

        }

        private static void FillMatrix(int rows, int cols, int[,] square)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    square[row, col] = input[col];
                }
            }
        }
    }
}
