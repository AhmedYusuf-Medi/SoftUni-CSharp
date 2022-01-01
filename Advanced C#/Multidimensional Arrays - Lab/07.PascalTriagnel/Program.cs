using System;

namespace _07.PascalTriagnel
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] triangle = new long[rows][];

            for (int row = 0; row < triangle.Length; row++)
            {
                triangle[row] = new long[row + 1];
                for (int i = 0; i < row  +1; i++)
                {
                    if (i > 0 && i < triangle[row].Length - 1)
                    {
                        triangle[row][i] = triangle[row - 1][i - 1] + triangle[row - 1][i];
                    }
                    else
                    {
                        triangle[row][i] = 1;
                    }

                }
            }

            foreach (long[] row in triangle)
            {
                Console.WriteLine(string.Join(' ',row));
            }
        }
    }
}
