using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int comandNum = int.Parse(Console.ReadLine());

            char[,] square = new char[n, n];

            FillMatrix(n, square);


            int playerRow = 0;
            int playerCol = 0;

            FindPlayerPosition(n, square, ref playerRow, ref playerCol);
           

            for (int i = 0; i < comandNum; i++)
            {
                string comand = Console.ReadLine();

                if (comand == "left")
                {
                    playerCol--;
                    AdjustCol(n, playerCol);
                    if (square[playerRow, playerCol] == 'F')
                    {
                        square[playerRow, playerCol] = 'f';
                        Console.WriteLine("Player won!");
                        break;
                    }
                    playerCol = NewMethod(square, playerRow, playerCol);
                }
            }
        }

        private static int NewMethod(char[,] square, int playerRow, int playerCol)
        {
            if (square[playerRow, playerCol] == 'B')
            {
                playerCol--;
            }
            else if (square[playerRow, playerCol] == 'T')
            {
                playerCol++;
            }

            return playerCol;
        }

        private static void AdjustCol(int n, int playerCol)
        {
            if (playerCol < 0)
            {
                playerCol = n;
            }
            else if (playerCol > n)
            {
                playerCol = 0;
            }
        }

        private static void FindPlayerPosition(int n, char[,] square, ref int playerRow, ref int playerCol)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (square[row, col] == 'f')
                    {
                        playerCol = col;
                        playerRow = row;
                    }
                }
            }
        }

        private static void FillMatrix(int n, char[,] square)
        {
            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    square[row, col] = input[col];
                }
            }
        }
    }
}
