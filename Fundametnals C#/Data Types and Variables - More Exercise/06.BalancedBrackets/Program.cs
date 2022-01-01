using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            bool isOpened = false;
            bool isBalanced = true;

            for (int i = 0; i < loops; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (!isOpened)
                    {
                        isOpened = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }

                if (input == ")")
                {
                    if (isOpened)
                    {
                        isOpened = false;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }
            if (isBalanced && !isOpened)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
