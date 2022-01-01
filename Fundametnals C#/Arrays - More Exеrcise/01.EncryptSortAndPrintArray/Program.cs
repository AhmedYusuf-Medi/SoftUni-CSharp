using System;
using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                int[] input = new int[n];
                for (int index = 0; index < n; index++)
                {
                    char[] arr = Console.ReadLine().ToArray();
                    char[] vowels = { 'A', 'a', 'E', 'e', 'U', 'u', 'I', 'i', 'O', 'o' };
                    int vowelsSum = arr.Where(x => vowels.Contains(x)).Sum(x => x * arr.Length);
                    int nonVowelsSum = arr.Where(x => !vowels.Contains(x)).Sum(x => x / arr.Length);
                    input[index] = vowelsSum + nonVowelsSum;
                }
                Console.WriteLine(string.Join(Environment.NewLine, input.OrderBy(x => x)));
            }

        }
    }
}
