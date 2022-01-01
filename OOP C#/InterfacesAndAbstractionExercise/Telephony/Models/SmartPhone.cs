using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class SmartPhone : IBrowsable
    {
        public void Browsing(string website)
        {
            foreach (var letter in website)
            {
                if (char.IsDigit(letter))
                {
                    throw new ArgumentException("Invalid URL!");
                }
            }
            Console.WriteLine($"Browsing: {website}.!");
        }

        public void Calling(string number)
        {
            foreach (var letter in number)
            {
                if (char.IsLetter(letter))
                {
                    throw new ArgumentException("Invalid number!");
                }
            }

            Console.WriteLine($"Calling... {number}");
        }
    }
}
