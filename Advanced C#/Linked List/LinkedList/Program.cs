using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList evenNumbers = new LinkedList();
            LinkedList oddNumbers = new LinkedList();

            for (int i = 1; i <= 20; i++)
            {
                if (IsEven(i))
                {
                    evenNumbers.AddLast(new Node(i));
                }
                else
                {
                    oddNumbers.AddFirst(new Node(i));
                }
            }

            evenNumbers.PrintEvenNumbers();
            oddNumbers.PrintOddNumbers();
        }

        private static bool IsEven(int value)
        {
            if (value % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
