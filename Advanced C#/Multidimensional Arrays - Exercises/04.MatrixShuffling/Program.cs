using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = numbers[0];
            int cols = numbers[1];

            string[,] matrix = new string[rows, cols];

            FillMatrix(rows, cols, matrix);


            string text = String.Empty;
            while ((text = Console.ReadLine()) != "END")
            {
                string[] arg = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string comand = arg[0];

                if (arg.Length == 5)
                {
                    int firstRow = int.Parse(arg[1]);
                    int firstCol = int.Parse(arg[2]);
                    int secRow = int.Parse(arg[3]);
                    int secCol = int.Parse(arg[4]);

                    if (firstRow > rows || firstRow < 0 || firstCol > cols || firstCol < 0 ||
                    secRow > rows || secRow < 0 || secCol < 0 || secCol > cols)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string firstElement = matrix[firstRow, firstCol];
                        string secElement = matrix[secRow, secCol];

                        matrix[firstRow, firstCol] = secElement;
                        matrix[secRow, secCol] = firstElement;
                        Output(rows, cols, matrix);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                
            }
            
        }

        private static void Output(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
