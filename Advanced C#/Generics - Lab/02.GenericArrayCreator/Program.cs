using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            char[] symbols = ArrayCreator.Create(4,'*');

            Console.WriteLine(string.Join(' ',symbols)) ;
        }
    }
}
