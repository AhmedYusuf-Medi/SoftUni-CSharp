using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string text = String.Empty;
            int N = n - 1;


            while ((text= Console.ReadLine().ToLower()) != "end")
            {
                string[] arg = text.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string comand = arg[0];
                int row = int.Parse(arg[1]);
                int col = int.Parse(arg[2]);
                int num = int.Parse(arg[3]);
                
                if (row > N || col > N || row < 0 || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    switch (comand)
                    {
                        case "add":
                            matrix[row, col] += num;
                            break; 
                        default:
                            matrix[row, col] -= num;
                            break;
                    }
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
