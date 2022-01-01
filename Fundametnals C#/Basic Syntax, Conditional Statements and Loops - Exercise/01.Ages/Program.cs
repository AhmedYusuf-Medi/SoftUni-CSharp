using System;

namespace FirstOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (input <= 13 && input >= 3)
            {
                Console.WriteLine("child");
            }
            else if (input <= 19 && input >= 14)
            {
                Console.WriteLine("teenager");
            }
            else if (input <= 65 && input >= 20)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
