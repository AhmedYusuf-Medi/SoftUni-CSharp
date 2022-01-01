using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] square = new int[n, n];
            fillMatrix(n, square);

            int sumD1 = 0;
            int sumD2 = 0;

            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < n; col++)
                {
                    int currNumber = square[row, col];

                    if (row == col)
                    {
                       sumD1 += currNumber;
                    }
                    if (col == n - 1 - row)
                    {
                        sumD2 += currNumber;
                    }
                }
            }
            Console.WriteLine(Math.Abs(sumD1 - sumD2));
        }

        private static void fillMatrix(int n, int[,] square)
        {
            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine().Split().
                    Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    square[row, col] = numbers[col];
                }
            }
        }
    }
}
