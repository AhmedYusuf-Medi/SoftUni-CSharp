using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var patern = @"\+359([ -])2\1\d{3}\1\d{4}\b";

            var phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, patern);

            var matchedPhones = phoneMatches.Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ",matchedPhones));
        }
    }
}
