using System;

namespace _03.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;

            double firstNum = double.Parse(Console.ReadLine());
            double secNum = double.Parse(Console.ReadLine());

            bool isEqual = Math.Abs(firstNum - secNum) < eps;

            if (isEqual)
            {
                Console.WriteLine(isEqual);
            }
            else
            {
                Console.WriteLine(isEqual);
            }
        }
    }
}
