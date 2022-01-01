using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public void Calling(string number)
        {
            foreach (var letter in number)
            {
                if (char.IsLetter(letter))
                {
                    throw new ArgumentException("Invalid number!");
                }
            }
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
