using System;
using System.Linq;

namespace _03.ZigZagArrayas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] currArr = Console.ReadLine().Split().ToArray();
                string indexZero = currArr[0];
                string indexOne = currArr[1];
                if (i % 2== 0)
                {
                    arr1[i] = indexZero;
                    arr2[i] = indexOne;
                }
                else if (i % 2 == 1)
                {
                    arr1[i] = indexOne;
                    arr2[i] = indexZero;

                }
            }
            Console.WriteLine(string.Join(" ",arr1));
            Console.WriteLine(string.Join(" ",arr2));
        }
    }
}
