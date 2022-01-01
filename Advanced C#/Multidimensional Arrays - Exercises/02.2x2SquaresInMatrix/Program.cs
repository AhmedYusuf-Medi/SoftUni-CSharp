using System;
using System.Linq;

namespace _02._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int rows = numbers[0];
            int cols = numbers[1];

            char[,] square = new char[rows, cols];

            fillMatrix(rows,cols,square);

            int count = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1 ; col++)
                {
                    char currChar = square[row, col];
                    if (currChar == square[row, col + 1] && 
                        currChar == square[row + 1, col + 1] &&
                        currChar == square[row + 1, col])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
        private static void fillMatrix(int rows,int cols, char[,] square)
        {
            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    square[row, col] = input[col];
                }
            }
        }
    }
}
