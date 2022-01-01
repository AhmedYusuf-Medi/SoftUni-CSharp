using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            string first = Console.ReadLine().TrimStart('0');
            int sec = int.Parse(Console.ReadLine());

            int temp = 0;

            if (sec == 0 || first == null)
            {
                Console.WriteLine(0);
                return;
            }

            foreach (var c in first.Reverse())
            {
                int digit = int.Parse(c.ToString());
                int result = digit * sec+temp;

                int restDigit = result % 10;
                temp = result / 10;
                sb.Insert(0, restDigit);
            }
            if (temp>0)
            {
                sb.Insert(0, temp);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
