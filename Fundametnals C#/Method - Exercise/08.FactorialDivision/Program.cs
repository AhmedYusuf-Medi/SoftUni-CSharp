using System;
using System.Numerics;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            long facOne = FactorialCalcu(first);
            long facTwo = FactorialCalcu(second);
            double division =(facOne * 1.0 / facTwo);
            Console.WriteLine($"{division:f2}");
        }

        private static long FactorialCalcu(int n)
        {
            //lets say n is 5/n = 5
            //if n is 0 we return 1

            if (n == 0)
            {
                return 1;
            }

            //else we multiply 1 * 2 = 2
            //then we multiply 2 * 3 =6
            //then we multiply 6 * 4 = 24
            //24 * 5 = 120

            //we are recaling the method until we get to the end 
            return n * FactorialCalcu(n - 1);
        }

    }
}
