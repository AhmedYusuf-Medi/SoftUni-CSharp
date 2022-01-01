using System;
using System.Numerics;

namespace _04.TribunaciSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(CallTribonacci(i) + " ");
            }
        }

        public static int CallTribonacci(int term)
        {
            int a = 0;
            int b = 1;
            int c = 1;
            int result = 0;

            if (term == 0) result = a;
            if (term == 1) result = b;
            if (term == 2) result = c;

            while (term > 2)
            {
                result = a + b + c;
                a = b;
                b = c;
                c = result;
                term--;
            }

            return result;
        }
    }
}
