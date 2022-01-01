using System;
using System.Collections.Generic;

namespace _03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> text = new List<string>();
            List<int> numbers = new List<int>();

            // Seprate digits and other symbols
            for (int i = 0; i < input.Length; i++)
            {
                char currentElement = input[i];
                if (char.IsDigit(currentElement))
                {
                    numbers.Add((int)Char.GetNumericValue(currentElement));
                }
                else
                {
                    text.Add(currentElement.ToString());
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            // Seperate even indexes to takelist and odd to skiplist

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            string result = String.Empty;

            int index = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int skipCount = skipList[i];

                int takeCount = takeList[i];

                if (index + takeCount > text.Count)
                {
                    takeCount = text.Count - index;
                }

                for (int j = 0; j < takeCount; j++)
                {
                    result += text[index + j];
                }

                index += takeCount + skipCount;
            }

            Console.WriteLine(result);
        }
    }
}
