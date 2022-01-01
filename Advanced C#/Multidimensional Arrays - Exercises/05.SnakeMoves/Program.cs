using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = numbers[0];
            int cols = numbers[1];


            char[,] matrix = new char[rows, cols];

            string snake = Console.ReadLine();

            int currChar = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++ )
                    {
                        matrix[row, col] = snake[currChar];
                        currChar++;
                        if (currChar == snake.Length)
                        {
                            currChar = 0;
                        }
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[currChar];
                        currChar++;
                        if (currChar == snake.Length)
                        {
                            currChar = 0;
                        }
                    }

                }
            }

            PritnMatrix(rows,cols, matrix);
        }

        private static void PritnMatrix(int rows,int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
