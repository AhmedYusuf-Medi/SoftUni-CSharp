using System;

namespace _05.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            string sign = FindResult(a, b, c);

            Console.WriteLine(sign);
        }

        private static string FindResult(double a, double b, double c)
        {
            if (IsZero(a, b, c))
            {
                return "zero";
            }
            else if (IsNegative(a, b, c))
            {
                return "negative";
            }
            else
            {
                return "positive";
            }
        }
        private static bool IsZero(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                return true;
            }

            return false;
        }

        private static bool IsNegative (double a , double b , double c)
        {
            double[] numbers = new double[] { a, b, c };
            int negativeCounter = 0;
            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] < 0)
                {
                    negativeCounter++;
                }
            }
            if (negativeCounter % 2 == 0)
            {
                return false;
            }
            return true;
        }
    }
}
