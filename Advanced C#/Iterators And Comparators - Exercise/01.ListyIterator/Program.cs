using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> inputCreate = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();

            ListyIterator<string> items = new ListyIterator<string>(inputCreate);

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "HasNext":
                        Console.WriteLine(items.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(items.Move());
                        break;
                    case "Print":

                        try
                        {
                            items.Print();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);       
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
