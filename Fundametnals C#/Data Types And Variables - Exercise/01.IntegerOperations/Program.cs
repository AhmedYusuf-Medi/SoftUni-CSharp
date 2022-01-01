using System;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int operationOne = first + sec;
            int operationTwo = operationOne / third;
            int operationThree = operationTwo * fourth;

            Console.WriteLine(operationThree);
        }
    }
}
