using System;
using System.Numerics;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            int splitPoint = 0;
            string input;
            BigInteger firstNum = 0;
            BigInteger secNum = 0;

            int firstSum = 0;
            int secSum = 0;

            for (int i = 0; i < loops; i++)
            {
                input = Console.ReadLine();

                splitPoint = FindSplitPoint(input,splitPoint);

                firstNum = CreateFirstNum(input, splitPoint);
                secNum = CreateSecNum(input, splitPoint);

                if (firstNum >= secNum)
                {
                    firstSum = TakeSum(firstNum);
                    Console.WriteLine(firstSum);
                }
                else
                {
                    secSum = TakeSum(secNum);
                    Console.WriteLine(secSum);
                }          
            }

        }

        private static int TakeSum(BigInteger firstNum)
        {
            int sumOfDigits = 0;
            for (int k = firstNum.ToString().Length; k >= 0; k--)
            {
                byte lastDigits = 0;
                lastDigits = (byte)(Math.Abs((decimal)firstNum % 10));
                sumOfDigits += (int)lastDigits;
                firstNum /= 10;
            }


            return sumOfDigits;
        }

        private static BigInteger CreateSecNum(string input, int splitPoint)
        {
            string value = String.Empty;
            for (int i = splitPoint + 1; i < input.Length; i++)
            {
                value += input[i];
            }

            return BigInteger.Parse(value);
        }

        private static BigInteger CreateFirstNum(string input, int splitPoint)
        {
            string value =  String.Empty;
            for (int i = 0; i < splitPoint; i++)
            {
                value += input[i];
            }

            return BigInteger.Parse(value);
        }

        private static int FindSplitPoint(string input,int splitPoint)
        {
            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] == ' ')
                {
                    splitPoint = j;
                    break;
                }
            }

            return splitPoint;
        }
    }
}
