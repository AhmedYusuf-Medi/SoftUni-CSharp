using System;

namespace _05.MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(GetFullName(n));
            }
        }
        static string GetFullName(int month)
        {
            DateTime date = new DateTime(2020, month, 1);

            return date.ToString("MMMM");
        }
    }
}
