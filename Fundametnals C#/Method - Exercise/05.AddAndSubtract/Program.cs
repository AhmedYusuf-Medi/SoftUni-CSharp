using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = Add(first, sec,third);
            Console.WriteLine(sum);

        }

        private static int Add(int first, int sec,int third)
        {
            int sum = first + sec;
            return Subtract(sum, third);
        }
        private static int Subtract(int sum, int third)
        {
            return sum - third;
        }
    }
}
