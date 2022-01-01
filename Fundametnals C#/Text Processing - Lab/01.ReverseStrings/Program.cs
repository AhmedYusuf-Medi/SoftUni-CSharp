using System;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            while ((input =Console.ReadLine()) != "end")
            {
                string reversed = String.Empty;

                for (int i = input.Length -1; i >= 0; i--)
                {
                    reversed += input[i];
                }

                Console.WriteLine($"{input} = {reversed}");
            }
        }
    }
}
