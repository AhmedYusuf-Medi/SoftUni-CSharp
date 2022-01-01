using System;

namespace _04.CeasarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            foreach (var c in text)
            {
                var currC =(char)(c + 3);
                Console.Write(currC);
            }
        }
    }
}
