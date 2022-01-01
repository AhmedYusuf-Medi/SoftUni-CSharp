using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] deviders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> numbers = new List<int>();

            GetDevisibles(length, deviders, numbers);

            Console.WriteLine(string.Join(" ",numbers));

        }

        private static void GetDevisibles(int length, int[] deviders, List<int> numbers)
        {
            for (int i = 1; i <= length; i++)
            {
                if (DevidersInfo(i, deviders))
                {
                    numbers.Add(i);
                }
            }
        }

        private static bool DevidersInfo(int n, int[] deviders)
        {
            bool isTrue = true;
            foreach (int divaider in deviders)
            {
                if (n % divaider != 0)
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
    }
}
