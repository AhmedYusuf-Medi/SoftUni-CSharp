using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VowelsCount(input);

        }
        private static void VowelsCount(string input)
        {
            var vowels = new[] {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O','U'};
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (currChar == vowels[j])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
