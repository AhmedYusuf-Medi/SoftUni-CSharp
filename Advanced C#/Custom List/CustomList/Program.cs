using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            List numbers = new List();

            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }
            numbers.Reverse();

            numbers.PrintListInOneLine(numbers);

            Console.WriteLine(numbers.Count);

        }
    }
}
