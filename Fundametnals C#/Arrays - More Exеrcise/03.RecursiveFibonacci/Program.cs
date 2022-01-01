using System;

namespace _03.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n));
        }
        public static int GetFibonacci(int n1)
        {
            if (n1 <= 2)
            {
                return 1;
            }
            else
            {
                return GetFibonacci(n1 - 1) + GetFibonacci(n1 - 2);
            }
        }
    }
}
