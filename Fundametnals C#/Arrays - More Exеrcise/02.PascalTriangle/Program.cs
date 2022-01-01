using System;
using System.Linq;
namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we work with N number arrays sepereated in rows
            int triangleRows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[triangleRows][];
            jaggedArray[0] = new int[1];
            jaggedArray[0][0] = 1;
            for (int row = 1; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = new int[row + 1];
                jaggedArray[row][0] = 1;
                jaggedArray[row][jaggedArray[row].Length - 1] = 1;

                for (int col = 1; col < jaggedArray[row].Length - 1; col++)
                {
                    int leftDiagonal = jaggedArray[row - 1][col - 1];
                    int rightDiagonal = jaggedArray[row - 1][col];

                    jaggedArray[row][col] = leftDiagonal + rightDiagonal;
                }
            }
            for (int row = 0; row < triangleRows; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
        }
    }
}
