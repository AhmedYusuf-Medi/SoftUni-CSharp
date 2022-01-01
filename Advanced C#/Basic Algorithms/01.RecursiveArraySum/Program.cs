using System;
using System.Linq;

namespace _01.RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sequence of numbers with whitespace: ");
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse).ToArray();

            int lenght = array.Length;

            Console.WriteLine();
            Console.WriteLine($"Sum of all numbers in the sequence u entered is: {findSum(array, lenght)}");
        }
        // Return sum of elements in 
        // A[0..N-1] using recursion.
        static int findSum(int[] array, int length)
        {
            if (length <= 0)
            {
                return 0;
            }

            return (findSum(array, length - 1) + array[length - 1]);
        }
    }
}
