using System;

namespace _04.SymboLinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] symbols = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] arg = Console.ReadLine().ToCharArray();
                    for (int col = 0; col < n; col++)
                    {
                        symbols[row, col] = arg[col];
                    }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool notOccur = true;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    char curr = symbols[row, col];
                    if (curr == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        notOccur = false; 
                    }
                }
                if (notOccur == false)
                {
                    break;
                }
            }

            if (notOccur)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
