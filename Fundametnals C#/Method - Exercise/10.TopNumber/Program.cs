using System;
using System.Linq;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            TopNumber(n);
        }

        private static void TopNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                char[] digits= i.ToString().ToCharArray();

                int digitSum = digits.Select(x => (int)Char.GetNumericValue(x)).Sum();
                bool doesContainAtleasOneOdd = false;

                for (int j = 0; j < digits.Length; j++)
                {
                    if ((int)Char.GetNumericValue(digits[j]) % 2 == 1)
                    {
                        doesContainAtleasOneOdd = true;
                        break;
                    }
                }

                if (digitSum % 8 == 0 && doesContainAtleasOneOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
