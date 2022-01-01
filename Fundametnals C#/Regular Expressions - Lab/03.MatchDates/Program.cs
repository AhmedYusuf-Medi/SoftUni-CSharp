using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var patern = @"\b([0-2]\d|[3][0-1])([\.\-\/])([A-Z][a-z]{2})\2([0-9]{4})\b";

            var datesText = Console.ReadLine();

            var dates = Regex.Matches(datesText, patern);

            foreach (Match date in dates)
            {
                Console.WriteLine($"Day: {date.Groups[1].Value}, Month: {date.Groups[3].Value}, Year: {date.Groups[4].Value}");
            }
        }
    }
}
