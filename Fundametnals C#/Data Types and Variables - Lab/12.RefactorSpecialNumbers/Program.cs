using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            int sum = 0;
            int currNumber = 0;
            bool isSpecial = false;
            for (int number = 1; number <= loops; number +=1)
            {
                currNumber = number;

                while (currNumber > 0)
                {
                    sum += currNumber % 10;
                    currNumber /= 10;
                }

                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecial);
                sum = 0;
            }
        }
    }
}
