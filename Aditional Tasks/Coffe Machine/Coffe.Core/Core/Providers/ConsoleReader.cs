using Coffee.Core.Contracts;
using System;

namespace Coffee.Core.Providers
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
