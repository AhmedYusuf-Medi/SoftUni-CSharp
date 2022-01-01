using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] square = new char[n, n];

            FillMatrix(square);

            int squreRow = 0;
            int squreCol = 0;

            FindUrPosition(n, square, ref squreRow, ref squreCol);

            string command = Console.ReadLine();

            int sum = 0;

            while (sum <= 50)
            {
                square[squreRow, squreCol] = '-';

                squreRow = MoveRow(squreRow, command);
                squreCol = MoveCol(squreCol, command);


                if (!IsPositionValid(squreRow, squreCol, n, n))
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }

                char currPosition = square[squreRow, squreCol];
                if (Char.IsDigit(currPosition))
                {
                    int currDigit = (int)Char.GetNumericValue(currPosition);
                    sum += currDigit;
                }


                if (square[squreRow, squreCol] == 'O')
                {
                    square[squreRow, squreCol] = '-';

                    for (int i = squreRow; i < n; i++)
                    {
                        for (int j = squreCol; j < n; j++)
                        {
                            if (square[i, j] == 'O')
                            {
                                squreRow = i;
                                squreCol = j;
                                break;
                            }
                        }
                    }
                }

                square[squreRow, squreCol] = 'S';

                command = Console.ReadLine();
            }

            bool isMoneyEnough = sum >= 50;

            if (isMoneyEnough)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            Console.WriteLine($"Money: {sum}");
            PrintMatrix(square);

        }

        private static void PrintMatrix(char[,] square)
        {
            for (int row = 0; row < square.GetLength(0); row++)
            {
                for (int col = 0; col < square.GetLength(1); col++)
                {
                    Console.Write(square[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void FindUrPosition(int n, char[,] square, ref int squareRow, ref int squareCol)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (square[row, col] == 'S')
                    {
                        squareRow = row;
                        squareCol = col;
                    }
                }
            }
        }

        private static void FillMatrix(char[,] square)
        {
            for (int row = 0; row < square.GetLength(0); row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < square.GetLength(1); col++)
                {
                    square[row, col] = line[col];
                }
            }
        }

        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }
            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }
            if (movement == "right")
            {
                return col + 1;
            }

            return col;
        }

        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }
    }
}
