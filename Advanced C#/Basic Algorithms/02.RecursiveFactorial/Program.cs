using System;

namespace _02.RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            uint n = uint.Parse(Console.ReadLine());

            Console.WriteLine($"Ur number factorial is: {FactorialCalcu(n)}");
        }

        private static decimal FactorialCalcu(uint n)
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
