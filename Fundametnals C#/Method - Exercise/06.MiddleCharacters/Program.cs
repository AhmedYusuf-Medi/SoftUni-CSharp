using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            //even
            if (input.Length % 2 == 0)
            {
                GetMiddleEven(input, result);
            }
            //odd
            if (input.Length % 2 == 1)
            {
                GetMiddleOdd(input,result);
               
            }

        }

        private static void GetMiddleOdd(string input,string result)
        {
            result = input.Substring(input.Length / 2, 1);
            Console.WriteLine(result);
        }

        private static void GetMiddleEven(string input,string result)
        {
            result = input.Substring(input.Length/2-1,2);
            Console.WriteLine(result);
          
        }
    }
}
