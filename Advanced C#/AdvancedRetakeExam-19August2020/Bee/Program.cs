using System;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] beeTeritory = new char[n, n];

            int beeRow = 0;
            int beeCol = 0;

            //Fill matrix and find bee
            FillAndFindBee(n, beeTeritory, ref beeRow, ref beeCol);

            string input;

            int polinatedFlowers = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                beeTeritory[beeRow, beeCol] = '.';

                beeRow = MoveRow(beeRow, input);
                beeCol = MoveCol(beeCol, input);

                if (!ValidatePosition(n, beeCol, beeRow))
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                if (beeTeritory[beeRow, beeCol] == 'f')
                {
                    polinatedFlowers++;
                }

                if (beeTeritory[beeRow, beeCol] == 'O')
                {
                    beeTeritory[beeRow, beeCol] = '.';
                    beeCol = MoveCol(beeCol, input);
                    beeRow = MoveRow(beeRow, input);

                    if (!ValidatePosition(n, beeCol, beeRow))
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                    if (beeTeritory[beeRow, beeCol] == 'f')
                    {
                        polinatedFlowers++;
                    }

                    //else if (beeTeritory[beeRow, beeCol] == '0')
                    //{
                    //    MoveCol(ref beeCol, input);
                    //    MoveRow(ref beeRow, input);
                    //}
                }

                beeTeritory[beeRow, beeCol] = 'B';
            }
            if (polinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - polinatedFlowers} flowers more");
            }

            PrintMatrix(beeTeritory);
        }

        private static void FillAndFindBee(int n, char[,] beeTeritory, ref int beeRow, ref int beeCol)
        {
            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    beeTeritory[row, col] = line[col];
                    if (beeTeritory[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }
        }

        private static void PrintMatrix(char[,] beeTeritory)
        {
            for (int row = 0; row < beeTeritory.GetLength(0); row++)
            {
                for (int col = 0; col < beeTeritory.GetLength(1); col++)
                {
                    Console.Write(beeTeritory[row, col]);
                }

                Console.WriteLine();
            }
        }
        private static int MoveCol(int beeCol, string input)
        {
            if (input == "left")
            {
                return beeCol-=1;
            }
            else if (input == "right")
            {
                return beeCol+= 1;
            }
            return beeCol;
            
        }

        private static int MoveRow(int beeRow, string input)
        {
            if (input == "up")
            {
                return beeRow-=1;
            }
            else if (input == "down")
            {
                return beeRow+=1;
            }

            return beeRow;
        }

        private static bool ValidatePosition(int n, int beeCol, int beeRow)
        {
            if (beeRow < 0 || beeRow >= n)
            {
                return false;
            }
            if (beeCol < 0 || beeCol >= n)
            {
                return false;
            }

            return true;
        }

    }
}
