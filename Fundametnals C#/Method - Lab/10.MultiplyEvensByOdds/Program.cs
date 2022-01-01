using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(MultiplyEvensByOdds(input));
        }

        private static int MultiplyEvensByOdds(string input)
        {
            int evens = 0;
            int odds = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '-')
                {
                    int currNum = (int)Char.GetNumericValue(input[i]);

                    if (currNum % 2 == 0)
                    {
                        evens += currNum;
                    }
                    else
                    {
                        odds += currNum;
                    }
                }
            }

            return evens * odds;
        }
    }
}
