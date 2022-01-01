using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[n][];

            FillMatrix(n, jaggedArray);

            EvenOrOddRow(n, jaggedArray);

            string text = String.Empty;

            while ((text = Console.ReadLine()) != "End")
            {
                string[] arg = text.Split();
                string comand = arg[0];
                int row = int.Parse(arg[1]);
                int col = int.Parse(arg[2]);
                double value = double.Parse(arg[3]);


                if (comand == "Add")
                {
                    if (row >= 0 && row <= n-1 && col >= 0 && col <= jaggedArray[row].Length-1)
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                else
                {
                    if (row >= 0 && row <= n - 1 && col >= 0 && col <= jaggedArray[row].Length - 1)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }
            PrintMatrix(n, jaggedArray);
        }

        private static void PrintMatrix(int n, double[][] jaggedArray)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void EvenOrOddRow(int n, double[][] jaggedArray)
        {
            for (int row = 0; row < n - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int currRow = 0; currRow < jaggedArray[row].Length; currRow++)
                    {
                        jaggedArray[row][currRow] = jaggedArray[row][currRow] * 2;
                    }

                    for (int currRow = 0; currRow < jaggedArray[row + 1].Length; currRow++)
                    {
                        jaggedArray[row + 1][currRow] = jaggedArray[row + 1][currRow] * 2;
                    }
                }
                else
                {
                    for (int currRow = 0; currRow < jaggedArray[row].Length; currRow++)
                    {
                        jaggedArray[row][currRow] = jaggedArray[row][currRow] / 2;
                    }

                    for (int currRow = 0; currRow < jaggedArray[row + 1].Length; currRow++)
                    {
                        jaggedArray[row + 1][currRow] = jaggedArray[row + 1][currRow] / 2;
                    }
                }
            }
        }

        private static void FillMatrix(int n, double[][] jaggedArray)
        {
            for (int row = 0; row < n; row++)
            {
                double[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                jaggedArray[row] = currentRow;
            }
        }
    }
}
//burkam mandja AHHAHAHA
//dali tova shte bachka da vuveda rows v jaggedArray
//shte razberem sled kato si dovursha mandjata
