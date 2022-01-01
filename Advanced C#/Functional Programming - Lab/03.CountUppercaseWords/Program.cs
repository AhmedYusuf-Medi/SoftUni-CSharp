using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isFirstLetterCapital = 
                str => str[0] == str.ToUpper()[0];

            Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(n => isFirstLetterCapital(n)).ToList().ForEach(n => Console.WriteLine(n));
             
        }
    }
}
